import { Component, OnInit, ViewChild } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { T_AD_USER } from 'src/app/models/AD/T_AD_USER.model';
import { UserService } from 'src/app/services/AD/user.service';
import { AppComponent } from 'src/app/app.component';
import * as jQuery from 'jquery';
import { Select } from 'src/app/models/Common/select.model';
import { OrganizeService } from 'src/app/services/AD/organize.service';

declare function MessageSuccess(response: string): any
declare function MessageDanger(response: string): any
declare function ShowLoading(): any
declare function HideLoading(): any

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css'],
})
export class UserComponent implements OnInit {

  constructor(public _serviceUser: UserService, public _app: AppComponent,
    private _serviceOrganize: OrganizeService) { }

  dataUser: T_AD_USER[] = [];
  dataUserSearch: T_AD_USER[] = [];
  requestForAdd: T_AD_USER = {
    USER_NAME: '',
    PASSWORD: '',
    ACCOUNT_AD: '',
    FULL_NAME: '',
    EMAIL: '',
    ADDRESS: '',
    PHONE: '',
    NOTES: '',
    ACTIVE: '',
    OTP_VERIFY: '',
    USER_TYPE: '',
    TITLE_CODE: '',
    COMPANY_ID: '',
    IS_MODIFY_RIGHT: '',
    VENDOR_CODE: '',
    USER_SAP: '',
    PASSWORD_SAP: '',
    LAST_CHANGE_PASS_DATE: new Date(),
    CREATE_BY: '',
    CREATE_DATE: new Date(),
    UPDATE_BY: '',
    UPDATE_DATE: new Date(),
  }

  dataTitle: Select[] = [];
  dataVendor: Select[] = [];
  dataCP: Select[] = [];
  dataBP: Select[] = [];

  pageSize : number = 15;
  page : number = this.dataUser.length / this.pageSize;

  getNameTitle(titleCode: string) {
    var item = this.dataTitle.find(x => x.id == titleCode);
    return item?.name;
  }

  getNameOrganize(organizeId: string) {
    var item = this.dataBP.find(x => x.id == organizeId);
    return item?.name;
  }

  ngOnInit(): void {
    ShowLoading();
    this._serviceUser.getListUser()
      .subscribe({
        next: (response) => {
          //this.dataUser = response;
          //this.dataUserSearch = response;
          HideLoading();
        },
        error: (response) => {
          console.log(response)
        }
      });
  }

  createUser() {
    this._serviceUser.createUser(this.requestForAdd)
      .subscribe({
        next: (response) => {
          this.ngOnInit();
          (function ($) {
            $(".btn-close").click();
          })(jQuery);
          MessageSuccess("Thêm mới  thành công");
        },
        error: (response) => {
          console.log(response)
          MessageDanger('Thêm mới không thành công! Đã có lỗi xảy ra!');
        }
      })
  }

  searchUser(event: any) {
    var key = event.target.value;
    if (!key) {
      this.dataUserSearch = this.dataUser;
    } else {
      var result = this.dataUser.filter(x => x.USER_NAME.toLowerCase().includes(key.toLowerCase()) || x.FULL_NAME.toLowerCase().includes(key.toLowerCase()))
      if (result) {
        this.dataUserSearch = result;
      }
    }
  }

}
