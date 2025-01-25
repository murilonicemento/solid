# SOLID

O **SOLID** é um acrônimo criado por [Michael Feathers](https://michaelfeathers.silvrback.com/), após observar que cinco princípios da orientação a objetos e design de código *— Criados por* [_Robert C. Martin_](https://pt.wikipedia.org/wiki/Robert_Cecil_Martin) *(\_a.k.a. _Uncle Bob) e abordados no artigo* [The Principles of OOD](http://butunclebob.com/ArticleS.UncleBob.PrinciplesOfOod) *—* poderiam se encaixar nesta palavra.

## Os princípios do S.O.L.I.D

O **SOLID** possui cinco princípios considerados como boas práticas no desenvolvimento de software que ajudam os programadores a escrever os códigos mais limpos, separando as responsabilidades, diminuindo acoplamentos, facilitando na refatoração e estimulando o reaproveitamento do código.

### Single Responsibility Principle (Princípio da Responsabilidade Única)

Esse primeiro princípio diz que *“uma classe deve ter apenas um motivo para mudar”,* ou seja*,* deve ter uma única responsabilidade. Basicamente, esse princípio trata especificamente a **coesão**. A coesão é definida como a afinidade funcional dos elementos de um módulo. Se refere ao relacionamento que os membros desse módulo possuem, se possuem uma relação mais direta e importante. Dessa forma, quanto mais bem definido o que sua classe faz, mais coesa ela é.

#### Problemas de não seguir SRP

- **Falta de coesão** — uma classe não deve assumir responsabilidades que não são suas;
- **Alto acoplamento** — Mais responsabilidades geram um maior nível de dependências, deixando o sistema engessado e frágil para alterações;
- **Dificuldades na implementação de testes automatizados** — É difícil de [_“mockar”_](https://pt.wikipedia.org/wiki/Objeto_Mock) *esse tipo de classe;*
- **Dificuldades para reaproveitar o código**;

### Open/Closed Principle (Princípio do Aberto/Fechado)

No princípio do **Open-Closed Principle** diz que *“as entidades de software (classes, módulos, funções etc.) devem ser abertas para ampliação, mas fechadas para modificação”.* De forma mais detalhada, diz que podemos estender o comportamento de uma classe, quando for necessário, por meio de **herança**, **interface** e **composição**, mas não podemos permitir a abertura dessa classe para fazer pequenas modificações.

### Liskov Substitution Principle (Princípio da Substituição de Liskov)

No princípio da Substituição de Liskov (LSP) diz que *“Os subtipos devem ser substituíveis pelos seus tipos base”,* e que as classes/tipos base podem ser substituídas por qualquer uma das suas subclasses, ponderando sobre os cuidados para usar a herança no seu projeto de software. Mesmo a herança sendo um mecanismo poderoso, ela deve ser utilizada de forma contextualizada e moderada, evitando os casos de classes serem estendidas apenas por possuírem algo em comum. Esse princípio foi descrito pela pesquisadora **_Barbara Liskov_**, em seu artigo de **1988**, em que ela explica que, antes de optar pela herança, precisamos pensar nas pré-condições e pós-condições da sua classe.

Um exemplo mais simples e de fácil compreensão dessa definição. Seria:

> _se S é um subtipo de T, então os objetos do tipo T, em um programa, podem ser substituídos pelos objetos de tipo S sem que seja necessário alterar as propriedades deste programa._

### Interface Segregation Principle (Princípio da Segregação de Interfaces)

No princípio da Segregação de Interfaces (ISP) diz que *“muitas interfaces específicas são melhores do que uma interface geral” que se* trata da coesão em interfaces, da construção de módulos enxutos, ou seja, com poucos comportamentos. Interfaces que possuem muitos comportamentos são difíceis de manter e evoluir, e devem ser evitadas.

### Dependency Inversion Principle (Princípio da Inversão de Dependência)

O princípio da Inversão de Dependências (DIP), diz que devemos *“depender de abstrações e não de classes concretas”*. O mestre Robert C. Martin conhecido como **_Uncle Bob_** quebra a definição desse princípio em dois sub-itens:

- _“Módulos de alto nível não devem depender de módulos de baixo nível.”_
- _“As abstrações não devem depender de detalhes. Os detalhes devem depender das abstrações.”_

E isso se dá porque abstrações mudam menos e facilitam a mudança de comportamento e as futuras evoluções do código.
