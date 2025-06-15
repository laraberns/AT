# Sistema de Gerenciamento de Agência de Turismo

## Descrição Geral

Este projeto consiste em uma aplicação web desenvolvida com **ASP.NET Core Razor Pages**, **Entity Framework Core** e **SQLite** como banco de dados, atendendo ao tema proposto:  
> *Sistema de gerenciamento para uma agência de turismo que oferece pacotes turísticos, cadastro de clientes, reservas e controle de disponibilidade de destinos.*

O projeto cobre desde a modelagem do domínio até funcionalidades de negócios com delegates, eventos, operações CRUD, leitura e escrita de arquivos, autenticação simples e exclusão lógica.

---

## Principais Tecnologias Utilizadas

- ASP.NET Core 8.0
- Razor Pages
- Entity Framework Core 9.0
- SQLite
- C#
- System.IO (manipulação de arquivos)
- Delegates, Func, Events

---

## Funcionalidades Implementadas

### ✅ Parte 1 — Delegates e Events

- **Delegate para cálculo de desconto:**  
  Implementado `CalculateDelegate` para aplicar 10% de desconto no valor da diária.
  
- **Multicast Delegate para logs:**  
  Implementado delegate `Action<string>` com métodos `LogToConsole`, `LogToFile` e `LogToMemory`.

- **Uso de Func com expressão lambda:**  
  Implementado `Func<int, int, decimal>` para cálculo de valor total de reservas.

- **Evento de alerta para limite de capacidade:**  
  Implementado evento `CapacityReached` na entidade `PacoteTuristico` para notificar quando o limite de participantes for atingido.

---

### ✅ Parte 2 — ASP.NET Razor Pages

- **Cadastro com validação (Model Binding):**  
  Formulário de cadastro de `Cliente` e `Destino` com validações via DataAnnotations.

- **Cadastro com objeto complexo:**  
  Cadastro de `PacoteTuristico` incluindo múltiplos destinos.

- **Detalhamento via roteamento:**  
  Página de detalhes por ID para cada entidade.

- **Sistema de Notas com leitura e escrita de arquivos:**  
  Página `ViewNotes` permitindo salvar anotações como arquivos `.txt` e visualizar seu conteúdo.

---

### ✅ Parte 3 — Acesso a Dados com EF Core

- **DbContext configurado:**  
  Classe `ATContext` com `DbSet` para todas as entidades (`Cliente`, `Destino`, `PacoteTuristico`, `Reserva`).

- **Modelagem e relacionamentos:**  
  Relacionamentos `1:N` e `N:N` definidos entre as entidades com DataAnnotations e Fluent API.

- **Banco de dados:**  
  Banco de dados SQLite configurado no `appsettings.json`.

---

### ✅ Parte 4 — Scaffolding + Autenticação

- **Operações CRUD com Scaffolding:**  
  CRUD completo gerado via Visual Studio Scaffolding, com personalizações de campos e visual.

- **Exclusão lógica:**  
  Campo `IsDeleted` adicionado para implementar soft delete nas entidades.

- **Autenticação simples:**  
  Sistema de login e senha fixos no código, protegendo páginas sensíveis com `[Authorize]`.

--
