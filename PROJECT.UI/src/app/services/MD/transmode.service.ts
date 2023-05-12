import { Injectable } from '@angular/core';
import { CommonService } from '../Common/common.service';
import { TransmodeFilter } from 'src/app/@filter/MD/transmode-filter.model';
import { T_MD_TRANSMODE } from 'src/app/models/MD/T_MD_TRANSMODE.model';

@Injectable({
  providedIn: 'root'
})
export class TransmodeService {
  constructor(private _commonService : CommonService) { }
  
  getListTransmode(pagination? : TransmodeFilter){
    var url = `/api/Transmode/GetList?CurrentPage=${pagination?.CurrentPage}&PageSize=${pagination?.PageSize}&KeySearch=${pagination?.KeySearch}`
    return this._commonService.getRequest(url)
  }

  searchTransmode(pagination? : TransmodeFilter){
    var url = `/api/Transmode/GetList?CurrentPage=${pagination?.CurrentPage}&PageSize=${pagination?.PageSize}&KeySearch=${pagination?.KeySearch}`
    return this._commonService.getRequestWithoutLoading(url)
  }

  updateTransmode(request : T_MD_TRANSMODE){
    return this._commonService.putRequestWithoutMessage(`/api/Transmode/Update`, request)
  }
}