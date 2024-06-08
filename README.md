# ehPar

Claro, vou descrever partes específicas do código como exemplo:

1. **Declaração e inicialização de variáveis:**
```csharp
int numero = 15;
bool ehPar = false;
```
   - Aqui, declaramos duas variáveis: "numero" do tipo inteiro e "ehPar" do tipo booleano. 
   - A variável "numero" é inicializada com o valor 15.
   - A variável "ehPar" é inicializada como falso (false).

2. **Uso do operador ternário (comentado):**
```csharp
// ehPar = numero % 2 == 0;
// Console.WriteLine($"O numero {numero} é " + (ehPar ? "par" : "impar"));
```
   - Este trecho de código mostra um exemplo de uso do operador ternário.
   - Ele verifica se o resto da divisão de "numero" por 2 é igual a zero.
   - Dependendo do resultado dessa verificação, uma mensagem diferente é exibida.

3. **Estrutura condicional "if" para determinar paridade:**
```csharp
if (numero % 2 == 0)
{
    Console.WriteLine($"O numero {numero} é par");
}
else
{
    Console.WriteLine($"O numero {numero} é impar");
}
```
   - Este trecho demonstra o uso da estrutura condicional "if-else" para determinar se o número é par ou ímpar.
   - Ele verifica se o resto da divisão de "numero" por 2 é igual a zero.
   - Se for igual a zero, exibe uma mensagem indicando que o número é par.
   - Caso contrário, exibe uma mensagem indicando que o número é ímpar.

Essas partes ilustram diferentes aspectos do código, desde declaração e inicialização de variáveis até o uso de estruturas de controle de fluxo para tomada de decisões.
