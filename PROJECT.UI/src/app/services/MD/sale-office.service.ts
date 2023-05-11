import { Injectable } from '@angular/core';
import { CommonService } from '../Common/common.service';
import { SaleOfficeFilter } from 'src/app/@filter/MD/sale-office-filter.model';
import { T_MD_SALEOFFICE } from 'src/app/models/MD/T_MD_SALEOFFICE.model';

@Injectable({
  providedIn: 'root'
})
export class SaleOfficeService {
  constructor(private _commonService : CommonService) { }
  
  getListSaleOffice(pagination? : SaleOfficeFilter){
    var url = `/api/SaleOffice/GetList?CurrentPage=${pagination?.CurrentPage}&PageSize=${pagination?.PageSize}&KeySearch=${pagination?.KeySearch}&Organize=${pagination?.Organize}`
    return this._commonService.getRequest(url)
  }

  searchSaleOffice(pagination? : SaleOfficeFilter){
    var url = `/api/SaleOffice/GetList?CurrentPage=${pagination?.CurrentPage}&PageSize=${pagination?.PageSize}&KeySearch=${pagination?.KeySearch}&Organize=${pagination?.Organize}`
    return this._commonService.getRequestWithoutLoading(url)
  }

  updateSaleOffice(request : T_MD_SALEOFFICE){
    return this._commonService.putRequestWithoutMessage(`/api/SaleOffice/Update`, request)
  }
}