import { forEach } from 'lodash';
import { ContractServiceProxy, InBillServiceProxy, OutBillServiceProxy, InvoiceServiceProxy } from './../../../shared/service-proxies/service-proxies';
import { Component, Injector, OnInit, ViewChild, ViewEncapsulation } from '@angular/core';
import { AppComponentBase } from '@shared/common/app-component-base';
import {
    ApexAxisChartSeries,
    ApexChart,
    ChartComponent,
    ApexDataLabels,
    ApexPlotOptions,
    ApexYAxis,
    ApexLegend,
    ApexStroke,
    ApexXAxis,
    ApexFill,
    ApexTooltip
  } from "ng-apexcharts";

export type ChartOptions = {
    series: ApexAxisChartSeries;
    chart: ApexChart;
    dataLabels: ApexDataLabels;
    plotOptions: ApexPlotOptions;
    yaxis: ApexYAxis;
    xaxis: ApexXAxis;
    fill: ApexFill;
    tooltip: ApexTooltip;
    stroke: ApexStroke;
    legend: ApexLegend;
  };
@Component({
    templateUrl: './host-dashboard.component.html',
    styleUrls: ['./host-dashboard.component.less'],
    encapsulation: ViewEncapsulation.None
})
export class HostDashboardComponent extends AppComponentBase implements OnInit {
    @ViewChild("chart", { static: false }) chart: ChartComponent;
    public chartOptions: Partial<ChartOptions>;
    contractData: { name: string, value: number }[];
    inBill: { name: string, value: number }[];
    inBillData=[0,0,0,0,0,0,0,0,0,0,0,0];
    outBillData=[0,0,0,0,0,0,0,0,0,0,0,0];
    invoiceData=[0,0,0,0,0,0,0,0,0,0,0,0];
    outBill: { name: string, value: number }[];
    invoice: { name: string, value: number }[];

    constructor(
        injector: Injector,
        private _contract :ContractServiceProxy,
        private _inBill :InBillServiceProxy,
        private _outBill :OutBillServiceProxy,
        private _invoice :InvoiceServiceProxy,

        ) {
        super(injector);
        this.chartOptions = {
            series: [
              {
                name: "Net Profit",
                data: this.inBillData
              },
            //   {
            //     name: "Revenue",
            //     data: [this.outBill[0].value,this.outBill[1].value,this.outBill[2].value,this.outBill[3].value,this.outBill[4].value,this.outBill[5].value,this.outBill[6].value,this.outBill[7].value,this.outBill[8].value,this.outBill[9].value,this.outBill[10].value,this.outBill[11].value]
            //   },
            //   {
            //     name: "Free Cash Flow",
            //     data: [this.invoice[0].value,this.invoice[1].value,this.invoice[2].value,this.invoice[3].value,this.invoice[4].value,this.invoice[5].value,this.invoice[6].value,this.invoice[7].value,this.invoice[8].value,this.invoice[9].value,this.invoice[10].value,this.invoice[11].value]
            //   }
            ],
            chart: {
              type: "bar",
              height: 350
            },
            plotOptions: {
              bar: {
                horizontal: false,
                columnWidth: "55%",
                endingShape: "rounded"
              }
            },
            dataLabels: {
              enabled: false
            },
            stroke: {
              show: true,
              width: 2,
              colors: ["transparent"]
            },
            xaxis: {
              categories: [
                "Feb",
                "Mar",
                "Apr",
                "May",
                "Jun",
                "Jul",
                "Aug",
                "Sep",
                "Oct"
              ]
            },
            yaxis: {
              title: {
                text: "$ (thousands)"
              }
            },
            fill: {
              opacity: 1
            },
            tooltip: {
              y: {
                formatter: function(val) {
                  return "$ " + val + " thousands";
                }
              }
            }
          };
    }
    ngOnInit(): void {
        this.onGridReady();
        console.log(this.inBillData);
    }
    onGridReady() {
        this._contract.getTotalContractForDashboard().subscribe(res=>{
            this.contractData = [
                { name: "Tháng 1", value: 0 },
              ];
            forEach(res, (item) => {
                switch (item.month) {
                    case "1":
                        this.contractData.push({ name:"Tháng 1", value: item.total });
                        break;
                    case "2":
                        this.contractData.push({ name:"Tháng 2", value: item.total });
                        break;
                    case "3":
                        this.contractData.push({ name:"Tháng 3", value: item.total });
                        break;
                    case "4":
                        this.contractData.push({ name:"Tháng 4", value: item.total });
                        break;
                    case "5":
                        this.contractData.push({ name:"Tháng 5", value: item.total });
                        break;
                    case "6":
                        this.contractData.push({ name:"Tháng 6", value: item.total });
                        break;
                    case "7":
                        this.contractData.push({ name:"Tháng 7", value: item.total });
                        break;
                    case "8":
                        this.contractData.push({ name:"Tháng 8", value: item.total });
                        break;
                    case "9":
                        this.contractData.push({ name:"Tháng 9", value: item.total });
                        break;
                    case "10":
                        this.contractData.push({ name:"Tháng 10", value: item.total });
                        break;
                    case "11":
                        this.contractData.push({ name:"Tháng 11", value: item.total });
                        break;
                    case "12":
                        this.contractData.push({ name:"Tháng 12", value: item.total });
                        break;
                }

            });
            this.contractData.shift();
            });
            this._inBill.getInBillForDashboard().subscribe(res=>{
                this.inBill = [
                    { name: "Tháng 1", value: 0 },
                    ];
                forEach(res, (item) => {
                    switch (item.month) {
                        case 1:
                            this.inBill.push({ name:"Tháng 1", value: item.total });
                            this.inBillData[0]=item.total;
                            break;
                        case 2:
                            this.inBill.push({ name:"Tháng 2", value: item.total });
                            this.inBillData[1]=item.total;
                            break;
                        case 3:
                            this.inBill.push({ name:"Tháng 3", value: item.total });
                            this.inBillData[2]=item.total;
                            break;
                        case 4:
                            this.inBill.push({ name:"Tháng 4", value: item.total });
                            this.inBillData[3]=item.total;
                            break;
                        case 5:
                            this.inBill.push({ name:"Tháng 5", value: item.total });
                            this.inBillData[4]=item.total;
                            break;
                        case 6:
                            this.inBill.push({ name:"Tháng 6", value: item.total });
                            this.inBillData[5]=item.total;
                            break;
                        case 7:
                            this.inBill.push({ name:"Tháng 7", value: item.total });
                            this.inBillData[6]=item.total;
                            break;
                        case 8:
                            this.inBill.push({ name:"Tháng 8", value: item.total });
                            this.inBillData[7]=item.total;
                            break;
                        case 9:
                            this.inBill.push({ name:"Tháng 9", value: item.total });
                            this.inBillData[8]=item.total;
                            break;
                        case 10:
                            this.inBill.push({ name:"Tháng 10", value: item.total });
                            this.inBillData[9]=item.total;
                            break;
                        case 11:
                            this.inBill.push({ name:"Tháng 11", value: item.total });
                            this.inBillData[10]=item.total;
                            break;
                        case 12:
                            this.inBill.push({ name:"Tháng 12", value: item.total });
                            this.inBillData[11]=item.total;
                            break;
                    }
                });
                this.inBill.shift();
                });
                this._outBill.getOutBillForDashboard().subscribe(res=>{
                    this.outBill = [
                        { name: "Tháng 1", value: 0 },
                        ];
                    forEach(res, (item) => {
                        switch (item.month) {
                            case 1:
                                this.outBill.push({ name:"Tháng 1", value: item.total });
                                break;
                            case 2:
                                this.outBill.push({ name:"Tháng 2", value: item.total });
                                break;
                            case 3:
                                this.outBill.push({ name:"Tháng 3", value: item.total });
                                break;
                            case 4:
                                this.outBill.push({ name:"Tháng 4", value: item.total });
                                break;
                            case 5:
                                this.outBill.push({ name:"Tháng 5", value: item.total });
                                break;
                            case 6:
                                this.outBill.push({ name:"Tháng 6", value: item.total });
                                break;
                            case 7:
                                this.outBill.push({ name:"Tháng 7", value: item.total });
                                break;
                            case 8:
                                this.outBill.push({ name:"Tháng 8", value: item.total });
                                break;
                            case 9:
                                this.outBill.push({ name:"Tháng 9", value: item.total });
                                break;
                            case 10:
                                this.outBill.push({ name:"Tháng 10", value: item.total });
                                break;
                            case 11:
                                this.outBill.push({ name:"Tháng 11", value: item.total });
                                break;
                            case 12:
                                this.outBill.push({ name:"Tháng 12", value: item.total });
                                break;
                        }
                    });
                    this.outBill.shift();
                    });
                    this._invoice.getInvoiceForDashboard().subscribe(res=>{
                        this.invoice = [
                            { name: "Tháng 1", value: 0 },
                            ];
                        forEach(res, (item) => {
                            switch (item.month) {
                                case 1:
                                    this.invoice.push({ name:"Tháng 1", value: item.total });
                                    break;
                                case 2:
                                    this.invoice.push({ name:"Tháng 2", value: item.total });
                                    break;
                                case 3:
                                    this.invoice.push({ name:"Tháng 3", value: item.total });
                                    break;
                                case 4:
                                    this.invoice.push({ name:"Tháng 4", value: item.total });
                                    break;
                                case 5:
                                    this.invoice.push({ name:"Tháng 5", value: item.total });
                                    break;
                                case 6:
                                    this.invoice.push({ name:"Tháng 6", value: item.total });
                                    break;
                                case 7:
                                    this.invoice.push({ name:"Tháng 7", value: item.total });
                                    break;
                                case 8:
                                    this.invoice.push({ name:"Tháng 8", value: item.total });
                                    break;
                                case 9:
                                    this.invoice.push({ name:"Tháng 9", value: item.total });
                                    break;
                                case 10:
                                    this.invoice.push({ name:"Tháng 10", value: item.total });
                                    break;
                                case 11:
                                    this.invoice.push({ name:"Tháng 11", value: item.total });
                                    break;
                                case 12:
                                    this.invoice.push({ name:"Tháng 12", value: item.total });
                                    break;
                            }
                        });
                        this.invoice.shift();
                        });
            };
    }



