import { Injectable } from '@angular/core';
import { CommonService } from '../Common/common.service';

@Injectable({
  providedIn: 'root'
})
export class OrganizeService {
  constructor(private _commonService : CommonService) { }
 
  buildTreeOrganize() {
    return this._commonService.getRequest('/api/Organize/BuildTree')
  }
  getDetailOrganize(pkid: string) {
    return this._commonService.getRequest(`/api/Organize/GetDetail?pkid=${pkid}`)
  }
  updateOrganize(request : any){
    return this._commonService.putRequest('/api/Organize/Update', request)
  }
  createOrganize(request : any){
    debugger;
    return this._commonService.postRequest('/api/Organize/Create', request)
  }
}