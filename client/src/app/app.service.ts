import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {EquityCalCulator} from "./models/model";

@Injectable({
  providedIn: 'root'
})
export class AppService {
  baseUrl = 'https://localhost:5001/api/equitycalculator/calculator';
  constructor(private http: HttpClient) { }

  onSave(values: any) {
    return this.http.post<EquityCalCulator>(this.baseUrl, values)
  }
}
