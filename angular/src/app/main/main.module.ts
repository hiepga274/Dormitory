import {CommonModule} from '@angular/common';
import {NgModule} from '@angular/core';
import {FormsModule} from '@angular/forms';
import {AppCommonModule} from '@app/shared/common/app-common.module';

import {AutoCompleteModule} from 'primeng/autocomplete';
import {PaginatorModule} from 'primeng/paginator';
import {EditorModule} from 'primeng/editor';
import {InputMaskModule} from 'primeng/inputmask';
import {FileUploadModule} from 'primeng/fileupload';
import {TableModule} from 'primeng/table';

import {UtilsModule} from '@shared/utils/utils.module';
import {CountoModule} from 'angular2-counto';
import {ModalModule} from 'ngx-bootstrap/modal';
import {TabsModule} from 'ngx-bootstrap/tabs';
import {TooltipModule} from 'ngx-bootstrap/tooltip';
import {BsDropdownModule} from 'ngx-bootstrap/dropdown';
import {PopoverModule} from 'ngx-bootstrap/popover';
import {MainRoutingModule} from './main-routing.module';
import {NgxChartsModule} from '@swimlane/ngx-charts';

import {BsDatepickerConfig, BsDaterangepickerConfig, BsLocaleService} from 'ngx-bootstrap/datepicker';
import {BsDatepickerModule} from 'ngx-bootstrap/datepicker';
import {NgxBootstrapDatePickerConfigService} from 'assets/ngx-bootstrap/ngx-bootstrap-datepicker-config.service';
import { HomeComponent } from '@app/shared/components/home/home.component';
import { KeyboardShortcutsModule } from 'ng-keyboard-shortcuts';
import { DynamicTabComponent } from '@app/shared/components/dynamic-tab/dynamic-tab.component';
import { TabDisplayDirective } from '@app/shared/components/tab-display/tab-display.directive';
import { DxReportViewerModule } from 'devexpress-reporting-angular';;
import { CommonDeclareModule } from '@app/shared/common-declare.module';
import { CarouselModule, MDBBootstrapModule } from 'angular-bootstrap-md';
import { UnlessDirective } from '@metronic/app/core/_base/layout/directives/unless.directive';;
import { NgMarqueeModule } from 'ng-marquee';

NgxBootstrapDatePickerConfigService.registerNgxBootstrapDatePickerLocales();

@NgModule({
    imports: [
        NgMarqueeModule,
        FileUploadModule,
        AutoCompleteModule,
        PaginatorModule,
        EditorModule,
        InputMaskModule, TableModule,
        KeyboardShortcutsModule.forRoot(),
        CommonModule,
        FormsModule,
        ModalModule,
        TabsModule,
        TooltipModule,
        AppCommonModule,
        UtilsModule,
        MainRoutingModule,
        CountoModule,
        NgxChartsModule,
        BsDatepickerModule.forRoot(),
        BsDropdownModule.forRoot(),
        PopoverModule.forRoot(),
        DxReportViewerModule,
        CommonDeclareModule,
        MDBBootstrapModule.forRoot(),
        CarouselModule.forRoot()

    ],
    exports: [
        KeyboardShortcutsModule
    ],
    declarations: [
        HomeComponent,
        DynamicTabComponent,
        TabDisplayDirective,
        UnlessDirective,
    ],
    providers: [
        {provide: BsDatepickerConfig, useFactory: NgxBootstrapDatePickerConfigService.getDatepickerConfig},
        {provide: BsDaterangepickerConfig, useFactory: NgxBootstrapDatePickerConfigService.getDaterangepickerConfig},
        {provide: BsLocaleService, useFactory: NgxBootstrapDatePickerConfigService.getDatepickerLocale}
    ]
})
export class MainModule {
}
