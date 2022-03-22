import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';

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
    return this.http.get('https://localhost:7041/calculator/' + c, { headers, params: new HttpParams().set('a', a).set('b', b) });
   
  }

  public calculatePrime(a: any) {
    const headers = { 'content-type': 'application/json' }
    return this.http.get('https://localhost:7041/calculator/prime', { headers, params: new HttpParams().set('a', a) });
   
    }
  }

