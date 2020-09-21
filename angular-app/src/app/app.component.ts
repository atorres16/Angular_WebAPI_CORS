import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Employee } from './models/employee';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'angular-app';
  Employees: Employee[];
  constructor(private httpClient: HttpClient) {

  }
  ngOnInit(): void {
    this.httpClient.get<Employee[]>('http://localhost:54125/api/employees')
      .subscribe((employees: Employee[]) => {
        this.Employees = employees;
      });
  }



}
