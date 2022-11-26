import { ViewListStudentComponent } from './view-list-student/view-list-student.component';
import { CreateOrEditRoomComponent } from './create-or-edit-room/create-or-edit-room.component';
import { CreateOrEditBuildingComponent } from './create-or-edit-building/create-or-edit-building.component';
import { TABS } from '@app/shared/constants/tab-keys';
import { NgModule } from '@angular/core';
import { BuildingRoomComponent } from './building-room.component';
import { CommonDeclareModule } from '@app/shared/common-declare.module';

const tabcode_component_dict = {
    [TABS.BUILDING_ROOM]: BuildingRoomComponent
  };
@NgModule({
  imports: [
    CommonDeclareModule
  ],
  declarations: [BuildingRoomComponent,
                CreateOrEditBuildingComponent,
                CreateOrEditRoomComponent,
                ViewListStudentComponent],
})
export class BuildingRoomModule {
    static getComponent(tabCode: string) {
        return tabcode_component_dict[tabCode];
      }
}
