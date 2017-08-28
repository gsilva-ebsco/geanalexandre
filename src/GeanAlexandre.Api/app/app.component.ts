import {Component, OnInit} from '@angular/core';
import {ResumeRepository} from "./components/shared/respository/ResumeRepository";

@Component({
    selector: 'app-root',
    templateUrl: './app.component.html'
})
export class AppComponent implements OnInit {

    private readonly resumeRepository: ResumeRepository;

    constructor(resumeRepository: ResumeRepository) {
        this.resumeRepository = resumeRepository;
    }

    ngOnInit() {
        this.resumeRepository.getResume("geanalexandre").then(value => {
            console.info(value)
        })
    }
}
