import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { T_AD_ORGANIZE } from 'src/app/models/AD/T_AD_ORGANIZE.model';
import { OrganizeService } from 'src/app/services/AD/organize.service';

@Component({
  selector: 'app-organize-edit',
  templateUrl: './organize-edit.component.html'
})
export class OrganizeEditComponent implements OnInit {
  constructor(private route: ActivatedRoute, private router: Router, private _service: OrganizeService) { }
  itemDetail: T_AD_ORGANIZE = {
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
  ngOnInit(): void {
    this.route.paramMap.subscribe({
      next: (params) => {
        console.log(params)
        const id = params.get('code');
        if (id) {
          this._service.getDetailOrganize(id)
            .subscribe({
              next: (response) => { this.itemDetail = response.Data; },
              error: (response) => { console.log(response); }
            });
        }
      }
    })
  }
  updateOrganize() {
    this._service.updateOrganize(this.itemDetail)
      .subscribe({
        next: (response) => {
          this.router.navigate(['SystemManage/Organize/List'])
        }
      })
  }
}
