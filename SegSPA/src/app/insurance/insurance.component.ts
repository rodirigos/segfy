import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-insurance',
  templateUrl: './insurance.component.html',
  styleUrls: ['./insurance.component.css']
})
export class InsuranceComponent implements OnInit {

  insurances: any;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getAllInsurances();
  }
  getAllInsurances() {
    this.http.get('http://localhost:5000/api/insurance').subscribe(response => {
      this.insurances = response;
      console.log(response);
    }, error => {
      console.log(error);
    });
  }

}
