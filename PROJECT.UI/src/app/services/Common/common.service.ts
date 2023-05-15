import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { environment } from 'src/environments/environment';
import { TranferObject } from 'src/app/models/Common/tranfer-object.model';
import { share } from 'rxjs';
declare function ShowLoading(): any
declare function HideLoading(): any
declare function Message(response: TranferObject): any

@Injectable({
    providedIn: 'root'
})
export class CommonService {

    token = localStorage.getItem('jwt');
    headers = new HttpHeaders({
        'Content-Type': 'application/json',
        'Authorization': `Bearer ${this.token}`,
        'Language': `${localStorage.getItem('lang')}`
    });
    requestOptions = { headers: this.headers };

    apiUrl: string = environment.baseApiUrl;

    constructor(private http: HttpClient) { }

    getRequest(url: string, params?: any): Observable<TranferObject> {
        debugger
        if (params && params.IsLoading) {
            ShowLoading();
        }
        var tranferObject = this.http.get<TranferObject>(this.apiUrl + url, { headers: this.headers, params: params }).pipe(share())
        tranferObject.subscribe({
            next: (response) => {
                HideLoading();
                if (response.Message?.MessageType == "E") {
                    Message(response);
                }
            },
            error: (response) => { HideLoading(); }
        })
        return tranferObject;
    }

    postRequest(url: string, request: any): Observable<TranferObject> {
        ShowLoading();
        var tranferObject = this.http.post<TranferObject>(this.apiUrl + url, request, this.requestOptions).pipe(share())
        tranferObject.subscribe({
            next: (response) => { Message(response) },
            error: (response) => { Message(response) }
        })
        HideLoading();
        return tranferObject;
    }
    postRequestWithoutLoading(url: string, request: any): Observable<TranferObject> {
        var tranferObject = this.http.post<TranferObject>(this.apiUrl + url, request, this.requestOptions).pipe(share())
        tranferObject.subscribe({
            next: (response) => { Message(response) },
            error: (response) => { Message(response) }
        })
        return tranferObject;
    }

    putRequest(url: string, request: any): Observable<TranferObject> {
        ShowLoading();
        var tranferObject = this.http.put<TranferObject>(this.apiUrl + url, request, this.requestOptions).pipe(share())
        tranferObject.subscribe({
            next: (response) => { Message(response) },
            error: (response) => { Message(response) }
        })
        HideLoading();
        return tranferObject;
    }

    putRequestWithoutLoading(url: string, request: any): Observable<TranferObject> {
        var tranferObject = this.http.put<TranferObject>(this.apiUrl + url, request, this.requestOptions).pipe(share())
        tranferObject.subscribe({
            next: (response) => { Message(response) },
            error: (response) => { Message(response) }
        })
        return tranferObject;
    }

    putRequestWithoutMessage(url: string, request: any): Observable<TranferObject> {
        var tranferObject = this.http.put<TranferObject>(this.apiUrl + url, request, this.requestOptions).pipe(share())
        tranferObject.subscribe({
            next: (response) => { },
            error: (response) => { console.log(response) }
        })
        return tranferObject;
    }

    deleteRequest(url: string): Observable<TranferObject> {
        ShowLoading();
        var tranferObject = this.http.delete<TranferObject>(this.apiUrl + url, this.requestOptions).pipe(share())
        tranferObject.subscribe({
            next: (response) => { Message(response) },
            error: (response) => { Message(response) }
        })
        HideLoading();
        return tranferObject;
    }

    deleteRequestWithoutLoading(url: string): Observable<TranferObject> {
        var tranferObject = this.http.delete<TranferObject>(this.apiUrl + url, this.requestOptions).pipe(share())
        tranferObject.subscribe({
            next: (response) => { Message(response) },
            error: (response) => { Message(response) }
        })
        return tranferObject;
    }
}