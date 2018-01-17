import { Component, OnInit } from '@angular/core';
import { ProductsService } from '../common/index';
import { IVendor } from '../vendors/shared/vendor.model';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  products: string[];
  vendors: IVendor[];

  constructor(private productsService: ProductsService) { }

  ngOnInit() {
    this.productsService.getProducts().subscribe(data => {
      this.products = <string[]> data;
    });

    this.productsService.getVendors().subscribe(data => {
      this.vendors = <IVendor[]> data;
    });
  }

}
