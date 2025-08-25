
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


---



 
