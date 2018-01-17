import { Component, OnInit } from '@angular/core';
import { ProductsService } from '../common/products.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  products: string[];
  categories: string[];

  constructor(private productService: ProductsService) { }

  ngOnInit() {
    this.productService.getProducts().subscribe(data => {
      this.products = <string[]> data;
    });

    this.productService.getCategories().subscribe(data => {
      this.categories = <string[]> data;
    });
  }

}
