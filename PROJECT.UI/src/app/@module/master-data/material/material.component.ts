import { Component, OnInit } from '@angular/core';
import { MaterialFilter } from 'src/app/@filter/MD/material-filter.model';
import { T_MD_MATERIAL } from 'src/app/models/MD/T_MD_MATERIAL.model';
import { MaterialService } from 'src/app/services/MD/material.service';

@Component({
  selector: 'app-material',
  templateUrl: './material.component.html'
})
export class MaterialComponent implements OnInit {
  constructor(private _service: MaterialService) { }

  listMaterial: T_MD_MATERIAL[] = [];
  filter: MaterialFilter = {
    CurrentPage: 1,
    TotalPage: 0,
    ItemCount: 0,
    PageSize: 15,
    KeySearch: 'Empty',
    Data: []
  }
  ngOnInit(): void {
    this._service.getListMaterial(this.filter)
      .subscribe({
        next: (response) => {
          this.listMaterial = response.Data.Data;
          this.filter = response.Data;
        },
        error: (response) => { console.log(response) }
      });
  }
  searchMaterial(event: any) {
    this.filter.CurrentPage = 1;
    if (event.target.value) {
      this.filter.KeySearch = event.target.value;
    } else {
      this.filter.KeySearch = "Empty"
    }
    this._service.searchMaterial(this.filter)
      .subscribe({
        next: (response) => {
          this.listMaterial = response.Data.Data;
          this.filter = response.Data;
        },
        error: (response) => { console.log(response); }
      });
  }
  onChangePage(event: any) {
    this.filter.CurrentPage = event;
    this._service.searchMaterial(this.filter)
      .subscribe({
        next: (response) => {
          this.listMaterial = response.Data.Data;
          this.filter = response.Data;
        },
        error: (response) => { console.log(response); }
      });
  }

  updateMaterial(item : T_MD_MATERIAL){
    this._service.updateMaterial(item);
  }
}
