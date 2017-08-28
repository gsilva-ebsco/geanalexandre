import 'rxjs/add/operator/toPromise'

import {Injectable} from "@angular/core";
import {Http} from "@angular/http";

import {IResumeRepository} from "./IResumeRepository";
import {ApiSettings} from "../context/ApiSettings";

@Injectable()
export class ResumeRepository implements IResumeRepository {

    private readonly http: Http;
    private readonly apiSettings: ApiSettings;

    constructor(http: Http, apiSettings: ApiSettings) {
        this.http = http;
        this.apiSettings = apiSettings;
    }


    public getResume(userName: string): Promise<string> {
        return this.http.get(`${this.apiSettings.resume}/${userName}`).toPromise()
            .then(response => response.toString())
    }

}
