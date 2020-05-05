import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { GuestListComponent } from './guests/guest-list/guest-list.component';
import { RoomListComponent } from './rooms/room-list/room-list.component';
import { HomeComponent } from './home/home.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'guests', component: GuestListComponent },
  { path: 'rooms', component: RoomListComponent },
  { path: '**', redirectTo: '', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
