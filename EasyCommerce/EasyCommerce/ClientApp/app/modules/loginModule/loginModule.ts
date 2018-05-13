import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

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
        ReactiveFormsModule,
        RouterModule.forChild([
            { path: 'login', component: LoginComponent}
        ])
    ]
})
export class LoginModule {
}