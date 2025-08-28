
---
*📅 **created: 28-08-2025 / 14:20**
🏷️ **tags: []**
**⌛ status: draft**
## 📋 Resumo

> Breve descrição do conteúdo

## 📚 [[CSharpIniciantes.pdf#page=139&selection=6,0,16,22&color=yellow| Método de Extensão, Dicionários, Parâmetros Opcionais e Delegates com Func<>]]

O C# permite ao desenvolvedor criar códigos próprios para auxiliar na produtividade e uso em qualquer parte do projeto, por exemplo, um método de extensão para auxiliar na formatação de um número, criamos uma vez um determinado formato customizado e o usamos o em todo o projeto, apenas chamando o método.

Já em casos de percorrer uma lista de dados, não importa qual o tipo, usamos os loopings (For, ForEach, While), a fim executar o processamento do mesmo conjunto de códigos até o fim do ciclo.

E existem outros meios de definir uma estrutura de dados, os chamados dicionários de dados e fazer a chamada de métodos customizados ou não, passando parâmetros como referência. No entanto, veremos como declarar parâmetros opcionais, passando ou não o dado, o método é  executado com valores padrão ou não.

Neste módulo, vamos aprender passo a passo os tópicos citados acima, pois são usados praticamente em todos os projetos porque são temas usuais.
### Método de Extensão

O conceito de método de extensão é criar um método customizado para um determinado tipo de dado (int, DateTime, string, etc) e aplicar uma ação. Os tipos primitivos do C# contém todas as possibilidades possíveis de customização, no entanto, de acordo com o tipo de aplicação é normal o desenvolvedor criar seus próprios formatos e funções, a fim de facilitar o uso e ter produtividade. 

Vamos a um exemplo, Adicionamos um novo Solution para este modulo e para o método de extensão é regra obrigatória que a classe (public static class) e os métodos (public static string) sejam estáticos. Criamos a classe MetodoExtensao.cs que possui o método FormatarData,  na declaração deste método dizemos que ele retorna um texto (string) e recebe como entrada um campo do tipo data (DateTime) e o outro do tipo texto (string). Este método receberá uma data e aplicará o formato de acordo com o que o desenvolvedor informar na variável formato.

A variável data está declarada com o THIS, o que significa que pertence a esta classe, ou seja, é dela mesma. E qual o retorno? O retorno do método está após a lambda => no código data.ToString() do C#, o formato que foi passado pelo desenvolvedor na variável formato.

Em seguida, digitamos o método Formatar, que também está declarado como static, retorna uma string, recebe o número do tipo decimal (apenas decimal e não int ou double), aplica o formato pelo ToString() de acordo como formato passado ao método. Isto significa que ora pode ser um formato monetário, somente número com zero ou 2 casas decimais, etc.


```csharp
using System;
using static System.Console;

namespace Modulo_6;

public static class Program
{
    static void Main(string[] args)
    {
        WriteLine(DateTime.Today.FormatarData("dd/MMM/yyyy"));
        WriteLine(DateTime.Today.FormatarData("ddddd dd/MMM/yyyy"));
        WriteLine(DateTime.Today.FormatarData("MMMM yyyy"));
        WriteLine(DateTime.Today.FormatarData("yyyy"));
        decimal valor = 5800.78M;        
        WriteLine(valor.Formatar("R$ ##,##0.00"));            
        WriteLine(4578.87M.Formatar("C2"));
    }
}
public static class MetodosExtensao
{
    // O método de extensão DEVE ser static
    public static string FormatarData(this DateTime data, string formato) => data.ToString(formato);
    public static string Formatar(this decimal valor, string formato) => valor.ToString(formato);
}
```

Agora que temos estes métodos declarados, em qualquer parte do projeto podemos usufruir deste recurso, basta invocarmos o método de extensão. É comum nos times de desenvolvimento criar uma biblioteca de utilitários de formatações, assim quando precisarmos alterar um determinado formato em toda a aplicação, isto é feito apenas uma única vez direto no método de extensão, o qual será replicado em todos os lugares que usamos.
### Parâmetros Opcionais 

Em qualquer linguagem de programação há muitas funções, métodos com diversas quantidades de parâmetros a serem passados. Muitas vezes somos obrigados a passar parâmetros para um método, mesmo que estes não sejam usados para nada, apenas por convenção da escrita de código de quem o criou. Nas primeiras versões do C# e até hoje podemos criar o que chamamos de sobrecarga de método, ou seja, a assinatura do método é a mesma, só que a quantidade de parâmetro é diferente. Por isto que em diversos métodos temos a indicação de 1 de 7, 2 de 7, ou seja, temos 7 opções de chamada.

Sendo assim, foi adicionado ao C# o chamado parâmetro opcional, ou seja, podemos ou não informar o valor. Caso não seja informado, o C# assume um valor padrão.

Adicionemos uma nova classe chamada ParametrosOpcionais.cs. O método Faturamento recebe 3 parâmetros, sendo qtde, preco e bonus. O primeiro (qtde) é obrigatório , já os demais são opcionais. O preco assume o valor de 10, caso não seja informado o valor, assim como o bonus assume o valor de 5.

Existe uma regra para esta declaração: Todos os parâmetros obrigatórios DEVERÃO ser declarados ANTES dos opcionais. Sendo assim , o método Faturamento retorna 

---



 
