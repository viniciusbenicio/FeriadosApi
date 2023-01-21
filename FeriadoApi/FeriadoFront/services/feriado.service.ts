import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { API_PATH } from 'environments/environment';
import { IFeriado } from '../Interface/IFeriado';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class FeriadoService {

  constructor(private httpClient: HttpClient) { }

  obterDadosApi(): Observable<any> {
    return this.httpClient.get<IFeriado[]>(`${API_PATH}feriado/buscar-todos-feriados`);
  }

  obterTodosFeriados(): Observable<any> {
    return this.httpClient.get<IFeriado[]>(`${API_PATH}feriado`);
  }

  obterPorId(id: number): Observable<any> {
    return this.httpClient.get<IFeriado>(`${API_PATH}feriado/${id}`);
  }

  atualizar(feriado: IFeriado): Observable<any> {
    return this.httpClient.put<IFeriado>(`${API_PATH}feriado/${feriado.id}`, feriado);
  }

  delete(id: number){
    return this.httpClient.delete(`${API_PATH}feriado/${id}`);
  }
}
