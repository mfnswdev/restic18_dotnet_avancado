2. Sintaxe Básica de C#: Variáveis, Tipos de Dados e Operadores:**
2.1. Explique a importância das variáveis em C# e forneça um exemplo de declaração.
    Recuperação de dados e armazenamento, é importante também que elas sejam mnemônicas, faça sentido com oque ou para que ela serve.
2.2. Quais são os tipos de dados básicos em C# e como são utilizados?
    int, float, double e string
2.3. Dê exemplos de operadores aritméticos e lógicos em C#.
    - Aritméticos:
        x + y

    - Lógicos
        x == 5 
        condicao1 && condicao2


**3. Estruturas de Controle de Fluxo: Condicionais e Loops em C#:**
3.1. Como as estruturas condicionais são implementadas em C#? Dê um exemplo.
    1- Exiba a mensagem "Par" caso um numero N seja divisivel por 2:
        if (x % 2 == 0){
            console.WriteLine("Par")
        } else
            return
    
3.2. Explique o funcionamento dos loops em C# e forneça um exemplo de uso.
    As estruturas são for, while, foreach. De forma geral elas podem ser usadas quando é esperado repetições de dados/estrutura.
    Exemplo: Exibir os usuario do banco de dados
    foreach ( user : Users){
        console.WriteLine("Nome"+ user.getNome())
    }
3.3. Qual é a diferença entre o "for" e o "while" em termos de controle de fluxo?
    Ambos podem oferecer o mesmo resultado, mas o for é mais utilizado quando se sabe a quantidade de repetição, sendo iterado e no while o codigo ira se repetir enquanto respeitar uma condição.


**4. Strings, Arrays e Listas, Datas:**
4.1. Descreva operações comuns realizadas em strings em C#.
    
4.2. Compare e contraste Arrays e Listas em termos de funcionalidade e uso.
    Array é necessario informar o tamanho do vetor, e listas armazena os dados por meio de ponteiros não tendo necessidade de informar tamanho maximo.

4.3. Como as datas são representadas e manipuladas em C#? Dê exemplos.
    Usamos o tipo DateTime, que implemnta algumas funções como validação de data, extração de mês, dia e ano


**5. Language Integrated-Query (LINQ):**
5.1. O que é o LINQ e qual é sua finalidade em C#?
    É como usamos busca ao banco pelo codigo, invés de usar SQL usamos LINQ no próprio codigo, isso possibilida eficiência nas buscas.

5.2. Forneça um exemplo prático de utilização do LINQ em uma coleção de dados.

5.3. Quais são as vantagens de usar o LINQ em comparação com abordagens convencionais?



**6. Debugging e Exceções:**
6.1. Descreva o processo de debugging em C# e mencione ferramentas úteis.
6.2. Qual é o papel das exceções em C#? Como são tratadas no código?
    As exceções são para evitar que o codigo pare com o surgimento de algum erro, nem sempre toda a sua aplicação precisa parar ao surgir erro em alguma etapa. Se seu programa e uma calculadora online, e o usuario solicita uma operação de divisão por zero, apesar disso gerar um erro (caso essa operação seja enviada para compilador e executada) a sua página não precisa ser vista com erro 404 na tela.

    No exemplo acima Try e catch supreem essa demanda.
6.3. Dê um exemplo de como utilizar a declaração "try-catch" para lidar com exceções.
    try{
        encontraUser(id)
    }catch{
        thron ("User não encontrado")
    }


**7. Conceitos de POO em C#:**
7.1. Explique o que é Programação Orientada a Objetos (POO) e sua importância em C#.
    Abstração dos dados, organizando ele através de classes

7.2. Quais são os pilares da POO? Descreva cada um brevemente.

7.3. Dê um exemplo prático de como um objeto é criado em C#.
    



**8. Encapsulamento, Construtores e Destrutores:**
8.1. Por que o encapsulamento é considerado importante na Programação Orientada a Objetos?
    Dados é de extrema importancia, e nem todos devem estar disponiveis para qualquer nivel> Com o encapsulamento correto, você protege dados e os deixa disponivel para quem realmente pode acessa-lo.
8.2. Explique a função dos construtores e destrutores em uma classe C#.
    construtores são executados sempre que o objteo for instanciado, então valor de inicialização, validações iniciais devem/podem ser postas aqui.

    Não sei sobre 'destrutores'
8.3. Como você implementaria um construtor em uma classe?
    Digamos que minha class 'Oficina' precisa ter sempre o nome e endereço, posso fazer com que o objeto só seja instanciado quando for passada essas informações

    public class Oficina (string nome, string endereco){}


**9. Herança e Polimorfismo:**
9.1. O que é herança em C# e como ela é aplicada?
    Ao ter comportamentos e/ou atributos que serão usadas em diferentes classe, esse atributos podem estar em uma unica classe, e servir de herança para todas as que compartilham desse comportamento

9.2. Explique o conceito de polimorfismo e forneça um exemplo prático.
    Métodos podem ter a mesma assinatura mas terem seu conteudo diferentes. Em uma exemplo de uma classe Animal, gato e cachorro. Na classe Animal tem um método fazerSom(), e essa classe é herdada em gato e em cachorro, so que o retorno para essas classes vão ser diferentes.

9.3. Quais são as vantagens da herança e do polimorfismo na programação orientada a objetos?


**10. Classes Abstratas e Interfaces:**
10.1. Qual é a diferença entre uma classe abstrata e uma interface em C#?
    a classe abstrata são a classes que não serão instanciadas e interfaces servem como contratos na qual a classe que usa-lá será obrigada e implementar tudo que ela declarou ter.
10.2. Em que cenários você optaria por usar uma classe abstrata em vez de uma interface?

10.3. Dê um exemplo de implementação de uma interface em C#.
    ao fazer entidades que terão CRUD , operações de getById, getAll, create, Update são necessãrias, sendo assim uma interface 'BaseEntity' com a assinatura desses métodos ira padronizar o nome dos métodos e ajudar em trabalhos em equipe.

