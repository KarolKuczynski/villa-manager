import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { GuestListComponent } from './guests/guest-list/guest-list.component';
import { GuestEditComponent } from './guests/guest-edit/guest-edit.component';
import { RoomListComponent } from './rooms/room-list/room-list.component';
import { RoomEditComponent } from './rooms/room-edit/room-edit.component';
import { HomeComponent } from './home/home.component';

@NgModule({
  declarations: [AppComponent, GuestListComponent, GuestEditComponent, RoomListComponent, RoomEditComponent, HomeComponent],
  imports: [BrowserModule, AppRoutingModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
