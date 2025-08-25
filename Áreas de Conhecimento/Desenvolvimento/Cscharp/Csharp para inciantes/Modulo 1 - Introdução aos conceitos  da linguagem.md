
---
*📅 **created: 20-08-2025 / 14:29**
🏷️ **tags: []**
**⌛ status: draft**
## 📋 Resumo

> Introdução a conceitos básicos da linguagem C# mostrando fundamentos não apenas de suas funções mas também as melhores práticas de gerenciamento de um projeto de software.
## 📚  [[CSharpIniciantes.pdf#page=31&annotation=1488R|Conceitos Básicos da Linguagem C#]]


### Namespaces

Os namespaces são usado no C# para organizar e prover um nível de separação de código fonte. Podemos considerá-lo como um "container" que consiste de outros namespaces, classes, etc. Normalmente um namespace pode conter os seguintes membros:
- Classes
- Interfaces
- Estruturas
- Delegates
Os namespaces ajuda a organizar diferentes tipos de membros que estão relacionados no mesmo lugar. Uma ou mais classe podem conter o mesmo nome, porém devem estar em namespaces diferentes. Se criarmos duas classes com o mesmo nome dentro do mesmo projeto, por exemplo, teremos um erro de compilação pois teremos um conflito de nomeação. 

```csharp
namespace ProgramPrincipal{
	public class ClasseUm
	{
		public int Id {get; set;}
		public string nome {get; set;}		
	}
	public class ClasseUm
	{	
		public int Id {get; set;}
		public string nome {get; set;}			
	}
}
```

No código acima temos duas classes com o nome de "ClasseUm". Isso não é permitido na estrutura da linguagem e o compilador vai exibir um erro informando que já existe uma classe com o mesmo nome. Assim que alterarmos o nome da classe o compilador entenderá que não temos mais conflitos dentro do mesmo namespace.
### Acessando os membros de um namespace

Os membros de um namespace podem ser acessados através de um operador de ponto (.). A sintaxe para acessar o membro dentro do namespace é o **NomeDoNameSpace.NomeDoMembro**. Por exemplo, se um classe chamada **ClasseUm** e queremos acessá-la, podemos fazer da seguinte da maneira:

```csharp
namespace MyProgram
{
	public class ClasseUm
	{
		public static Void Main()
		{
			ProgramPrincipal.ClasseDois ClasseDois = new ProgramPrinciapal.ClasseDois();
		}
	}
}
```

O namespace **MyProgram** não tem visibilidade do namespace ProgramaPrincipal, dessa forma, podemos indicar no programa qual é a localidade dele.
Apesar Dessa forma funcionar, existe uma forma mais amigável e prática de obtermos a visibilidade do outro namespace e, para isso podemos usar a palavra chave **using**

```csharp
using ProgramPrincipal;

namespace MyProgram
{
	public class ClasseUm
	{
		public static Void Main()
		{
			ClasseDois ClasseDois = new ClasseDois();
		}
	}
}
```

Removemos o nome do namespace antes da classe **ClasseDois** e adicionamos no topo do programa a palavra chave **using**, indicando onde ir buscar a referência do objeto. Não existe um padrão ou melhor forme de utilizar, ambos funcionam, porém, é muito comum ver no mercado a utilização do using no topo do programa.

A principal funcionalidade do namespace é organizar o projeto. A medida que ele vai ficando maior e com mais arquivos é importante que saibamos como segregar o projeto visando sobre a responsabilidade de cada componente e determinando suas ações de forma isolada.

Uma boa prática é criar a estrutura do projeto seguindo a seguinte sintaxe:

$$NomeDaEmpresa.NomeDoProjeto.CamadaDoProjeto.Funcionalida$$
Exemplo:
$$Microsoft.LivroCShharp.CamadaDeDados.ConcectorSqlServer$$
### Classes

A classe é uma abstração do mundo real da programação. Ela vai modelar no sistema quais atores ou processos existirão e como eles se comportam. Esses atores possuem características comuns tais como nome, idade certamente um número de CPF, dessa forma, a classe também precisará refletir essas propriedades.

Criaremos uma classe chamada **Gerente.cs** e colocaremos o seguinte código:

```csharp
namespace SistemaBancario 
{
	public class Gerente 
	{
		public string Nome {get; set;}
		public int Idade {get; set;}
		public int Cpf {get; set;}
	}
}
```

Identificamos quais atributos o gerente possui e são relevantes para o sistema e quais propriedades criaríamos na classe para que fosse utilizado em nosso sistema.
  
 ![[Pasted image 20250820173618.jpeg | center]]
 
No momento temos apenas as propriedades da classe que podem ser utilizadas em nosso sistema e nada mais, Porém, no papel esse ator certamente efetua tarefas no seu dia a dia tais como aprovar horas de funcionários, criar novas contas de clientes e diversas outras atividades.

Essas atividades são refletidas em nossa classe através de **métodos**. Os métodos representam computacionalmente uma ação feita pelo ator na vida real. Dessa forma, vamos alterar um pouco nosso código e incluir um método que vai possibilitar o gerente aprovar as horas de um funcionário informando o cpf do funcionário.

```csharp
namespace SistemaBancario 
{
	public class Gerente 
	{
		public string Nome {get; set;}
		public int Idade {get; set;}
		public int Cpf {get; set;}		
		public void AprovarHorasDeFuncionarios(int cpf)
		{
			//Lógica para aprovar horas
		}
	}
}
```

A estrutura desse código representa uma classe no C#, uma representação do mundo real descrita através de um código fonte onde o computador possa entender e executar tarefas de forma automatizada. Esse processo feito até agora representa a modelagem de domínio do negócio e normalmente em um projeto real é feito junto com especialistas que entendem do negócio em questão.

Idealmente é uma boa prática explorar os especialistas de negócio, criar fluxos e mapeamentos do trabalho que é executado no ambiente que necessita de um sistema e posteriormente modelar o sistema. 

### Objetos

As classes têm propriedades e métodos, porém não sabemos como o computador ou compilador da linguagem vai entender e processar essas informações. É aqui que os objetos têm um papel fundamental.

O objeto nada mais é que a compilação deste código escrito por nós sendo colocado na memória do computador para que ele seja interpretado e executado.

Esse processo de criar o objeto e colocá-lo na memória é denominado instanciamento de classe. Para isso, basta criar um código similar ao demonstrado abaixo:

```csharp
namespace SistemaBancario
{
	public class InstanciaObjeto
	{
		public static void Main()
		{
			var objetoGerente = new Gerente();
		}
	}
}
```
 
A utilização da palavra reservada **new** no C# é responsável por analisar o código feito na classe, e então, disponibilizar na memória do computador para utilização

Durante o desenvolvimento , após criar a instância da classe, é possível analisar quais atributos e métodos á classe possui apenas colocando um ponto (.) após o nome da variável, conforme a figura abaixo:

![[Pasted image 20250822133845.png]]

### Variáveis

As variáveis são espaços na memória do computador onde podemos salvar, manipular e exibir informações. Vamos analisar novamente o código anterior:

```csharp
{
	public class InstanciaObjeto
	{
		public static void Main()
		{
			var objetoGerente = new Gerente();
		}
	}
}
```

A palavra reservada **var** tem a função de informar o sistema que ali está ocorrendo a criação de uma variável. Nesse exemplo, estamos criando um novo objeto e atribuindo seu valor e estado na variável ObjetoGerente. É possível também criar a variável com o tipo dela implicitamente ao invés de usar a palavra **var**

A variável é meramente um nome dado para um armazenamento de dados que nosso programa vai manipular. Cara variável no C# possui um tipo específico que determina seu tamanho e o quanto de informação ela pode salvar na memória. Os tipos básicos são categorizados em:


| <center>**Tipo**</center> | <center>**Exemplo**</center>                                |
| :------------------------ | :---------------------------------------------------------- |
| Tipos integrais           | sbyte, byte, short, ushort, int, uint, long, ulong and char |
| Tipos de ponto flutuante  | float and double                                            |
| tipos decimais            | decimal                                                     |
| tipos booleanos           | true or false values, as assigned                           |
| Tipos nulos               | Nullable data Types                                         |
Existem outros tipos de variáveis também, como por exemplo **Enums** e tipos por referência como classes. Como definimos variáveis no C# é:

<center>tipo de dados - nome da variavel = valor;</center>

```csharp
namespace SistemaBancario
{
	public class Variaveis
	{
		public static void Main()
		{
			int cpf = 123456789;
			string nome = "Ray Carnero";
			decimal salario = 1000;
			bool funcionarioAtivo = true;
		}
	}
}
```

No código anterior temos alguns exemplos de variáveis e tipos diferentes. Visualizando o nome das variáveis podemos perceber que cada uma delas tem uma finalidade, um tipo e um valor inicial.
Assim que essas variáveis ficam disponíveis na memória é possível acessá-las, exibi-las ou manipulá-las. As variáveis são formas como podemos armazenar as informações durante o fluxo a ser feito dentro do sistema.  


---