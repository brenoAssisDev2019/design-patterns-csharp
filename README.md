# Repositório com implementações complexas de Design Patterns em C#

# Design Patterns em C#

[![.NET](https://img.shields.io/badge/.NET-8.0-blue)](https://dotnet.microsoft.com/en-us/)
[![C#](https://img.shields.io/badge/C%23-9.0-blue)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)

Repositório com implementações detalhadas e exemplos complexos dos principais Design Patterns em C#, visando aprendizado avançado e aplicação prática.

---

## Sobre o Projeto

Este projeto visa a exploração aprofundada dos principais Design Patterns clássicos, organizados em três categorias principais:

- **Criacionais:** padrões que facilitam a criação de objetos, garantindo flexibilidade e reutilização.
- **Estruturais:** padrões que tratam da composição de classes e objetos para formar estruturas maiores.
- **Comportamentais:** padrões que focam na comunicação e responsabilidade entre objetos.

Cada padrão possui uma implementação independente, com exemplos realistas que simulam cenários do mundo real.

---

## Estrutura do Repositório

```plaintext
/design-patterns-csharp
│
├── Creational           # Padrões de criação de objetos
│   ├── AbstractFactory  # Interface para criar famílias de objetos relacionados
│   ├── Builder          # Construção passo a passo de objetos complexos
│   ├── FactoryMethod    # Criação de objetos por métodos especializados
│   ├── Prototype        # Criação de novos objetos clonando objetos existentes
│   └── Singleton        # Garante uma única instância de uma classe
│
├── Structural           # Padrões para composição e estruturação de objetos
│   ├── Adapter          # Adaptador entre interfaces incompatíveis
│   ├── Bridge           # Desacopla abstração da implementação
│   ├── Composite        # Composição de objetos em estruturas de árvore
│   ├── Decorator        # Adiciona responsabilidades a objetos dinamicamente
│   ├── Facade           # Interface simplificada para um sistema complexo
│   ├── Flyweight        # Compartilhamento eficiente de objetos para economizar memória
│   └── Proxy            # Representante ou substituto para outro objeto
│
├── Behavioral           # Padrões para comunicação e responsabilidades entre objetos
│   ├── ChainOfResponsibility  # Passa uma solicitação por uma cadeia de handlers
│   ├── Command               # Encapsula uma solicitação como objeto
│   ├── Interpreter           # Interpreta sentenças em uma linguagem
│   ├── Iterator              # Acesso sequencial a elementos de uma coleção
│   ├── Mediator              # Centraliza comunicação entre objetos
│   ├── Memento              # Captura e restaura o estado interno de um objeto
│   ├── Observer              # Notificação automática de mudanças para múltiplos objetos
│   ├── State                 # Permite que um objeto altere seu comportamento quando seu estado muda
│   ├── Strategy              # Define uma família de algoritmos intercambiáveis
│   ├── TemplateMethod       # Define o esqueleto de um algoritmo em uma operação
│   └── Visitor               # Representa uma operação a ser realizada em elementos de uma estrutura
│
└── README.md
```
---

## Como Usar

Clone o repositório:

```bash
git clone https://github.com/seu-usuario/design-patterns-csharp.git
Entre na pasta do padrão que deseja estudar, por exemplo:
```
```bash
cd Creational/Singleton
Abra a solução no Visual Studio, Rider ou VS Code e execute para ver o padrão em funcionamento.
```
---

## Contribuição

Contribuições são bem-vindas! Caso queira sugerir um novo padrão, melhorar um exemplo ou corrigir algo, abra uma issue ou envie um pull request.

Por favor, siga o padrão de codificação C# e mantenha a estrutura do projeto.

---

## Licença

Este projeto está licenciado sob a MIT License.
