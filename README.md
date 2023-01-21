## Projeto Feriados Nacionais 

### O Projeto está organizado da seguinte maneira.
####  FeriadoApi - BackEnd - FeriadoFront - FrontEnd

![image](https://user-images.githubusercontent.com/63131764/213869623-f5681063-ea63-4024-a05c-6e65d84247ec.png)

---- 
Antes de iniciar o projeto necessita do SQL SERVER instalado.

#### Verificar 'appsettings.Development'

![image](https://user-images.githubusercontent.com/63131764/213869713-6fe8598c-5aa2-49bb-8b26-8dbd17edc22c.png)
---- 
Utilizando database "FeriadoNacional" executar script de criação da Database.

'
USE master
GO  

CREATE DATABASE FeriadoNacional  
GO
'
---- 
### Tabela Criada na FeriadoNacional iremos rodar o migrate.

add-migrate initial - Para inicializar o Migrate 
![image](https://user-images.githubusercontent.com/63131764/213869903-6b96d36b-8b1f-440d-b655-72e3d811d2dd.png)
update-database - Para criar a tabela no banco 
![image](https://user-images.githubusercontent.com/63131764/213869909-46af95c8-0a5d-4979-8e9a-ccde70964237.png)
---- 
### Agora vamos iniciar o Back-End
Com projeto aberto aperte F5 ou 
![image](https://user-images.githubusercontent.com/63131764/213870028-9fe0f335-4294-4cbf-bc57-b25ff9a514f9.png)

---- 
## Nosso projeto BackEnd irá abrir no Swagger 
Na Url : http://localhost:5250/swagger/index.html
![image](https://user-images.githubusercontent.com/63131764/213870076-5e1abf2b-6f46-4e1d-8abd-67187e64e1a3.png)
Api's :
### 1 . /api/v1/feriado/buscar-todos-feriados - METODO GET
  #### Essa rota irá consultar Api de Feriados passada no teste http://dadosbr.github.io/feriados/nacionais.json, irá fazer um GET e persitir no banco de dados.
### 2 . /api/v1/feriado  - METODO GET
  #### Essa rota irá consultar os dados de feriados que foram persistido no banco de dados.
### 3 . /api/v1/feriado/{id} - METODO GET COM PARAMETRO ID
  #### Essa rota irá trazer um feriado baseado no Id do banco de dados.
### 4 . /api/v1/feriado/{id} - METODO PUT COM PARAMETRO ID 
  #### Essa rota irá atualizar um feriado do banco de dados, alterando a coluna Description que foi pedida no teste prático
### 5 . /api/v1/feriado/{id} - METODO DELETE COM PARAMETRO ID
 #### Essa rota irá deletar um feriado do banco de dados
 
---- 
#### Agora vamos iniciar nosso Front-End
##### Abra o projeto no VSCODE de Preferencia no console do VSCODE com projeto aberto digite NPM INSTALL para instalar os pacote do projeto.
em seguida digite NPM START para execução do projeto que irá abrir na URL : http://localhost:4200/
![image](https://user-images.githubusercontent.com/63131764/213870491-068092c4-24fa-4f9a-9086-f2fd3457ba5d.png)


---- 
# Tecnologias e plugins utilizados

#### C# | .NET | AngularTS | SQL SERVER
