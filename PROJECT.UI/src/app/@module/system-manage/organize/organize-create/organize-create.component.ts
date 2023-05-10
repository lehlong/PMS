import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { T_AD_ORGANIZE } from 'src/app/models/AD/T_AD_ORGANIZE.model';
import { OrganizeService } from 'src/app/services/AD/organize.service';

@Component({
  selector: 'app-organize-create',
  templateUrl: './organize-create.component.html'
})
export class OrganizeCreateComponent {
  constructor(private router: Router, private _service: OrganizeService){}
  itemCreate: T_AD_ORGANIZE = {
    PKID: '',
    COMPANY_CODE: '',
    PARENT: '',
    NAME: '',
    TYPE: '',
    C_ORDER: 0,
    COST_CENTER_CODE: '',
    CREATE_BY: '',
    CREATE_DATE: new Date(),
    UPDATE_BY: '',
    UPDATE_DATE: new Date(),
  }

  createOrganize() {
    this._service.createOrganize(this.itemCreate)
      .subscribe({
        next: (response) => {
          this.router.navigate(['SystemManage/Organize/List'])
        }
      })
  }
}
