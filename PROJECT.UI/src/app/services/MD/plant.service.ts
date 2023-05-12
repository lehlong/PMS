import { Injectable } from '@angular/core';
import { CommonService } from '../Common/common.service';
import { PlantFilter } from 'src/app/@filter/MD/plant-filter.model';

@Injectable({
  providedIn: 'root'
})
export class PlantService {
  constructor(private _commonService : CommonService) { }
  
  getListPlant(pagination? : PlantFilter){
    var url = `/api/Plant/GetList?CurrentPage=${pagination?.CurrentPage}&PageSize=${pagination?.PageSize}&KeySearch=${pagination?.KeySearch}`
    return this._commonService.getRequest(url)
  }

  searchPlant(pagination? : PlantFilter){
    var url = `/api/Plant/GetList?CurrentPage=${pagination?.CurrentPage}&PageSize=${pagination?.PageSize}&KeySearch=${pagination?.KeySearch}`
    return this._commonService.getRequestWithoutLoading(url)
  }
}