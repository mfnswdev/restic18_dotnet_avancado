**2. Sintaxe Básica de C#: Variáveis, Tipos de Dados e Operadores:**

2.1. Explique a importância das variáveis em C# e forneça um exemplo de declaração.

R= Sendo uma linguagem de programação fortemente tipada, o uso de variáveis é essencial em C#. As variáveis são utilizadas para armazenar e manipular dados em um programa, permitindo que o desenvolvedor trabalhe com valores de diferentes tipos, como números, texto, booleanos, entre outros. A declaração de variáveis em C# segue a sintaxe:
```csharp
tipo nomeDaVariavel;
```

2.2. Quais são os tipos de dados básicos em C# e como são utilizados?

R= C# possui diversos tipos de dados básicos, incluindo inteiros, decimais, booleanos, caracteres, strings, entre outros. Esses tipos de dados são utilizados para representar diferentes tipos de valores em um programa, como números inteiros, números de ponto flutuante, valores lógicos, caracteres individuais e sequências de caracteres. Alguns exemplos de tipos de dados básicos em C# incluem:
- int: para números inteiros.
- double: para números de ponto flutuante.
- bool: para valores lógicos (true ou false).
- char: para caracteres individuais.
- string: para sequências de caracteres.

2.3. Dê exemplos de operadores aritméticos e lógicos em C#.

R= Os operadores aritméticos e lógicos são utilizados para realizar operações matemáticas e lógicas em C#. Alguns exemplos de operadores aritméticos incluem:
- Soma (+): para adicionar dois valores.
- Subtração (-): para subtrair um valor de outro.
- Multiplicação (*): para multiplicar dois valores.


**3. Estruturas de Controle de Fluxo: Condicionais e Loops em C#:**

3.1. Como as estruturas condicionais são implementadas em C#? Dê um exemplo.

R= As estruturas condicionais em C# permitem que o programa tome decisões com base em condições específicas. As estruturas condicionais mais comuns em C# são o "if", "else if" e "else". Um exemplo de estrutura condicional em C# é:
```csharp
int numero = 10;
if (numero > 0)
{
    Console.WriteLine("O número é positivo.");
}
else if (numero < 0)
{
    Console.WriteLine("O número é negativo.");
}
else
{
    Console.WriteLine("O número é zero.");
}
```
3.2. Explique o funcionamento dos loops em C# e forneça um exemplo de uso.

R= Os loops em C# são utilizados para repetir a execução de um bloco de código várias vezes com base em uma condição específica. Existem três tipos principais de loops em C#: "for", "while" e "do-while". Um exemplo de loop "for" em C# é:
```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}
```

3.3. Qual é a diferença entre o "for" e o "while" em termos de controle de fluxo?

R = A principal diferença entre o "for" e o "while" em C# é a forma como a condição de repetição é verificada.

**4. Strings, Arrays e Listas, Datas:**

4.1. Descreva operações comuns realizadas em strings em C#.

R= As strings em C# são utilizadas para representar sequências de caracteres e são amplamente utilizadas em operações de manipulação de texto. Algumas operações comuns realizadas em strings em C# incluem:
- Concatenação: combinar duas ou mais strings em uma única string.
- Substring: extrair uma parte específica de uma string.
- Comparação: verificar se duas strings são iguais ou diferentes.

4.2. Compare e contraste Arrays e Listas em termos de funcionalidade e uso.

R= Arrays e Listas são estruturas de dados comuns em C# que permitem armazenar coleções de elementos. 

4.3. Como as datas são representadas e manipuladas em C#? Dê exemplos.

R= As datas em C# são representadas pelo tipo de dados "DateTime", que permite armazenar informações sobre datas e horas. Alguns exemplos de manipulação de datas em C# incluem:

- Obter a data e hora atuais: DateTime.Now
- Adicionar dias a uma data: data.AddDays(7)
- Calcular a diferença entre duas datas: data1 - data2


**5. Language Integrated-Query (LINQ):**

5.1. O que é o LINQ e qual é sua finalidade em C#?

R= O LINQ (Language Integrated Query) é uma extensão da linguagem C# que permite realizar consultas em coleções de dados de forma simples e eficiente. O LINQ fornece uma sintaxe semelhante a SQL para consultar objetos em memória, bancos de dados, XML e outros tipos de fontes de dados.

5.2. Forneça um exemplo prático de utilização do LINQ em uma coleção de dados.

R= Um exemplo prático de utilização do LINQ em uma coleção de dados em C# é:
```csharp
List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
var numerosPares = numeros.Where(n => n % 2 == 0);
foreach (var numero in numerosPares)
{
    Console.WriteLine(numero);
}
```

5.3. Quais são as vantagens de usar o LINQ em comparação com abordagens convencionais?

R= O LINQ oferece várias vantagens em comparação com abordagens convencionais de manipulação de dados em C#, incluindo:
- Sintaxe simplificada e legível para consultas de dados.
- Maior produtividade e facilidade de manutenção do código.
- Suporte a consultas em diferentes fontes de dados, como coleções em memória, bancos de dados e XML.

**6. Debugging e Exceções:**

6.1. Descreva o processo de debugging em C# e mencione ferramentas úteis.

R= O processo de debugging em C# envolve a identificação e correção de erros em um programa. Algumas ferramentas úteis para debugging em C# incluem:
- Breakpoints: pontos de interrupção que permitem pausar a execução do programa e inspecionar o estado das variáveis.
- Console.WriteLine: instruções de saída que exibem informações úteis durante a execução do programa.

6.2. Qual é o papel das exceções em C#? Como são tratadas no código?

R= As exceções em C# são utilizadas para lidar com situações excepcionais que ocorrem durante a execução de um programa, como erros de lógica, falhas de comunicação ou condições inesperadas. As exceções são tratadas no código usando blocos "try-catch", que permitem capturar e tratar exceções de forma controlada.

6.3. Dê um exemplo de como utilizar a declaração "try-catch" para lidar com exceções.

R= Um exemplo de utilização da declaração "try-catch" em C# para lidar com exceções é:
```csharp
try
{
    int resultado = 10 / 0;
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Erro: divisão por zero.");
}
```

**7. Conceitos de POO em C#:**

7.1. Explique o que é Programação Orientada a Objetos (POO) e sua importância em C#.

R= A Programação Orientada a Objetos (POO) é um paradigma de programação que se baseia na criação e interação de objetos para modelar sistemas de software. Em C#, a POO é amplamente utilizada para organizar e estruturar o código de forma modular, reutilizável e fácil de manter.

7.2. Quais são os pilares da POO? Descreva cada um brevemente.

R= Os pilares da Programação Orientada a Objetos (POO) são:
- Encapsulamento: consiste em agrupar dados e métodos relacionados em uma única unidade, chamada de classe, e controlar o acesso a esses membros.
- Herança: permite que uma classe herde características e comportamentos de outra classe, promovendo a reutilização de código e a criação de hierarquias de classes.
- Polimorfismo: permite que objetos de diferentes classes sejam tratados de forma genérica, facilitando a extensibilidade e flexibilidade do código.

7.3. Dê um exemplo prático de como um objeto é criado em C#.

R= Um exemplo prático de como um objeto é criado em C# é:
```csharp
public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}
```

**8. Encapsulamento, Construtores e Destrutores:**

8.1. Por que o encapsulamento é considerado importante na Programação Orientada a Objetos?

R= O encapsulamento é considerado importante na Programação Orientada a Objetos porque permite a reutilização e a manutenção do código, além de facilitar a evolução e a extensibilidade do sistema.

8.2. Explique a função dos construtores e destrutores em uma classe C#.

R= Não sei responder ao certo, mas utilizo ele geralmente quando quero injetar dependências em uma classe, ou seja, quando quero passar um objeto para a classe que estou instanciando.

8.3. Como você implementaria um construtor em uma classe?

R= Um construtor em C# é um método especial que é chamado automaticamente quando um objeto da classe é criado. Para implementar um construtor em uma classe, você pode definir um método com o mesmo nome da classe e sem tipo de retorno. Por exemplo:
```csharp
public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}
```


**9. Herança e Polimorfismo:**

9.1. O que é herança em C# e como ela é aplicada?

R= A herança em C# é um mecanismo que permite que uma classe herde características e comportamentos de outra classe, promovendo a reutilização de código e a criação de hierarquias de classes. Para aplicar a herança em C#, você pode usar a palavra-chave "class" seguida do nome da classe e da classe base, separados por dois pontos. Por exemplo:
```csharp
public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}

public class Estudante : Pessoa
{
    public string Curso { get; set; }
}
```

9.2. Explique o conceito de polimorfismo e forneça um exemplo prático.

R= O polimorfismo em C# é a capacidade de objetos de diferentes classes serem tratados de forma genérica, permitindo que métodos com o mesmo nome se comportem de maneiras diferentes com base no tipo do objeto. Um exemplo prático de polimorfismo em C# é:
```csharp
public class Animal
{
    public virtual void EmitirSom()
    {
        Console.WriteLine("Som genérico de animal.");
    }
}

public class Cachorro : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("Au au!");
    }
}
```


9.3. Quais são as vantagens da herança e do polimorfismo na programação orientada a objetos?

R= As vantagens da herança e do polimorfismo na programação orientada a objetos incluem:
- Reutilização de código: a herança permite que as classes compartilhem características e comportamentos comuns, evitando a duplicação de código.
- Extensibilidade: o polimorfismo permite que novas classes sejam adicionadas ao sistema sem modificar o código existente, facilitando a manutenção e a evolução do sistema.
- Flexibilidade: o polimorfismo permite tratar objetos de diferentes classes de forma genérica, aumentando a flexibilidade e a modularidade do código.



**10. Classes Abstratas e Interfaces:**

10.1. Qual é a diferença entre uma classe abstrata e uma interface em C#?

R= Uma classe abstrata em C# é uma classe que não pode ser instanciada diretamente e pode conter métodos abstratos e concretos, bem como propriedades e campos. Por outro lado, uma interface em C# é um contrato que define um conjunto de métodos e propriedades que uma classe deve implementar. Uma classe pode implementar várias interfaces.

10.2. Em que cenários você optaria por usar uma classe abstrata em vez de uma interface?
Não sei responder.

10.3. Dê um exemplo de implementação de uma interface em C#.

R= Um exemplo de implementação de uma interface em C# é:
```csharp
public interface IAnimal
{
    void EmitirSom();
}

public class Cachorro : IAnimal
{
    public void EmitirSom()
    {
        Console.WriteLine("Au au!");
    }
}
```

