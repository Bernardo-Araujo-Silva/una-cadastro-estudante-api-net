# 📚 Cadastro de Estudantes API

API desenvolvida em .NET para cadastro de estudantes, utilizando arquitetura simples de microserviço com persistência em banco SQLite.

---

## 🚀 Tecnologias utilizadas

* .NET 10
* ASP.NET Core Web API
* Entity Framework Core
* SQLite
* Swagger (OpenAPI)

---

## 📁 Estrutura do projeto

```
CadastroEstudanteApi
│── Controllers/
│── Data/
│── Models/
│── Program.cs
```

---

## ⚙️ Como executar o projeto

### 1. Clonar o repositório

```
git clone https://github.com/SEU-USUARIO/una-cadastro-estudante-api-net.git
```

### 2. Acessar a pasta do projeto

```
cd CadastroEstudanteApi
```

### 3. Restaurar dependências

```
dotnet restore
```

### 4. Criar o banco de dados

```
dotnet ef migrations add CriarMigration
dotnet ef database update
```

### 5. Executar a aplicação

```
dotnet run
```

---

## 🌐 Acessar a API

Após rodar o projeto, acesse:

```
https://localhost:xxxx/swagger
```

---

## 🧪 Teste da API

### Criar estudante (POST)

```
POST /api/estudantes
```

```json
{
  "nome": "Daniel Paiva"
}
```

---

### Listar estudantes (GET)

```
GET /api/estudantes
```

---

## 💾 Banco de dados

O banco é criado automaticamente no arquivo:

```
BancoEstudante.db
```

---

## 📌 Funcionalidades

* Cadastro de estudantes
* Listagem de estudantes
* Persistência de dados com SQLite

---

## 👨‍💻 Autor

Projeto desenvolvido para a disciplina de Sistemas Distribuídos e Mobile.
