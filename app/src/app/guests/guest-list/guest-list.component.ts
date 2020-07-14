import { Component, OnInit } from '@angular/core';
import { Guest } from '../../_models/guest.model';
import { GuestService } from '../../_services/guest.service';

@Component({
  selector: 'app-guest-list',
  templateUrl: './guest-list.component.html',
  styleUrls: ['./guest-list.component.scss'],
})
export class GuestListComponent implements OnInit {
  public guests: Guest[] = [];

  constructor(private guestsService: GuestService) {}

  ngOnInit() {
    this.guestsService.getGuests().subscribe((result) => {
      console.log(result);
      this.guests = result;
    });
  }
}
