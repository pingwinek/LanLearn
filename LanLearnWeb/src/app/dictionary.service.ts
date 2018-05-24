import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import { Observable } from 'rxjs';
import { Dictionary } from './dictionary.model';

import { Headers, Response } from '@angular/http';
import { map } from 'rxjs/operators';

@Injectable()
export class DictionaryService {

    constructor(private http: Http) {}

    getDictionaries(): Observable<Dictionary[]> {
        return this.http.get('http://localhost:57245/api/values')
        .pipe(map(res => res.json()));
    }
}
