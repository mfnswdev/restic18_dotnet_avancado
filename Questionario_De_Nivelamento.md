
**2. Sintaxe Básica de C#: Variáveis, Tipos de Dados e Operadores:**
-
2.1. Explique a importância das variáveis em C# e forneça um exemplo de declaração.

 
 ```csharp
//É uma forma de armazenar dados de forma permanente ou temporaria, a tipagem de dados é uma forma de garantir a consistencia

//Exemplos:
//Declaração
 int minhaVariavel;

//Atribuição 
minhaVariavel = 10;
```

2.2. Quais são os tipos de dados básicos em C# e como são utilizados?

```csharp

int algumavariavel; //Variavel do tipo interio

varchar algumaVariavel; // Armazena caracteres individuais, como 'a', 'B', '$'.

bouble algumavariavel; //Armazena números de ponto flutuante (decimais), como 3.14, -0.5.

bool algumaVariavel; //dados do tipo booleano (sim ou nao; 0 ou 1)

string algumaVariavel; //variavel do tipo texto

```


2.3. Dê exemplos de operadores aritméticos e lógicos em C#.
```csharp
//Operador lógico
int resultado = 5 + 3; //O mesmo se aplica aos demais operadores (/, +, *, ^). 

//Operador
bool resultado = (5 > 3) && (4 < 7); // Verifica se a váriavel resulltado é maior que 5 ou menor que 3, depois menor que 4 ou maior que 7. Fornecerá verdadeiro somente se as duas condições forém satisfeitas ($$). Nesse caso o resultado é verdadeiro (5+3=8)


bool resultado = (2 == 1) || (3 != 4); // ou uma condição ou a outra condição deve ser (||). A primeira condição não é atendida, mas a segunda sim  

```

---


**3. Estruturas de Controle de Fluxo: Condicionais e Loops em C#:**

---
3.1. Como as estruturas condicionais são implementadas em C#? Dê um exemplo.

```csharp

using System;

class Program
{
    static void Main()
    {
        
        int numero = 10;
        
        if (numero > 0) //se atender a primeira condição executa o proximo conteudo entre {}, se não segue para o proximo
        {
            Console.WriteLine("O número é positivo.");
        }
        else if (numero == 0) // roda se não atender a condição anterior, caso o if atual seja atendido executa o proximo conteudo entre {}, se não segue para o proximo        {
            Console.WriteLine("O número é zero.");
        }
        else
        {
            Console.WriteLine("O número é negativo.");
        }
    }
}

```
3.2. Explique o funcionamento dos loops em C# e forneça um exemplo de uso.

```csharp
//Em C#, os loops são estruturas que possibilita que um bloco de código seja repetido várias vezes seguindo restrições de condição. Existem varios tipode laço em C#, um exemplo deles bastnte usado é 'for'

using System;

class Program
{
    static void Main()
    {
        // Exemplo de loop for em C#
        for (int i = 1; // nessa parte inicia a variavel i com valor temporario 1
            i <= 5; i++) //se a condição de i ser menor que 5 for atendida, lhe é somado mais um (mas poderia ser outra operação, como --). 


        {
            Console.WriteLine("Iteração: " + i); //aqui pode ser incluido qualquer 'operação de sua escolha, nesse caso, impreme o numero da iteração a cada "volta" 
        }
    }
}


```
3.3. Qual é a diferença entre o "for" e o "while" em termos de controle de fluxo?

```csharp

//Ambos são estruturas de contrle de fluxo em C# que permitem a execução repetida de um cloco de código enquanto uma condição for atendida. While é ideal quando não se sabe o numero de interaçoes antecipadamente, enquanto for sim.

```
----
**4. Strings, Arrays e Listas, Datas:**

4.1. Descreva operações comuns realizadas em strings em C#.
```csharp
//strings são objetos que representam sequências de caracteres, como concatenação, Comprimento da String, acesso a caracteres, comapração
//exemplos:
//Concatenação:
//
string str1 = "Olá";
string str2 = " Mundo!";
string resultado = str1 + str2;

//Comprimento de strig:
string minhaString = "Exemplo";
int comprimento = minhaString.Length;

```
4.2. Compare e contraste Arrays e Listas em termos de funcionalidade e uso.

```cshap
Arrays têm tamanho fixo e armazenam elementos do mesmo tipo. Listas têm tamanho dinâmico e podem armazenar diferentes tipos de dados. Arrays podem ter melhor desempenho no acesso direto, mas listas são mais flexíveis e fáceis de manipular. Escolha conforme a necessidade de tamanho e variedade de dados.
```
4.3. Como as datas são representadas e manipuladas em C#? Dê exemplos.

```
TimeSpan diferenca = outraData - dataEspecifica;
int diasDeDiferenca = diferenca.Days;

```

----
**5. Language Integrated-Query (LINQ):**

5.1. O que é o LINQ e qual é sua finalidade em C#?

5.2. Forneça um exemplo prático de utilização do LINQ em uma coleção de dados.

5.3. Quais são as vantagens de usar o LINQ em comparação com abordagens convencionais?

----
**6. Debugging e Exceções:**
6.1. Descreva o processo de debugging em C# e mencione ferramentas úteis.
```cshap
não sei, ou não tenho certeza
```
6.2. Qual é o papel das exceções em C#? Como são tratadas no código?
```cshap
não sei, ou não tenho certeza
```

6.3. Dê um exemplo de como utilizar a declaração "try-catch" para lidar com exceções.
```cshap
não sei, ou não tenho certeza
```
----

**7. Conceitos de POO em C#:**
7.1. Explique o que é Programação Orientada a Objetos (POO) e sua importância em C#.

```
  é um paradigma de programação que organiza o código em torno de objetos, que contém dados na forma de campos (atributos) e procedimentos na forma de métodos. Em C#, a criação de classes e objetos, issso facilita a modularidade, reutilização de código, e encapsulamento, promovendo um código mais estruturado e compreensível. 
```
7.2. Quais são os pilares da POO? Descreva cada um brevemente.
```cshap
    Encapsulamento: Controla o acesso aos dados e métodos de uma classe.

    Herança: Permite a reutilização de código ao herdar características de outras classes.

    Polimorfismo: Permite tratar objetos de diferentes tipos de maneira uniforme.

    Abstração: Simplifica e modela objetos do mundo real, destacando o essencial.
```
7.3. Dê um exemplo prático de como um objeto é criado em C#.

```csharp
using System;


class MinhaclasseMinhaVida
{
    
    public string Nome;
    public int Idade;

    
    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
    }
}


class Programa
{
    static void Main()
    {
        //  objeto da classe Pessoa
        MinhaclasseMinhaVida pessoa1 = new MinhaclasseMinhaVida();

        // Atribuindo valores ao objeto
        pessoa1.Nome = "João";
        pessoa1.Idade = 25;

        // Chamando o método do objeto
        pessoa1.Apresentar();
    }
}

```
-----

**8. Encapsulamento, Construtores e Destrutores:**
8.1. Por que o encapsulamento é considerado importante na Programação Orientada a Objetos?

```
Em POO encapsulamento ajuda proteger os detalhes internos de uma classe, controla o acesso aos dados e métodos, promovendo a integridade do objeto e facilitando a manutenção do código. A fim evitar interferências externas não desejadas, e melhora modularidade e segurança do sistema.
```
8.2. Explique a função dos construtores e destrutores em uma classe C#.

```
Construtores em C#:Inicializam objetos ao serem criados, definindo valores iniciais.

Destrutores em C#:Liberam recursos quando um objeto é destruído.

```

8.3. Como você implementaria um construtor em uma classe?

```csharp
public class MinhaclasseMinhaVida
{
    public string Nome { get; private set; }
    public int Idade { get; private set; }

    // Construtor da classe
    public MinhaclasseMinhaVida(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    
}
```
---

**9. Herança e Polimorfismo:**

9.1. O que é herança em C# e como ela é aplicada?

```csharp
//Permite que uma classe herde características (membros e 
//métodos) de outra classe.o operador ':' para indica que 
//uma classe está herdando da outra. emxemplo

class Herdeira : ProvedoraDaHerança
{
    // Conteúdo adicional da classe Herdeira
}
```

9.2. Explique o conceito de polimorfismo e forneça um exemplo prático.

```csharp
//Permite que objetos de diferentes tipos sejam tratados de 
//maneira uniforme.

class Pessoa
{
    public virtual void Trabalhar()
    {
        Console.WriteLine(" bom dia");
    }
}

class Medico : Pessoa
{
    public override void Trabalhar()
    {
        Console.WriteLine("É virose");
    }
}

class Peciente : Pessoa
{
    public override void Trabalhar()
    {
        Console.WriteLine("Não fui trabalhar hoje, estou de atestado");
    }
}

class Program
{
    static void Main()
    {
        Pessoa pessoa1 = new medico();
        pessoa pessoa2 = new paciente();

        pessoa1.Trabalhar(); 
        pessoa2.Trabalhar(); 
    }
}

```

9.3. Qaius são as vantagens da herança e do polimorfismo na programação orientada a objetos?

```
Herança: Reutilização de código, estrutura hierárquica.
Polimorfismo:Flexibilidade, extensibilidade.
```

---

**10. Classes Abstratas e Interfaces:**

10.1. Qual é a diferença entre uma classe abstrata e uma interface em C#?

```
Uma Classe Abstrata pode conter métodos abstratos e concretos, campos, construtores e herdar apenas de uma classe. Por outro lado, uma Interface contém apenas métodos sem implementação, campos ou construtores. Pode ser implementada por várias classes, permitindo que uma classe implemente várias interfaces.
```
10.2. Em que cenários você optaria por usar uma classe abstrata em vez de uma interface?
```
não tenho certeza
```
10.3. Dê um exemplo de implementação de uma interface em C#.

```csharp
using System;

// interface IPessoa
public interface IPessoa
{
    string Nome { get; set; }
    int Idade { get; set; }

    void Apresentar();
}

// medico assinando contrato de IPessoa
public class Medico : IPessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Especialidade { get; set; }

    public void Apresentar()
    {
        Console.WriteLine($"Médico: {Nome}, Idade: {Idade}, Especialidade: {Especialidade}");
    }
}

//  Paciente assina com IPessoa 
public class Paciente : IPessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string ProblemaSaude { get; set; }

    public void Apresentar()
    {
        Console.WriteLine($"Paciente: {Nome}, Idade: {Idade}, Problema de Saúde: {ProblemaSaude}");
    }
}

class Program
{
    static void Main()
    {
        // Criando instâncias de Médico e Paciente
        IPessoa medico = new Medico { Nome = "Dr. Silva", Idade = 40, Especialidade = "Psiquiatra" };
        IPessoa paciente = new Paciente { Nome = "João", Idade = 25, ProblemaSaude = "Virose" };
        medico.Apresentar();
        paciente.Apresentar();

        
        
    }
}


```
