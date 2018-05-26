import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { MatButtonModule, MatCheckboxModule } from '@angular/material';
import 'hammerjs';

@NgModule({
    declarations: [
    ],
    imports: [
        MatButtonModule,
        MatCheckboxModule
    ],
    exports: [
        MatButtonModule,
        MatCheckboxModule
    ],
    providers: [],
    bootstrap: []
})
export class MaterialModule { }
