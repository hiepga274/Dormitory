import { CreateOrEditInBillComponent } from './create-or-edit-in-bill/create-or-edit-in-bill.component';
import { TABS } from '@app/shared/constants/tab-keys';
import { CommonDeclareModule } from '@app/shared/common-declare.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { InBillComponent } from './in-bill.component';

const tabcode_component_dict = {
    [TABS.INBILL]: InBillComponent
  };
@NgModule({
  imports: [
    CommonDeclareModule
  ],
  declarations: [InBillComponent,
                CreateOrEditInBillComponent]
})
export class InBillModule {
    static getComponent(tabCode: string) {
        return tabcode_component_dict[tabCode];
      }
}
