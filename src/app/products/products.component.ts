import { Component, OnInit } from '@angular/core';
import { ProductsService } from '../common/index';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {
  categories: string[];

  constructor(private productsService: ProductsService) { }

  ngOnInit() {
    this.productsService.getCategories().subscribe(data => {
      this.categories = <string[]>data;
    });
  }

}
