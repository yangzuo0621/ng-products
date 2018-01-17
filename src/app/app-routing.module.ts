import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HowItWorkComponent } from './how-it-work/how-it-work.component';
import { FaqComponent } from './faq/faq.component';

const routes: Routes = [
  { path: 'how-it-works', component: HowItWorkComponent },
  { path: 'faq', component: FaqComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
