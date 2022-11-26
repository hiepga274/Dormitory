import { finalize } from 'rxjs/operators';
import { CreateOrEditRoomDto, BuildingRoomServiceProxy } from './../../../../../shared/service-proxies/service-proxies';
import { AppComponentBase } from '@shared/common/app-component-base';
import { Component, OnInit, Output, ViewChild, EventEmitter, Injector } from '@angular/core';
import { ModalDirective } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-create-or-edit-room',
  templateUrl: './create-or-edit-room.component.html',
  styleUrls: ['./create-or-edit-room.component.less']
})
export class CreateOrEditRoomComponent extends AppComponentBase  {


    @ViewChild("createOrEditModal", { static: true }) modal: ModalDirective;
    @Output() modalSave: EventEmitter<any> = new EventEmitter<any>();

    room: CreateOrEditRoomDto = new CreateOrEditRoomDto();
    buildingId;
    active: boolean = false;
    saving: boolean = false;
    constructor(
        injector: Injector,
        private _buildingRoom :BuildingRoomServiceProxy

    ) {
        super(injector);
    }

    ngOnInit() {

    }

    show(buildingId: number,roomId?: number,): void {
        if (!roomId) {
            this.room = new CreateOrEditRoomDto();
            this.room.id = roomId;
            this.room.buildingId = buildingId;
            this.active = true;
            this.modal.show();
        } else {
            this._buildingRoom.getRoomForEdit(roomId)
                .subscribe((result) => {
                    this.room = result[0];
                    this.active = true;
                    this.modal.show();
                });
        }
    }

    save(): void {
        this.saving = true;
        this._buildingRoom
            .createOrEditRoom(this.room)
            .pipe(
                finalize(() => {
                    this.saving = false;
                })
            )
            .subscribe(() => {
                this.notify.info(this.l("SavedSuccessfully"));
                this.close();
                this.modalSave.emit(null);
            });
    }

    close(): void {
        this.active = false;
        this.modal.hide();
    }
}
