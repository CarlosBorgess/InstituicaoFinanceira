using ControleContas;

Conta conta = new Conta();

Conta conta1 = new Conta (123456789);
Conta conta2 = new Conta();

Console.WriteLine($"O numero da conta 1 é {conta1.Numero}");
Console.WriteLine($"O numero da conta 2 é {conta2.Numero}");
Console.WriteLine($"O valor do saldo é ${conta2.Saldo} reais");

//Crie um atributo saldo na classe conta cuja a propriedade seja somente leitura 
//Crie um atributo saldo na classe Conta cuja propriedade de teste para testar a classe Conta ele deverá testar um método depositar 