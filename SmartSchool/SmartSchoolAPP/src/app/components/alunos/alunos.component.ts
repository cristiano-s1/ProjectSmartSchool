import { Component, OnInit, TemplateRef } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { Subject } from 'rxjs';
import { takeUntil } from 'rxjs/operators';
import { Aluno } from 'src/app/models/Aluno';
import { Professor } from 'src/app/models/Professor';
import { AlunoService } from 'src/app/services/aluno.service';
import { ProfessorService } from 'src/app/services/professor.service';
import { ProfessoresComponent } from '../professores/professores.component';

@Component({
  selector: 'app-alunos',
  templateUrl: './alunos.component.html',
  styleUrls: ['./alunos.component.css']
})
export class AlunosComponent implements OnInit {

  public modalRef?: BsModalRef; //Modal
  public alunoForm?: FormGroup; //Formulário
  public titulo = 'Alunos';
  public alunoSelecionado?: Aluno;
  public textSimple?: string;
  public profsAlunos?: Professor[];
  public alunos?: Aluno[];
  public aluno?: Aluno;
  public msnDeleteAluno?: string;
  public modeSave = 'post';
  private unsubscriber = new Subject();

  constructor(
    private alunoService: AlunoService,
    private route: ActivatedRoute, //Formulario
    private professorService: ProfessorService,
    private fb: FormBuilder, //Formulario
    private modalService: BsModalService, //Modal
    private toastr: ToastrService, //Toastr
    private spinner: NgxSpinnerService //Spinner
  ) 
  {
    this.criarForm();
  }

  ngOnInit() {
    this.carregarAlunos();
  }

  //Toastr e Spinner
  professoresAlunos(template: TemplateRef<any>, id: number) {
    this.spinner.show();
    this.professorService.getByAlunoId(id)
      .pipe(takeUntil(this.unsubscriber))
      .subscribe((professores: Professor[]) => {
        this.profsAlunos = professores;
        this.modalRef = this.modalService.show(template);
      }, (error: any) => {
        this.toastr.error(`erro: ${error}`);
        console.log(error);
      }, () => this.spinner.hide()
    );
  }

  //Criação do Formulário
  criarForm() {
    this.alunoForm = this.fb.group({
      id: [0],
      nome: ['', Validators.required],
      sobrenome: ['', Validators.required],
      telefone: ['', Validators.required]
    });
  }

  //Post
  saveAluno() {
    if (this.alunoForm?.valid) {
      this.spinner.show();

      if (this.modeSave === 'post') {
        this.aluno = {...this.alunoForm.value};
      } else {
        this.aluno = {id: this.alunoSelecionado?.id, ...this.alunoForm.value};
      }

      this.alunoService?[this.modeSave](this.aluno)
        .pipe(takeUntil(this.unsubscriber))
        .subscribe(
          () => {
            this.carregarAlunos();
            this.toastr.success('Aluno salvo com sucesso!');
          }, (error: any) => {
            this.toastr.error(`Erro: Aluno não pode ser salvo!`);
            console.error(error);
          }, () => this.spinner.hide()
        );

    }
  }

  //Get
  carregarAlunos() {
    const id = + this.route.snapshot.paramMap.get('id');

    this.spinner.show();
    this.alunoService.getAll()
      .pipe(takeUntil(this.unsubscriber))
      .subscribe((alunos: Aluno[]) => {
        this.alunos = alunos;

        if (id > 0) {
          this.alunoSelect(this.alunos.find(aluno => aluno.id === id));
        }

        this.toastr.success('Alunos foram carregado com Sucesso!');
      }, (error: any) => {
        this.toastr.error('Alunos não carregados!');
        console.log(error);
      }, () => this.spinner.hide()
    );
  }

  alunoSelect(aluno: Aluno) {
    this.modeSave = 'put';
    this.alunoSelecionado = aluno;
    this.alunoForm.patchValue(aluno);
  }

  voltar() {
    this.alunoSelecionado = null;
  }

  openModal(template: TemplateRef<any>, alunoId: number) {
    this.professoresAlunos(template, alunoId);
  }

  closeModal() {
    this.modalRef?.hide();
  }

  ngOnDestroy(): void { //Limpar 
    this.unsubscriber.next();
    this.unsubscriber.complete();
  }

}
