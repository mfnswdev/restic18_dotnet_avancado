**2. Sintaxe Básica de C#: Variáveis, Tipos de Dados e Operadores:**

2.1. Explique a importância das variáveis em C# e forneça um exemplo de declaração.

    Armazenar informações na memória para serem utilizadas posteriormente, organizar e facilitar a manutenção do código através de reutilização, aumentar a legibilidade utilizando apelidos para os valores armazenados.

2.2. Quais são os tipos de dados básicos em C# e como são utilizados?

    short - numeros inteiros, menor do que int
    int - números inteiros
    long - numeros inteiros, maior do que int
    float - números de ponto flutuante
    double - números de ponto flutuante com maior precisão
    string - textos
    bool - true ou false

2.3. Dê exemplos de operadores aritméticos e lógicos em C#.

    operadores aritméticos:
        '+' - Adição
        '-' - Subtração
        '*' - Multiplicação
        '/' - Divisão
        '%' - Operador resto da divisão
    operadores lógicos:
        '&&' - Operador 'e' lógico
        '||' - Operador 'ou' lógico
        '!' - Operador de negação
        '>' - Operador maior que
        '<' - Operador menor que
        '==' - Operador de igualdade
        '!=' - Operador de diferença


**3. Estruturas de Controle de Fluxo: Condicionais e Loops em C#:**

3.1. Como as estruturas condicionais são implementadas em C#? Dê um exemplo.

        São estruturas que alteram o fluxo de execução do programa baseadas em condições que resultam em true ou false.
        Essas estruturas servem para definir se um bloco de código vai ou não ser executado baseado nessas condições
        Estrutura 'if else':
            if (<condição>) {
                <código executado quando a condição é verdadeira>
            } else {
                <código executado quando a condição é falsa>
            }
            Exemplo:
            if(x > 10){
                Console.WriteLine("X é maior que 10");
            } else {
                Console.WriteLine("X é menor que 10");
            }
        
        Estrutura 'switch case':
            switch (<variável>){
                case <valordesejado>:
                    codigo executado quando a condição for verdadeira
                    break;
                case <outrovalordesejado>:
                    codigo executado quando a condição for verdadeira
                    break;
                default:
                    código executado quando nenhuma condição das anteriores for verdadeira
            }
            Exemplo:
            int opcao = 1;
            switch (opcao){
                case 1:
                    Console.WriteLine("Você escolheu a opção 1");
                    break;
                case 2:
                    Console.WriteLine("Você escolheu a opção 2");
                    break;
                default:
                    Console.WriteLine("Digite uma opção válida");
            }

3.2. Explique o funcionamento dos loops em C# e forneça um exemplo de uso.

        São estruturas que repetem um determinado bloco de código até que uma determinada condição seja atendida:
        Laço 'for':
            for(<inicialização_da_variavel>; <condicao_de_parada>; <incremento_da_variavel>){
                bloco de código que será executado
            }
        Exemplo:
            for(int i = 0; i < 10; i++){
                Console.WriteLine(i+1);
            }
        
        Laço 'foreach':
            foreach(<variavel> in <lista>){
                código que será executado
            }
        Exemplo:
            foreach(item in listaItens){
                Console.WriteLine(item.nome);
            }
        
        Laço 'while':
            while(<condição>){
                código que será executado
            }
        Exemplo:
            int i = 0;
            while(i < 10){
                Console.WriteLine(i+1);
                i++;
            }
        
        Laço 'do while':
            do {
                código que será executado
            } while (<condição>);
        Exemplo:
            int i = 0;
            do {
                Console.WriteLine(i+1);
                i++;
            } while (i < 10);
        
        É importante notar que nos laços 'while' e 'do while' a variavel deve ser declarada fora do laço de repetição e seu incremento deve ser feito dentro do bloco de execução

3.3. Qual é a diferença entre o "for" e o "while" em termos de controle de fluxo?

        For é comumente utilizado para situações onde é conhecida a quantidade de vezes que uma repetição vai ocorrer.
        Foreach é comumente usado para iterar sobre listas, mesmo que não saibamos quantas vezes a repetição irá ocorrer
        While e Do While são comumente utilizados para repetições sem uma quantidade de vezes definida, normalmente possuindo uma condição de parada dentro dos blocos de código que executarão.
        É importante lembrar que enquanto o while sempre testa antes de executar, o do while executa a primeira iteração antes de testar a condição, o que pode gerar comportamentos indesejados. Apesar disto uma possível utilidade é para menus em terminal.


**4. Strings, Arrays e Listas, Datas:**

4.1. Descreva operações comuns realizadas em strings em C#.

    Normalmente as operações utilizadas em strings envolvem recuperar apenas um pedaço dela ou dividi-la em uma lista de strings baseando-se em um caractere separador. É comum também fazer concatenação de strings.

4.2. Compare e contraste Arrays e Listas em termos de funcionalidade e uso.

    Arrays são conjuntos de elementos com menos métodos disponíveis se comparados às Listas. Listas possuem acesso a todos métodos LINQ, bem como todos os métodos relacionados a arrays. Arrays, apenas para exibição de dados, são mais eficientes, enquanto listas são mais robustas no que diz respeito à manipulação de dados.

4.3. Como as datas são representadas e manipuladas em C#? Dê exemplos.

    Utilizando o tipo 'DateTime' ou 'DateTimeOffset'.
    DateTimeOffset também salva, além da data e hora, o fuso horário daquela data e hora. O DateTime apenas salva data e hora.
    Para usar datas precisamos usar os atributos da classe, por exemplo:
        DateTime data = DateTime.Now;
        ou
        DateTime data = DateTime.UtcNow;
    ou utilizando o método da classe passando uma string que representa uma data:
        DateTime data = DateTime.TryParse(<data>);
    ou instanciar um novo objeto
        DateTime data = new DateTime();
        
    e podemos manipular essas datas com métodos como 'AddDays()', 'AddMonths()', 'AddYears()' para avançar ou retroceder dias, meses ou anos na data.
    Podemos também acessar o dia, mes ou ano de uma data usando os atributos Day, Month, Year.


**5. Language Integrated-Query (LINQ):**

5.1. O que é o LINQ e qual é sua finalidade em C#?

    LINQ é uma forma de estruturar consultas e manipular listas utilizando expressões lambda de modo que simplifica e otimiza esse tipo de operação 

5.2. Forneça um exemplo prático de utilização do LINQ em uma coleção de dados.

    Se eu quero verificar se existe um usuário com determinado email na minha lista por exemplo:

    usuarios.any(usuario => usuario.nome == <nome>)

    ou retornar todos os usuários com determinado sobrenome:

    usuarios.where(usuario => usuario.sobrenome == <sobrenome>)


5.3. Quais são as vantagens de usar o LINQ em comparação com abordagens convencionais?


**6. Debugging e Exceções:**

6.1. Descreva o processo de debugging em C# e mencione ferramentas úteis.

    É possível debugar um projeto em C# rodando a aplicação em modo debug, adicionando breakpoints no código para que a execução do programa seja pausada ao chegar neles. Ao chegar em um breakpoint é possível analisar os valores que as variáveis assumem naquele ponto específico do código e entender melhor o por que do bug estar ocorrendo.

6.2. Qual é o papel das exceções em C#? Como são tratadas no código?

    Exceções podem ser lançadas em blocos de código em que existe a suspeita de acontecer um erro que pode parar a execução do programa. Posteriormente essas exceções podem ser capturadas e tratadas baseadas no tipo delas sem que o fluxo de execução do programa seja interrompido.

6.3. Dê um exemplo de como utilizar a declaração "try-catch" para lidar com exceções.

    Podemos usar o "try-catch" para capturar exceções lançadas anteriormente, por exemplo se tivermos um método:

    public divisao(int n1, int n2){
        if(n2 == 0){
            throw new DivideByZeroException();
        }

        return n1 / n2;
    }

    Podemos usar um try catch da seguinte forma para capturar a exceção caso n2 seja 0:

    try {
        Console.WriteLine(divisao(1, 0));
    } catch {
        Console.WriteLine("Não é possível dividir por 0");
    }

**7. Conceitos de POO em C#:**

7.1. Explique o que é Programação Orientada a Objetos (POO) e sua importância em C#.
    
    A programação orientada a objetos nos permite abstrair objetos do mundo real e representá-los na programação com seus atributos.
    A programação orientada a objetos nos permite aplicar o conceito de herança para reutilizar código e garantir hierarquia e certo nivel de uniformidade garantindo que classes herdeiras tenham que fornecer os atributos de seus pais além dos seus próprios.
    Utilizando POO é possível melhorar a legibilidade, manutenção e reutilização do código e é um paradigma amplamente utilizado atualmente.

7.2. Quais são os pilares da POO? Descreva cada um brevemente.

7.3. Dê um exemplo prático de como um objeto é criado em C#.


**8. Encapsulamento, Construtores e Destrutores:**

8.1. Por que o encapsulamento é considerado importante na Programação Orientada a Objetos?

8.2. Explique a função dos construtores e destrutores em uma classe C#.

8.3. Como você implementaria um construtor em uma classe?


**9. Herança e Polimorfismo:**

9.1. O que é herança em C# e como ela é aplicada?

9.2. Explique o conceito de polimorfismo e forneça um exemplo prático.

9.3. Quais são as vantagens da herança e do polimorfismo na programação orientada a objetos?


**10. Classes Abstratas e Interfaces:**

10.1. Qual é a diferença entre uma classe abstrata e uma interface em C#?

10.2. Em que cenários você optaria por usar uma classe abstrata em vez de uma interface?

10.3. Dê um exemplo de implementação de uma interface em C#.
