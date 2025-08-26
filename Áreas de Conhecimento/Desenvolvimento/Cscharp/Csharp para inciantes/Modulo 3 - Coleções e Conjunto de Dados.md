
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

Paralelamente, se não quisermos informar o tipo ()
 

---



 
