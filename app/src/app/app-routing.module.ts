import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { GuestListComponent } from './guests/guest-list/guest-list.component';
import { RoomListComponent } from './rooms/room-list/room-list.component';
import { HomeComponent } from './home/home.component';
import { GuestEditComponent } from './guests/guest-edit/guest-edit.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'guests', component: GuestListComponent },
  { path: 'guests/:id', component: GuestEditComponent },
  { path: 'rooms', component: RoomListComponent },
  { path: '**', redirectTo: '', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { relativeLinkResolution: 'legacy' })],
  exports: [RouterModule],
})
export class AppRoutingModule {}
