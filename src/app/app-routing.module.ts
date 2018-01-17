import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HowItWorkComponent } from './how-it-work/how-it-work.component';

const routes: Routes = [
  { path: 'how-it-works', component: HowItWorkComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
