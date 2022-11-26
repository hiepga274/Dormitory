import {NgModule} from '@angular/core';
import {NavigationEnd, Router, RouterModule} from '@angular/router';
import {HostDashboardComponent} from './dashboard/host-dashboard.component';

@NgModule({
    imports: [
        RouterModule.forChild([
            {
                path: '',
                children: [

                    {
                        path: 'hostDashboard',
                        component: HostDashboardComponent,
                        data: {
                            permission: 'Pages.Administration.Host.Dashboard',
                        },
                    },

                    //New Path Here
                    {
                        path: '',
                        redirectTo: 'hostDashboard',
                        pathMatch: 'full',
                    },

                    {path: '**', redirectTo: 'hostDashboard'},

                ],
            },
        ]),
    ],
    exports: [RouterModule],
})
export class AdminRoutingModule {
    constructor(private router: Router) {
        router.events.subscribe((event) => {
            if (event instanceof NavigationEnd) {
                window.scroll(0, 0);
            }
        });
    }
}
