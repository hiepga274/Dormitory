import { CommonDeclareModule } from '@app/shared/common-declare.module';
import { CreateOrEditContractComponent } from './create-or-edit-contract/create-or-edit-contract.component';
import { TABS } from '@app/shared/constants/tab-keys';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ContractComponent } from './contract.component';


const tabcode_component_dict = {
    [TABS.CONTRACT]: ContractComponent
  };
@NgModule({
  imports: [
    CommonDeclareModule
  ],
  declarations: [ContractComponent,
    CreateOrEditContractComponent]
})
export class ContractModule {
    static getComponent(tabCode: string) {
        return tabcode_component_dict[tabCode];
      }
 }
