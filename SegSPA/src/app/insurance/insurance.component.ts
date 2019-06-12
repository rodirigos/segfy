import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Component({
  selector: 'app-insurance',
  templateUrl: './insurance.component.html',
  styleUrls: ['./insurance.component.css']
})
export class InsuranceComponent implements OnInit {
  model: any = {};
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

  createInsurance() {
      this.http.post('http://localhost:5000/api/insurance' + '/create', this.model)
      .subscribe(response => {
        this.getAllInsurances();
      });
  }

  clear() {
    this.model.id = null;
    this.model.policyNumber = '';
    this.model.cpfcnpj = '';
    this.model.idAuto = '';
    this.model.prizeValue = '';
  }

  updateInsurance() {
    this.http.put('http://localhost:5000/api/insurance/' + this.model.id, this.model)
    .subscribe(response => {
      this.getAllInsurances();
    });
  }

  removeInsurance() {
    this.http.delete('http://localhost:5000/api/insurance/' + this.model.id)
    .subscribe(response => {
      this.getAllInsurances();
    });
  }

  clickInsurance(insurance: any) {
    this.model.id = insurance.id;
    this.model.policyNumber = insurance.policyNumber;
    this.model.cpfcnpj = insurance.cpfcnpj;
    this.model.idAuto = insurance.idAuto;
    this.model.prizeValue = insurance.prizeValue;
  }

}
