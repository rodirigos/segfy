# Segfy Teste

Demonstração de CRUD utilizando dotnetcore.
```
- Padrçao repositorio

- Injeção de dependencia pelo ASPNET CORE

- Convertendo DTOs utilizando o AutoMapper
```
Demonstração Angular

```
- Sem padrões. Apenas code behind para testar as funcionalidades 

- Colocado aparencia
```

### Instalação WEBAPI

Para rodar o projeto são necessários alguns passos

Primeiro passo é ter dotnet core instalado. Para verificar abra o prompt de comando e  use o comando 

```
dotnet --version
```

Depois de verificar a instalação. Restaure os pacotes 

```
dotnet restore
```

Para iniciar a api. Também será necessário o banco de dados que por padrão é o Mysql ( Podendo mudar para sqllite facilmente).

Verifique o arquivo appsettings.json e configure o seu banco de dados mysql que deseja que seja criado o projeto. 

Após o banco configurado utilize o comando 

```
dotnet ef database update
```

para a criação dos seu banco persistente. 

Finalmente para rodar a webapi 

```
dotnet run
```

Na pasta do projeto de webapi.

### Angular

Dentro da pasta do projeto angular. São necessarios que o usuario tenha o instalador de pacotes npm instalado no computador. 

Para rodar o projeto. Utilize o comando

```
npm i
```

Para instalar todos os pacotes necessarios para o projeto. O projeto angular está em code behind, apenas para o teste da WebApi.

Podendo mudar algumas coisas para serviços para melhor aproveitamento de codigo. Mas como foi feito uma página. Ficou dessa maneira mesmo.

Para rodar o projeto após os pacotes instalados e com angular CLI instalado. Utilize o comando.

```
ng serve
```


