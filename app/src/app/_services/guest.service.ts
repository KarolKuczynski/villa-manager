import { BaseService } from './base.service';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Guest } from '../_models/guest.model';
import { Injectable } from '@angular/core';

@Injectable()
export class GuestService extends BaseService {
  constructor(private http: HttpClient) {
    super('guests', http);
  }

  getGuests(): Observable<Guest[]> {
    return this.get<Guest[]>();
  }
}
