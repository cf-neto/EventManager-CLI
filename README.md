<h1 align="center"> 📅 Projeto Eventos - Gerenciador de Eventos em Console</h1>

<p align="center">
  <img src="https://img.shields.io/badge/Language-C%23-512BD4?style=for-the-badge&logo=csharp&logoColor=white" />
  <img src="https://img.shields.io/badge/.NET-6.0+-blueviolet?style=for-the-badge&logo=dotnet" />
</p>
  
## 📝 Descrição

O **Projeto Eventos** é um sistema de gerenciamento de eventos desenvolvido em C# como aplicativo de console. Permite cadastrar, visualizar e remover eventos de forma simples e eficiente, com persistência em arquivo CSV.

---

## ✨ Funcionalidades

- ✅ **Cadastro de Eventos**: Nome, data e endereço
- ✅ **Listagem Completa**: Visualização de todos os eventos cadastrados
- ✅ **Remoção de Eventos**: Por nome do evento
- ✅ **Persistência em CSV**: Armazenamento permanente dos dados
- ✅ **Validação de Dados**: Verificação de campos obrigatórios e formatos

---

## 🛠 Tecnologias Utilizadas

| Tecnologia | Descrição |
|------------|-----------|
| **C#** | Linguagem principal do projeto |
| **.NET 6+** | Plataforma de desenvolvimento |
| **POO** | Programação Orientada a Objetos |
| **CSV** | Armazenamento persistente dos dados |

---

## 🗂 Estrutura do Projeto

```plaintext
ProjetoEventos/
├── Models/
│   └── Event.cs          # Modelo de dados do evento
├── Services/
│   └── EventService.cs   # Lógica de negócios e manipulação de arquivos
└── Program.cs            # Interface do usuário e menu principal
```

---

## ⚙️ Como Executar

**Pré-requisitos:**
- .NET SDK 6.0 ou superior instalado

**Execução:**
```bash
dotnet run
```

---


## 🚀 Melhorias Planejadas

- Edição de eventos existentes
- Busca por data ou localização
- Sistema de categorias/etiquetas
- Versão com interface gráfica
