import { Component, OnInit, Inject } from '@angular/core';
import { JQUERY_TOKEN } from '../../common/jquery.service';

@Component({
  selector: 'app-product-details',
  templateUrl: './product-details.component.html',
  styleUrls: ['./product-details.component.css']
})
export class ProductDetailsComponent implements OnInit {

  constructor(@Inject(JQUERY_TOKEN) private $: any) { }

  ngOnInit() {
    this.$('.menu .item').tab();
  }

}
