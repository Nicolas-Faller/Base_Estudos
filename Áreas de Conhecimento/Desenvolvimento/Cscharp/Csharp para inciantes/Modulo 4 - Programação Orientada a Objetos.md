
---
*📅 **created: 27-08-2025 / 12:58**
🏷️ **tags: []**
**⌛ status: draft**
## 📋 Resumo

> Breve descrição do conteúdo

## 📚[[CSharpIniciantes.pdf#page=97&selection=0,13,1,16&color=yellow|Programação Orientada a Objetos com C#]]

Quando aprendemos a programação, na maioria das vezes é de maneira estruturada, ou seja, efetuar a leitura de um código de "cima para baixo", começando no topo, executando cada linha sequência de maneira estruturada e lógica. Claro que não há nada de errado nisso, de fato é assim que se aprende lógica de programação, tão fundamental para quem está iniciando no mundo da programação. Pensar estruturado, com lógica é fundamental, é o começo de tudo e nos ajuda em muitas decisões na vida, estar diante de um código é um problema a ser solucionado ou codificado

Mas entendemos que este modelo de programação, ainda presente em muitas linguagens não é aplicado em C#. De fato, nunca foi, C# nasceu em 1999 (data que foi lançado oficialmente no Brasil) orientado a Objetos. Entender o básico da orientação a objetos ajudará a tirar o máximo proveito da linguagem C#, reutilizar código, criar nossas próprias bibliotecas de comando, proteger acessos indevidos e funções e comandos que são apenas internos, evitando assim, erros e bugs desnecessários. Além de tudo como já dizia Stroustrup (O criador da linguagem de programação C++, que é o C orientado a objetos) "OPP deixa seu código organizado com acessos bem definidos e além de tudo, elegante". 
### Lógica da Orientação a Objetos

A Orientação a objetos possui alguns pilares importantes e essenciais de serem entendidos antes de começar a codificar. Uma rápida pesquisa na internet encontrará centenas de artigos, alguns com os 5 pilares do OOP, outros com os 12 pilares o OOP, mas não vamos enumerar os pilares, e sim discorrer agora sobre alguns conceitos importantes em programação orientada a objetos que devemos saber antes de codificar.
### Próximo ao Mundo Real

A Orientação a Objetos (e por isso leva esse nome de "Objetos") tenta aproximar a programação ao que vemos no mundo real. Tratando partes do código como se fossem objetos (fisicamente reais) e com suas características e propriedades, com isso conseguimos abordar um problema a ser solucionado em pequenas partes de código, que juntas solucionam o problema inteiro. Veja na figura a seguir o entendimento dessa abordagem, comparando com a programação estruturada.

![[Pasted image 20250827132151.png]]

A abordagem do problema a ser solucionado é diferente na orientação a objetos. Procuramos quebrar o problema em diversos "objetos" e cada objeto possui uma característica, um nome, uma funcionalidade e uma propriedade. Neste conceito vamos entender um dos principais pilares da Orientação a objetos, a abstração.
### Abstração

O conceito de abstração é tornar aquele código autossuficiente de maneira que possa ser chamado por outras partes do programa, sem que necessitemos entender como ele foi implementado para que assim possa chamá-lo. A abstração na orientação a objetos tem este objetivo, tornar parte de um código complexo abstraído de toda uma regra de negócio, por exemplo, e assim ser chamado quando houver necessidade diversas vezes ao longo do programa.
### Encapsulamento

Este é o que consideramos ser outro pilar da programação orientada a objetos. Encapsulamento é a forma de "esconder" ao mundo uma parte do código que não faz necessário todo o programa conhecer. No gráfico da figura anterior, temos Método 1 e Método 2 em cada um dos objetos criado para solucionar o problema. Mas os problemas não precisam enxergar a implementação um do outro, apenas saber que existem comandos (ou métodos) chamado "Método 1" e "Método 2" que irão resolver o problema proposto, sem que haja a necessidade de dar a cesso a todo o código implementado. Com isso, protegemos parte do código que está dentro dos métodos, contra acesso indevido. Uma vez que um código (ou objeto) é encapsulado, seus detalhes não mais visíveis ou acessíveis ao restante do programa, apenas aquela parte do programa autorizada á visibilidade. Aqui entramo os modificadores chamados "Public", "Private", "Protected" 
### Herança

Outro pilar importante na orientação a objetos. A Herança é hierarquicamente baseada, pode ser modificada após herdada. Uma classe pode ser herdada, ou seja, ela recebe tudo o que é possível daquele código anterior, possibilitando que ela modifique ou adicione o que for necessário para dar continuidade aquela classe(objeto código) que foi herdado.

Um exemplo de herança é codificar um sistema que irá catalogar animais. Temos um "objeto" ou classe chamado de "Animais", o qual possui características globais de todos os animais, por exemplo, idade, peso, raça, cor, etc. Se desejarmos refinar um pouco mais o código, a fim de controlar os animais mamíferos por exemplo, herdar a classe "Animais" e e nela adicionar a características "Glândulas de Mama", que só estão presentes nos animais mamíferos. Sem a necessidade de repetir novamente todas as características como idade, peso, altura, etc.
### Polimorfismo 

Outro poderoso pilar da orientação a objetos. O Polimorfismo permite que os objetos (ou classes) possuam o mesmo nome de método, a mesma implementação, para facilitar a leitura do código e até mesmo porque ás vezes a regra de negócio aplicada traz esta necessidade de ter o mesmo nome de "Método" em classes herdadas. Possuem a mesma assinatura de comando ou de método, mas a implementação ou resultado é diferente. Já falamos de herança, então vamos aproveitar para explicar polimorfismo com herança.

Vamos ao exemplo clássico ensinado nas universidades sobre Polimorfismo. O Homem e os animais mamíferos. Imagine o desenvolvimento de um sistema relacionado a este tema, a melhor prática seria a seguinte:

Classe(ou Objeto) Mamífero - Nesta classe mamífero há uma função ou método chamado Locomocao(). Obviamente não sabemos e não conhecemos esta locomoção porque ela é específica de cada animal. Com isso começamos a usar herança, o qual implementa o método "Locomocao()", conforme a necessidade.

Sendo assim Classe(ou Objeto) Macaco herdado da classe Mamífero que possui sua função "Locomocao()" implementado com o resultado de "de galho em galho" .

Classe (ou objeto) Homem herdado da classe Mamífero que possui sua função "Locomocao()" implementado com o resultado "Caminhando".

Classe (ou objeto) Canguru herdado da classe Mamífero que possui sua função "Locomocao()" implementado com o resultado "Saltitando".

```csharp
classe Mamifero
Locomocao() // Ainda a ser codificado na herança

Mamifero.ObjetoMamifero;

ObjetoMamifero = new Macado();
ObjetoMamifero.Locomocao(); // de galho em galho

ObjetoMamifero = new Homem();
ObjetoMamifero.Locomocao(); // caminhando 

ObjetoMamifero = new Canguru();
ObjetoMamifero.Locomocao(); // saltitando
```
### Entendendo as Classes (Objetos)

Vamos entender sobre classes criando a primeira classe no C# para mostrar um texto digitado pelo usuário. Vamos fazer primeiro de maneira estruturada e depois vamos abstrair os comandos dentro de uma casse, chamando -a desde o programa inicial.

```csharp
using static System.Console;
using System;
using System.Linq;

namespace Livrocsharp
{
    class ProgramaInicial
    {
        static void Main(string[] args)
        {
            // Declaramos uma variável do tipo string
            string Digitado = new string("");
            // Solicitamos que o usuário digite alguma coisa e armazene na variável criada
            Digitado = ReadLine();
            // Mostrarmos o que foi digitado
            WriteLine(Digitado);
        }
    }
}
```

Agora vamos transformar este código em uma classe, de maneira que ela possa ser chamada em outras partes do código sem que sejam necessárias todas as vezes chamar funções do System.WriteLine e System.ReadLine, os quais são invocados na classe ProgramaInicial. Código muito simples mas que já permite entender que a qualquer momento do código, podemos usar esta classe InteracaoUsuario.

```csharp
using static System.Console;
using System;
using System.Linq;

namespace Livrocsharp
{
    class ProgramaInicial
    {
        static void Main(string[] args)
        {
            /// Criamos um objeto Pedido herado da classe InteracaoUsuario
            InteracaoUsuario Pedido = new InteracaoUsuario();
            /// Invocamos os métodos do objeto Pedido herdado da classe mãe InteracaoUsuario
            var Digitado = Pedido.SolicitarDigitacao();
            Pedido.MostrarDigitacao(Digitado);
        }
    }
    /// Criamos a Classe InteracaoUsuario com dois metodos principais
    /// Método que solicita a digitação de algo no terminal 
    /// Método que mostra o que foi digitado
    class InteracaoUsuario
    {
        public string SolicitarDigitacao()
        {
            return ReadLine();
        }
        public void MostrarDigitacao(string Digitado)
        {
            WriteLine(Digitado);
        }
    }
}
```

Vamos aproveitar e ver algumas variações de implementação da mesma classe, porém agora usando o GET e SET, protegendo assim a implementação da classe e ampliando o encapsulamento.

Os métodos GET e SET permitem acessar as propriedades privadas da classe sem que haja a necessidade de acessar diretamente aquela variável, não necessitando torná-la pública para todo o programa. Vamos chamar isso de controle de acesso. Este controle de acesso permite que apenas o objeto da classe derivada obtenha valores e inclua valores nas variáveis da classe através dos métodos GET e SET.

Agora abstraímos ainda mais a classe InteracaoUsuario fazendo com que ela não apenas receba e imprima o valor digitado no console, criamos uma propriedade para a classe chamada Mensagem e através dela é que iremos recuperar a mensagem que foi digitada para futura manipulação no programa. Usamos o SET para atribuir um valor e o GET para ler o valor em si e implementamos no programa principal a manipulação da mensagem que foi apresentada pela classe. Realizamos isso recebendo a mensagem digitada lendo a propriedade Mensagem, manipulando o valor desta propriedade na variável Digitado. Estamos colocando tudo em Maiúsculas (ToUpper) e solicitando que seja impresso o novo valor digitado.

```csharp
using static System.Console;
using System;
using System.Linq;

namespace Livrocsharp
{
    class ProgramaInicial
    {
        static void Main(string[] args)
        {
            /// Criamos um objeto Pedido herado da classe InteracaoUsuario
            InteracaoUsuario Pedido = new InteracaoUsuario();
            /// Invocamos os métodos do objeto Pedido herdado da classe mãe InteracaoUsuario
            Pedido.SolicitarDigitacao();
            Pedido.MostrarDigitacao();
            // Recupero pleo método GET o valor da mensagem digitada para futura manipulação
            var Digitado = Pedido.Mensagem;
            // Escrevo  nova mensagem colocando toda a mensagem em Maiúscula
            WriteLine("Nova Digitação sem Espaços -> " + Digitado.ToUpper());     
        }
    }
    /// Criamos a Classe InteracaoUsuario com dois metodos principais
    /// Método que solicita a digitação de algo no terminal 
    /// Método que mostra o que foi digitado
    class InteracaoUsuario
    {
        private string _MensagemDigitada;
        public string Mensagem
        {
            get
            {
                return _MensagemDigitada;
            }
            set
            {
                _MensagemDigitada = value;
            }
        }
        public void SolicitarDigitacao()
        {
             _MensagemDigitada = ReadLine();
        }
        public void MostrarDigitacao()
        {
            WriteLine(_MensagemDigitada);
        }
    }
}
```

Agora vamos melhorar o projeto transformando a classe em uma arquivo CS, em uma classe que pode não apenas ser usada no programa, mas em outros programas que necessitem da classe InteracaoUsuario. Criamos uma subpasta chamada OlaMundo_GetSet_ Classe e dentro dela criamos o arquivo  Classe_Interacao.cs:

```csharp
using static System.Console;
using System;
using System.Linq;

namespace MinhaClasseUsuario
{
    class InteracaoUsuario
    {
        private string _MensagemDigitada;
        public string Mensagem
        {
            get
            {
                return _MensagemDigitada;
            }
            set
            {
                _MensagemDigitada = value;
            }
        }
        public void SolicitarDigitacao()
        {
            _MensagemDigitada = ReadLine();
        }
        public void MostrarDigitacao()
        {
            WriteLine(_MensagemDigitada);
        }
    }
}

```

Em seguida, na mesma subpasta, criamos o arquivo Program.cs e incluímos o using MinhaClasseUsuario , que é o namespace da classe anterior (InteracaoUsuario), afinal ela será referenciada neste código. É importante usar um namespace de fácil assimilação, facilitando o entendimento do programa. Neste caso, o namespace desta classe é Livrocsharp, o qual referencia no using MinhaClasseUsuario a classe a ser usada neste código.

```csharp
using System;
using MinhaClasseUsuario;

namespace Livrocsharp
{
    class PrograPrincipal
    {
        static void Main(string[] args)
        {
            /// Criamos um objeto Pedido herado da classe InteracaoUsuario
            InteracaoUsuario Pedido = new InteracaoUsuario();
            /// Invocamos os métodos do objeto Pedido herdado da classe mãe InteracaoUsuario
            Pedido.SolicitarDigitacao();
            Pedido.MostrarDigitacao();
            // Recupero pleo método GET o valor da mensagem digitada para futura manipulação
            var Digitado = Pedido.Mensagem;
            // Escrevo  nova mensagem colocando toda a mensagem em Maiúscula
            Console.WriteLine("Nova Digitação sem Espaços -> " + Digitado.ToUpper());
        }
    }
}
```

Até aqui conseguimos entender os conceitos básicos da classe e por sua vez a criação de objetos herdados de uma classe mãe que permitirá derivar, organizar, garantir aceso, proteger, estender e reutilizar o código fonte em diversas situações. Mas vamos agora com C# colocar em prática os quatro principais pilares da orientação a objetos que comentamos no começo do capítulo.

Antes disso, vamos entender o que são os construtores de uma classe, sem dúvida, utilíssimo em uma programação orientada a objeto. Até o momento não usamos construtores, isso já é uma evidência de que seu uso não é mandatório nem obrigatório em uma classe. Mas ainda assim vamos estudar seu conceito, sua utilidade e como podemos criar um construtor em C#. Aqui vamos dar início ao principal projeto em C# que irá nortear os principais pilares da orientação a objetos até o final deste modulo.

Existem vários artigos sobre orientação a objetos, e muitos deles usam carros e seus modelos para explicar OOP, outros usam pessoas e animais para explicar classe e modelo. Neste código vamos usar um controle de livros em uma biblioteca. Criaremos uma classe que ajudará a controlar nossa biblioteca, nossos livros. No final, veremos particularidades inseridas no C# que também faz parte da OOP e que podem ser muito úteis no dia a dia.

Para o próximo passo criamos uma pasta chamada Biblioteca e dentro dela criamos uma subpasta Biblioteca_V1. Dentro de Biblioteca_V1 criamos o arquivo LibraryClass.cs:
```csharp
namespace LibraryClass
{
    //Principal classe de controle de livros na Biblioteca
    public class Biblioteca
    {
        private string _Titulo; //Recebe o titulo do livro
        private string _Autor; //Recebe o nome do autor do livro
        private int _Paginas; //Recebe o número de paginas que o livro contem
        private bool _Status; //Recebe saindo (False) ou entrando (TRUE) na biblioteca

        public Biblioteca() //Contrutor sem parametros
        {
           
        }
        //Contrutor com parametros
        public Biblioteca(string Titulo, string Autor, int Paginas, bool Status)
        {
            _Titulo = Titulo;
            _Autor = Autor;
            _Paginas = Paginas;
            _Status = Status;
        }
        public string Titulo //Metodo para acesso a propriedade Titulo da calsse
        {
            get { return _Titulo;}
            set {_Titulo = value;}
        }
        public string Autor
        {
            get { return _Autor; }
            set { _Autor = value; }
        }
        public int Paginas
        {
            get { return _Paginas; }
            set { _Paginas = value; }
        }
        public bool Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
    }
}
```

Neste código não aplicamos construtor, na verdade todas as vezes precisaremos de um objeto do tipo Biblioteca, teremos que chamar as propriedades GET e SET que são chamadas quando designamos um valor para essas propriedades ou quando solicitamos seu valor atual.

Vamos criar o construtor da Biblioteca usando outro pilar conhecido em orientação a objetos Sobrecarga ou em inglês, overloading. Este pilar permite ter dois métodos dentro de uma classe com o mesmo nome, porém com diferentes parâmetros, o que terão diferentes resultados.

Em seguida, vamos adicionar o arquivo Program.cs para referenciar a classe Biblioteca e iremos por o using LibraryClass declarado para termos acesso á classe Biblioteca:

```csharp
using System;
using LibraryClass;

namespace Biblioteca_V1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicializando a classe com o construtor nulo
            Biblioteca MinhaBiblioteca = new Biblioteca();
            //Por isso a necessidade de setar o valor de cada propriedade
            MinhaBiblioteca.Autor = "Des Dearlove";
            MinhaBiblioteca.Titulo = "O Estilo Bill Gates de Gerir";
            MinhaBiblioteca.Paginas = 203;
            MinhaBiblioteca.Status = true;
            //Imprimindo os valores da classe
            Console.WriteLine("Autor: " + MinhaBiblioteca.Autor);
            Console.WriteLine("Titulo: " + MinhaBiblioteca.Titulo);
            Console.WriteLine("Paginas: " + MinhaBiblioteca.Paginas);
            Console.WriteLine("Status: " + MinhaBiblioteca.Status);
            //Inicializando a classe com o novo construtor
            Biblioteca MeusLivros = new Biblioteca("Linguagem C", "Jua Garcia Sola", 296, true);
            Console.WriteLine();
            Console.WriteLine("Autor: " + MeusLivros.Autor);
            Console.WriteLine("Titulo: " + MeusLivros.Titulo);
            Console.WriteLine("Paginas: " + MeusLivros.Paginas);
            Console.WriteLine("Status: " + MeusLivros.Status);
        }
    }
}
```

A classe Biblioteca já possui um construtor da classe porém não declarado, afinal de contas se este construtor não existisse não conseguiríamos criar o objeto MinhaBiblioteca. Quando chamamos o código **Biblioteca MinhaBiblioteca =  new Biblioteca();** estamos chamando o construtor desta classe e criando um objeto baseado na classe Biblioteca em que a construção desta classe não tem parâmetros. Por isso apenas com a chamada **new Biblioteca()** invocamos implicitamente o construtor da classe e assim um novo objeto é criado sem dados, sem autor, sem título, sem nada, uma classe vazia . O objetivo de declarar explicitamente o construtor será útil para no momento de invocarmos a criação de um objeto, já indicarmos quais serão os valores das propriedades deste objeto sem a necessidade de chamar o código a seguir:

```csharp
            MinhaBiblioteca.Autor = "Des Dearlove";
            MinhaBiblioteca.Titulo = "O Estilo Bill Gates de Gerir";
            MinhaBiblioteca.Paginas = 203;
            MinhaBiblioteca.Status = true;
```

E como a classe contém dois construtores, temos duas maneiras de inicializar a classe, prova disso é que no Program.cs aparece a sobrecarga de um método. Ao invocar o new temos duas maneiras de inicializarmos a classe, com parâmetros e sem parâmetros, conforme a figura a seguir:
![[Pasted image 20250827162457.png]]

O código do construtor com parâmetros não há necessidade de "setar" as propriedades porque elas já são configuradas em tempo de execução do programa, no momento da chamada no construtor.
```csharp
Biblioteca MeusLivros = new Biblioteca("Linguagem C", "Jua Garcia Sola", 296, true);
```

Entendemos sobre Classe, método, propriedade, construtor, sobrecarga. Conceitos importantes para entendermos e programarmos corretamente em C#, já que é uma linguagem nativamente orientada a objetos. Seguindo em frente, iremos aplicar herança que é um dos atributos fundamentais da programação orientada a objeto. Ela permite que definamos uma classe filha que reutiliza (herda), estende ou modifica o comportamento de uma classe pai. A classe cujos membros são herdados é chamada de classe base. A classe que herda os membros da classe base é chamada de classe derivada.

Agora dentro da pasta Biblioteca, criaremos outra subpasta Biblioteca_V2 e dentro dela o arquivo LibraryClass.cs. Vamos criar uma classe herdada da classe principal Biblioteca. Até aqui a classe Biblioteca está controlando os livros de uma biblioteca. Porém, agora a biblioteca recebe também revistas e precisamos ter o controle do mês e ano da revista, já que geralmente as revistas são mensais. Aqui temos duas novas propriedades (mês e ano) que não faz sentido serem incluídas na classe base. Mas, por outro lado as revistas possuem todas as propriedades do livro (autor, páginas, etc) e necessitam que sejam adicionados o mês e o ano. Resolveremos isso com herança.

No arquivo LibraryClass.cs iremos criar uma nova classe chamada Revista que é herdada da classe Biblioteca, o qual possui todos os métodos que a revista também necessita. Para que a herança aconteça utilizamos o modificador ":" (dois pontos), sendo:

```csharp
public class Revistas : Biblioteca
```

Com esta declaração criamos a classe para controlar as revistas, herdando todas as características que possuem a classe mãe, sem que tenhamos que reescrever novamente as propriedades e métodos, pois herdamos todos eles na classe derivada para controlar as revistas. 

```csharp
//namespace que irá conter a classe de controle de livros e seus metodos
namespace LibraryClass_V2
{
    //nova classe para controlar as revistas
    public class Revistas : Biblioteca
    {
        //Propriedades da Classe
        private int _MesPublicacao;
        private int _AnoPublicacao;
        //Construtor da classe
        public Revistas(int MesPublicacao, int AnoPublicacao)
        {
            _MesPublicacao = MesPublicacao;
            _AnoPublicacao = AnoPublicacao;
        }
        public int MesPublicacao
        {
            get { return _MesPublicacao; }
            set { _MesPublicacao = value; }
        }
        public int AnoPublicacao
        {
            get { return _AnoPublicacao; }
            set { _AnoPublicacao = value; }
        }
    }
    //Principal classe de controle de livros na Biblioteca
    public class Biblioteca
    {
        private string _Titulo; //Recebe o titulo do livro
        private string _Autor; //Recebe o nome do autor do livro
        private int _Paginas; //Recebe o número de paginas que o livro contem
        private bool _Status; //Recebe saindo (False) ou entrando (TRUE) na biblioteca

        public Biblioteca() //Contrutor sem parametros
        {
           
        }
        //Contrutor com parametros
        public Biblioteca(string Titulo, string Autor, int Paginas, bool Status)
        {
            _Titulo = Titulo;
            _Autor = Autor;
            _Paginas = Paginas;
            _Status = Status;
        }
        public string Titulo //Metodo para acesso a propriedade Titulo da calsse
        {
            get { return _Titulo;}
            set {_Titulo = value;}
        }
        public string Autor
        {
            get { return _Autor; }
            set { _Autor = value; }
        }
        public int Paginas
        {
            get { return _Paginas; }
            set { _Paginas = value; }
        }
        public bool Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
    }
}
```

Agora iremos criar o Program.cs que irá referenciar e consumir a classe Revista. Na chamada do construtor da classe Revista são passados os parâmetros mês e ano. Em seguida são inicializadas as outras propriedades que também são importantes para o objeto Revista herdado de Biblioteca.

```csharp
using System;
using static System.Console;
using LibraryClass_V2;

namespace Biblioteca_V1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Incializando nossa nova classe com herança
            Revistas MinhasRevistas = new Revistas(3, 2021);
            //Inicializando as outras propriedades da calsse que foram herdadas
            MinhasRevistas.Autor = "Microsoft";
            MinhasRevistas.Titulo = "MSDN Magazine";
            MinhasRevistas.Paginas = 20;
            MinhasRevistas.Status = true;
            //Imprimindo os valores da minha classe
            WriteLine("Revista Mes: " + MinhasRevistas.MesPublicacao);
            WriteLine("Revista Ano: " + MinhasRevistas.AnoPublicacao);
            WriteLine("Revista Autor: " + MinhasRevistas.Autor);
            WriteLine("Revista Titulo: " + MinhasRevistas.Titulo);
            WriteLine("Revista Páginas: " + MinhasRevistas.Paginas);
            WriteLine("Revista Status: " + MinhasRevistas.Status);
            Console.WriteLine();
            // Inicializando a classe com o construtor nulo
            Biblioteca MinhaBiblioteca = new Biblioteca();
            //Por isso a necessidade de setar o valor de cada propriedade
            MinhaBiblioteca.Autor = "Des Dearlove";
            MinhaBiblioteca.Titulo = "O Estilo Bill Gates de Gerir";
            MinhaBiblioteca.Paginas = 203;
            MinhaBiblioteca.Status = true;
            //Imprimindo os valores da classe
            Console.WriteLine("Autor: " + MinhaBiblioteca.Autor);
            Console.WriteLine("Titulo: " + MinhaBiblioteca.Titulo);
            Console.WriteLine("Paginas: " + MinhaBiblioteca.Paginas);
            Console.WriteLine("Status: " + MinhaBiblioteca.Status);
            //Inicializando a classe com o novo construtor
            Biblioteca MeusLivros = new Biblioteca("Linguagem C",
                "Jua Garcia Sola", 296, true);
            Console.WriteLine();
            Console.WriteLine("Autor: " + MeusLivros.Autor);
            Console.WriteLine("Titulo: " + MeusLivros.Titulo);
            Console.WriteLine("Paginas: " + MeusLivros.Paginas);
            Console.WriteLine("Status: " + MeusLivros.Status);
        }
    }
}
```

```
Resultado:
Revista Mes: 3
Revista Ano: 2021
Revista Autor: Microsoft
Revista Titulo: MSDN Magazine
Revista Páginas: 20
Revista Status: True

Autor: Des Dearlove
Titulo: O Estilo Bill Gates de Gerir
Paginas: 203
Status: True

Autor: Jua Garcia Sola
Titulo: Linguagem C
Paginas: 296
Status: True
```

Vamos abordar agora o polimorfismo, outro pilar da orientação a objetos  e que nos ajudará a codificar melhor, mais rápido e reutilizando código. O principal conceito do polimorfismo é a propriedade de duas ou mais classes derivadas de uma super classe responderem a mesma mensagem cada uma de uma forma diferente, mas utilizam o mesmo método que outrora foi sobrescrito.

Vamos ver isso na prática, vamos complicar um pouco mais nosso controle de biblioteca. Agora, além de controlar livros e revistas precisamos controlar Fotos, como agravante que o jornal tem todas as características de um livro possui (Autor, Título, etc), porém um novo campo que chamaremos de Tipo, o qual armazenará o valor Colorido ou Preto ou Branco.

Já aprendemos neste modulo como resolver isso, basta criarmos a classe Fotos herdada da classe Revistas, assim teremos todas as propriedades á disposição para trabalhar sem precisar rescrever. Vamos fazer isso antes de aplicarmos o polimorfismo.

```csharp
//namespace que irá conter a classe de controle de livros e seus metodos
namespace LibraryClass_V2
{
    //Classe para controlar as fotos
    public class Fotos : Revistas
    {
        //Propriedades da Classe
        private string _Tipo;
        //Neste construtor preciso referenciar a classe base
        //Revistas é uma classe já herdada de Biblioteca
        public Fotos(string Tipo) : base(0, 0)
        {
            _Tipo = Tipo;
        }
        public string Tipo //Metodo para acesso a prpriedade da classe
        {
            get { return _Tipo; }
            set { _Tipo = value; }
        }
    }
    //nova classe para controlar as revistas
    public class Revistas : Biblioteca
    {
        //Propriedades da Classe
        private int _MesPublicacao;
        private int _AnoPublicacao;
        //Construtor da classe
        public Revistas(int MesPublicacao, int AnoPublicacao)
        {
            _MesPublicacao = MesPublicacao;
            _AnoPublicacao = AnoPublicacao;
        }
        public int MesPublicacao
        {
            get { return _MesPublicacao; }
            set { _MesPublicacao = value; }
        }
        public int AnoPublicacao
        {
            get { return _AnoPublicacao; }
            set { _AnoPublicacao = value; }
        }
    }
    //Principal classe de controle de livros na Biblioteca
    public class Biblioteca
    {
        private string _Titulo; //Recebe o titulo do livro
        private string _Autor; //Recebe o nome do autor do livro
        private int _Paginas; //Recebe o número de paginas que o livro contem
        private bool _Status; //Recebe saindo (False) ou entrando (TRUE) na biblioteca

        public Biblioteca() //Contrutor sem parametros
        {
           
        }
        //Contrutor com parametros
        public Biblioteca(string Titulo, string Autor, int Paginas, bool Status)
        {
            _Titulo = Titulo;
            _Autor = Autor;
            _Paginas = Paginas;
            _Status = Status;
        }
        public string Titulo //Metodo para acesso a propriedade Titulo da calsse
        {
            get { return _Titulo;}
            set {_Titulo = value;}
        }
        public string Autor
        {
            get { return _Autor; }
            set { _Autor = value; }
        }
        public int Paginas
        {
            get { return _Paginas; }
            set { _Paginas = value; }
        }
        public bool Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
    }
}
```

Para consumir a classe Fotos, no Program.cs criaremos o objeto MinhasFotos derivada da classe Fotos e designaremos valores para suas propriedades. A classe MinhasFotos possui todas as propriedades e métodos que foram herdados da classe Revistas que por sua vez herdou da classe Biblioteca: 

```csharp
using System;
using static System.Console;
using LibraryClass_V2;

namespace Biblioteca_V1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicializando nossa nova classe Fotos
            Fotos MinhasFotos = new Fotos("Colorida");
            MinhasFotos.AnoPublicacao = 2021;
            MinhasFotos.MesPublicacao = 3;
            MinhasFotos.Autor = "Desconhecido";
            MinhasFotos.Titulo = "Vida Eterna";
            MinhasFotos.Paginas = 1;
            MinhasFotos.Status = true;
            //Imprimindo os valores da minha classe
            WriteLine("Foto Tipo: " + MinhasFotos.Tipo);
            WriteLine("Foto Mes: " + MinhasFotos.MesPublicacao);
            WriteLine("Foto Ano: " + MinhasFotos.AnoPublicacao);
            WriteLine("Foto Autor: " + MinhasFotos.Autor);
            WriteLine("Foto Titulo: " + MinhasFotos.Titulo);
            WriteLine("Foto Páginas: " + MinhasFotos.Paginas);
            WriteLine("Foto Status: " + MinhasFotos.Status);
            Console.WriteLine();
            //Incializando nossa nova classe com herança
            Revistas MinhasRevistas = new Revistas(3, 2021);
            //Inicializando as outras propriedades da calsse que foram herdadas
            MinhasRevistas.Autor = "Microsoft";
            MinhasRevistas.Titulo = "MSDN Magazine";
            MinhasRevistas.Paginas = 20;
            MinhasRevistas.Status = true;
            //Imprimindo os valores da minha classe
            WriteLine("Revista Mes: " + MinhasRevistas.MesPublicacao);
            WriteLine("Revista Ano: " + MinhasRevistas.AnoPublicacao);
            WriteLine("Revista Autor: " + MinhasRevistas.Autor);
            WriteLine("Revista Titulo: " + MinhasRevistas.Titulo);
            WriteLine("Revista Páginas: " + MinhasRevistas.Paginas);
            WriteLine("Revista Status: " + MinhasRevistas.Status);
            Console.WriteLine();
            // Inicializando a classe com o construtor nulo
            Biblioteca MinhaBiblioteca = new Biblioteca();
            //Por isso a necessidade de setar o valor de cada propriedade
            MinhaBiblioteca.Autor = "Des Dearlove";
            MinhaBiblioteca.Titulo = "O Estilo Bill Gates de Gerir";
            MinhaBiblioteca.Paginas = 203;
            MinhaBiblioteca.Status = true;
            //Imprimindo os valores da classe
            Console.WriteLine("Autor: " + MinhaBiblioteca.Autor);
            Console.WriteLine("Titulo: " + MinhaBiblioteca.Titulo);
            Console.WriteLine("Paginas: " + MinhaBiblioteca.Paginas);
            Console.WriteLine("Status: " + MinhaBiblioteca.Status);
            //Inicializando a classe com o novo construtor
            Biblioteca MeusLivros = new Biblioteca("Linguagem C","Jua Garcia Sola", 296, true);
            Console.WriteLine();
            Console.WriteLine("Autor: " + MeusLivros.Autor);
            Console.WriteLine("Titulo: " + MeusLivros.Titulo);
            Console.WriteLine("Paginas: " + MeusLivros.Paginas);
            Console.WriteLine("Status: " + MeusLivros.Status);
        }
    }
}
```

```
Resultado:
Foto Tipo: Colorida
Foto Mes: 3
Foto Ano: 2021
Foto Autor: Desconhecido
Foto Titulo: Vida Eterna
Foto Páginas: 1
Foto Status: True

Revista Mes: 3
Revista Ano: 2021
Revista Autor: Microsoft
Revista Titulo: MSDN Magazine
Revista Páginas: 20
Revista Status: True

Autor: Des Dearlove
Titulo: O Estilo Bill Gates de Gerir
Paginas: 203
Status: True

Autor: Jua Garcia Sola
Titulo: Linguagem C
Paginas: 296
Status: True
```

Agora entra a utilidade do polimorfismo, ou seja, a classe obtém múltiplas formas e múltiplos comportamentos. Vamos agora, dentro do nosso exercício proposto, criar um método de descarte do Livro, da revista e da Foto. Todos terão o mesmo objetivo de descartar, porém para cada um o descarte é realizado de maneira diferente, o jornal é reciclado, o livro é doado e a foto é destruída. Para solucionar este problema podemos criar um método base na classe base chamado Descarte e designar diferentes comportamentos nas classes derivadas.

Veja os métodos Descarte nas classes Biblioteca, Revistas e Fotos. Note que a propriedade Titulo de cada classe tem um texto diferente. Nas classes derivadas Revistas e Fotos, a declaração da propriedade Titulo, usamos o this, o qual indica que é desta classe.

```csharp
//namespace que irá conter a classe de controle de livros e seus metodos
namespace LibraryClass_V2
{
    //Classe para controlar as fotos
    public class Fotos : Revistas
    {
        //Propriedades da Classe
        private string _Tipo;
        //Neste construtor preciso referenciar a classe base
        //Revistas é uma classe já herdada de Biblioteca
        public Fotos(string Tipo) : base(0, 0)
        {
            _Tipo = Tipo;
        }
        public string Tipo //Metodo para acesso a prpriedade da classe
        {
            get { return _Tipo; }
            set { _Tipo = value; }
        }
        public override void Descarte()
        {
            this.Titulo = "A foto doi Destruída";
        }
    }
    //nova classe para controlar as revistas
    public class Revistas : Biblioteca
    {
        //Propriedades da Classe
        private int _MesPublicacao;
        private int _AnoPublicacao;
        //Construtor da classe
        public Revistas(int MesPublicacao, int AnoPublicacao)
        {
            _MesPublicacao = MesPublicacao;
            _AnoPublicacao = AnoPublicacao;
        }
        public int MesPublicacao
        {
            get { return _MesPublicacao; }
            set { _MesPublicacao = value; }
        }
        public int AnoPublicacao
        {
            get { return _AnoPublicacao; }
            set { _AnoPublicacao = value; }
        }
        public override void Descarte()
        {
            this.Titulo = "A revista foi Reciclada";
        }
    }
    //Principal classe de controle de livros na Biblioteca
    public class Biblioteca
    {
        private string _Titulo; //Recebe o titulo do livro
        private string _Autor; //Recebe o nome do autor do livro
        private int _Paginas; //Recebe o número de paginas que o livro contem
        private bool _Status; //Recebe saindo (False) ou entrando (TRUE) na biblioteca

        public Biblioteca() //Contrutor sem parametros
        {
           
        }
        //Contrutor com parametros
        public Biblioteca(string Titulo, string Autor, int Paginas, bool Status)
        {
            _Titulo = Titulo;
            _Autor = Autor;
            _Paginas = Paginas;
            _Status = Status;
        }
        public string Titulo //Metodo para acesso a propriedade Titulo da calsse
        {
            get { return _Titulo;}
            set {_Titulo = value;}
        }
        public string Autor
        {
            get { return _Autor; }
            set { _Autor = value; }
        }
        public int Paginas
        {
            get { return _Paginas; }
            set { _Paginas = value; }
        }
        public bool Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        //Método de Descarte
        public virtual void Descarte()
        {
            _Titulo = "O livro foi Doado";
        }
    }
}
```

No Program.cs, adicionaremos este bloco de código no final, assim teremos os objetos de foto, jornal e o livro na biblioteca com os respectivos descartes.

```csharp
using System;
using static System.Console;
using LibraryClass_V2;

namespace Biblioteca_V1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicializando nossa nova classe Fotos
            Fotos MinhasFotos = new Fotos("Colorida");
            MinhasFotos.AnoPublicacao = 2021;
            MinhasFotos.MesPublicacao = 3;
            MinhasFotos.Autor = "Desconhecido";
            MinhasFotos.Titulo = "Vida Eterna";
            MinhasFotos.Paginas = 1;
            MinhasFotos.Status = true;
            //Imprimindo os valores da minha classe
            WriteLine("Foto Tipo: " + MinhasFotos.Tipo);
            WriteLine("Foto Mes: " + MinhasFotos.MesPublicacao);
            WriteLine("Foto Ano: " + MinhasFotos.AnoPublicacao);
            WriteLine("Foto Autor: " + MinhasFotos.Autor);
            WriteLine("Foto Titulo: " + MinhasFotos.Titulo);
            WriteLine("Foto Páginas: " + MinhasFotos.Paginas);
            WriteLine("Foto Status: " + MinhasFotos.Status);
            Console.WriteLine();
            //Incializando nossa nova classe com herança
            Revistas MinhasRevistas = new Revistas(3, 2021);
            //Inicializando as outras propriedades da calsse que foram herdadas
            MinhasRevistas.Autor = "Microsoft";
            MinhasRevistas.Titulo = "MSDN Magazine";
            MinhasRevistas.Paginas = 20;
            MinhasRevistas.Status = true;
            //Imprimindo os valores da minha classe
            WriteLine("Revista Mes: " + MinhasRevistas.MesPublicacao);
            WriteLine("Revista Ano: " + MinhasRevistas.AnoPublicacao);
            WriteLine("Revista Autor: " + MinhasRevistas.Autor);
            WriteLine("Revista Titulo: " + MinhasRevistas.Titulo);
            WriteLine("Revista Páginas: " + MinhasRevistas.Paginas);
            WriteLine("Revista Status: " + MinhasRevistas.Status);
            Console.WriteLine();
            // Inicializando a classe com o construtor nulo
            Biblioteca MinhaBiblioteca = new Biblioteca();
            //Por isso a necessidade de setar o valor de cada propriedade
            MinhaBiblioteca.Autor = "Des Dearlove";
            MinhaBiblioteca.Titulo = "O Estilo Bill Gates de Gerir";
            MinhaBiblioteca.Paginas = 203;
            MinhaBiblioteca.Status = true;
            //Imprimindo os valores da classe
            Console.WriteLine("Autor: " + MinhaBiblioteca.Autor);
            Console.WriteLine("Titulo: " + MinhaBiblioteca.Titulo);
            Console.WriteLine("Paginas: " + MinhaBiblioteca.Paginas);
            Console.WriteLine("Status: " + MinhaBiblioteca.Status);
            //Inicializando a classe com o novo construtor
            Biblioteca MeusLivros = new Biblioteca("Linguagem C",
                "Jua Garcia Sola", 296, true);
            Console.WriteLine();
            Console.WriteLine("Autor: " + MeusLivros.Autor);
            Console.WriteLine("Titulo: " + MeusLivros.Titulo);
            Console.WriteLine("Paginas: " + MeusLivros.Paginas);
            Console.WriteLine("Status: " + MeusLivros.Status);
            Console.WriteLine();
            //Mesmo método com comportamentos diferentes
            MeusLivros.Descarte();
            WriteLine("Titulo: " + MeusLivros.Titulo);
            MinhasRevistas.Descarte();
            WriteLine("Titulo: " + MinhasRevistas.Titulo);
            MinhasFotos.Descarte();
            WriteLine("Titulo: " + MinhasFotos.Titulo);
        }
    }
}
```

```
Resultado:
Foto Tipo: Colorida
Foto Mes: 3
Foto Ano: 2021
Foto Autor: Desconhecido
Foto Titulo: Vida Eterna
Foto Páginas: 1
Foto Status: True

Revista Mes: 3
Revista Ano: 2021
Revista Autor: Microsoft
Revista Titulo: MSDN Magazine
Revista Páginas: 20
Revista Status: True

Autor: Des Dearlove
Titulo: O Estilo Bill Gates de Gerir
Paginas: 203
Status: True

Autor: Jua Garcia Sola
Titulo: Linguagem C
Paginas: 296
Status: True

Titulo: O livro foi Doado
Titulo: A revista foi Reciclada
Titulo: A foto doi Destruída
```




---



 
