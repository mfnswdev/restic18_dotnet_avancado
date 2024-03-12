## **2.Sintaxe Básica de C#: Variáveis, Tipos de Dados e Operadores:**

**2.1.A importância das variáveis em C# é fundamental para o funcionamento de qualquer programa. Com as variáveis, é possível armazenar valores e fazer referência a eles durante o programa.**

> Exemplo de declaração:

```csharp
int idade;
```
**2.2. Os tipos de dados básicos em C# são: inteiros (int), decimais (double), char (caractere), bool (booleano) e strings (texto).**

### **2.3. Operadores aritméticos:**

*São utilizados para realizar operações matemáticas em valores numéricos.*

>Exemplo:
```csharp
int resultado = 5 + 2 * 3; // resultado = 11
```
**Operadores lógicos:**

*São utilizados para realizar comparações e união de condições lógicas.*

>Exemplo:

```csharp
bool verdade = (5 > 2) && (5 < 8); // verdade = true
```

## **3. Estruturas de Controle de Fluxo: Condicionais e Loops em C#:**

**3.1. As estruturas condicionais em C# são if e switch.**

>Exemplo de if:
```csharp
if (idade >= 18)
{
    Console.WriteLine("Maior de idade");
}
else
{
    Console.WriteLine("Menor de idade");
}
```
>Exemplo de switch:
```csharp
switch (opcao)
{
    case 1:
        // código a ser executado caso a opção selecionada seja 1
        break;
    case 2:
        // código a ser executado caso a opção selecionada seja 2
        break;
    default:
        // código a ser executado caso nenhuma das opções acima seja selecionada
        break;
}
```
**3.2. Os loops em C# são for, foreach e while.**

>Exemplo de for:
```csharp
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
```
>Exemplo de foreach:
```csharp
int[] nums = { 1, 2, 3, 4, 5 };
foreach (int num in nums)
{
    Console.WriteLine(num);
}
```
>Exemplo de while:
```csharp
int contador = 0;
while (contador < 10)
{
    Console.WriteLine(contador);
    contador++;
}
```
**3.3. A principal diferença entre o "for" e o "while" é que o "for" é mais simples e conciso, enquanto o "while" permite maior flexibilidade na condição de parada.**


## **4. Strings, Arrays e Listas, Datas:**

**4.1. Operações comuns realizadas em strings em C#:**

***Concatenação:***
```csharp
string nomeCompleto = primeiroNome + " " + sobrenome;***
```
***Interpolação:***
```csharp
string mensagem = $"Olá, {nome}! Seu nome completo é {nomeCompleto}";***
```
**4.2. Arrays e listas são coleções de dados que armazenam elementos do mesmo tipo.
A principal diferença entre eles é que arrays são estáticos, ou seja, sua capacidade é definida
no momento da criação, enquanto listas são dinâmicas, ou seja, podem ser adicionados ou 
removidos elementos durante o programa.**

>Exemplo de array:
```csharp
int[] numeros = { 1, 2, 3, 4, 5 };
```
>Exemplo de lista:
```csharp
List<int> listaNumeros = new List<int> { 1, 2, 3, 4, 5 };
```
**4.3. Datas em C# são representadas e manipuladas pelo tipo "DateTime".**

>Exemplo de obtenção da data atual:
```csharp
DateTime hoje = DateTime.Now;
```
>Exemplo de obtenção de uma data específica:
```csharp
DateTime dataNascimento = new DateTime(1990, 1, 1);
```
## **5. Language Integrated-Query (LINQ):**

**5.1. O que é o LINQ e qual é sua finalidade em C#?**

*Resposta: O LINQ é uma técnica de programação para consultar e manipular coleções de dados.
Ele permite escrever consultas em uma sintaxe clara e expressiva, independente do tipo de 
coleção de dados que está sendo utilizada. A finalidade do LINQ é facilitar a consulta e
manipulação de dados em C#.*

**5.2. Forneça um exemplo prático de utilização do LINQ em uma coleção de dados.
Resposta: Um exemplo prático de LINQ é a seguinte consulta:**
```csharp
var nomes = new List<string> { "Maria", "João", "Pedro", "Ana" };

var nomesIniciais = from nome in nomes
                    where nome.Length == 4
                    orderby nome
                    select nome.Substring(0, 1);

// A variável nomesIniciais agora contém as iniciais dos nomes que têm 4 letras.
```
**5.3. Quais são as vantagens de usar o LINQ em comparação com abordagens convencionais?**

*Resposta: Em comparação com abordagens convencionais, o LINQ oferece algumas vantagens, como:*

* Facilita a consulta e manipulação de dados em coleções de dados.
* Permite escrever consultas em uma sintaxe clara e expressiva.
* É independente do tipo de coleção de dados que está sendo utilizada.
* É muito útil para consultas complexas que envolvem várias operações.

## **6. Debugging e Exceções:**

**6.1. Debugging em C# é o processo de depuração de código para encontrar e corrigir bugs ou
outros problemas. Ferramentas úteis para debugging em C# são o Visual Studio, o ReSharper e o
LINQPad.**

**6.2. As exceções em C# são usadas para tratar condições de erro ou situações inesperadas em um 
programa. Quando uma exceção é lançada, ele é tratado pelo código ou é propagado para o código 
superior na pilha de chamadas. A declaração "try-catch" é usada para lidar com exceções.**

>Exemplo de como utilizar a declaração "try-catch":
```csharp
try
{
    // código que pode lançar uma exceção
}
catch (Exception ex)
{
    // código que é executado caso a exceção seja lançada
}
```
## **7. Conceitos de POO em C#:**
***7.1. A Programação Orientada a Objetos (POO) é uma abordagem de programação que organiza o código em torno de objetos, que são
instâncias de classes que representam coisas do mundo real. A POO é importante em C# pois permite criar código mais modular, 
reutilizável e escalável.***

**7.2. Os pilares da POO são: abstração, encapsulamento, herança e polimorfismo. Abstração é a capacidade de representar objetos da 
realidade de forma resumida e genérica, enquanto que encapsulamento é a capacidade de esconder detalhes da implementação de um 
objeto, tornando-o mais seguro e flexível. Herança permite que classes derivem comportamentos e características de outras classes, 
enquanto polimorfismo permite que objetos sejam tratados de forma consistente, independentemente de sua classe concreta.**

**7.3. Um exemplo prático de como um objeto é criado em C# é o seguinte:**
```csharp
using System;

namespace ExemploPOO
{
    class Pessoa
    {
        private string _nome;

        public Pessoa() { }

        public Pessoa(string nome)
        {
            _nome = nome;
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public void Apresentar()
        {
            Console.WriteLine("Olá, meu nome é " + _nome + ".");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("João");
            p1.Apresentar();
            Console.ReadKey();
        }
    }
}
```
## **8. Encapsulamento, Construtores e Destrutores:**
**8.1. O encapsulamento é importante na Programação Orientada a Objetos pois permite que os dados de um objeto sejam manipulados de 
forma controlada, garantindo que eles estejam em um estado consistente e válido. Isso é especialmente útil quando diversos objetos 
estão interagindo entre si, pois evita que um objeto altere o estado de um objeto sem permissão.**

**8.2. Os construtores são métodos especiais que são executados sempre que um objeto de uma classe é criado. Eles permitem 
inicializar os dados de um objeto de forma consistente e padronizada. Os destrutores, por sua vez, são métodos especiais que são
executados sempre que um objeto de uma classe é destruído. Eles permitem liberar recursos alocados pelo objeto de forma
consistente e garantir que o objeto esteja em um estado consistente.**

**8.3. Para implementar um construtor em uma classe, basta criar um método com o mesmo nome da classe e sem retorno. Por exemplo:**
```csharp
public class Pessoa
{
    private string _nome;

    public Pessoa()
    {
        _nome = "Desconhecido";
    }

    // outras propriedades e métodos...
}
```
## **9. Herança e Polimorfismo:**
**9.1. A herança é uma técnica de programação que permite criar classes que sejam derivadas de classes existentes, herdando seus 
atributos e métodos. Isso é feito usando a palavra-chave "class" seguida do nome da classe base e dos parênteses que contém a 
lista de classes base. Por exemplo:**
```csharp
public class Animal {}

public class Cachorro : Animal {}

//Isso significa que a classe Cachorro é derivada da classe Animal e herda todos os atributos e métodos definidos na classe Animal.
```
**9.2. O polimorfismo é a capacidade de um objeto ser tratado de forma consistente, independentemente de sua classe concreta. Isso 
é feito usando métodos virtuais, que são métodos que podem ser sobrescritos em classes derivadas. Por exemplo:**
```csharp
public abstract class Animal
{
    public abstract void Falar();
}

public class Cachorro : Animal
{
    public override void Falar()
    {
        Console.WriteLine("Au au!");
    }
}

public class Gato : Animal
{
    public override void Falar()
    {
        Console.WriteLine("Miau!");
    }
}

//Isso significa que a classe Cachorro e a classe Gato são derivadas da classe Animal, mas elas sobrescrevem o método Falar de forma diferente, mas ainda mantém a mesma assinatura do método virtual na classe base.
```
**9.3. As vantagens da herança e do polimorfismo na programação orientada a objetos são:**

* Reutilização de código.
* Flexibilidade e extensibilidade na implementação de classes.
* Capacidade de tratar objetos de forma consistente, independentemente de sua classe concreta.

## **10. Classes Abstratas e Interfaces:**
**10.1. A principal diferença entre uma classe abstrata e uma interface em C# é que uma classe abstrata pode conter métodos e 
atributos concretos, enquanto uma interface não pode conter nada além de métodos e propriedades abstratos. Além disso, uma classe 
abstrata pode ser instanciada, enquanto uma interface não pode ser instanciada.**

**10.2. Em que cenários você optaria por usar uma classe abstrata em vez de uma interface?**

*Uma classe abstrata é uma classe que pode ser instanciada e pode conter métodos e atributos concretos. Isso é útil quando você 
quer fornecer uma implementação padrão de algumas funcionalidades, mas ainda quer que as subclasses possam sobrescrever essas 
implementações.*

*Por exemplo, se você quiser criar uma classe que representa uma base de dados, você poderia criar uma classe abstrata chamada 
"Database" com métodos concretos para inserir, atualizar e deletar registros. As subclasses dessa classe abstrata podem 
sobrescrever esses métodos para implementar a lógica específica de cada base de dados.*

*Já uma interface, por outro lado, é um contrato que define um conjunto de métodos e propriedades que uma classe deve implementar.
É uma forma de especificar o que uma classe deve fazer sem fornecer uma implementação específica.*

*Se você quiser criar uma classe que deve implementar um conjunto de funcionalidades que podem ser diferentes em cada caso, uma 
interface é uma escolha mais apropriada. Por exemplo, se você quiser criar uma classe que implemente a interface "IComparable" 
para que uma instância dessa classe possa ser comparada com outras instâncias de classes similares, isso é um cenário em que 
uma interface é a escolha mais apropriada.*

**10.3. Dê um exemplo de implementação de uma interface em C#.**

*Uma implementação de interface em C# é feita da seguinte forma:*
```csharp
public class Pessoa : IComparable
{
    public int Idade { get; set; }

    public int CompareTo(object obj)
    {
        Pessoa outraPessoa = obj as Pessoa;

        if (outraPessoa == null)
        {
            throw new ArgumentException("obj não é uma instância de Pessoa");
        }

        return this.Idade.CompareTo(outraPessoa.Idade);
    }
}

/*Isso significa que a classe Pessoa implementa a interface IComparable, que define um método chamado "CompareTo" que deve ser implementado. A implementação do método "CompareTo" compara a idade de uma instância de Pessoa com a idade de outra instância de Pessoa passada como parâmetro.

Agora, se você criar uma instância de Pessoa e chamar o método "CompareTo" com uma outra instância de Pessoa, o resultado será a 
comparação das idades das duas instâncias de Pessoa.*/
