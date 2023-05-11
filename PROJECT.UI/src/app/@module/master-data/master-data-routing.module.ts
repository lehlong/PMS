import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { UnitComponent } from './unit/unit.component';
import { SaleOfficeComponent } from './sale-office/sale-office.component';

const routes: Routes = [
    {path:'Unit', component: UnitComponent},
    {path:'SaleOffice', component: SaleOfficeComponent}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MasterDataRoutingModule { }
