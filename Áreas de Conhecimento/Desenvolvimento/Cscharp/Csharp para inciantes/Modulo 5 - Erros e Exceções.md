
---
*📅 **created: 28-08-2025 / 12:48**
🏷️ **tags: []**
**⌛ status: draft**
## 📋 Resumo

> Breve descrição do conteúdo

## 📚 [[CSharpIniciantes.pdf#page=127&selection=0,14,0,35&color=yellow|Tratamento de Exceções]]

Uma exceção é um erro causado por alguma operação dentro do software, como por exemplo, falha em ler um arquivo do disco, falha em se conectar a um banco de dados, uma variável sem um valor adequado, entre muitos outros.  importante neste caso é tratarmos o erro de maneira que o usuário da aplicação receba alguma informação que faça sentido para ele.

Outro aspecto no tratamento de exceções é relativo á segurança da aplicação, pois se deixarmos um erro aparecer "em sua forma bruta" para o usuário, podemos estar expondo dados sensíveis da nossa aplicação, como banco de dados que usamos, tecnologia, linguagem, além de outros dados que podem ser utilizados sem o nosso conhecimento.

Para entendermos os erros e como trata-los de maneira correta, iremos explorar o mecanismo de tratamento de exceções da linguagem C#.
### O que é um erro ?

Um erro é um comportamento que pode paralisar nossa aplicação, seu fluxo normal de execução, então, quando um erro acontece, podemos chama-lo de "exceção", pois é algo que não planejamos , e claro, não planejamos erros em nossa aplicação, mas precisamos planejar o que fazer como eles caso aconteçam.

Alguns exemplos comuns de erros:

-  Banco de dados indisponível: por algum erro de rede ou alto nível de                  processamento, nossa aplicação não consegue acessar o banco de dados.
-  Dados Nulos: chamamos uma função externa e o valor retornado é um nulo e    não  o que deveria voltar de fato.
-  Erros Matemáticos: um erro bem comum nesta área é o erro e divisão por zero.

E assim podemos listar aqui centenas de tipos de erros que podem acontecer na aplicação.
### Sempre teremos erro em nossa aplicação?

Nós não criamos uma aplicação para ela conter erros, mas eles podem acontecer, e como um bom desenvolvedor, precisamos tratar esses erros, evitando problemas maiores na aplicação. Além disso, existem recursos que consumimos em uma aplicação que estão fora o nosso controle, por exemplo, dados acessados pela internet, um serviço de banco de dados externo, uma API, ou seja, temos muitos pontos em uma aplicação que realmente podem falhar e nossa missão é tratar tudo isto da melhor maneira possível.

### Como tratamos um erro?

Já entendemos que erros podem acontecer e que precisamos tratá-los, o que precisamos agora é saber a melhor maneira de fazer isto e principalmente, identificar pontos de falha em nosso código que possam gerar um problema.

Para iniciarmos com os estudos de tratamento de erros, vamos acompanhar o código a seguir que se trata de uma divisão de dois números.

```csharp
namespace Modulo_5
{
     class ProgramaPrincipal
    {
        static void Main(string[] args)
        {
            TratamentoExcecao tratamentoExcecao = new TratamentoExcecao();
            tratamentoExcecao.ExemploTratamentoExcecao();
        }
    }
    public class TratamentoExcecao
    {
        public void ExemploTratamentoExcecao()
        {
            Console.WriteLine("Divisão de dois números");
            Console.WriteLine();
            Console.Write("Digite o Primeiro número: ");
            var strNum1 = Console.ReadLine();
            Console.Write("Digite o Segundo número: ");
            var strNum2 = Console.ReadLine();
            int num1 = int.Parse(strNum1);
            int num2 = int.Parse(strNum2);
            var divisao = num1 / num2;
            Console.WriteLine($"A divisão de {num1} por {num2} é {divisao}");
            Console.WriteLine("FIM");
        }
    }
}
```

Vamos entender o código: Pegamos o primeiro e o segundo número e guardamos em duas variáveis chamadas de num1 e num2. Como a função Console.ReadKey() retorna apenas uma string, precisamos converter num1 e num2 para int, então usamos a função int.Parse() que converte uma string para um int. Finalmente pegamos os dois valores e agora como inteiros e fazemos a divisão.

Primeiro vamos fazer o que chamamos de "caminho feliz", ou seja, vamos usar a nossa aplicação como ela foi criada, informando os valores corretamente: 

```
Resultado:
Divisão de dois números

Digite o Primeiro número: 10
Digite o Segundo número: 2
A divisão de 10 por 2 é 5
FIM
```

A pergunta aqui é o que poderia dar errado neste código tão simples? E a resposta é: muitas coisas, vamos lá: o usuário não digitou nada no campo dos números, o que provoca um erro na conversão para int. Isso resulta nesta mensagem de erro:

```
Divisão de dois números

Digite o Primeiro número:
Digite o Segundo número:
Unhandled exception. System.FormatException: The input string '' was not in a correct format.
   at System.Number.ThrowFormatException[TChar](ReadOnlySpan`1 value)
   at System.Int32.Parse(String s)
   at Modulo_5.TratamentoExcecao.ExemploTratamentoExcecao() in B:\Knolage_Base\Codigos\CsharpParaInciantes\Modulo 5\Program.cs:line 21
   at Modulo_5.ProgramaPrincipal.Main(String[] args) in B:\Knolage_Base\Codigos\CsharpParaInciantes\Modulo 5\Program.cs:line 8
```

Agora o usuário digita um valor inválido no campo:

```
Divisão de dois números

Digite o Primeiro número: 0
Digite o Segundo número: 0
Unhandled exception. System.DivideByZeroException: Attempted to divide by zero.
   at Modulo_5.TratamentoExcecao.ExemploTratamentoExcecao() in B:\Knolage_Base\Codigos\CsharpParaInciantes\Modulo 5\Program.cs:line 23
   at Modulo_5.ProgramaPrincipal.Main(String[] args) in B:\Knolage_Base\Codigos\CsharpParaInciantes\Modulo 5\Program.cs:line 8
```

Em nenhum dos dois exemplos, a palavra "FIM" foi impressa na tela, pois ela estava depois da conta de dividir, onde o erro foi provocado, Então o erro interrompeu o fluxo da nossa aplicação. O que precisamos fazer é tratar o erro e seguir com a execução da aplicação, então vamos incluir no nosso exemplo um tratamento de exceção:

```csharp
namespace Modulo_5
{
     class ProgramaPrincipal
    {
        static void Main(string[] args)
        {
            TratamentoExcecao tratamentoExcecao = new TratamentoExcecao();
            tratamentoExcecao.ExemploTratamentoExcecao();
        }
    }
    public class TratamentoExcecao
    {
        public void ExemploTratamentoExcecao()
        {
            Console.WriteLine("Divisão de dois números");
            Console.WriteLine();
            Console.Write("Digite o Primeiro número: ");
            var strNum1 = Console.ReadLine();
            Console.Write("Digite o Segundo número: ");
            var strNum2 = Console.ReadLine();
            try
            {
                int num1 = int.Parse(strNum1);
                int num2 = int.Parse(strNum2);
                var divisao = num1 / num2;
                Console.WriteLine($"A divisão de {num1} por {num2} é {divisao}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro na divisão:{ex.Message}");
            }
            Console.WriteLine("FIM");
        }
    }
}
```

Quem resolve o problema do tratamento de exceção no C# é o bloco try...catch...finaly. Este bloco é o responsável por tratar qualquer exceção que ocorra dentro do try, pegando o erro no catch, e em alguns casos, excetuando código no finally.

Então o código que queremos proteger fica dentro do bloco try, que no nosso exemplo é a conversão do dado e a divisão. Se acontecer algum erro dentro do try, então o bloco catch é chamado, e no nosso caso, mostramos uma mensagem que recebemos de erro. O nosso exemplo não tem finally, mas iremos explorar este bloco depois. Vejamos como ficou o resultado no caso do usuário não ter passado nenhum valor:

```
Divisão de dois números

Digite o Primeiro número:
Digite o Segundo número:
Erro na divisão:The input string '' was not in a correct format.
FIM
```

E agora em caso de divisão por zero:

```
Divisão de dois números

Digite o Primeiro número: 0
Digite o Segundo número: 0
Erro na divisão:Attempted to divide by zero.
FIM
```

Agora temos uma mensagem de erro mais simples e também temos a palavra "FIM" sendo mostrada nos dois casos.

O bloco try...catch...finally é muito útil mas não deve ser utilizado em toda a nossa aplicação, ou seja, não comecemos o código com um try, coloquemos o bloco onde realmente precisemos. E isto só iremos aprender com o uso da linguagem e a construção de aplicações, Mas vamos ver um exemplo de como não usar um bloco try:

```csharp
try
{
    int a = 1;
    int b = 0;
    int c = a / b;
}
catch
{

}
```

Este código provoca um erro que pode nunca ser encontrado, pois o catch não mostra nada, absolutamente nada; Se não temos certeza do que escrever no catch, usamos o comando throw:

```csharp
try
{
    int a = 1;
    int b = 0;
    int c = a / b;
}
catch
{
	throw;
}
```

O throw joga a exceção para quem chamou o código.
### Tratando erros específicos com try...catch

Vimos como tratar um erro dentro no nosso código C#, mas até agora estamos tratando este erro de maneira genérica, através da classe Exception, mas o C# tem uma hierarquia de tratamento de erros, que vai do mais específico para o mais genérico.

Isso pode ter parecido um pouco estranho, então vamos explicar usando o código do nosso exemplo anterior, mas incrementando o tratamento de erros:

```csharp
public class TratamentoExcecao
{
    public void ExemploTratamentoExcecao()
    {
        Console.WriteLine("Divisão de dois números");
        Console.WriteLine();
        Console.Write("Digite o Primeiro número: ");
        var strNum1 = Console.ReadLine();
        Console.Write("Digite o Segundo número: ");
        var strNum2 = Console.ReadLine();
        try
        {
            int num1 = int.Parse(strNum1);
            int num2 = int.Parse(strNum2);
            var divisao = num1 / num2;
            Console.WriteLine($"A divisão de {num1} por {num2} é {divisao}");
        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine($"Erro de divisão por zero: {ex.Message}");
        }
        catch(FormatException ex)
        {
            Console.WriteLine($"Erro de Formatação: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro na divisão:{ex.Message}");
        }
        Console.WriteLine("FIM");
    }
}
```

Agora temos três blocos catch, onde o primeiro trata erro de divisão por zero, o segundo trata erro de formato e o ultimo trata qualquer erro que não foi tratado pelos anteriores. Então é bem simples, vamos tratar os erros do mais específico para o mais genérico.

Mas qual a vantagem disto? A vantagem é que usando uma classe específica podemos pegar mais detalhes dos erros. Se executarmos novamente o código dos exemplos anteriores teremos o resultado a seguir:

```
Divisão de dois números

Digite o Primeiro número:
Digite o Segundo número:
Erro de Formatação: The input string '' was not in a correct format.
FIM
```

Temos a mensagem  "Erro de Formatação" pois o erro foi provocado por um dado inserido incorretamente e que não pode ser convertido.

```
Divisão de dois números

Digite o Primeiro número: 0
Digite o Segundo número: 0
Erro de divisão por zero: Attempted to divide by zero.
FIM
```

E agora temos uma mensagem específica de divisão por Zero.

### O comando finally

Agora que já entendemos o try...catch, vou adicionar o segmento finally, que sempre é executado, independente do que ocorra no try ou no catch. Vamos ver no código a seguir:

```csharp
public class TratamentoExcecao
{
    public void ExemploTratamentoExcecao()
    {
        Console.WriteLine("Divisão de dois números");
        Console.WriteLine();
        Console.Write("Digite o Primeiro número: ");
        var strNum1 = Console.ReadLine();
        Console.Write("Digite o Segundo número: ");
        var strNum2 = Console.ReadLine();
        try
        {
            int num1 = int.Parse(strNum1);
            int num2 = int.Parse(strNum2);
            var divisao = num1 / num2;
            Console.WriteLine($"A divisão de {num1} por {num2} é {divisao}");
        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine($"Erro de divisão por zero: {ex.Message}");
        }
        catch(FormatException ex)
        {
            Console.WriteLine($"Erro de Formatação: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro na divisão:{ex.Message}");
        }
        finally
        {
            Console.WriteLine("Sempre vai excecutar o Finally");
        }
        Console.WriteLine("FIM");
    }
}
```

```
Divisão de dois números

Digite o Primeiro número: 10
Digite o Segundo número: 5
A divisão de 10 por 5 é 2
Sempre vai excecutar o Finally
FIM
```

O tratamento de erros, de maneira correta, é extremamente importante para uma aplicação. Não devemos deixar erros sem sentido na tela do usuário, sempre mostrar informações que fazem sentido e orientem para o correto uso da aplicação.

---



 
