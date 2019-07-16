import { Injectable } from '@angular/core';
import { Seed } from './seed.model';
import { HttpClient } from '@angular/common/http'

@Injectable({
  providedIn: 'root'
})
export class SeedsService {
formData:Seed;
readonly rootURL = 'https://localhost:44382/api/';

  constructor(private http:HttpClient) { }

  postSeed(formData:Seed){
   return this.http.post(this.rootURL+'/MCSeed', formData)
  }
}
