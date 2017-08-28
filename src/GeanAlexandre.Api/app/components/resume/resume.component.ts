import {Component, OnInit} from '@angular/core';
import {ResumeService} from "./resume.service";

@Component({
    selector: 'resume-body',
    templateUrl: './resume.component.html'
})
export class ResumeComponent implements OnInit {

    private resumeService: ResumeService;

    constructor(resumeService: ResumeService) {
        this.resumeService = resumeService
    }

    ngOnInit() {
    }
}
