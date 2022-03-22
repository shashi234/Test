import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AngularserviceService {

  private http: HttpClient;
  public r: any;

  constructor(private _http: HttpClient) {
    this.http = _http;
  }

  public calculate(a: any, b: any, c: string) {
    const headers = { 'content-type': 'application/json' }
    return this.http.get('https://localhost:44381/Calculator.asmx/' + c, { headers, params: new HttpParams().set('a', a).set('b', b)});
   
    }
  }

