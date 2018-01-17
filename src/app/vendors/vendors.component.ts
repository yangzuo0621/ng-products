import { Component, OnInit } from '@angular/core';
import { ProductsService } from '../common/index';
import { IVendor } from './shared/vendor.model';

@Component({
  selector: 'app-vendors',
  templateUrl: './vendors.component.html',
  styleUrls: ['./vendors.component.css']
})
export class VendorsComponent implements OnInit {
  vendors: IVendor[];

  constructor(private productsService: ProductsService) { }

  ngOnInit() {
    this.productsService.getVendors().subscribe(data => {
      this.vendors = <IVendor[]>data;
    });
  }

}
