import { Injectable } from '@angular/core';
import { CommonService } from '../Common/common.service';
import { UnitFilter } from 'src/app/@filter/MD/unit-filter.model';
import { T_MD_UNIT } from 'src/app/models/MD/T_MD_UNIT.model';

@Injectable({
  providedIn: 'root'
})
export class UnitService {
  constructor(private _commonService : CommonService) { }
  
  getListUnit(pagination? : UnitFilter){
    var url = `/api/Unit/GetList?CurrentPage=${pagination?.CurrentPage}&PageSize=${pagination?.PageSize}&KeySearch=${pagination?.KeySearch}`
    return this._commonService.getRequest(url)
  }

  searchUnit(pagination? : UnitFilter){
    var url = `/api/Unit/GetList?CurrentPage=${pagination?.CurrentPage}&PageSize=${pagination?.PageSize}&KeySearch=${pagination?.KeySearch}`
    return this._commonService.getRequestWithoutLoading(url)
  }

  updateUnit(request : T_MD_UNIT){
    return this._commonService.putRequestWithoutMessage(`/api/Unit/Update`, request)
  }
}