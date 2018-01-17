import { Component, OnInit } from '@angular/core';
import { ProductsService } from '../common/index';

@Component({
  selector: 'app-main-content',
  templateUrl: './main-content.component.html',
  styleUrls: ['./main-content.component.css']
})
export class MainContentComponent implements OnInit {
  categories: string[];

  constructor(private productService: ProductsService) { }

  ngOnInit() {
    this.productService.getCategories().subscribe(data => {
      this.categories = <string[]>data;
    });
  }

}
