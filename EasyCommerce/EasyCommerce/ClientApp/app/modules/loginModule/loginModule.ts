import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { MatCardModule } from '@angular/material/card';
import { MatFormFieldModule } from '@angular/material';
import { MatInputModule } from '@angular/material';
import { ReactiveFormsModule } from '@angular/forms';

import { LoginComponent } from './components/loginComponent/login.component';

@NgModule({
    declarations: [
        LoginComponent
    ],
    imports: [
        MatCardModule,
        MatInputModule,
        MatFormFieldModule,
        ReactiveFormsModule,
        BrowserAnimationsModule,
        RouterModule.forChild([
            { path: 'login', component: LoginComponent}
        ])
    ]
})
export class LoginModule {
}