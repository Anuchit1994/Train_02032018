import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable()
export class CallApiProvider {

  constructor(public http: HttpClient) {
    console.log('Hello CallApiProvider Provider');
  }

  public getAllName() {
    return this.http.get("http://localhost:5000/api/Demo/Get");
  }

  public postData(data: string) {
    return this.http.post("http://localhost:5000/api/Demo/Post/" + data, []);
  }

}
