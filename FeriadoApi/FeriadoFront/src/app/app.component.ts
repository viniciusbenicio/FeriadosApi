import { Component, OnInit } from '@angular/core';
import { FeriadoService } from '../../services/feriado.service';
import { IFeriado } from '../../Interface/IFeriado';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css', './style.css']
})
export class AppComponent implements OnInit {
  title = 'Feriado Nacionais';

  feriadoNacionais: IFeriado[] = new Array<IFeriado>();



  ngOnInit() {
    this.obterTodosFeriados();
  }

  constructor(private FeriadoService: FeriadoService) {
  }
  obterDadosApi() {
    this.FeriadoService.obterDadosApi().subscribe(result => {
      this.feriadoNacionais = result;
    })
    window.location.reload();
  }

  obterTodosFeriados() {
    this.FeriadoService.obterTodosFeriados().subscribe(result => {
      this.feriadoNacionais = result;
    })

  }
  // obterPorId() {
  //   this.FeriadoService.obterPorId(4)

  // }


  atualizar(item: any) {
    debugger;
    item.descriptionCopia = item.description;
    if(item.description){
      item.description = prompt("Digite a nova descrição");

    }else{
      item.description = item.descriptionCopia;
    }
    this.obterTodosFeriados();
    this.FeriadoService.atualizar(item).subscribe(result => {
      this.obterTodosFeriados();
    })
  }

    remover(id: number){
      this.FeriadoService.delete(id).subscribe(result => {
        this.obterTodosFeriados();
    })
  }
}
