import { Injectable, Inject } from '@angular/core';
import { HttpClient} from '@angular/common/http';
import { Observable, } from 'rxjs';
import { map } from 'rxjs/operators'
import { Router } from '@angular/router';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';

@Injectable()
export class EmployeeService {
  myAppUrl: string = "";

  constructor(private _http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.myAppUrl = baseUrl;
  }

  getDepaList() {
    return this._http.get(this.myAppUrl + 'api/Empleado/GetDepaList')
      .pipe(map((response: Response) => response.json()))
  }

  getEmpleados() {
    return this._http.get(this.myAppUrl + 'api/Empleado/Index')
      .pipe(map((response: Response) => response.json()))
   
  }

  getEmpleadoById(id: number) {
    return this._http.get(this.myAppUrl + "api/Empleado/Details/" + id)
      .pipe(map((response: Response) => response.json()))
  }

  saveEmpleado(employee) {
    return this._http.post(this.myAppUrl + 'api/Empleado/Create', employee)
      .pipe(map((response: Response) => response.json()))
  }

  saveDepartamento(departamento) {
    return this._http.post(this.myAppUrl + 'api/Departamento/Create', departamento)
      .pipe(map((response: Response) => response.json()))
  }

  updateEmpleado(employee) {
    return this._http.put(this.myAppUrl + 'api/Empleado/Edit', employee)
      .pipe(map((response: Response) => response.json()))
  }

  deleteEmpleado(id) {
    return this._http.delete(this.myAppUrl + "api/Empleado/Delete/" + id)
      .pipe(map((response: Response) => response.json()))
  }

  
}  
