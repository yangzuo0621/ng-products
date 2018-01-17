import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';

import { AppComponent } from './app.component';
import { NavComponent } from './nav/nav.component';
import { HowItWorksComponent } from './how-it-works/how-it-works.component';
import { FaqComponent } from './faq/faq.component';
import { FooterComponent } from './footer/footer.component';
import { MainContentComponent } from './main-content/main-content.component';

import {
  JQUERY_TOKEN,
  ProductsService
} from './common/index';

declare let jQuery: Object;

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    HowItWorksComponent,
    FaqComponent,
    FooterComponent,
    MainContentComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule
  ],
  providers: [
    ProductsService,
    { provide: JQUERY_TOKEN, useValue: jQuery }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
