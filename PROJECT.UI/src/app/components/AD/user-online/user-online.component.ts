import { Component, OnInit, ViewChild } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { T_AD_USER } from 'src/app/models/AD/T_AD_USER.model';
import { HistoryLoginService } from 'src/app/services/AD/history-login.service';
declare function ShowLoading() :any
declare function HideLoading() :any

@Component({
  selector: 'app-right',
  templateUrl: './user-online.component.html',
  styleUrls: ['./user-online.component.css'],
})
export class UserOnlineComponent implements OnInit {

  constructor(public _service: HistoryLoginService, private router: Router, private route: ActivatedRoute) { }

  lstUserOnline: T_AD_USER[] = [];

  ngOnInit(): void {
    // this._service.userOnline()
    //   .subscribe({
    //     next: (response) => {
    //       this.lstUserOnline = response
    //     },
    //     error: (response) => {
    //       console.log(response)
    //     }
    //   });
  }
}