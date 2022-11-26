import { AfterViewInit, Component, ViewChild } from '@angular/core';
import { ICellEditorAngularComp } from '@ag-grid-community/angular';
import { InputMask } from 'primeng/inputmask';
import * as moment from 'moment';
import { ICellEditorParams } from '@ag-grid-enterprise/all-modules';

const srcFormat = 'DD-MMM-YYYY';
const desFormat = 'DD-MM-YYYY';

@Component({
  selector: 'ag-datepicker-editor',
  templateUrl: './ag-date-editor.component.html',
  styleUrls: ['./ag-date-editor.component.less']
})
export class AgDateEditorComponent implements AfterViewInit, ICellEditorAngularComp {
  @ViewChild('dateInput', { read: InputMask, static: false }) private dateInput: InputMask;
  params: ICellEditorParams;
  dateValue: string;

  constructor() { }

  ngAfterViewInit(): void {
    setTimeout(() => this.dateInput.focus());
  }

  agInit(params: ICellEditorParams): void {
    this.params = params;
    const date = moment(params.value, srcFormat);
    this.dateValue = date.isValid() ? date.format(desFormat) : null;
  }

  getValue(): any {
    const date = moment(this.dateValue, desFormat);
    return date.isValid() ? date.format(srcFormat) : null;
  }

  isCancelBeforeStart(): boolean {
    return false;
  }

  isCancelAfterEnd(): boolean {
    return false;
  }

  isPopup(): boolean {
    return false;
  }

}
