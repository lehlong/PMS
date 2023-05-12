import { Injectable } from '@angular/core';
import { CommonService } from '../Common/common.service';
import { DischardFilter } from 'src/app/@filter/MD/dischard-filter.model';
import { T_MD_DISCHARD } from 'src/app/models/MD/T_MD_DISCHARD.model';

@Injectable({
  providedIn: 'root'
})
export class DischardService {
  constructor(private _commonService : CommonService) { }
  
  getListDischard(pagination? : DischardFilter){
    var url = `/api/Dischard/GetList?CurrentPage=${pagination?.CurrentPage}&PageSize=${pagination?.PageSize}&KeySearch=${pagination?.KeySearch}`
    return this._commonService.getRequest(url)
  }

  searchDischard(pagination? : DischardFilter){
    var url = `/api/Dischard/GetList?CurrentPage=${pagination?.CurrentPage}&PageSize=${pagination?.PageSize}&KeySearch=${pagination?.KeySearch}`
    return this._commonService.getRequestWithoutLoading(url)
  }

  updateDischard(request : T_MD_DISCHARD){
    return this._commonService.putRequestWithoutMessage(`/api/Dischard/Update`, request)
  }
}