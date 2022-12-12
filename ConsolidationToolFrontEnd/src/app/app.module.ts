import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { StoreModule } from '@ngrx/store';
import { MaterialModule } from './modules/material/material.module';
import { AppRoutingModule } from './app-routing.module';

@NgModule({
  declarations: [
    // declarations Use When use Component and Directive , Pipe
    AppComponent
  ],
  imports: [
    // import All Module
    MaterialModule,
    BrowserModule,
    BrowserAnimationsModule,
    StoreModule.forRoot({}, {}),
    AppRoutingModule
  ],
  providers: [
    // providers Use When auth
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
