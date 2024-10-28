# GerenciadorCMS
Content Management System é um sistema de gerenciamento de conteúdo (CMS) 

simples, desenvolvido em C#. O projeto permite a criação, organização e gestão de postagens de blog e artigos, incluindo gerenciamento de categorias, tags, usuários e comentários.

# Funcionalidades
* Criação e Edição de Postagens: Interface para adicionar e modificar postagens de blog.
* Categorias e Tags: Sistema de categorização e tags para facilitar a organização e busca de conteúdos.
* Gerenciamento de Usuários: Adição e autenticação de usuários.
* Controle de Comentários: Sistema para gerenciamento e exibição de comentários em postagens.
* Controle de Versões: Estrutura que permite a reversão de alterações em posts.

# Estrutura do Projeto

O projeto está organizado nas seguintes pastas e arquivos:


````
ContentManagementSystem/
│
├── Program.cs
├── Models/
│   ├── Post.cs
│   ├── Category.cs
│   ├── Tag.cs
│   ├── User.cs
│   └── Comment.cs
│
├── Services/
│   ├── PostService.cs
│   ├── CategoryService.cs
│   ├── TagService.cs
│   ├── UserService.cs
│   └── CommentService.cs
│
├── Controllers/
│   ├── PostController.cs
│   ├── CategoryController.cs
│   ├── UserController.cs
│   └── CommentController.cs
│
├── Views/
│   ├── PostView.cs
│   ├── CategoryView.cs
│   ├── UserView.cs
│   └── CommentView.cs
│
└── Utils/
    ├── HtmlHelper.cs
    ├── LoggerService.cs
    └── AuthService.cs
````

# Dependências
 1. Para executar o projeto, é necessário ter:

.NET SDK (versão 6.0 ou superior) - Instale o .NET SDK
Editor de código como Visual Studio Code ou Visual Studio (opcional para desenvolvimento)

# Instalação e Execução

 1. Clone o Repositório

    Clone o projeto para sua máquina usando o seguinte comando:

````
git clone https://github.com/seu-usuario/ContentManagementSystem.git
````
 2. Navegue para a Pasta do Projeto
````
cd ContentManagementSystem
````
 3. Restaurar Dependências e Compilar o Projeto

    No terminal, execute o comando:

````
dotnet build
````
 4. Executar o Projeto

    Execute o projeto usando:

````
dotnet run
````
 5.Utilização do CMS
     Ao iniciar, o CMS está pronto para criar e gerenciar postagens, categorias, tags e comentários. Utilize as classes Controller e Service para interagir com o conteúdo e criar os registros.

# Estrutura de Pastas e Arquivos

* Program.cs: Arquivo principal que inicializa o projeto.
* Models/: Contém as classes de dados para posts, categorias, tags, usuários e comentários.
* Services/: Lida com a lógica de negócios e manipulação de dados para cada entidade.
* Controllers/: Controladores que conectam a interface com os serviços, processando entradas do usuário.
* Views/: Gerencia a exibição das informações, incluindo posts, categorias, usuários e comentários.
* Utils/: Inclui utilitários como autenticação, logger e renderização HTML.

# Aprendizado com o Projeto
   Este projeto aborda conceitos fundamentais em C# e .NET, incluindo:

* Programação Orientada a Objetos: Estruturação de classes e relacionamentos entre modelos de dados.
* Organização de Código e Arquitetura: Separação da lógica de negócios (services), controle (controllers) e visualização (views).
* Manutenção e Expansão: Uso de padrões para adicionar novas funcionalidades, facilitando a manutenção e escalabilidade.
* Autenticação e Autorização: Controle básico de usuários e autenticação simulada.
 *Utilitários de Log e Helpers: Implementação de um serviço de logger e renderização de HTML.

# Próximos Passos e Expansões
  Algumas funcionalidades que podem ser adicionadas ao projeto:

* Banco de Dados: Integração com um banco de dados como SQLite ou SQL Server para persistência de dados.
* Autenticação Completa: Implementação de autenticação real e permissões de usuário.
* API RESTful: Desenvolvimento de endpoints RESTful para interação com o sistema através de HTTP.
