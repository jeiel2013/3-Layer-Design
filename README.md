# Projeto 3 Camadas em C# com MySQL

Este repositório contém um exemplo de implementação de uma arquitetura de software em 3 camadas utilizando C# e MySQL, abordado em uma aula tutorial.

## Índice

- [Visão Geral](#visão-geral)
- [Arquitetura do Projeto](#arquitetura-do-projeto)
- [Ferramentas Utilizadas](#ferramentas-utilizadas)
- [Configuração do Projeto](#configuração-do-projeto)
- [Como Executar](#como-executar)
- [Estrutura do Código](#estrutura-do-código)
- [Contribuição](#contribuição)
- [Licença](#licença)

## Visão Geral

Este projeto demonstra como criar uma aplicação Windows Forms com uma arquitetura em 3 camadas, que separa a lógica de apresentação, de negócios e de acesso a dados. Isso facilita a manutenção, a escalabilidade e a organização do código.

## Arquitetura do Projeto

O projeto é dividido em três camadas principais:

1. **Camada de Apresentação (Presentation Layer)**:
   - Interface gráfica do usuário (GUI), onde os dados são exibidos e inseridos.
   - Utiliza Windows Forms para a criação de formulários.
  
2. **Camada de Negócios (Business Logic Layer)**:
   - Contém a lógica de negócios e as regras de processamento.
   - Responsável por processar os dados da aplicação.

3. **Camada de Acesso a Dados (Data Access Layer)**:
   - Gerencia a comunicação com o banco de dados.
   - Inclui operações CRUD (Create, Read, Update, Delete) para a base de dados.

## Ferramentas Utilizadas

- **Visual Studio 2022**: Ambiente de desenvolvimento para o código C#.
- **MySQL Workbench**: Ferramenta para gerenciar o banco de dados MySQL.
- **.NET Framework**: Plataforma para desenvolvimento e execução de aplicativos.

## Configuração do Projeto

1. **Clonar o repositório**:
   ```bash
   git clone https://github.com/jeiel2013/3-Layer-Design.git
   ```

2. **Abrir o projeto no Visual Studio**:
   - Navegue até a pasta do projeto e abra o arquivo `3CamadasJeiel.sln`.

3. **Configurar o Banco de Dados**:
   - Crie um banco de dados MySQL utilizando o MySQL Workbench.
   - Configure a string de conexão no projeto para se conectar ao banco de dados criado.

## Como Executar

1. **Compilar o Projeto**:
   - Compile o projeto no Visual Studio.

2. **Executar a Aplicação**:
   - Execute a aplicação para abrir o formulário de cadastro de clientes.

3. **Interagir com a GUI**:
   - Utilize a interface para adicionar, visualizar e gerenciar os dados dos clientes.

## Estrutura do Código

- **`CODE`**:
  - **`BLL`**: Contém a camada de negócios com as classes e métodos de lógica de negócios.
  - **`DAL`**: Inclui a camada de acesso a dados com classes para comunicação com o banco de dados.
  - **`DTO`**: Contém os objetos de transferência de dados.

- **`FormCadastroCliente.cs`**:
  - Formulário de cadastro de clientes.

- **`AcessoBancoDados.cs`**:
  - Classe para conexão e execução de comandos SQL no banco de dados.

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests. Certifique-se de seguir as diretrizes de contribuição.

## Licença

Este projeto está licenciado sob a [Licença MIT](LICENSE.txt).
