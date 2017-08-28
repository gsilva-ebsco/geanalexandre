import {NgModule} from '@angular/core';

import {HttpModule} from '@angular/http'

import {ExperienceComponent} from './experience/experience.component'
import {EducationComponent} from './education/education.component'
import {AboutComponent} from './about/about.component'
import {ContactComponent} from './contact/contact.component'
import {SkillComponent} from './skill/skill.component'
import {LanguageComponent} from './language/language.component'
import {HobbieComponent} from './hobbie/hobbie.component'

import {ResumeComponent} from './resume.component'
import {ResumeService} from './resume.service'

@NgModule({
    declarations: [
        HobbieComponent,
        LanguageComponent,
        SkillComponent,
        ContactComponent,
        AboutComponent,
        ExperienceComponent,
        EducationComponent,
        ResumeComponent,
    ],
    imports: [
        HttpModule
    ],
    providers: [
        ResumeService
    ],
    exports: [ResumeComponent]
})
export class ResumeModule {
}
