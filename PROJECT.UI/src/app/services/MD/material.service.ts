import { Injectable } from '@angular/core';
import { CommonService } from '../Common/common.service';
import { MaterialFilter } from 'src/app/@filter/MD/material-filter.model';
import { T_MD_MATERIAL } from 'src/app/models/MD/T_MD_MATERIAL.model';

@Injectable({
  providedIn: 'root'
})
export class MaterialService {
  constructor(private _commonService : CommonService) { }
  
  getListMaterial(pagination? : MaterialFilter){
    var url = `/api/Material/GetList?CurrentPage=${pagination?.CurrentPage}&PageSize=${pagination?.PageSize}&KeySearch=${pagination?.KeySearch}`
    return this._commonService.getRequest(url)
  }

  searchMaterial(pagination? : MaterialFilter){
    var url = `/api/Material/GetList?CurrentPage=${pagination?.CurrentPage}&PageSize=${pagination?.PageSize}&KeySearch=${pagination?.KeySearch}`
    return this._commonService.getRequestWithoutLoading(url)
  }

  updateMaterial(request : T_MD_MATERIAL){
    return this._commonService.putRequestWithoutMessage(`/api/Material/Update`, request)
  }
}