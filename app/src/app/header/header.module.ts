import { NgModule } from '@angular/core';
import { HeaderComponent } from './header.component';

import { SharedModule } from '../shared/shared.module';
import { HeaderSearchComponent } from './header-search/header-search.component';

@NgModule({
  declarations: [HeaderComponent, HeaderSearchComponent],
  imports: [
    SharedModule
  ],
  exports: [HeaderComponent]
})
export class HeaderModule { }
