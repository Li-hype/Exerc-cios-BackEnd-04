using Atividade05;

//Instanciando aclasse Funcionário
Funcionario func1 = new Funcionario { Nome = "Lívia", Idade = 17 };
Funcionario func2 = new Funcionario { Nome = "Lívia", Idade = 17 };

//Chamando o método Envelhecer
func1.Envelhecer(12); //Somar a idade que você passou para a variável mais 12

Console.WriteLine($"Nome {func1.Nome}, sua idade somada + 12: {func1.Idade}");

//Chamando o método Rejuvelhecer
func2.Rejuvelhecer(12); //Somar a idade que você passou para a variável menos 12 

Console.WriteLine($"Nome {func2.Nome}, sua idade subtraída - 12 é: {func2.Idade}\n");



//Instanciando aclasse Funcionário
Funcionario func3 = new Funcionario { Nome = "Fernanda ", Idade = 19 };
Funcionario func4 = new Funcionario { Nome = "Fernanda", Idade = 19 };

//Chamando o método Envelhecer
func3.Envelhecer(10); //Somar a idade que você passou para a variável mais 12

Console.WriteLine($"Nome {func3.Nome}, sua idade somada + 10 é: {func3.Idade}");

//Chamando o método Rejuvelhecer
func4.Rejuvelhecer(10); //Somar a idade que você passou para a variável menos 12 

Console.WriteLine($"Nome {func4.Nome}, sua idade subtraída - 10 é: {func4.Idade}\n");



//Instanciando aclasse Funcionário
Funcionario func5 = new Funcionario { Nome = "Rafaela ", Idade = 23 };
Funcionario func6 = new Funcionario { Nome = "Rafaela", Idade = 23 };

//Chamando o método Envelhecer
func5.Envelhecer(5); //Somar a idade que você passou para a variável mais 12

Console.WriteLine($"Nome {func5.Nome}, sua idade somada + 5 é: {func5.Idade}");

//Chamando o método Rejuvelhecer
func6.Rejuvelhecer(10); //Somar a idade que você passou para a variável menos 12 

Console.WriteLine($"Nome {func6.Nome}, sua idade subtraída - 5 é: {func6.Idade}");



//Encerrar o programa
Console.WriteLine("Pressione qualquer  tecla para sair");
Console.ReadLine();

