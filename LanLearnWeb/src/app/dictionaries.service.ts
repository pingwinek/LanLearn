import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';

import { Observable } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { HttpErrorHandler, HandleError } from './http-error-handler.service';

import { Headers, Response } from '@angular/http';
import { map } from 'rxjs/operators';

import { Dictionary } from './dictionary.model';
import { Translate } from './translate.model';

const httpOptions = {
    headers: new HttpHeaders({
        'Content-Type': 'application/json',
        'Authorization': 'my-auth-token'
    })
};

@Injectable()
export class DictionariesService {
    private handleError: HandleError;

    constructor(private http: HttpClient,
        httpErrorHandler: HttpErrorHandler) {
        this.handleError = httpErrorHandler.createHandleError('DictionariesService');
    }

    /** GET dictionaries from the server */
    getDictionaries(): Observable<Dictionary[]> {
        return this.http.get<Dictionary[]>('http://localhost:57245/api/values')
            .pipe(
                catchError(this.handleError('getDictionaries', []))
            );
    }

    /** POST: add translate to the database */
    sendTranslate(translate: Translate[]): Observable<Translate[]> {
        return this.http.post<Translate[]>('http://localhost:57245/api/values', translate, httpOptions)
            .pipe(
                catchError(this.handleError('sendTranslate', translate))
            );
    }
}
