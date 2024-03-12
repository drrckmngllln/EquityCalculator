import { Component } from '@angular/core';
import {FormBuilder, Validators} from "@angular/forms";
import {AppService} from "./app.service";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'client';

  equity: any[] = [];
  constructor(private fb: FormBuilder, private appService: AppService) {
  }

  equityForm = this.fb.group({
    sellingPrice: ['', Validators.required],
    reservationDate: ['', Validators.required],
    equityTerm: ['', Validators.required]
  })

  onSubmit() {
    this.appService.onSave(this.equityForm.value).subscribe({
      next: (response: any) => {
        console.log(response);
        this.equity = response;
      }
    })
  }
}
