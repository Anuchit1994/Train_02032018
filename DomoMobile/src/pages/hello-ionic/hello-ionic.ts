import { CallApiProvider } from './../../providers/call-api/call-api';
import { Component } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';

@Component({
  selector: 'page-hello-ionic',
  templateUrl: 'hello-ionic.html'
})
export class HelloIonicPage {

  public getData: any;
  public user: FormGroup

  constructor(public callAPI: CallApiProvider, public fb: FormBuilder) {
    this.user = this.fb.group({
      'text': null
    })
  }

  ionViewDidLoad() {
    this.get();
  }

  get() {
    this.callAPI.getAllName()
      .subscribe(data => {
        console.log("get Done");
        this.getData = data;
      });
  }

  post() {
    this.callAPI.postData(this.user.get('text').value)
      .subscribe(data => {
        console.log("post Done");
        this.get();
      });
  }
}
