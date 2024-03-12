# 2. Sintaxe Básica de C#: Variáveis, Tipos de Dados e Operadores:
1. Variaveis são as de sempre Int,bool,string,char,list,array,dicionarios. Tipos de dados ficam os de valor e os de referencia no caso valor fifcariam os tipos simples, enumerators, etc e os operadores os classicos logicos(&, ||,etc), aritiméticos(+,-,*,etc) e relacionais(=,etc). 

## 2.1. Explique a importância das variáveis em C# e forneça um exemplo de declaração.
1. Separar e expecificar os tipos de dados para melhor uso e tratamento por exemplo 
2. ```C#
    int var1 = 1;
    string var2 = "1";
    ``` 

## 2.2. Quais são os tipos de dados básicos em C# e como são utilizados?
1. Os dados mais basicos são int,char e bool sendo int utilizado para numeros inteiros, char para letras(lembrando do tipo string que armazena conjuntos de digitos) e bool para true/false.

## 2.3. Dê exemplos de operadores aritméticos e lógicos em C#.
1. Operadores aritméticos: + , - , * , / , etc.
2. Operadores lógicos: &&, || e !.

# 3. Estruturas de Controle de Fluxo: Condicionais e Loops em C#:

## 3.1. Como as estruturas condicionais são implementadas em C#? Dê um exemplo.
1. ```C#
    /*estrutura condicional =>*/ if(/*condição =>*/var1 = 1 ){
        //algo a ser executado caso a condição seja atendida
    }/* estrutura condicional caso a primeira condição não seja atendida =>*/ else{
        //algo a ser executado 
    }
    ``` 

## 3.2. Explique o funcionamento dos loops em C# e forneça um exemplo de uso.
1. Loops recebem uma variavel a verficar para especificar a uantidade de repetições e executam ações em cada repetição(ou podem não executar alguma ação caso utilizados junto com estruturas condicionais)
2. ```C#
    //repetição com valor estatico
    for(int i = 0; i < 10; i++){
        //algo a ser executado em cada repetição
    }
    ```

## 3.3. Qual é a diferença entre o "for" e o "while" em termos de controle de fluxo?
1. A principal diferença é que o for cria um loop dentro de um alcance específico ja o while
cria um loop potencialmente infinito onde so tem um fim caso uma determinada condição seja atendida.

# 4. Strings, Arrays e Listas, Datas:

## 4.1. Descreva operações comuns realizadas em strings em C#.
1. operações para verificar o tamanho(length) e operações de separação(parce).

## 4.2. Compare e contraste Arrays e Listas em termos de funcionalidade e uso.
1. Arrays armazenam itens de um mesmo tipo na memoria estaticamente e tendo um tamanho fixo ja listas podem armazenar itens de forma dinamica e não possuem limite de tamanho(poerm listas acabam ocupando mais espaço na memória)

## 4.3. Como as datas são representadas e manipuladas em C#? Dê exemplos.
1. tenho uma certa dificuldade em lembrar desse assunto porem sei que existem e ja utilizei funções nativas do c# para manipulação de datas porem não lembro como utilizalas sem buscar no google.

# 5. Language Integrated-Query (LINQ):

## 5.1. O que é o LINQ e qual é sua finalidade em C#?
1. LINQ são conjuntos de funções utilizadas para percorrer e filtar dados de forma prática.

## 5.2. Forneça um exemplo prático de utilização do LINQ em uma coleção de dados.
1. ```C#
    from x in y where x =! true orderby x ascending select $"x is {x}";
    //utiliza uma variavel temporaria x na coleção y percorrendo cada item da coleção, filtra as que possuem o valor true e cria uma nova coleção ordenando de forma crescente.
    //obs: so não estou certo do uso do select então não mencionei, usei um exemplo que lembrei de cabeça mas essa ultima parte esqueci.
    ```

## 5.3. Quais são as vantagens de usar o LINQ em comparação com abordagens convencionais?
1. A redução do tamanho do código e a praticidade para filtrar os dados

# 6. Debugging e Exceções:

## 6.1. Descreva o processo de debugging em C# e mencione ferramentas úteis.
1. Não tenho tanta experiencia com o processso de debug, entao não sei descrever porem as veze uso para ver ass partes de codigo que estao dando problema. 

## 6.2. Qual é o papel das exceções em C#? Como são tratadas no código?
1. É basicamente lidar com erros. Elas podem ser tratadas com um codigo que captura e lida com o erro no caso se não me engano try-catch

## 6.3. Dê um exemplo de como utilizar a declaração "try-catch" para lidar com exceções.
1. ```C#
    try{
        //tenta fazer algo
    }catch(/*pode ser usado para capturar um erro especifico ou não*/){
        //medida a ser tomada caso o erro seja capturado
    }
    ```

# 7. Conceitos de POO em C#:

## 7.1. Explique o que é Programação Orientada a Objetos (POO) e sua importância em C#.
1. POO consiste encapsular, abstrair e facilitar a reutilização do um codigo.

## 7.2. Quais são os pilares da POO? Descreva cada um brevemente.
1. Abstração ue consiste em representar algo do mundo real em forma de codigo.
2. Encapsulamento que consiste separar a informação de forma a evitar blocos muito grandes de informação assim facilitando a manutenção.
3. Herança não consegui formular uma resposta direito.
4. polimorfismo tambem. 

## 7.3. Dê um exemplo prático de como um objeto é criado em C#.
1. ```C#
    //criando o objeto
    public class OBJ
    {
        public string nome {get; set;} //colocando get e set padrão sem verificações personalizadas
        public int idade {get; set;}
    }
    //criando uma instancia dele em outro lugar
    var novoObjeto = new OBJ
    ```


# 8. Encapsulamento, Construtores e Destrutores:

## 8.1. Por que o encapsulamento é considerado importante na Programação Orientada a Objetos?
1. Separa e define acesso a informação de forma correta evitando erros de segurança. 

## 8.2. Explique a função dos construtores e destrutores em uma classe C#.
1. Definir a criação do objeto de forma a obter a estrutura desejada ou modificação dela.

## 8.3. Como você implementaria um construtor em uma classe?
1. ```C#
    public class OBJ
    {
        private string nome; 
        private int idade;
        //construtor com nome e idade
        public OBJ (string _nome, int _idade){
            nome = _nome;
            idade = _idade;
        }
        //construtor so com nome
        public OBJ (string _nome){
            nome = _nome;
        }
    }
    ```

# 9. Herança e Polimorfismo:

## 9.1. O que é herança em C# e como ela é aplicada?
1. Herança é a capacidade de um codigo de herdar atributos e metodos de outro codigo.
2. ```C#
    public class classe2 : classe1 {} // classe2 irá herdar metodos ou atributos não privados de classe1 
    ```

## 9.2. Explique o conceito de polimorfismo e forneça um exemplo prático.
1. Não sei explicar direito de cabeça

## 9.3. Quais são as vantagens da herança e do polimorfismo na programação orientada a objetos?
1. Evitam a repetição de codigo de forma desnecessária e fazem com que a informação seja armazenada de forma mais segura e organizada.

# 10. Classes Abstratas e Interfaces:

## 10.1. Qual é a diferença entre uma classe abstrata e uma interface em C#?
1. As 2 são similares e não sei realmete dizer.


## 10.2. Em que cenários você optaria por usar uma classe abstrata em vez de uma interface?
1. Sendo sincero não sei responder.

## 10.3. Dê um exemplo de implementação de uma interface em C#.
1. ```C#
    //uma interface para usuario(isso de um projeto que fizemos na residenca anteriormente)
    public interface IUserRepository<T> where T : User
    {
        Task<T> Get(string email, CancellationToken cancellationToken);
    }
    ```