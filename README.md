# ASP. NET Core MVC

## Introdução
Nesse projeto aplicarei conceitos do Model-View-Controller e utilizarei Git pela primeira vez como forma de versionar meu código.

## Git

O Git é um sistema para **versionamento de código**. Ele é responsável por guardar o histórico de modificações realizadas pelo usuário em um repositório Git. Veja a seguir os benefícios da utilização desse sistema seguindo um [artigo apresentado pela Ditech](http://ditech.com.br/git-beneficios-ferramenta-projetos/):
- Facilidade de Trabalho: Trabalhar mais de uma pessoa em um mesmo projeto, facilidade dos comandos;
- Repositórios pequenos;
- Capacidade de mover ou adicionar arquivos;
- Trabalhar sem interferir no código principal do projeto, de modo a desenvolver novas funcionalidades;
- Testar uma modificação temporária;
- Descobrir em que versão um bug foi introduzido.

Desse modo, podemos perceber como o Git é extremamente importante para manter o trabalho organização e controlado.

## ASP.NET Model-View-Controller

## Model-View-Controller
É um padrão de arquitetura de software responsável por dividir em etapas as camadas de desenvolvimento da aplicação. Tais camadas são divididas em três:
- **Model:** Aqui é onde está a regra de negócios: Onde ocorrem alterações no banco, consumo de Api's, gerenciamento dos dados, entre outros, parte em que o usuário não tem capacidade de mensurar e visualizar.
- **View:** A view é a parte em que ocorre a interação com o usuário, normalmente, com páginas HTML.
- **Controller:** O controller faz a intermediação entre a View e a Model, sendo responsável por atualizar os dados presentes na Model e na View.
