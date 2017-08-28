import {Injectable} from "@angular/core";

@Injectable()
export class ApiSettings {
    resume: string;

    constructor() {
        this.resume = "http://localhost:5000/api/resume"
    }
}
