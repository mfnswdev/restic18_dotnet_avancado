**2. Sintaxe Básica de C#: Variáveis, Tipos de Dados e Operadores:**
2.1. Explique a importância das variáveis em C# e forneça um exemplo de declaração.
Variáveis são locais na memória e servem, na aplicação, para armazenar determinado valor temporariamente. Por exemplo, pode-ser declarar uma variável do tipo String, chamada nome: String nome;

2.2. Quais são os tipos de dados básicos em C# e como são utilizados?

2.3. Dê exemplos de operadores aritméticos e lógicos em C#.
Operadores aritméticos: a + b / a * b ...
Operadores lógicos: a && b / b || c ...


**3. Estruturas de Controle de Fluxo: Condicionais e Loops em C#:**
3.1. Como as estruturas condicionais são implementadas em C#? Dê um exemplo.
Dado:  a = 3;

if(a==3){ 
    Console.WriteLine("Verdade");
}
else{
    Console.WriteLine("Falso");
}

3.2. Explique o funcionamento dos loops em C# e forneça um exemplo de uso.
Loops são as estruturas de repetição na programação, usada, por exemplo, quando se quer fazer a mesma operação em determinada quantidade de vezes. Exemplo:
char opcao = 'N'
While(opcao != 'S'){
    Console.WriteLine("Deseja sair do programa?");
    opcao = Console.ReadLine();
}
3.3. Qual é a diferença entre o "for" e o "while" em termos de controle de fluxo?
For é mais recomendado usar quando se já conhece a quantidade de vezes da iteração e while não precisar ter conhecimento sobre isso, mas a condição que parada que irá ditar se continua ou não a iteração.


**4. Strings, Arrays e Listas, Datas:**
4.1. Descreva operações comuns realizadas em strings em C#.
4.2. Compare e contraste Arrays e Listas em termos de funcionalidade e uso.

4.3. Como as datas são representadas e manipuladas em C#? Dê exemplos.
No C# existe uma classe chamada DateTime. Nela contém alguns métodos para manipulação de data. Exemplo

DateTime data = new DateTime();

dia = data.Day;


**5. Language Integrated-Query (LINQ):**
5.1. O que é o LINQ e qual é sua finalidade em C#? É uma ferramenta de consulta integrada que serve para facilitar as consultas no C#.
5.2. Forneça um exemplo prático de utilização do LINQ em uma coleção de dados.
5.3. Quais são as vantagens de usar o LINQ em comparação com abordagens convencionais?
O uso de LINQ faz com que o código fique mais exuto, facilitando a sua manutenção. Além de ser de fácil aprendizagem e facilitar consultas em banco de dados juntamente com o ORM (Entity Framework, por exemplo)


**6. Debugging e Exceções:**
6.1. Descreva o processo de debugging em C# e mencione ferramentas úteis.

6.2. Qual é o papel das exceções em C#? Como são tratadas no código?
Exceções serve para lidar com situações inesperadas na execução do código. Pode-ser utilizada o try/catch para lidar com elas. 

6.3. Dê um exemplo de como utilizar a declaração "try-catch" para lidar com exceções.

try{

} catch(Exception e){

}


**7. Conceitos de POO em C#:**
7.1. Explique o que é Programação Orientada a Objetos (POO) e sua importância em C#.
POO é um paradigma de programação onde se abstrai objetos do mundo real para a aplicação. Tudo é øbjeto na POO.

7.2. Quais são os pilares da POO? Descreva cada um brevemente.
Abstração: Transformar objetos do mundo real em um objeto na aplicação com atributos, etc.
Polimorfismo: O objeto pode se comportar de várias formas
Herança: Quando se coloca em uma classe (que é o molde para o objeto) características comuns a outros objetos e ao criar a classe para os objetos (classes-filha), elas herdam da classe-pai anteriormente criada.
Encapsulamento. Forma de esconder alguns atributos de determinados objetos.

7.3. Dê um exemplo prático de como um objeto é criado em C#.

No exemplo acima (ao criar uma data), tem-se: DateTime data = new DateTime();


**8. Encapsulamento, Construtores e Destrutores:**
8.1. Por que o encapsulamento é considerado importante na Programação Orientada a Objetos?
8.2. Explique a função dos construtores e destrutores em uma classe C#.
Construtor é o método que que constrói o objeto ao instânciá-lo
8.3. Como você implementaria um construtor em uma classe?


**9. Herança e Polimorfismo:**
9.1. O que é herança em C# e como ela é aplicada?
Herança: Quando se coloca em uma classe (que é o molde para o objeto) características comuns a outros objetos e ao criar a classe para os objetos (classes-filhas), elas herdam da classe-pai anteriormente criada.
9.2. Explique o conceito de polimorfismo e forneça um exemplo prático.
9.3. Quais são as vantagens da herança e do polimorfismo na programação orientada a objetos?


**10. Classes Abstratas e Interfaces:**
10.1. Qual é a diferença entre uma classe abstrata e uma interface em C#?
Classe abstrata é uma  classe que não pode ser instanciada, servem como modelo para outros. Interface é uma forma de definir um contrato e a classe que a implementar, deverá, obrigatoriamente, definir os metodos, por exemplo, nela.
10.2. Em que cenários você optaria por usar uma classe abstrata em vez de uma interface?
10.3. Dê um exemplo de implementação de uma interface em C#.
