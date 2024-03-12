<h1>Aluno: Brendom Victor Gama Gonçalves</h1>

<h2>2. Sintaxe Básica de C#: Variáveis, Tipos de Dados e Operadores:</h2>

- 2.1. Explique a importância das variáveis em C# e forneça um exemplo de declaração.

  > <code>String carroNovo = "Honda Civic";</code><br>
  > A importância se dá pela praticiadade de ter um nome como representação de um conteúdo importante para o código, tornando a reutilização e manipulação mais fácil.
- 2.2. Quais são os tipos de dados básicos em C# e como são utilizados?

  > <code>int, boolean, String, float</code><br>
  > <code>int numeroAleatorio = 10;</code><br>
  > <code>boolean condicaoTeste = true;</code><br>
  > <code>String nomeSobrenome = "Brendom Goncalves";</code><br>
  > <code>float pi = 3,14159265;</code>
- 2.3. Dê exemplos de operadores aritméticos e lógicos em C#.

  > <code>+, -, /, *, ==, !=, !</code><br>
  > <code>int soma = 4 + 5;</code><br>
  > <code>int subtracao = 4 - 5</code><br>
  > <code>float divisao = 6 / 3</code><br>
  > <code>boolean primeiraCondicao = soma == subtracao;</code><br>
  > <code>boolean segundaCondicao = soma != subtracao;</code><br>
  > <code>boolean terceiraCondicaoContraria = !(soma == subtracao);</code>

<h2>3. Estruturas de Controle de Fluxo: Condicionais e Loops em C#:</h2>

- 3.1. Como as estruturas condicionais são implementadas em C#? Dê um exemplo.

  > São implementadas com um bloco de condição após a palavra "if" e chaves para o primeiro bloco de ativação e um else para condição false/verdadeira a depender da lógica imposta<br>
  > <code>boolean ativacao = true;</code><br>
  > <code>if(ativao) System.Console.WriteLine("Ativação é verdadeira!")</code><br>
- 3.2. Explique o funcionamento dos loops em C# e forneça um exemplo de uso.

  > Os loops funcionam a a partir de uma condição verdadeira/falsa imposta no bloco após o "while" e "do-while", já o "for" utiliza contadores para percorrer determina estrutura ou contar repetições.<br>
  > <code>boolean condicaoRepeticao = true;</code><br>
  > <code>int contadorRepeticao = 1;</code><br>
  > <code>while(condicaoRepeticao) System.Console.WriteLine("Repetir infinitamente");</code><br><br>
  > <code>do{</code><br>
  > <code>&nbsp;&nbsp;&nbsp;contadorRepeticao++;</code><br>
  > <code>}while(contadorRepeticao == 10);</code><br><br>
  > <code>for(int i=1;i<=10;i++){<br>&nbsp;&nbsp;&nbsp;Console.WriteLine(i);<br>}</code><br>

- 3.3. Qual é a diferença entre o "for" e o "while" em termos de controle de fluxo?

  > O <code>for</code> trabalha com controle de variável e o <code>while</code> com condições;

<h2>4. Strings, Arrays e Listas, Datas:</h2>

- 4.1. Descreva operações comuns realizadas em strings em C#.

  > <code>String nomeCompleto = "Brendom Gonçalves"</code><br>
  > <code>System.Console.WriteLine(nomeCompleto.ToLower());</code><br>
  > <code>System.Console.WriteLine(nomeCompleto.ToUpper());</code><br>
  > <code>System.Console.WriteLine(nomeCompleto.Length);</code><br>

- 4.2. Compare e contraste Arrays e Listas em termos de funcionalidade e uso.

  > Os <code>Arrays</code> precisam ser manipulados indexadamente, enquanto as <code>Listas</code>> são dinâmicas como o exemplo do <code>Vector</code> que dá pra adicionar, deletar, procurar apenas com os métodos do próprio vector.

- 4.3. Como as datas são representadas e manipuladas em C#? Dê exemplos.

  > São manipuladas a partir da classe <code>DateTime</code> que te da acesso aos métodos e construtor dela pra criar uma nova data, capturar a data atual, etc.<br>
  > <code>DateTime novaData = new DateTime(2008, 6, 1, 10, 30, 0)</code><br>
  > <code>System.Console.WriteLine(novaData.ToString());</code><br>

<h2>5. Language Integrated-Query (LINQ):</h2>

- 5.1. O que é o LINQ e qual é sua finalidade em C#?

  > O uso do LINQ serve para facilitar o manipulação de listas, pesquisas, alterações, deletes. Com ele atrelado ao Lambda fica mais fácil realizar essas operações.

- 5.2. Forneça um exemplo prático de utilização do LINQ em uma coleção de dados.

  > <code>int[] idades = [10, 35, 47, 18, 9, 12]</code><br>
  > <code>int[] menoresDeIdade = </code><br>
  > <code>&nbsp;&nbsp;&nbsp;from idade in idades</code><br>
  > <code>&nbsp;&nbsp;&nbsp;where idade < 18</code><br>
  > <code>&nbsp;&nbsp;&nbsp;select idade;</code>

- 5.3. Quais são as vantagens de usar o LINQ em comparação com abordagens convencionais?
  > O <code>LINQ</code> facilita a leitura, tem desempenho melhor (padrão) em toda execução de pesquisa, leitura, etc.

<h2>6. Debugging e Exceções:</h2>

- 6.1. Descreva o processo de debugging em C# e mencione ferramentas úteis.

  > Os únicos debugging que eu utilizei foram os do Rider da JetBrains e do Vs Code para degub do código. Mas acredito que usar o Swagger para Web seja uma forma de debug támbem.<br><br>
  > O processo de debugging se dá pelo acompanhamento linha por linha do seu código através de stops que você pode settar no código, uma possível linha importante, um método impotante. Assim você consegue acompanhar as declarações das variáveis, quis valores elas estão recebendo.

- 6.2. Qual é o papel das exceções em C#? Como são tratadas no código?

  > As <code>exceções</code> funcionam como tratamento de erros que possivelmente encerram o programa que está rodando, então para conter essas eventualidades, utiliza-se os <code>try-catch</code>, após gerar um <code>throw</code> ou <code>new exception</code> pra contorlar um erro e poder tratar sem deixar a aplicação encerrar.

- 6.3. Dê um exemplo de como utilizar a declaração "try-catch" para lidar com exceções.

  > <code>public float DivisaoZero (float num1, float num2){<br></code>
  > <code>&nbsp;&nbsp;&nbsp;if(num2 ==  0) throw new Exception("Não podemos dividir por 0.");</code><br>
  > <code>&nbsp;&nbsp;&nbsp;return num1 / num2;</code><br>
  > <code>}</code><br>
  > <code>try{</code><br>
  > <code>&nbsp;&nbsp;&nbsp;float resultado = DivisaoZero(10, 0);</code><br>
  > <code>} catch (Exception e){</code><br>
  > <code>&nbsp;&nbsp;&nbsp;System.Console.WriteLine(e.Message);</code><br>
  > <code>}</code>

<h2>7. Conceitos de POO em C#:</h2>

- 7.1. Explique o que é Programação Orientada a Objetos (POO) e sua importância em C#.

  > POO basicamente pelo que entendi, é uma maneira de repesentar o que quisermos no código a partir de obejtos com propriedades, então se quero represetnar uma pessoa eu posso criar uma classe com um construtor e suas propriedades para inicializar, criar métodos que facilitam manipular essa classe.

- 7.2. Quais são os pilares da POO? Descreva cada um brevemente.

  > Encapsulamento<br>
  > Classes Abstratas<br>
  > Herança de classes<br>
  > Polimorfismo<br>

- 7.3. Dê um exemplo prático de como um objeto é criado em C#.

  > <code>Pessoa novaPessoa = new Pessoa("Brendom", "Gonçalves");</code>

<h2>8. Encapsulamento, Construtores e Destrutores:</h2>

- 8.1. Por que o encapsulamento é considerado importante na Programação Orientada a Objetos?

  > Acredito que facilita na manipulação de dados em comum, por exemplo em uma classe pessoa, ter propriedades que tem relação com os dados de uma pessoa como: nome, cpf, endereço, idade, etc. Isso tudo encapsulado em uma classe, torna mais fácil o acesso e a manipulação.

- 8.2. Explique a função dos construtores e destrutores em uma classe C#.

  > <code>Construtores:</code> São métodos que são chamados quando um objeto da classe é criado. Eles têm o mesmo nome da classe e não possuem um tipo de retorno. Tem como função inicializar os membros da classe e preparar o objeto para uso.<br>
  > <code>Destrutores:</code> São usados para gerenciar os dados antes que o objeto seja destruído e removido da memória.

- 8.3. Como você implementaria um construtor em uma classe?

  > <code>public class Pessoa{<br></code>
  > <code>&nbsp;&nbsp;&nbsp;private String Nome {get;set}</code><br>
  > <code>&nbsp;&nbsp;&nbsp;private String Sobrenome {get;set}</code><br>
  > <code>&nbsp;&nbsp;&nbsp;public Pessoa(String _nome, String _sobrenome){</code><br>
  > <code>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Nome = _nome;</code><br>
  > <code>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Sobrenome = sobrenome;</code><br>
  > <code>&nbsp;&nbsp;&nbsp;}</code><br>
  > <code>}</code><br>

<h2>9. Herança e Polimorfismo:</h2>

- 9.1. O que é herança em C# e como ela é aplicada?

  > Herança é uma forma de permitir que uma classe herde as características e métodos de outra classe, Tornando mais prático e menos repetitivo o uso das propriedades.<br>
  > <code>public class Pessoa {<br></code>
  > <code>&nbsp;&nbsp;&nbsp;Propriedades e Métodos da classe</code><br>
  > <code>}</code><br><br>
  > <code>public class Professor : Pessoa {</code><br>
  > <code>&nbsp;&nbsp;&nbsp;Propriedades e Métodos da classe Professor</code><br>
  > <code>}</code>

- 9.2. Explique o conceito de polimorfismo e forneça um exemplo prático.

  > O polimorfismo permite que um objeto seja tratado de diferentes maneiras, dependendo do contexto. Ele permite que um objeto de uma classe seja tratado como um objeto de uma classe mais genérica, permitindo a reutilização de código.<br>
  > <code>public class Animal {</code><br>
  > <code>&nbsp;&nbsp;&nbsp;public virtual void EmitirSom() {</code><br>
  > <code>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Console.WriteLine("O animal emite um som.");</code><br>
  > <code>&nbsp;&nbsp;&nbsp;}<br>}</code><br>
  > <code>public class Cachorro : Animal {</code><br>
  > <code>&nbsp;&nbsp;&nbsp;public override void EmitirSom(){</code><br>
  > <code>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Console.WriteLine("O cachorro late.");</code><br>
  > <code>&nbsp;&nbsp;&nbsp;}<br>}</code><br>
  > <code>public class Gato : Animal {</code><br>
  > <code>&nbsp;&nbsp;&nbsp;public override void EmitirSom(){</code><br>
  > <code>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Console.WriteLine("O gato mia.");</code><br>
  > <code>&nbsp;&nbsp;&nbsp;}<br></code>
  > <code>}</code>

- 9.3. Quais são as vantagens da herança e do polimorfismo na programação orientada a objetos?

  > Eu acho que são: <code>Reutilização de código, Organização do código, Flixibilidade, Abstração</code>

<h2>10. Classes Abstratas e Interfaces:</h2>

- 10.1. Qual é a diferença entre uma classe abstrata e uma interface em C#?

  > Acho que a diferença entre as duas que mais constrata é a questão do contrato, quando eu crio uma classe abstrata e uso ela como classe base, não tenho uma garantia a depender do contexto de que serão implementados todos os métodos. Já na interface, é assinado um "contrato" que obriga a implementação, então a depender o uso da interface gera mais segurança.

- 10.2. Em que cenários você optaria por usar uma classe abstrata em vez de uma interface?

  > Na ultima trilha passei por um exemplo, quando estávamos fazendo o projeto ResTIConnect, haviam as interfaces dos serviços que utilizavamos para implementar as classes de serviços, neles tinhamos os métodos que usavamos como: <code>update, delete, gettAll, getById.</code> Com isso obrigávamos os serviços a implementar, o que gera um certo padrão onde todos os serviços tinham que obrigatóriamente implementar os métodos.

- 10.3. Dê um exemplo de implementação de uma interface em C#.

  > <code>public interface IVoador {</code><br>
  > <code>&nbsp;&nbsp;&nbsp;void Voar();</code><br>
  > <code>}</code><br>
  > <code>public class Passaro : IVoador {</code><br>
  > <code>&nbsp;&nbsp;&nbsp;public void Voar(){</code><br>
  > <code>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Console.WriteLine("O passaro está voando.");</code><br>
  > <code>&nbsp;&nbsp;&nbsp;}<br></code>
  > <code>}</code>