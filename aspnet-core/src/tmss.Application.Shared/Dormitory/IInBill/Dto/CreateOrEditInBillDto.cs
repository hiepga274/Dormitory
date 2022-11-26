﻿using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace tmss.Dormitory.IInBill.Dto
{
    public class CreateOrEditInBillDto : EntityDto<long?>
    {
        public long RoomId { get; set; }
        public long Cost { get; set; }
        public DateTime Date { get; set; }
        public string Reason { get; set; }
        public bool IsPaid { get; set; }
    }
}
