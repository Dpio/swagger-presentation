import { BrowserModule } from '@angular/platform-browser';
import { NgModule, InjectionToken, ReflectiveInjector } from '@angular/core';


import { AppComponent } from './app.component';
import { ProductsComponent } from './products/products.component';
import { ProductsService } from './products.service';
import { MessagesComponent } from './messages/messages.component';
import { MessageService } from './message.service';
import { AppRoutingModule } from './app-routing.module';
import { ProductServiceProxy } from '../shared/service-proxies/service-proxies';
import { HttpClientModule } from '@angular/common/http';
import { HttpModule } from '@angular/http';

@NgModule({
  declarations: [
    AppComponent,
    ProductsComponent,
    MessagesComponent,
  ],
  imports: [
    HttpModule,
    HttpClientModule,
    BrowserModule,
    AppRoutingModule,
    BrowserModule
  ],
  providers: [
    ProductsService,
    MessageService,
    ProductServiceProxy,
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
