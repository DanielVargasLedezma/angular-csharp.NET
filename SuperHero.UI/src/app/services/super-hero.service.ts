import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { SuperHero } from '../models/super-hero';

@Injectable({
  providedIn: 'root',
})
export class SuperHeroService {
  private url: String = 'SuperHero';

  constructor(private htttp: HttpClient) {}

  public getSuperHeroes(): Observable<SuperHero[]> {
    return this.htttp.get<SuperHero[]>(`${environment.baseApiUrl}/${this.url}`);
  }
}
