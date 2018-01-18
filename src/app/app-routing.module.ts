import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HowItWorksComponent } from './how-it-works/how-it-works.component';
import { FaqComponent } from './faq/faq.component';
import { MainContentComponent } from './main-content/main-content.component';
import { VendorsComponent } from './vendors/vendors.component';

const routes: Routes = [
  { path: 'how-it-works', component: HowItWorksComponent },
  {
    path: 'products',
    loadChildren: 'app/products/products.module#ProductsModule'
  },
  { path: 'vendors', component: VendorsComponent },
  { path: 'faq', component: FaqComponent },
  { path: '', component: MainContentComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
