**2. Sintaxe Básica de C#: Variáveis, Tipos de Dados e Operadores:**
2.1. Explique a importância das variáveis em C# e forneça um exemplo de declaração.

R: As variáveis são fundamentais na programação em C# pois permitem armazenar valores que podem ser utilizados posteriormente no código. Essas variáveis são importantes pois permitem que o código seja mais organizado, fácil de ler e reutilizar. A declaração de uma variável em C# é feita da seguinte forma:

```csharp
int x = 10;
```

```csharp
string nome = "João";
```

```csharp
bool ativo = true;
```

```csharp
float pi = 3.14f;
```

```csharp
char letra = 'a';
```

```csharp
DateTime data = DateTime.Now;
```

```csharp
decimal valor = 10.5m;
```

```csharp
double valor2 = 10.5;
```

```csharp
long valor3 = 10;
```

```csharp
short valor4 = 10;
```

```csharp
sbyte valor5 = 10;
```

```csharp
byte valor6 = 10;
```

```csharp
ulong valor7 = 10;
```

2.2. Quais são os tipos de dados básicos em C# e como são utilizados?
    R: Os tipos de dados básicos em C# são: int, string, bool, float, char, DateTime, decimal, double, long, short, sbyte, byte e ulong. Exemplos implementados na pergunta anterior.

2.3. Dê exemplos de operadores aritméticos e lógicos em C#.
    R: Os operadores aritméticos em C# são: +, -, *, /, %, ++, --. Exemplos: 
    
```csharp
2 + 2, 2 - 2, 2 * 2, 2 / 2, 2 % 2.
```    
    Os operadores lógicos em C# são: &&, ||, !. Exemplos: 
    
```csharp
true && false, true || false, !true.
```


**3. Estruturas de Controle de Fluxo: Condicionais e Loops em C#:**
3.1. Como as estruturas condicionais são implementadas em C#? Dê um exemplo.
    R: As estruturas condicionais são implementadas em C# são: if, else if, else, switch. Exemplo: 
    
```csharp
if (x > 0) { 
} else if (x < 0) {
} else {
};
```

3.2. Explique o funcionamento dos loops em C# e forneça um exemplo de uso.
    R: Os loops em C# são: for, while, do-while. Exemplo: 

```csharp
for (int i = 0; i < 10; i++) {
};
```

3.3. Qual é a diferença entre o "for" e o "while" em termos de controle de fluxo?
    R: A estrutura de controle do "for" é baseada em iterações fixas, já que a estrutura do "while" é baseada em uma condição de parada.


**4. Strings, Arrays e Listas, Datas:**
4.1. Descreva operações comuns realizadas em strings em C#.
    R: As operações comuns em strings em C# são: concatenação, divisão, substring, replace.

4.2. Compare e contraste Arrays e Listas em termos de funcionalidade e uso.
    R: Arrays em C# são estruturas de dados imutáveis, após sua criação não podem ter o seu tamanho modificado. As listas são estruturas de dados mutáveis, podem ter seu tamanho modificado durante em tempo de execução.
    
    Arrays são mais adequados para situações em que o tamanho da estrutura será fixo desde o início do programa, já listas são mais adequadas para situações em que o tamanho da estrutura irá variar.

4.3. Como as datas são representadas e manipuladas em C#? Dê exemplos.
    R: As datas em C# são representadas por uma estrutura chamada "DateTime" e as operações que podem ser realizadas em elas são: add, subtract, compare, ToString.


**5. Language Integrated-Query (LINQ):**
5.1. O que é o LINQ e qual é sua finalidade em C#?
    R: O LINQ é uma abordagem de programação para manipular e filtrar dados de uma coleção de dados.

5.2. Forneça um exemplo prático de utilização do LINQ em uma coleção de dados.
    R: O exemplo abaixo é para demonstrar a utilização do LINQ em uma coleção de dados.

```csharp
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
int sum = numbers.Sum();
```

5.3. Quais são as vantagens de usar o LINQ em comparação com abordagens convencionais?
    R: As vantagens de usar o LINQ em comparação com abordagens convencionais são: 
        * A simplicidade do uso do LINQ, permitindo que o código seja mais legivel e organizado. 
        * A flexibilidade do uso do LINQ, permitindo que o código seja reutilizado em diferentes contexts. 
        * A manutenção do LINQ, permitindo que o código seja melhorado e evitando erros.
        * A independência do LINQ, permitindo que o código seja executado de forma isolada.


**6. Debugging e Exceções:**
6.1. Descreva o processo de debugging em C# e mencione ferramentas úteis.
    R: O processo de debugging em C# é o processo de encontrar erros e identificar possiveis erros. A ferramenta de debugging mais utilizada em C# para a Residência é o "Debug Mode" do Visual Studio Code.

6.2. Qual é o papel das exceções em C#? Como são tratadas no código?
    R: As exceções em C# são erros que ocorrem durante o processamento de um programa. As exceções são tratadas em C# usando o bloco try-catch. 


6.3. Dê um exemplo de como utilizar a declaração "try-catch" para lidar com exceções.
    R: O exemplo abaixo:

```csharp
try {
    // Código que pode gerar exceções
} catch (Exception ex) {
    // Tratamento da exceção
}
```

**7. Conceitos de POO em C#:**
7.1. Explique o que é Programação Orientada a Objetos (POO) e sua importância em C#.
    R: Programação Orientada a Objetos (POO) em C# é uma abordagem de programação que permite criar programas baseados em objetos. As classes que representam objetos do mundo real. A importância da POO em C# é que permite criar programas mais flexíveis, reutilizáveis e escaláveis, além de tornar o código mais legível e organizado.

7.2. Quais são os pilares da POO? Descreva cada um brevemente.
    R: Os pilares da POO são:
        * Abstração
        * Encapsulamento
        * Herança
        * Polimorfismo

7.3. Dê um exemplo prático de como um objeto é criado em C#.
    R: O exemplo abaixo:

```csharp
class Person {
    public string Name;
    public int Age;
    public Person(string name, int age) {
        Name = name;
        Age = age;
    }
}
```


**8. Encapsulamento, Construtores e Destrutores:**
8.1. Por que o encapsulamento é considerado importante na Programação Orientada a Objetos?
    R: O encapsulamento é fundamental na POO, pois permite isolar os dados de um objeto, impedindo que outros objetos ou mesmo o programador acesse e modifiquem diretamente esses dados. 
    
    Isso é importante para garantir a integridade dos dados. Além disso, o encapsulamento permite que os dados sejam acessados e manipulados apenas através de métodos da classe.


8.2. Explique a função dos construtores e destrutores em uma classe C#.
    R: Os Construtores são métodos especiais da classe que são executados quando um objeto é criado e destrutores são métodos especiais que são executados quando um objeto é desalocado na memória.  


8.3. Como você implementaria um construtor em uma classe?
    R: Exemplo abaixo:

```csharp
public Person(string name, int age) {
    Name = name;
    Age = age;
}

public Example(string name, int value)
    {
        this.Name = name;
        this.Value = value;
    }
```


**9. Herança e Polimorfismo:**
9.1. O que é herança em C# e como ela é aplicada?
    R: A herança é uma abordagem de programação que permite que uma classe herde os atributos e métodos de outras classes.

9.2. Explique o conceito de polimorfismo e forneça um exemplo prático.
    R: O polimorfismo em C# é o conceito de sobrescrita de métodos. Por exemplo, se uma classe filha herda os métodos da classe pai, essa classe pode sobrescrever o método da classe pai.

    Exemplo:

```csharp
class Person {
    public string Name;
    public int Age;
    public Person(string name, int age) {
        Name = name;
        Age = age;
    }
}
```

```csharp
class Employee : Person {
    public string JobTitle;
    public Employee(string name, int age, string jobTitle) : base(name, age) {
        JobTitle = jobTitle;
    }
}
```

```csharp
Employee employee = new Employee("John Doe", 30, "Software Engineer");
Console.WriteLine(employee.Name); // Output: John Doe
Console.WriteLine(employee.Age); // Output: 30
Console.WriteLine(employee.JobTitle); // Output: Software Engineer
```

9.3. Quais são as vantagens da herança e do polimorfismo na programação orientada a objetos?
    R: A herança e o polimorfismo fornecem uma maneira eficiente de reutilizar código.
    Com a herança, pode-se criar uma classe que tenha todas as características de outra classe e depois adicionar novas. Com o polimorfismo, pode-se ter diferentes classes que podem ser utilizadas da mesma forma.Isso significa que pode ter várias classes que possuem o mesmo método, mas fazem coisas diferentes.
    


**10. Classes Abstratas e Interfaces:**
10.1. Qual é a diferença entre uma classe abstrata e uma interface em C#?
    R: A diferença entre uma classe abstrata e uma interface é que uma classe abstrata pode conter atributos e métodos, enquanto uma interface apenas pode conter atributos e métodos.

10.2. Em que cenários você optaria por usar uma classe abstrata em vez de uma interface?
    R: Classes abstratas são usadas quando você deseja fornecer uma implementação comum para alguns dos métodos, mas ainda deseja forçar as subclasses a implementar alguns de seus próprios métodos. Eles são úteis quando você deseja compartilhar algum comportamento comum entre subclasses, mas também deseja garantir que cada subclasse tenha algum comportamento próprio.
    
    As interfaces são usadas quando você deseja definir um contrato com uma classe. Eles são úteis quando você deseja definir um conjunto de métodos que uma classe deve ter, sem se preocupar com os detalhes de implementação.


10.3. Dê um exemplo de implementação de uma interface em C#.
    R: O exemplo abaixo:

```csharp
public interface IExample {
    void MethodA();
    void MethodB();
}
```

