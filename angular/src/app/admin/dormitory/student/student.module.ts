import { CreateOrEditStudentComponent } from './create-or-edit-student/create-or-edit-student.component';
import { CommonDeclareModule } from '@app/shared/common-declare.module';
import { TABS } from '@app/shared/constants/tab-keys';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StudentComponent } from './student.component';


const tabcode_component_dict = {
    [TABS.STUDENT]: StudentComponent
  };
@NgModule({
  imports: [
    CommonDeclareModule
  ],
  declarations: [StudentComponent,
                CreateOrEditStudentComponent]
})
export class StudentModule {
     static getComponent(tabCode: string) {
    return tabcode_component_dict[tabCode];
  }
 }
