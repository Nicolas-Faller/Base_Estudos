
---
*📅 **created: 26-08-2025 / 17:27**
🏷️ **tags: []**
**⌛ status: draft**
## 📋 Resumo

> Breve descrição do conteúdo

## 📚 [[CSharpIniciantes.pdf#page=87&selection=0,0,1,16&color=red|Coleções Mais Comuns Utilizadas no C#]]

As coleções nas linguagens de programação são basicamente estruturas de dados que podemos criar ou gerenciar quando queremos definir objetos e utilizar os mesmo em nossos sistemas. A ideia central de utilizar coleções em uma linguagem de programação é representar aspectos do mundo real em nosso sistema. Por exemplo, imaginemos que precisamos criar no sistema  um controle de senhas para gerenciar uma recepção de um consultório.

Neste consultório teremos  apenas cem vagas disponíveis por dia apenas. Como representaremos isso no sistema então? Precisaremos de uma coleção de um tipo de dados para gerenciar esse controle de senhas. Como dito anteriormente, existem diversos tipos de coleções e cada uma delas é adequada para um determinado cenário.
### Arrays

As arrays são normalmente utilizadas e criadas quando temos um número fixo de posições em mente. Como no exemplo citado, temos apenas cem senhas disponíveis, então podemos criar e declarar o array da seguinte forma:

```csharp
//Declarando uma array com cinco elementos do tipo inteiro
int[] primeiraArray = new int[100];
```

A  declaração é bem simples, poderíamos guardar apenas cem números do tipo inteiro nessa array. Perceba que estamos apenas deixando disponível, mas não atribuindo os valores ao array. Para o caso de já iniciar um array com os valores atribuídos, usamos:

```csharp
//Delcarando uma array e já atribuindo valores
int[] segundaArray = new int[] {1, 3, 5, 7, 9};
```

Ao invés de informar para o C# que temos cem posições de inteiros disponíveis, estamos apenas informando que temos posições para alocar os números e já colocando os valores diretamente na criação.

Paralelamente, se não quisermos informar o tipo (neste caso, int), também  é possível iniciar desta forma:

```csharp
// Forma alternativa d criar um array
int[] terceriaArray = {1, 2, 3, 4, 5, 6};
```

Essas formas de criação de array acima vão basicamente criar o que chamamos de arrays dimensional. Teremos apenas uma dimensão par alocar e trabalhar com valores.

Existe também uma forma de criar uma array multidimensional, como se fosse uma matriz. Nesse caso, na criação da array, precisamos informar na declaração, conforme exemplo:

```csharp
// Declarando uma array multi-dimensional
int[,] arrayMultiDimensional = new int[2, 3];
```

Esse seria um cenário um pouco mais avançado, mas ainda válido. Para atribuir valores já na criação de um array multidimensional poderíamos fazer da seguinte forma:

```csharp
// Declarando uma array multi-dimensional e atribuindo valores
int[,] arrayMultiDimensional2 = {{1, 2, 3}, {4, 5, 6}};
```

### Acessando o valor de uma array

Até aqui já criamos as arrays, atribuímos valores na sua criação. Porém, em um cenário real de desenvolvimento, precisamos obter os valores que estão contidos nesses arrays para exibir em alguma tela, por exemplo:

```csharp
using static System.Console;
using System;
using System.Linq;
using System.Globalization;

namespace Livrocsharp
{
    public class ExemploClasseArray
    {
        static void Main(string[] args)
        {
            ClasseArray();
            static void ClasseArray()
            {
                // Declarando uma array e já atribuindo valores
                int[] segundArray = new int[] { 1, 3, 5, 7, 9 };
                WriteLine("Valor da array na posição 0 -> {0}", segundArray[0]);
            }
        }
        
    }
}
```

```
Resultado:
Valor da array na posição 0 -> 1
```
O motivo disso é porque quando vamos ler uma array, iniciamos pelo indexador zero. O valor 1 esta na posição 0. O valor 3 está na posição 1. O valor 5 está na posição 3 e assim por diante. Em resumo, a posição de uma array inicia em zero e vai até o tamanho definido da array. Veja a lista completa como ficaria:

 -  Posição 0 - valor 1 
 -  Posição 1 - valor 3 
 -  Posição 2 - valor 5 
 -  Posição 3 - valor 7 
 -  Posição 4 - valor 9

Pode até parecer confuso, mas não é. O motivo de iniciar do zero remete a forma como os computadores foram projetados e essa convenção é adotada até hoje em estrutura de dados. 
### Listas

As listas no C# têm a finalidade de armazenar um tipo de dados no sistema. Esses tipos de dados comumente são denominados como listas tipadas. Ao se referir a "tipadas", estamos meramente informando ou entendendo que ao criar uma lista com um tipo de dados, como por exemplo string, todos os valores daquela lista devem ser de fato uma string. A tipagem garante que estamos trabalhando de forma efetiva e não estamos misturando dados diferentes na mesma coleção.

As listas são utilizadas normalmente em cenários onde mais de um valor deve ser associado a uma variável. Pense num cenário onde precisamos criar uma estrutura de dados para salvar o nome de todos os funcionários de um determinado departamento de uma empresa. Nesse departamento temos a Maria, João, o André e a Flávia. Dessa forma, precisaremos criar uma estrutura de dados do tipo **List\<T>** para acrescentar os nomes e manipular essa estrutura de dados, conforme o exemplo a seguir:

```csharp
using static System.Console;
using System;
using System.Linq;
using System.Globalization;

namespace Livrocsharp
{
    public class ExemploList
    {        
        static void Main()
        {
            List<string> nomesFuncioanrios = new List<string>();
            nomesFuncioanrios.Add("Maria");
            nomesFuncioanrios.Add("João");
            nomesFuncioanrios.Add("André");
            nomesFuncioanrios.Add("Flávia");
            WriteLine("");
            foreach(string pessoa in nomesFuncioanrios)
            {
                WriteLine(pessoa);
            }
        }
    }
}
```

```
Resultado:
Maria
João
André
Flávia
```
Criamos uma instância de uma lista de funcionários utilizando o List\<string> 

```csharp
List<string> nomesFuncioanrios = new List<string>();
```

Dessa forma estamos criando na memória uma estrutura para guardar uma lista do tipo string. Se tentarmos incluir nessa lista um valor inteiro, por exemplo 0 ou 1, não será possível, pois ela foi tipada com o tipo string.

Por se tratar de uma lista, podemos manipular os valores da mesma, acrescentando ou removendo valores. Para isso temos o método Add() que vai possibilitar incluir uma nova string nessa lista.

```csharp
nomesFuncioanrios.Add("Maria");
nomesFuncioanrios.Add("João");
nomesFuncioanrios.Add("André");
nomesFuncioanrios.Add("Flávia");
```

A forma como a lista é indexada, ou seja, seus valores são determinados e iniciados em 0, então, se tentarmos obter o primeiro valor da lista, precisamos programar da seguinte forma:
```csharp
Console.WriteLine(nomesFuncionarios[0]);
```

A saída desse processamento será "Maria" pois Maria é o primeiro valor que foi adicionado na lista.

Podemos ter cenários onde será necessários remover pessoas da lista. Nesse caso temos o método RemoveAt() se soubermos qual a posição exata da pessoa na lista; No exemplo a seguir vamos remover a Maria novamente da lista e já sabemos que ela é a primeira da lista, sendo assim a posição dela é 0. Podemos fazer da seguinte maneira:
```csharp
using static System.Console;
using System;
using System.Linq;
using System.Globalization;

namespace Livrocsharp
{
    public class ExemploList
    {        
        static void Main()
        {
            List<string> nomesFuncioanrios = new List<string>();
            nomesFuncioanrios.Add("Maria");
            nomesFuncioanrios.Add("João");
            nomesFuncioanrios.Add("André");
            nomesFuncioanrios.Add("Flávia");
            WriteLine("");
            //foreach(string pessoa in nomesFuncioanrios)
            //{
            //    WriteLine(pessoa);
            //}
            nomesFuncioanrios.RemoveAt(0);
            WriteLine(nomesFuncioanrios[0]);
        }
    }
}
```
 
```
Resultado:
João
```

Esse resultado foi executado pois acresentamos os quatro nome na lista, mas em seguida fizemos a remoção do indexador zero, o qual representava o valor Maria. Sendo assim, havia 4 nomes na lista e removemos o primeiro. Nesse mesmo momento, João passou  a ser o indexador zero que anteriormente estava ocupado por Maria.

Esse tipo de manipulação de dados é muto comum e corriqueira, as manipulações de dados e estrutura de dados representam boa parte do cotidiano de uma programador.
### Tipos Genéricos 

Nos exemplos anteriores fixamos que a lista era do tipo string. Esse é um bom cenário quando temos certeza que os tipos dos valores são exatamente os que precisamos para trabalhar. Porém, em algumas situações precisaremos flexibilizar essa tipagem dos valores.

Em um cenário onde precisamos colocar em uma mesma lista valores inteiros e letras, ou melhor, criar uma lista apenas de inteiro e outra apenas de letras. Nesse caso, o C# tem disponível o conceito de genéricos.

Os tipos genéricos facilitam esse cenário e tudo que precisamos fazer é utilizar parâmetros do tipo genérico **T**. Podemos então escrever uma única classe que qualquer outra parte do sistema pode utilizar sem precisar criar uma nova estrutura e passando o tipo específico que ele deseja.

Para ficar mais claro, vamos utilizar o seguinte exemplo. Imaginamos que queremos criar uma classe que vai possibilitar a criação de várias listas de qualquer tipo, seja strings, inteiro ou até mesmo de outra classe. Nesse cenário, seria mais produtivo criarmos uma classe genérica que nos possibilite passar como parâmetro um tipo qualquer:

```csharp
using static System.Console;
using System;
using System.Linq;
using System.Globalization;

namespace Livrocsharp
{
    public class ExemploList
    {        
        static void Main()
        {
 
        }
    }
    // Declarnado uma lista genérica
    public class ListaGenerica<T>
    {
        public void Adicionar(T input) { }
    }
    class TesteGenerica
    {
        private class ExampleClass { }
        static void Testa()
        {
            //Declarando uma lista do tipo inteiro
            ListaGenerica<int> lista1 = new ListaGenerica<int>();
            lista1.Adicionar(1);
            //Declarando uma lista do tipo string
            ListaGenerica<string> lista2 = new ListaGenerica<string>();
            lista2.Adicionar("");
            ///Declarando uma lsita do tipo de uma classe
            ListaGenerica<ExampleClass> lista3 = new ListaGenerica<ExampleClass>();
            lista3.Adicionar(new ExampleClass());
        }
    }
}
```

Os tipos genéricos facilitam criar as estruturas de dados de uma forma dinâmica, facilitando a centralização e reaproveitamento de código. No exemplo anterior, a classe ListaGenerica\<T> assume essa responsabilidade de flexibilizar a tipagem de dados utilizando o parâmetro \<T>. Dessa forma, podemos passar qualquer tipagem de dados e utilizar essa classe em qualquer locar do sistema de forma centralizada.
 


---



 
