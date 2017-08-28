import {NgModule} from '@angular/core';
import {BrowserModule} from '@angular/platform-browser';
import {FormsModule} from '@angular/forms';
import {HttpModule} from '@angular/http';

import {ResumeRepository} from './components/shared/respository/ResumeRepository'
import {ApiSettings} from './components/shared/context/ApiSettings'

import {AppComponent} from './app.component'

import {HeaderModule} from './components/header/header.module'
import {ResumeModule} from './components/resume/resume.module'


@NgModule({
    declarations: [
        AppComponent
    ],
    imports: [
        BrowserModule,
        FormsModule,
        HttpModule,
        HeaderModule,
        ResumeModule
    ],
    providers: [
        ApiSettings,
        ResumeRepository
    ],
    bootstrap: [AppComponent]
})
export class AppModule {
}
