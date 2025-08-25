
---
*📅 **created: 22-08-2025 / 14:38**
🏷️ **tags: []**
**⌛ status: draft**
## 📋 Resumo

> O C# contém métodos internos da linguagem para manipular textos, datas, contas com números, etc. Essas funcionalidades existem justamente para que não seja preciso construir uma lógica, ocasionando possibilidade de erros.

## 📚[[CSharpIniciantes.pdf#page=43&selection=0,0,0,35&color=note| Funções Internas do C#]]

### Funções de Textos

As funções de textos são usadas para manipular strings, Para isso precisamos limpar espaços em branco, obter quantidade de caracteres, transformar tudo para maiúscula ou minúscula, trocar o conteúdo, etc. Para os exemplos usaremos o código base abaixo:

```csharp
using System;
using System.Linq;

namespace livrocsharp
{
	class funcoesTexto
	{
		static void Main(string[] args)
		{
			
		}
	}	
}
```

### TRIM

Este é um método que retira todos os espaços em branco antes e depois de uma expressão (Não retira espaços entre expressões). Este método é usado em interações com usuários, em casos onde são digitadas muitas informações. Ou ainda em casos de trazer informações de outra fonte de dados, arquivos de textos, CSV, Excel, dados exportados de bancos de dados, etc.

```csharp
using static System.Console;  // WriteLine
using System;
using System.Linq;

namespace Livrocsharp
{
	class funcoesTexto
	{
		static void Main(string[] args)
		{
			WriteLine("------ Funções de Textos -------”);
			string empresa = " Microsoft Corporation ";
			WriteLine("TRIM - retira os espaços em branco antes e após a expressão ");
			WriteLine($"Nome sem espaços:{empresa.Trim()}");
		}
	}
}
```

Neste caso usamos um texto "Nome sem espaços", seguido, entre chaves, nome da variável **empresa + método TRIM()**. O C# só permite ter um SVM(static void Main) por projeto, devemos abrir o **livrocsharp.csproj** e adicionar a linha do \<StartupObject> contendo o nome do namespace + classe a ser executada, neste caso, **livrocsharp.funcoesTexto**.
![[Pasted image 20250822161113.png]]

Após concluídos os processos de codificações podemos executar, o resultado ficará assim:

```
------ Funções de Textos -------
TRIM - retira os espaços em breanco antes e após a expressão
Nome sem espaços:Microsoft Corporation
```
### Length

O método *Length* conta a quantidade de caracteres da expressão, incluindo os espaços em branco. É muito usado para definir um tamanho limite que caiba num campo ou espaço a ser impresso ou mostrado. Em aplicativos onde a interação com usuário é feita, usamos para checar a quantidade de caracteres digitados, em importação de dados de outras fontes, checamos se o tamanho da expressão está de acordo com o necessário, e caso seja preciso podemos até descartar o restante.

Para teste iremos mostrar a quantidade de caracteres da variável empresa (empresa.Length), antes e após o uso do TRIM, para isso a própria variável empresa será atribuída o comando empresa.Trim() para retirar os espaços em branco, deixando a variável limpa.

```csharp
using static System.Console;  // WriteLine
using System;
using System.Linq;

namespace Livrocsharp
{
	class funcoesTexto
	{
		static void Main(string[] args)
		{
			WriteLine("------ Funções de Textos -------”);
			...
            WriteLine("Length - retorna a qtde de caracteres");
            WriteLine($"Tamanho do texto:{empresa.Length}");
            
            empresa = empresa.Trim();
            WriteLine($"Tamanho do texto após o Trim:{empresa.Length}");
		}
	}
}
```

```
Resultado:
------ Funções de Textos -------
Length - retorna a qtde de caracteres
Tamanho do texto:23
Tamanho do texto após o Trim:21
```
### ToUpper

O método *ToUpper* tem a função de transformar toda a expressão em letras maiúsculas. É usado em casos de formatação, onde precisamos chamar a atenção como nome, cargo, informações críticas, etc. O uso é simples, basta informar a cadeia de caracteres ou variável, seguido do método *ToUpper()*.

```csharp
using static System.Console;  // WriteLine
using System;
using System.Linq;

namespace Livrocsharp
{
	class funcoesTexto
	{
		static void Main(string[] args)
		{
			WriteLine("------ Funções de Textos -------”);
			...
            WriteLine("ToUpper - converte todos os carecteres para maiúsculo");
            WriteLine($"Converte para Maisuculo: {empresa.ToUpper()}");            
		}
	}
}
```

```
Resultado:
------ Funções de Textos -------
ToUpper - converte todos os carecteres para maiúsculo
Converte para Maisuculo: MICROSOFT CORPORATION
```
### ToLower

O método *ToLower* faz o contrário do ToUpper, transforma toda a expressão em letras minúsculas, Se aplica também á expressões de caracteres ou variáveis. 
```csharp
using static System.Console;  // WriteLine
using System;
using System.Linq;

namespace Livrocsharp
{
	class funcoesTexto
	{
		static void Main(string[] args)
		{
			WriteLine("------ Funções de Textos -------”);      
            ...
            WriteLine("ToLower - converte todos os carecteres para minúsculo");
            WriteLine($"Converte para Minúsculo: {empresa.ToLower()}");            
		}
	}
}
```

```
Resultado:
------ Funções de Textos -------
ToLower - converte todos os carecteres para minúsculo
Converte para Minúsculo: microsoft corporation

```

É importante ressaltar que aos olhos da linguagem, comprar expressões  com conteúdos iguais nem sempre o resultado é o esperado, por exemplo, no código a seguir qual será o resultado da comparação das variáveis nomeUpper e nomeLower?


```csharp
using static System.Console;
using System;
using System.Linq;

namespace Livrocsharp
{
    class funcoesTexto
    {
        static void Main(string[] args)
        {
            var nomeUpper = "AIRTON SENNA";
            var nomeLower = "airton senna";
            // Comparação 1
            if (nomeUpper == nomeLower)
                WriteLine("1 nomes iguais");
            else
                WriteLine("1 - nomes diferentes");
            // Comparação 2
            if (nomeUpper.ToLower() == nomeLower)
                WriteLine("1 nomes iguais");
            else
                WriteLine("1 - nomes diferentes");
            // Comparação 3
            if (nomeUpper.Equals(nomeLower,  StringComparison.OrdinalIgnoreCase))
                WriteLine("1 nomes iguais");
            else
                WriteLine("1 - nomes diferentes");
        }
    }
}
```

```
Resultado:
1 - nomes diferentes
1 nomes iguais
1 nomes iguais
```

Comparar maiúsculas e minúsculas são conjuntos diferentes (resultado 1), exceto se convertermos tudo para ToLower e comparar, aí sim o resultado será igual (resultado 2). Já no caso do resultado 3 estamos comparando das duas variáveis (.Equals), no entanto, está explícito para ignorar maiúsculas e minúsculas. O uso do *StringComparison* permite o tipo de comparação, neste caso o *OrdinalIgnoreCase*.

E importante ressaltar que na interação com usuários em mecanismos de pesquisas, convém converter tudo para ToLower ou ToUpper e depois comparar ou ainda definir o tipo da comparação com o *StringComparison*.
### Remove

O método *Remove* serve para capturar uma quantidade de caracteres á esquerda de uma expressão, por exemplo, ler os primeiros 10 caracteres. Podemos notar que o *Remove* está sendo usado na variável empresa, o qual está declarando que apenas os 9 primeiros caracteres devem ser mostrados.

Em seguida, criamos um array de nomes completos. Num email de comunicado, precisamos referenciar apenas o primeiro nome de cada um. Para isto, criamos um looping do tipo *foreach* para percorrer cada um dos nomes e no *WriteLine* encadearemos o *Remove* com o *IndexOf*.

Isto é bem comum, pois o *Remove* precisa saber quantos caracteres deve extrair á esquerda. E, como cada primeiro nome tem um tamanho diferente, como dizer ao *Remove* a exata posição. Para isto, usamos o método *IndexOf* que retorna a posição exata de onde encontrar o espaço em branco, neste caso, *IndexOf*(" "). Ou seja, a cada iteração no looping, ele pega o nome completo, pesquisa a posição do espaço em branco e usa para extrair os primeiros caracteres.

```csharp
using static System.Console;
using System;
using System.Linq;


namespace Livrocsharp
{
    class funcoesTexto
    {
        static void Main(string[] args)
        {
            WriteLine("------ Funções de Textos -------");
			...
            WriteLine("Remove - extrai x caracteres a partir da esquerda da expressão");
            WriteLine($"Texto esquerdo: {empresa.Remove(9)}");
            WriteLine("Caputra apenas o primeiro nome das pessoas");
            string[] nomes = { "Fabricio dos Santos", "José da Silva", "Roberta Brasil" };
            foreach(var n in nomes)
            {
                WriteLine($"{n.Remove(n.IndexOf(" "))}");
            }

        }
    }
}
```

```
Resultado:
------ Funções de Textos -------
Remove - extrai x caracteres a partir da esquerda da expressão
Texto esquerdo: Microsoft
Caputra apenas o primeiro nome das pessoas
Fabricio
José
Roberta
```

### Replace

O método *Replace* é usado para substituir cadeias de expressões de textos. Existem dois parâmetros, o primeiro indica qual o texto a ser substituído e o segundo é texto que substituirá. Um uso comum é em casos de tratamento de dados, por exemplo, numa lista de endereços, trocar os termos "R", "RUA" ou "Street" por "Rua".

No código iremos trocar o nome "Microsoft" para "Google" na nova variável "novaEmpresa", depois de executado o *Replace*, a variável passa a valer o novo conteúdo para qualquer código após esta operação.

```csharp
using static System.Console;
using System;
using System.Linq;


namespace Livrocsharp
{
    class funcoesTexto
    {
        static void Main(string[] args)
        {
            WriteLine("------ Funções de Textos -------");
			...
            WriteLine("Replace - troca da expressão");
            WriteLine($"texto atual:{empresa}");
            var NovaEmpresa = empresa.Replace("Microsoft", "Google");
            WriteLine($"Texto trocado:{NovaEmpresa}");
        }
    }
}
```

```
Resultado:
------ Funções de Textos -------
Replace - troca da expressão
texto atual:Microsoft Corporation
Texto trocado:Google Corporation
```
### Split

O método *Split* é muito usado para tratamento de dados oriundos de arquivos de textos, CSV, Excel, onde é preciso separar cadeias de caracteres através de um caractere chave. O mais usado é o espaço em branco, mas pode ser qualquer caractere.

No código abaixo temos uma expressão na variável NivelLivro e um array de string na variável blocos. O objetivo é usar o *Split* em toda a expressão de NivelLivro, e cada bloco de texto será adicionado ao array "blocos"

Em seguida é feito um looping foreach para exibir cada conjunto de texto e ao final o método Count() conta a quantidade de itens do array. Toda vez que o texto for exibido, a expressão contém a variável contador para mostrar a ordem de classificação. A cada iteração do looping, o contador é incrementado (contador++). 


```csharp
using static System.Console;
using System;
using System.Linq;


namespace Livrocsharp
{
    class funcoesTexto
    {
        static void Main(string[] args)
        {
            WriteLine("------ Funções de Textos -------");
			...
			WriteLine("Split - divide e extrai cada palavra em um array");
            string NivelLivro = "Este livro é o básico do C#.";
            string[] blocos = NivelLivro.Split(' ');
            var contador = 1;
            foreach(var exp in blocos)
            {
                WriteLine($"Texto {contador++}: {exp}");
            }
            WriteLine($"Qtde de palavras: {blocos.Count()}");         
        }
    }
}
```

```
Resultado:
------ Funções de Textos -------
Split - divide e extrai cada palavra em um array
Texto 1: Este
Texto 2: livro
Texto 3: é
Texto 4: o
Texto 5: básico
Texto 6: do
Texto 7: C#.
Qtde de palavras: 7
```
### Substring

O  método *Substring* é usado para extrair parte do texto a partir de uma posição inicial. O tamanho do texto a ser capturado pode ou não ser informada, caso não seja, todo o texto a partir da posição é capturado. Caso declarado o tamanho, é capturado o texto conforme o número de caracteres.

No código abaixo, o conteúdo da variável NivelLivro que contém toda uma expressão. Na sintaxe NivelLivro.Substring(5, 14) informa que o texto a ser capturado deverá iniciar na posição 5 e pegar os próximos 14 caracteres. O resultado será "o livro é básico".

Já no array string\[]  cesta onde temos 4 elementos (itens de cesta de compra), como fazer para ler apenas os nomes de frutas, excluindo-se as quantidades? Criamos um looping foreach e a cada iteração precisamos saber qual a posição do primeiro espaço em branco *p.IndexOf(" ")* . A soma +1 indica a próxima posição do texto, ou seja, o nome da fruta logo após o número. Assim já temos a posição inicial. E como a quantidade de caracteres não foi especificada, o método *Substring* retorna todo o restante. Em outras palavras, o código pega qualquer nome de fruta após o número.

```csharp
using static System.Console;
using System;
using System.Linq;


namespace Livrocsharp
{
    class funcoesTexto
    {
        static void Main(string[] args)
        {
            WriteLine("------ Funções de Textos -------");
			...
            WriteLine("Substring é usado para extrair parte do texto");
            WriteLine(NivelLivro.Substring(5, 16));
            string[] cesta = { "5 Laranjas", "10 Goiabas vermelhas", "5 Pêssegos doces", "5 Bananas" };
            foreach(var p in cesta)
            {
                // p.IndexOf(" ") +1 retorna a posição incial logo após o número
                // ex: 5 Laranjas = posiçaõ 1 + 1 = 2
                WriteLine($"{p.Substring(p.IndexOf(" ") + 1)}");
            }     
        }
    }
}

```

```
Resultado:
------ Funções de Textos -------
Substring é usado para extrair parte do texto
livro é o básico
Laranjas
Goiabas vermelhas
Pêssegos doces
Bananas
```

Agora também devemos somar todas as quantidades contidas dos produtos da cesta. Partindo do pressuposto que as quantidades estão sempre no prefixo do nome dos produtos e há um espaço em branco entre o número e o texto, criamos uma variável Qtde do tipo inteiro que durante a iteração do looping é somada a Qtde de cada produto; 

```csharp
using static System.Console;
using System;
using System.Linq;


namespace Livrocsharp
{
    class funcoesTexto
    {
        static void Main(string[] args)
        {
            WriteLine("------ Funções de Textos -------");
			...
            WriteLine("Substring é usado para extrair parte do texto");
            WriteLine(NivelLivro.Substring(5, 16));
            string[] cesta = { "5 Laranjas", "10 Goiabas vermelhas", "5 Pêssegos doces", "5 Bananas" };
            int Qtde = 0;
            foreach(var p in cesta)
            {
                // p.IndexOf(" ") +1 retorna a posição incial logo após o número
                // ex: 5 Laranjas = posiçaõ 1 + 1 = 2
                WriteLine($"{p.Substring(p.IndexOf(" ") + 1)}");
                Qtde += Convert.ToInt32(p.Substring(0, p.IndexOf(" ")));
            }
            WriteLine($"Qtde total: {Qtde:n0}");   
        }
    }
}
```

```
Resultado:
------ Funções de Textos -------
Substring é usado para extrair parte do texto
livro é o básico
Laranjas
Goiabas vermelhas
Pêssegos doces
Bananas
Qtde total: 25
```

A variável p contém o texto completo do produto. O que precisamos é extrair os primeiros números apenas, converter para número inteiro e somar na variável Qtde. o *p.Substring(0, p.IndexOf(" "))* retorna o número em si, pois inicia na posição 0 e captura tudo que estiver até o primeiro espaço em branco. Em seguida usamos o *Convert.ToInt32* para converter o texto que contém o número em si para inteiro, a fim de ser somado á variável Qtde.
### IsNullOrEmpty

O método *IsNullOrEmpty* verifica se um *String* está nula ou vazia. Isto é muito usado onde há interação com o usuário, afim de consistência de dados. Em casos de manipular um objeto dentre as camadas de acesso a dados e interface, também usamos com frequência.

Vamos a um exemplo prático o qual temos duas variáveis, nome e sobrenome. Em seguida há um **IF** questionando se a variável Nome é diferente de nula ou vazia. Na sintaxe, o uso do "!" (exclamação) antes do **String.IsNullOrEmpty** indica negativa. Já o uso do **&&** significa E (AND) na condição, ou seja, se as variáveis Nome e Sobrenome forem diferentes de nulo ou vazia, mostre o nome completo. Caso contrário, mostre apenas o nome.

Neste caso, poderíamos ter usado apenas um **&**, o que também indica o E (AND). Mas, no C# quando temos mais de uma condição a ser avaliada é melhor usar os dois **&&**. Isto porque aquando a primeira condição não atende ao critério, as demais não são nem validadas. Já o uso de um **&**, todas as condições são avaliadas, mesmo que as anteriores sejam falsas.

```csharp
using static System.Console;
using System;
using System.Linq;


namespace Livrocsharp
{
    class funcoesTexto
    {
        static void Main(string[] args)
        {
            WriteLine("------ Funções de Textos -------");
			...
            WriteLine("IsNullOrEmpty verifica se a string está nula ou vazia");
            string nome = null;
            string sobrenome = "Albani";
            if (!String.IsNullOrEmpty(nome) & !String.IsNullOrEmpty(sobrenome))
            {
                WriteLine($"Nome completo:{nome} {sobrenome}");
            }
            else
            {
                WriteLine($"Nome:{sobrenome} ");
            }   
        }
    }
}
```

```
Resultado:
------ Funções de Textos -------
IsNullOrEmpty verifica se a string está nula ou vazia
Nome:Renato
```
### Funções Datas

As funções de datas permitem manipular qualquer informação de uma data que esteja no modelo *DateTime* contendo o dia, o mês e o ano. Sendo assim, conseguimos fazer contas com datas, adicionar ou subtrair, dias, meses e anos, aplicar formatações customizadas, obter a data e hora completa do sistema operacional, converter em texto, ler um texto e converter em data, entre outras.

Para esse exemplo vamos criar um novo arquivo funcoesDatas.cs, mas como estamos dentro do mesmo namespace o C# precisa saber qual Main executar, é necessário configurar o  arquivo Modulo2 adicionando o **StartupObject**  indicando o namespace e o nome da classe.

```csharp
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net9.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>	  
	  <StartupObject>Livrocsharp.funcoesDatas</StartupObject>  // <- Adição do novo Main
  </PropertyGroup>

</Project>
```

```csharp

using static System.Console;
using System;
using System.Linq;


namespace Livrocsharp
{
    class funcoesDatas
    {
        static void Main(string[] args)
        {
             
        }
    }
}
```
### DateTime

Para o C# uma data, hora, minuto, segundos e ticks dependem do tipo *DateTime*. Todos estes são conhecidos, exceto o Ticks, que é tipo um Long que permite atribuir um número para milissegundos e nanosegundos.

O *DateTime* para uma data comum é composto pelo dia (1-31), mês (1-12) e o ano, todos os valores numéricos. A ordem de entrada sempre será o Ano, Mês, Dia, nesta ordem respectivamente. Vamos a um código exemplo, dentro do SVM, criaremos três variáveis dia, mês e ano contendo os seguintes valores, conforme o código a seguir.

A primeira variável dtAniversario é do tipo *DateTime* e ao contribuir *new DateTime*  os parâmetros são as variáveis ano, mês e dia, nesta ordem. Podemos também definir uma data digitando números fixos, por exemplo, veja a variável dtFesta = new DateTime(2021, 08, 25). O que não pode é desrespeitar a ordem e os valores dos três parâmetros, senão será gerado um erro.

Uma vez tendo a data válida, partimos para a formatação. Como a exibição de uma data pode ser customizada, usamos para o **dia** a letra **d** minúscula, que pode ter de 1 a 4 letras d. Para o **mês**, usamos a letra **M** maiúscula que pode ter de 1 a 3 letras M. A letra m minúscula é usada para minutos. Já o **ano**, usamos a letra **y** minúscula que pode ter 2 ou 4 letras y.

```csharp
using static System.Console;
using System;
using System.Linq;

namespace Livrocsharp
{
    class funcoesDatas
    {
        static void Main(string[] args)
        {
            int dia = 12;
            int mes = 05;
            int ano = 2021;
            DateTime dtAniversario = new DateTime(ano, mes, dia);
            DateTime dtFesta = new DateTime(2021, 08, 25);
            WriteLine("“------ Funções de Datas -------”)");
            WriteLine($"Aniversário:{dtAniversario}");
            WriteLine($"Aniversário: {dtAniversario:dd/MM/yyyy}");
            WriteLine($"Aniversário: {dtAniversario:ddd/MMM/yyyy}");
            WriteLine($"Aniversário: {dtAniversario:dddddd/MMMM/yyyy}");
        }
    }
}
```

```
Resultado:
"------ Funções de Datas -------")
Aniversário:12/05/2021 00:00:00
Aniversário: 12/05/2021
Aniversário: qua./mai./2021
Aniversário: quarta-feira/maio/2021
```
### Today

A propriedade *Today* do DateTime retorna a data completa com o dia, mês e ano do sistema operacional. Usamos com muita frequência em aplicações onde precisamos saber a data de hoje, assim o usuário não tem como informar, a data é capturada diretamente da máquina e não existem parâmetros.
### Now

A propriedade *Now* do DateTime retorna a data, hora, minutos e segundos automaticamente do sistema operacional. Em aplicações de bolsa de valores, transações em bancos e uso de medicamentos são alguns dos exemplos de onde são utilizadas. 

No código a seguir veremos como são as chamadas do *Today* e do *Now*, assim como as formatações a serem aplicadas. 
```csharp
using static System.Console;
using System;
using System.Linq;

namespace Livrocsharp
{
    class funcoesDatas
    {
        static void Main(string[] args)
        {
            WriteLine("“------ Funções de Datas -------”)");
            ...
            DateTime hoje = DateTime.Today;
            WriteLine("TODAY - retorna a data atual");
            WriteLine($"TODAY:{hoje:dd/MM/yyyy}");
            DateTime DataHora = DateTime.Now;
            WriteLine($"NOW - retorna a data e a hora atual");
            WriteLine($"Data e Hora: {DataHora:dd/MM/yyyy hh:mm:ss}");
        }
    }
}
```

```
Resultado:
"------ Funções de Datas -------")
TODAY - retorna a data atual
TODAY:25/08/2025
NOW - retorna a data e a hora atual
Data e Hora: 25/08/2025 02:14:52
```
### Day / Month / Year

A partir de uma data completa é possível extrair as devidas partes como dia, mês e ano, armazenar em variáveis, fazer contas, manipular, enfim, fazer o que quiser conforme o escopo da aplicação. 

Para isto, basta criar uma data completa e usar as propriedades *Day,* *Month* e *Year* do objeto **DateTime**. No código a seguir estamos extraindo da variável DataHora e mostrando cada uma das partes.

```csharp
using static System.Console;
using System;
using System.Linq;

namespace Livrocsharp
{
    class funcoesDatas
    {
        static void Main(string[] args)
        {
            WriteLine("“------ Funções de Datas -------”)");
            ...
            DateTime DataHora = DateTime.Now;
            WriteLine($"NOW - retorna a data e a hora atual");
            WriteLine($"Data e Hora: {DataHora:dd/MM/yyyy hh:mm:ss}");
            WriteLine("DAY/MONTH/YEAR - capturar o dia, mês e ano separadamente");
            WriteLine($"Dia: {DataHora.Day}");
            WriteLine($"Mês: {DataHora.Month}");
            WriteLine($"Ano: {DataHora.Year}");
        }
    }
}
```

```
Resultado:
"------ Funções de Datas -------")
TODAY - retorna a data atual
TODAY:25/08/2025
NOW - retorna a data e a hora atual
Data e Hora: 25/08/2025 02:20:54

DAY/MONTH/YEAR - capturar o dia, mês e ano separadamente
Dia: 25
Mês: 8
Ano: 2025
```

### Manipular Data

Em uma data DateTime válida podemos adicionar dias *AddDays(n)*, meses *AddMonths(n)* e anos *AddYears(n)*, basta informar o respectivo número a ser adicionado. Podemos ir para um exemplo clássico de pedido de compra. No código a seguir temos a data do pedido (dtPedido) que captura o dia atual (Today), data de vencimento (dtVencto) que são adicionados 35 dias á dtPedido (AddDays(35)), a data do pagamento (dtPagamento) que são adicionados 2 meses á dtVencto(AddMounths2)).

Em seguida, as datas do pedido e vencimento são exibidas com o formato customizado dd/MM/yyyy. E como o C# dispõe de duas formatações prontas, vamos usá-las em dtVencto como formato longo (ToLongDateString) e o formato curto (ToShortDateString).

Toda data tem obrigatoriamente o dia da semana (domingo, segunda, ..., sábado), e para saber qual é o dia usamos a propriedade DayOfWeek, o qual está sendo aplicada á dtVencto.

Podemos usar um formato específico do ToString de acordo com a cultura definida, neste caso a cultura do Brasil pt-BR, dtVencto.ToString("dddd", new CultureInfo("pt-BR")). Caso use uma cultura é preciso adicionar o using System.Globalization. Já o dia do ano (DayOfYear) aplicado á dtVencto mostra quantos dias foram corridos desde o inicio do ano.

E, para saber quantos dias se passaram entre duas datas, usamos o Subtract, onde referenciamos a maior data, neste caso dtPagamento, seguido do método Subtract, passando como parâmetro a data a ser comparada, dtPedido. Isto retorna o número de dias corridos.

```csharp
using static System.Console;
using System;
using System.Linq;
using System.Globalization;

namespace Livrocsharp
{
    class funcoesDatas
    {
        static void Main(string[] args)
        {
            WriteLine("“------ Funções de Datas -------”)");
            ...
            DateTime dtPedido = DateTime.Today;
            //Adiciona 35 dias
            DateTime dtVencto = dtPedido.AddDays(35);
            //Adcionar 2 meses
            DateTime dtPagamento = dtVencto.AddMonths(2);
            WriteLine($"Pedido feito em {dtPedido:dd/MMM/yyyy} vence em {dtVencto:dd/MMM/yyyy}");
            WriteLine($"Formatação completa: {dtVencto.ToLongDateString()}");
            WriteLine($"Formatação curta: {dtVencto.ToShortDateString()}");
            //Dia da Semana
            WriteLine($"dia da semana: {dtVencto.DayOfWeek}");
            WriteLine($"dia da semana em portugês: {dtVencto.ToString("dddd", new CultureInfo("pt-BR"))}");
            WriteLine($"Número do dia da semana: {(int)dtVencto.DayOfWeek}");
            //Dia do ano
            WriteLine($"dia do ano: {dtVencto.DayOfYear}");
            //Subtrai 2 datas
            var qtdeDias = dtPagamento.Subtract(dtPedido);
            WriteLine($"Entre o pedido e o pagamento foram {qtdeDias:dd} dias");
        }
    }
}
```

```
Resultado:
"------ Funções de Datas -------")
Pedido feito em 25/ago./2025 vence em 29/set./2025
Formatação completa: segunda-feira, 29 de setembro de 2025
Formatação curta: 29/09/2025
dia da semana: Monday
dia da semana em portugês: segunda-feira
Número do dia da semana: 1
dia do ano: 272
Entre o pedido e o pagamento foram 96 dias
```
### Conversões de Datas

Quando precisamos ler dados externos á aplicação, seja retornando informações de uma API, banco de dados, CSV, Textos, etc. É comum uma data vir no formato de texto, então cabe uma conversão para deixar no formato DateTime, permitindo manipular de acordo com a necessidade.

No código a seguir temos uma variável "dataTexto" do tipo String contendo uma data no formato dia/mês/ano, só que é um texto. Já a variável dataTextoConvertida está definida no formato DateTime. E, para converter para outro formato, independente do tipo de dado, sempre há um risco de erro e tentativa. Quem faz esta tentativa é o *TryParse* onde os parâmetros são a data no formato  texto e a data no formato DateTime. Cabe ressaltar que a palavra chave OUT informa qual a variável se espera o resultado convertido.

O **TryParse** serve para muitos outros formatos e podemos entender da seguinte forma: tente converter, se der certo jogue o resultado em OUT, caso contrário, dará erro.

No exemplo a seguir, caso a conversão seja com sucesso, o texto exibido será "Data com conversão aceita". Em seguida, temos a variável dataTextoErrada com um formato de data inválido, e na tentativa de conversão será gerado um erro.

```csharp
using static System.Console;
using System;
using System.Linq;
using System.Globalization;

namespace Livrocsharp
{
    class funcoesDatas
    {
        static void Main(string[] args)
        {
            WriteLine("“------ Funções de Datas -------”)");
            ...
            string dataTexto = "15/07/2021";
            DateTime dataTextoConvertida;
            //Tentativa (TryParse) de conversão de dataTexto.
            //Caso dê certo a saída OUT será em dataTextoConvertida
            if(DateTime.TryParse(dataTexto, out dataTextoConvertida))
            {
                WriteLine("Data com conversão aceita");
            }
            else
            {
                WriteLine("Erro na conversão da data");
            }
            string dataTextoErrada = "15/metade do ano/2021";
            DateTime dataTextoErradaConvertida;
            if (DateTime.TryParse(dataTextoErrada, out dataTextoErradaConvertida))
            {
                WriteLine("Data com conversão aceita");
            }
            else
            {
                WriteLine("Erro na conversão da data"); 
            }
        }
    }
}
```

```
Resultado:
"------ Funções de Datas -------")
Conversão de Texto para Date
Data com conversão aceita
Erro na conversão da data
```
### Datas em Objetos

A programação Orientada a Objetos (OOP) nos ajuda na estrutura dos objetos, entre muitos outros benefícios que não é o foco agora, temos um capítulo somente deste tópico. O importante aqui é criarmos um objeto chamado Pedido contendo as respectivas propriedades, conforme o código a seguir. Todo objeto é uma classe, então na parte inferior do código, após o class  funcoesDatas iremos declarar uma classe pública (public class Pedido).

Em seguida, iremos digitar as propriedades do Pedido, sendo o PedidoID (chave do pedido), as datas DateTime dtPedido, dtVencto (que automaticamente adiciona 30 dias baseado na dtPedido), DiasAtraso (tipo TimeSpan) que faz a subtração entre o dtPagto e o DtVencto, o Valor e a Multa de 10% a ser aplicada 

```csharp
using static System.Console;
using System;
using System.Linq;
using System.Globalization;

namespace Livrocsharp
{
    class funcoesDatas
    {
		 ...
    }
    public class Pedido
    {
        public int PedidoID { get; set; }
        public DateTime dtPedido { get; set; }
        public DateTime dtVencimento() => dtPedido.AddDays(30);
        public DateTime dtPagto { get; set; }
        public decimal Valor { get; set; }
        public decimal Multa => Valor * 0.10M;
    }
}

```

Agora que o objeto Pedido está definido, podemos instancia-lo no SVM. No código a seguir, atribuímos ao objeto Pedido novos dados (new Pedido) como PedidoID, dtPedido, dtPagamento, DiasAtraso e Multa são calculadas automaticamente.

```csharp
using static System.Console;
using System;
using System.Linq;
using System.Globalization;

namespace Livrocsharp
{
    class funcoesDatas
    {
	    // Uso de Datas em objetos
        var pedido = new Pedido
        {
            PedidoID = 1,
            dtPedido = DateTime.Today,
            dtPagto = DateTime.Today.AddDays(45),
            Valor = 1500
        };
        WriteLine($"Pedido:{pedido.PedidoID} - " + $"{pedido.dtPedido:dd/MMM/yyyy} -" + $"Vencto: {pedido.dtVencimento():dd/MMM/yyyy}- "
        + $"dias atraso: {pedido.DiasAtraso().TotalDays} - " + $"valor: {pedido.Valor:n2} - " + $"multa: {pedido.Multa:n2}"); 
    }
    public class Pedido
    {
        public int PedidoID { get; set; }
        public DateTime dtPedido { get; set; }
        public DateTime dtVencimento() => dtPedido.AddDays(30);
        public DateTime dtPagto { get; set; }
        public decimal Valor { get; set; }
        public decimal Multa => Valor * 0.10M;
    }
}
```

```
Resultado:
("------ Funções de Datas -------")
Pedido:1 - 25/ago./2025 -Vencto: 24/set./2025- dias atraso: 15 - valor: 1.500,00 - multa: 150,00
```
### Conversão de Dados

No C# temos dois tipos de dados que são sempre armazenados na memória, sendo tipos de **valor** e **referência**. Quando atribuímos um valor a uma variável dos tipos int, float, double, decimal, bool e char são do tipo **VALOR**. Isto porque o conteúdo vai diretamente para um local na memória . Já o tipo por **REFERÊNCIA** armazena o endereço do valor onde esta armazenado, por exemplo, object, string, array.

Em qualquer tipo de aplicação é comum a conversão de tipos de dados, int para double, texto para data, object para float e vice-versa. A estas conversões chamamos de *Boxing* e *Unboxing. 

**Boxing** é a conversão de um tipo de valor para o tipo de objeto ou qualquer tipo de interface implementado por este tipo de valor. O **Boxing** está implícito. 

```csharp
// boxing
int percentual = 10;
objetc objeto1 = percentual;
```

**Unboxing** é o inverso do Boxing. È a conversão de um tipo de referência em tipo de valor. O **unboxing** extrai o valor do tipo de referência e atribui a um tipo de valor. O **unboxing** é explícito, ou seja, precisamos declarar, por exemplo (int) objeto2.
```csharp
// unboxing
objetc objeto2 = 10;
int desconto = (int)objeto2;
```

> Como os valores funcionam na memória do CLR (Commom Language Runtime)?

Todas as informações são armazenadas na memória quando atribuímos valores aos objetos. O valor e o tipo de dado é apenas uma referência na memória. No exemplo acima, int percentual é atribuído ao objeto1, sendo que objeto1 é apenas um endereço e não um valor em si. Com isto, o CLR configura o tipo de valor criado num novo System.Object no heap (pilha de memória) e atribui o valor de percentual a ele. Em seguida, atribui um endereço desse objeto ao objeto1. Isto é denominado **Boxing** 

Para vermos isso na prática, criamos um novo arquivo conersaoDados.cs onde iremos fazer o *boxing*  de tipos numéricos int e decimal. Temos a variável percentual do tipo int que é atribuída á variável objPercentual do tipo object. No código da variável salario, do tipo decimal, é atribuída a variável objSalario do tipo object. No WriteLine colocamos o GetType das variáveis para visualizarmos o tipo que o CLR definiu. 

```csharp
using static System.Console;
using System;
using System.Linq;
using System.Globalization;

namespace Livrocsharp
{
    class conversaoDados
    {
        static void Main(string[] args)
        {
            // boxing (converte um tipo para Object)
            WriteLine("----- Boxing -----");
            int percentual = 10;
            object objPercentual = percentual;
            WriteLine($"percentual: {percentual} - {percentual.GetType()}");
            WriteLine($"objPercentual: {objPercentual} - {objPercentual.GetType()}");
            decimal salario = 12500.50M;
            object objSalario = salario;
            WriteLine($"Salario: {salario} - {salario.GetType()}");
            WriteLine($"obSalario: {objSalario} - {objSalario.GetType()}");
        }

    }
}
```

```
Resultado:
----- Boxing -----
percentual: 10 - System.Int32
objPercentual: 10 - System.Int32
Salario: 12500,50 - System.Decimal
obSalario: 12500,50 - System.Decimal
```

Agora vamos adicionar o seguinte bloco de código para fazermos o Boxing de tipos texto (string) e data (DateTime). A ideia é a mesma que a anterior, criamos as variáveis que serão atribuídas a um object e, no final, mostramos os dados.

```csharp
using static System.Console;
using System;
using System.Linq;
using System.Globalization;

namespace Livrocsharp
{
    class conversaoDados
    {
        static void Main(string[] args)
        {
            
            WriteLine("----- Boxing -----");
            ...
            string nome = "Visual C#";
            object objNome = nome;
            WriteLine($"nome:{nome} - {nome.GetType()}");
            WriteLine($"objNome:{objNome} - {objNome.GetType()}");
            DateTime hoje = DateTime.Today;
            object objHoje = hoje;
            WriteLine($"hoje:{hoje} - {hoje.GetType()}");
            WriteLine($"objHoje:{objHoje} - {objHoje.GetType()}");
        }
    }
}
```

```
Resultado:
----- Boxing -----
nome:Visual C# - System.String
objNome:Visual C# - System.String
hoje:25/08/2025 00:00:00 - System.DateTime
objHoje:25/08/2025 00:00:00 - System.DateTime
```

Agora vamos criar um código para mostrar o unboxing, que é o oposto do boxing. Neste caso, vamos definir a variável objDesconto do tipo object que é atribuída á variável desconto do tipo int. Note que na sintaxe é obrigatório colocar entre parênteses do tipo da variável que receberá o object. Neste caso, usamos (int)objDesconto.

```csharp
using static System.Console;
using System;
using System.Linq;
using System.Globalization;

namespace Livrocsharp
{
    class conversaoDados
    {
        static void Main(string[] args)
        {
            
            WriteLine("----- Boxing -----");
            ...
            WriteLine("----- Unboxing -----");
            WriteLine($"desconto:{desconto} - {desconto.GetType()}");
            WriteLine($"objDesconto:{objDesconto} - {objDesconto.GetType()}");
        }
    }
}
```

```
Resultado:
----- Unboxing -----
desconto:10 - System.Int32
objDesconto:10 - System.Int32
```

É bom ter em mente que no unboxing o object a ser atribuído precisa permitir tal conteúdo, não adianta jogar um dado texto em um int ou double que dará erro.
### Parse

Uma outra forma que existe de conversão de tipos de dados é através do *Parse*. A sintaxe deve conter o tipo de campo (int32, int64, int, DateTime) seguido do *.Parse* contendo o valor a ser convertido.

No código a seguir temos diversos onde temos diversos exemplos de int16, int 64, int e DateTime. Note que quando há um texto com símbolos de negativos (parênteses ou -), separador de milhar, símbolo da moeda R$ ou espaço em branco á esquerda ou direita do número, é preciso informar ao Parse do que se trata. Isto ocorre através do Enum NumberStyler (AllowParentheses, AllowThousands, AllowCurrencySymbol, AllowLeandingSign, AllowLeadinigWhite, AllowTrailingWhite). 

No exemplo a seguir, no uso do símbolo a moeda, colocamos o comando para exibir o nome da cultura atual CultureInfo.CurrentCulture.Name e símbolo de moeda usado NumberFormatInfo.CurrentInfo.Currency.Symbol. Todo  o código esta dentro do bloco try...catch, pois se ocorrer algum erro na conversão, o código cairá no catch e será mostrada uma mensagem de erro.

```csharp
using static System.Console;
using System;
using System.Linq;
using System.Globalization;

namespace Livrocsharp
{
    class conversaoDados
    {
        static void Main(string[] args)
        {
	         ...
	        // Conversões com PARSE
			try
			{
                WriteLine("----- Parse");
                WriteLine($"{Int16.Parse("150")}");
                //Retorna -150, os parênteses representam o valor negativo
                WriteLine($"{Int16.Parse("(150)", NumberStyles.AllowParentheses)}");
                // Retorna 50000 mesmo com o ponto de milhar
                WriteLine($"{int.Parse("50.000", NumberStyles.AllowThousands)}");
                // retorna 50000 mesmo com o símbolo monetário
                WriteLine($"Cultura atual: {CultureInfo.CurrentCulture.Name}");
                WriteLine($"Símbolo da moeda: {NumberFormatInfo.CurrentInfo.CurrencySymbol}");
                // Retorna -200 mesmo com o símbolo de negativo - 
                WriteLine($"{int.Parse("-200", NumberStyles.AllowLeadingSign)}");
                // Retorna 200 mesmo com os espaços em branco antes e depois
                WriteLine($"{int.Parse(" 100 ", NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite)}");
                //Retorna 5432123456
                WriteLine($"{Int64.Parse("5432123456")}");
                WriteLine($"Data: {DateTime.Parse("21/04/2021"):dd/MMM/yyyy}");	
            }
            catch (Exceotion ex)		
            {
	            WriteLine(ex);
            }							
        }
    }
}
```

```
Resultado:
----- Parse
150
-150
50000
Cultura atual: pt-BR
Símbolo da moeda: R$
-200
100
5432123456
Data: 21/abr./2021
```










---



 
