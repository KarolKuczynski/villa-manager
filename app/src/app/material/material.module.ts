import { NgModule } from '@angular/core';
import { MatIconModule } from '@angular/material/icon';
import {MatInputModule} from '@angular/material/input';
import {MatButtonModule} from '@angular/material/button';

@NgModule({
    exports: [
      MatIconModule,
      MatInputModule,
      MatButtonModule
    ],
  })
  export class MaterialModule {}