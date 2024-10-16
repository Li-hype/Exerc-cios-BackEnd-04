using Atividade07;

ContaCorrente conta1 = new ContaCorrente
{
    Banco = "Bradesco",
    Agencia = "Brotas",
    Conta = "Corrente",
    Saldo = "3000",
    limite = "1700",
};
Console.WriteLine($"Seu banco é: {conta1.Banco}, sua agencia é: {conta1.Agencia}, sua conta é: {conta1.Conta}, " +
    $"seu saldo é de: {conta1.Saldo}, seu limite é de: {conta1.limite}.");


ContaCorrente conta2 = new ContaCorrente
{
    Banco = "Caixa",
    Agencia = "Brotas",
    Conta = "Corrente",
    Saldo = "6000",
    limite = "1900",
};
Console.WriteLine($"Seu banco é: {conta2.Banco}, sua agencia é: {conta2.Agencia}, sua conta é: {conta2.Conta}, " +
    $"seu saldo é de: {conta2.Saldo}, seu limite é de: {conta2.limite}.");

ContaCorrente conta3 = new ContaCorrente
{
    Banco = "Santander",
    Agencia = "Brotas",
    Conta = "Corrente",
    Saldo = "8500",
    limite = "2500",
};
Console.WriteLine($"Seu banco é: {conta3.Banco}, sua agencia é: {conta3.Agencia}, sua conta é: {conta3.Conta}, " +
    $"seu saldo é de: {conta3.Saldo}, seu limite é de: {conta3.limite}.");
Console.ReadKey();