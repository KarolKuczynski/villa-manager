import { environment } from '../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export abstract class BaseService {
  private readonly baseUrl: string = environment.apiUrl;
  protected readonly url: string;

  constructor(controller: string, private httpClient: HttpClient) {
    this.url = this.baseUrl + controller + '/';
  }

  protected get<T>(params: string = ''): Observable<T> {
    return this.httpClient.get<T>(this.url + params);
  }
}
