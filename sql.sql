	
	--Store for Get list student 
	CREATE PROCEDURE [dbo].[GetAllOrFilterStudent]
	@Name nvarchar(255),
	@Gender int,
	@StudentNo nvarchar(64),
	@Cmnd nvarchar(64),
	@Phone nvarchar(64),
	@IsRoom bit
	As
	Select Id, Name,StudentNo,Gender,Cmnd,Phone,IsRoom From Student
	Where IsDeleted=0 and (@Name IS null or Name like '%'+@Name+'%') and (@StudentNo is null Or StudentNo like '%'+@StudentNo+'%')
	and (@Gender is null or Gender = @Gender)
	and (@Cmnd is null or Cmnd like '%'+@Cmnd+'%')
	and (@Phone is null or Phone like '%'+@Phone+'%') 
	and (@IsRoom is null or IsRoom = @IsRoom)

	--Trigger update Amount of Room and Status of Student when insert contract
	CREATE trigger trg_contract On CONTRACT after 
	insert 
	as begin
	Declare @a int = (Select StudentId from inserted)
	Declare @RoomId int = (Select RoomId from inserted)
	update room set Amount = (Select Count(Id) from Contract where IsDeleted =0 and RoomId = @RoomId AND EndDate>=GETDATE()) where Id = @RoomId
	update Student 
	set IsRoom = 1 where Student.Id = @a
	end

	go
	-- trigger update Amount of Room and Status of Student when update of delete contract
	create trigger trg_contract_delete On Contract after 
	update 
	as begin 
	Declare @dele bit = (Select IsDeleted from inserted)
	Declare @a int = (Select StudentId from deleted)
	Declare @RoomId int = (Select RoomId from deleted)
	update room set Amount = (Select Count(Id) from Contract where IsDeleted =0 and RoomId = @RoomId) where Id = @RoomId
	if(@dele = 1)
	begin
	update Student
	set IsRoom = 0 where Student.Id = @a
	end
	else
	begin 
	update Student 
	set IsRoom = 1 where Student.Id = @a
	end
	end

	--Store get list Invoice
	Create Procedure [dbo].[GetAllOrFilterInvoice]
	@RoomId int,
	@StartDate nvarchar(50),
	@EndDate nvarchar(50),
	@IsPaid bit
	As
	Select Invoice.Id AS Id,RoomId,Room.RoomNo As RoomNo, ElecOld,ElecNew,WarOld,WarNew,ElecUnit,WarUnit,Month,IsPaid 
	from Invoice inner join Room on Room.Id = Invoice.RoomId  where Invoice.IsDeleted = 0 and
	(@RoomId IS null or RoomId = @RoomId) and (Invoice.Month between @StartDate and @EndDate )
	and (@IsPaid is null or IsPaid = @IsPaid)

	--Store get list InBill
	Create Procedure [dbo].[GetAllOrFilterInBill]
	@RoomId int,
	@StartDate nvarchar(50),
	@EndDate nvarchar(50),
	@IsPaid bit
	As
	select InBill.Id,RoomNo,Cost,Date,Reason,IsPaid from InBill
    inner join Room on Room.Id=InBill.RoomId
    where InBill.IsDeleted =0 and Room.IsDeleted=0 and
	(@RoomId Is null or RoomId = @RoomId) and (InBill.Date between @StartDate and @EndDate )
	and (@IsPaid is null or IsPaid = @IsPaid)

	--Store get list OutBill
	Create Procedure [dbo].[GetAllOrFilterOutBill]
	@StartDate nvarchar(50),
	@EndDate nvarchar(50)
	As
	select Id,Cost,Date,Description from OutBill
    where IsDeleted =0 and 
	(Date between @StartDate and @EndDate)

	--Store get list Contract
	Create Procedure [dbo].[GetAllOrFilterContract]
	@RoomId int,
	@StartDate nvarchar(50),
	@EndDate nvarchar(50)
	As
	 select Contract.Id,ContractNo,StudentNo,Student.Name As StudentName,Gender,
                Phone,RoomNo,UnitPrice,ContractDate,StartDate,EndDate
                from Contract 
                inner join Student on Student.Id = Contract.StudentId
                inner join Room on Room.Id = Contract.RoomId
                where Contract.IsDeleted = 0 and
	(@RoomId Is null or RoomId = @RoomId) and (Contract.ContractDate between @StartDate and @EndDate )


	--Store get total OutBill For Dashboard
	Create Procedure [dbo].[GetOutBillForDashboard]
	@Date nvarchar(50)
	As
	SELECT
    DATEPART(MONTH, Date) AS Month,
    SUM(OutBill.Cost ) AS Total
	FROM
    OutBill where IsDeleted =0 and YEAR(Date)=YEAR(@Date)
	GROUP BY DATEPART(MONTH, Date)
	ORDER BY Month;

	--Store get total InBill For Dashboard
	Create Procedure [dbo].[GetInBillForDashboard]
	@Date nvarchar(50)
	As
	SELECT
    DATEPART(MONTH, Date) AS Month,
    SUM(InBill.Cost ) AS Total
	FROM
    InBill where IsDeleted =0 and YEAR(Date)=YEAR(@Date)
	GROUP BY DATEPART(MONTH, Date)
	ORDER BY Month;

	--Store get total Invoice For Dashboard
	Create Procedure [dbo].[GetInvoiceForDashboard]
	@Date nvarchar(50)
	As
	SELECT
    DATEPART(MONTH, Month) AS Month,
    SUM((ElecNew-ElecOld)*ElecUnit+(WarNew-WarOld)*WarUnit) AS Total
	FROM
    Invoice where IsDeleted =0 and YEAR(Month)=YEAR(@Date)
	GROUP BY DATEPART(MONTH, Month)
	ORDER BY Month;

	--Store get total Contract For Dashboard
	Create Procedure [dbo].[GetContractForDashboard]
	@Date nvarchar(50)
	As
	SELECT
    DATEPART(MONTH, ContractDate) AS Month,
    COUNT(*) AS Total
	FROM Contract
	where YEAR(ContractDate)=YEAR(@Date) and IsDeleted=0
	GROUP BY
    DATEPART(MONTH, ContractDate)
	ORDER BY
    DATEPART(MONTH, ContractDate)


	-- update 06/12/2022

	--Store get list room for create contract
		create Procedure GetListRoomForConTract
		@StudentId int
		As
		begin
			Declare @Gender int 
			Set @Gender = (Select Gender From Student where id = @StudentId)
			select Room.Id,RoomNo,UnitPrice,Maxx,Amount from Room 
			left join Contract on Room.Id = Contract.RoomId 
			left join Student on Student.Id = Contract.StudentId
			where Amount<Maxx and Room.Id Not In (select RoomId from contract inner join student on contract.studentId = Student.Id where gender <>@Gender)
		end
	--Store get list Room for create Invoice
	Create Procedure GetListRoomForCreateInvoice
		As
		Begin
		Select Id,RoomNo from Room where IsDeleted = 0 and Id Not In 
		(Select Room.Id From Room inner join Invoice on Room.Id = Invoice.RoomId 
		Where MONTH(Invoice.Month)=MONTH(GetDate()) and YEAR(Invoice.Month)=YEAR(GetDate()))
		End

	-- update 07/12/2022
	--create procrdure update isRoom=0 and Amount=Amount-1 when Contract.EndDate <= GetDAte()
	CREATE PROCEDURE contract_timeout
		AS
		BEGIN 
			DECLARE @RoomId int
			DECLARE cursorContract CURSOR FOR
			SELECT RoomId FROM dbo.Contract WHERE EndDate < GETDATE() AND IsDeleted =0
			Open cursorContract
			FETCH NEXT FROM cursorContract     -- Đọc dòng đầu tiên
			  INTO @RoomId
			  WHILE @@FETCH_STATUS = 0          --vòng lặp WHILE khi đọc Cursor thành công
				BEGIN
					UPDATE dbo.Room SET Amount = (Select Count(Id) from Contract where IsDeleted =0 and RoomId = @RoomId AND dbo.Contract.EndDate >= GETDATE()) WHERE Id = @RoomId
				FETCH NEXT FROM cursorContract -- Đọc dòng tiếp
				  INTO @RoomId
				END
			CLOSE cursorContract              -- Đóng Cursor
			DEALLOCATE cursorContract 
			UPDATE dbo.Student SET	IsRoom = 0 WHERE Id IN (SELECT StudentId FROM dbo.Contract WHERE EndDate < GETDATE() AND IsDeleted =0)
		END
	-- Create store get list student in a room
	ALTER PROCEDURE GetListStudentInRoom
	@RoomId int
		AS
		BEGIN
		select Student.Id, Student.Name as Name, Gender, StudentNo, Cmnd, Phone from Student
		INNER JOIN Contract on Student.Id =Contract.StudentId
        where RoomId = @RoomId and Student.IsDeleted=0 and Contract.IsDeleted=0 and	Contract.EndDate>=GETDATE()
		END

	EXEC GetListStudentInRoom @RoomId =13
