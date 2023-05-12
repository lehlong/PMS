import { Injectable } from '@angular/core';
import { CommonService } from '../Common/common.service';
import { VehicleFilter } from 'src/app/@filter/MD/vehicle-filter.model';
import { T_MD_VEHICLE } from 'src/app/models/MD/T_MD_VEHICLE.model';

@Injectable({
  providedIn: 'root'
})
export class VehicleService {
  constructor(private _commonService : CommonService) { }
  
  getListVehicle(pagination? : VehicleFilter){
    var url = `/api/Vehicle/GetList?CurrentPage=${pagination?.CurrentPage}&PageSize=${pagination?.PageSize}&KeySearch=${pagination?.KeySearch}`
    return this._commonService.getRequest(url)
  }

  searchVehicle(pagination? : VehicleFilter){
    var url = `/api/Vehicle/GetList?CurrentPage=${pagination?.CurrentPage}&PageSize=${pagination?.PageSize}&KeySearch=${pagination?.KeySearch}`
    return this._commonService.getRequestWithoutLoading(url)
  }

  updateVehicle(request : T_MD_VEHICLE){
    return this._commonService.putRequestWithoutMessage(`/api/Vehicle/Update`, request)
  }
}