import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { AlunosComponent } from './components/alunos/alunos.component'; 
import { ProfessoresComponent } from './components/professores/professores.component';
import { PerfilComponent } from './components/perfil/perfil.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { NavComponent } from './shared/nav/nav.component';
import { TituloComponent } from './shared/titulo/titulo.component';

import { FormsModule, ReactiveFormsModule } from '@angular/forms'; //Fromulario
import { BrowserAnimationsModule } from '@angular/platform-browser/animations'; //toastr
import { HttpClientModule } from '@angular/common/http'; //Fazer requisições para API
import { ToastrModule } from 'ngx-toastr'; //toastr
import { NgxSpinnerModule } from "ngx-spinner"; //spinner
import { BsDropdownModule } from 'ngx-bootstrap/dropdown'; //DropDown
import { ModalModule } from 'ngx-bootstrap/modal'; //Modal


@NgModule({
  declarations: [
    AppComponent,
    AlunosComponent,
    ProfessoresComponent,
    PerfilComponent,
    DashboardComponent,
    NavComponent,
    TituloComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgxSpinnerModule, //spinner
    BrowserAnimationsModule, //toastr
    FormsModule, //Formulário
    ReactiveFormsModule, //Formulário
    HttpClientModule, //Fazer requisições para API
    ModalModule.forRoot(), //Modal
    BsDropdownModule.forRoot(), //DropDown
    ToastrModule.forRoot({ //toastr
      timeOut: 3500,
      positionClass: 'toast-bottom-rigth',
      preventDuplicates: true,
      progressBar: true,
      closeButton: true
    })
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
