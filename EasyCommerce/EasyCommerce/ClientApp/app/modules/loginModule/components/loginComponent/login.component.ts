import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
    selector: 'login-component',
    templateUrl: './login.component.html'
})
export class LoginComponent implements OnInit {

    loginForm: FormGroup;

    constructor(private formBuider: FormBuilder) {

    }

    ngOnInit(): void {

        this.buildForm();
    }

    private buildForm() {
        this.loginForm = this.formBuider.group({
            email: ['', Validators.required],
            password: ['', Validators.required]
        });
    }
}