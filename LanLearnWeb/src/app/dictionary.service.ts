import { Injectable } from '@angular/core';
import { Http } from '@angular/http';

@Injectable()
export class DictionaryService {

    constructor(private http: Http) {}

    getDictionaries() {
        return this.http.get('http://localhost:57245/api/values');
    }
}
