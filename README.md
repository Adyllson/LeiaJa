                                            LEAIJA
=======================================================================================
1.  LeiaJa

    LeiaJa é um sistema de gestão de empréstimos, desenvolvido para simplificar o gerenciamento de solicitações, devoluções e       organização de itens emprestados.
=======================================================================================

2. Funcionalidades

    Sistema de login com diferentes perfis de acesso: Administrador e Cliente.
    Controle de empréstimos e devoluções.
    Organização e gerenciamento eficiente dos itens emprestados.
    Funcionalidades adicionais a serem desenvolvidas ao longo do projeto.
=======================================================================================

3. Tecnologias Utilizadas

    Este projeto foi desenvolvido utilizando as seguintes tecnologias e ferramentas:
    3.1. Backend

        1=> .NET Core: Framework principal para o backend.
        2=> ASP.NET Core: Para desenvolvimento da API RESTful.
        3=> Entity Framework Core: Para mapeamento objeto-relacional (ORM).
                                  3.1 Providers: InMemory, SQL Server, Design.
        4=> JWT Bearer: Para autenticação e autorização via tokens JWT.

    3.2. Frontend

        1=> Blazor: Framework para desenvolvimento do frontend interativo e moderno.
        2=> Mudblazor:
        3=> JavaScript:

    3.3. Testes

        1=> xUnit: Framework para criação de testes de unidade e integração.
        2=> Moq: Para criação de mocks e stubs durante os testes.
        3=> EntityFrameworkCore.InMemory: Banco de dados em memória utilizado nos testes.

    3.4. Ferramentas e Bibliotecas Adicionais

        1=> AutoMapper: Para mapeamento entre objetos.
        2=> Swashbuckle: Para documentação da API com Swagger.
        3=> EF Tools: Para gerenciamento de migrações de banco de dados.

    3.5. Banco de Dados

        1=> SQL Server: Banco relacional para armazenamento dos dados do sistema.

Nota: Outros frameworks e bibliotecas podem ser adicionados conforme o progresso do projeto.
=======================================================================================

4. Configuração do Ambiente
    4.1. Requisitos

        4.1.1. SDKs e Ferramentas:
                1=> .NET SDK 6.0 ou superior
                2=> SQL Server
                3=> Visual Studio ou Visual Studio Code (com extensão C#)
            
            
        4.1.2. Pacotes NuGet:
                1=> Microsoft.EntityFrameworkCore (InMemory, SQL Server, Design)
                2=> AutoMapper
                3=> Swashbuckle.AspNetCore
                4=> Moq
                5=> Microsoft.AspNetCore.Authentication.JwtBearer
=======================================================================================

6. Funcionalidades Futuras

        1=> Notificações automáticas para devoluções pendentes.
        2=> Histórico detalhado de empréstimos.
        3=> Relatórios personalizados para administradores.
        4=> Integração com serviços de e-mail para lembretes.
=======================================================================================

7. Estrutura do Projeto
    A estrutura do projeto está organizada em src, test e docs, com separação clara entre backend e frontend, seguindo uma abordagem modular e de fácil manutenção:
    
        LeiaJa/
        ├── src/                      # Código-fonte principal
        │   ├── backend/              # Código do backend
        │   │   ├── LeiaJa.Presentation/   # Camada de apresentação (API)
        │   │   ├── LeiaJa.Application/    # Regras de negócios e serviços
        │   │   ├── LeiaJa.Domain/         # Entidades de domínio e validações
        │   │   ├── LeiaJa.Infrastructure/ # Acesso a dados e integração com o banco de dados
        │   │   ├── LeiaJa.IoC/            # Configuração de injeção de dependências
        │   ├── frontend/              # Código do frontend
        │   │   ├── LeiaJa.Web/         # Interface do usuário (Blazor)
        ├── test/                      # Projetos de testes
        │   ├── LeiaJa.UnitTests/        # Testes de unidade
        │   ├── LeiaJa.IntegrationTests/  # Testes de integração
        ├── docs/                      # Documentação adicional do projeto
        │   ├── Arquitetura.md          # Detalhes sobre a arquitetura do projeto
        │   ├── API.md                  # Documentação da API (endpoints, contratos)
        │   ├── GuiaDeInstalação.md     # Instruções de configuração do ambiente
        │   ├── ROADMAP.md              # Planejamento de funcionalidades futuras
        ├── README.md                  # Documentação principal do projeto
        ├── LeiaJa.sln                 # Solução do projeto
=======================================================================================

## Licença

Este projeto está licenciado sob a Licença MIT - veja o arquivo [LICENSE](./LICENSE) para mais detalhes.
