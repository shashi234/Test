import { XmlParser } from '@angular/compiler';
import { Component } from '@angular/core';
import { first, map } from 'rxjs/operators';

import { AngularserviceService } from './angularservice.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent {

  private r: AngularserviceService
  public result: any;
  

  constructor(private cal: AngularserviceService) {
    this.r = cal;
    this.result = 0;
  } 

  calculate(a: any, b: any, c: string) {
    this.r.calculate(a, b, c).pipe(first()).subscribe(result => {
      this.result = result;      
    }, error => console.error(error));
  }

  
}
