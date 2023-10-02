import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { User } from '../Interfaces/user.interface';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  private corsHeaders: HttpHeaders;
  constructor(private http: HttpClient) {
    this.corsHeaders= new HttpHeaders({
      'Content-Type': 'application/json',
      'Accept': 'application/json',
      'Access-Control-Allow-Origin': 'http://localhost:4200'
    })
   }
  getUsers(){
  return this.http.get<User[]>('https://localhost:44390/api/values', {headers: this.corsHeaders});
  }
}
