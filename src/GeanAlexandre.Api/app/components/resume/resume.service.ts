import {Http} from '@angular/http'
import {Injectable} from "@angular/core";

@Injectable()
export class ResumeService {

    private readonly http: Http;

    constructor(http: Http) {
        this.http = http
    }

    public static getResume(userName: string) {
        alert(userName)
    }
}