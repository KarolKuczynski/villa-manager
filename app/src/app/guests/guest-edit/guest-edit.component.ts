import { Component, OnInit, Input } from '@angular/core';
import { Guest } from 'src/app/_models/guest.model';

@Component({
  selector: 'app-guest-edit',
  templateUrl: './guest-edit.component.html',
  styleUrls: ['./guest-edit.component.scss'],
})
export class GuestEditComponent implements OnInit {
  @Input() guest: Guest;

  constructor() {}

  ngOnInit(): void {}
}
