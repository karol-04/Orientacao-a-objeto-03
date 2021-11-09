using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente gerenteDouglas = new Gerente()
            {
                Nome = "Douglas Bonifácio",
                CPF = "111.222.333-44",
                Salario = 15000,
                NumeroAgencias = 3,
            };
            gerenteDouglas.Bonificacao = gerenteDouglas.Salario;

            Vendedor vendedorLuciano = new Vendedor()
            {
                Nome = "Luciano Machado",
                CPF = "222.333.444-55",
                Salario = 5000,
                NumeroClientesAtendidos = 5,
            };
            vendedorLuciano.Bonificacao = vendedorLuciano.Salario;

            Vendedor vendedorNea = new Vendedor()
            {
                Nome = "Néa Bonifacio",
                CPF = "333.444.555-66",
                Salario = 2500,
                NumeroClientesAtendidos = 5,
            };
            vendedorNea.Bonificacao = vendedorNea.Salario;

            Vendedor vendedorLazaro = new Vendedor()
            {
                Nome = "Lazaro Teodoro",
                CPF = "444.555.666-77",
                Salario = 2500,
                NumeroClientesAtendidos = 5,
            };
            vendedorLazaro.Bonificacao = vendedorLazaro.Salario;

            ContaCorrente contaDaKarol = new ContaCorrente("Karolaine Bonifácio Teodoro", "111.222.333-55", 789, 2000, vendedorLazaro);
            ContaCorrente contaDoKaique = new ContaCorrente("Kaique Bonifácio", "111.222.333-66", 987, 1200, vendedorLuciano);
            ContaCorrente contaDaKatlin = new ContaCorrente("Katlin Bonifácio", "111.222.333-77", 988, 1500, vendedorNea);
            
            contaDaKarol.Conta = 890;
            contaDaKatlin.Conta= 980;
            contaDoKaique.Conta= 809;

            Console.WriteLine("Contas correntes: ");
            Console.WriteLine("Conta 1: \nNome: "+contaDaKarol.Nome+
            "\nCPF: "+contaDaKarol.CPF+
            "\nAgência: "+contaDaKarol.Agencia+
            "\nConta: "+contaDaKarol.Conta+
            "\nSaldo: "+contaDaKarol.Saldo);

            Console.WriteLine("\nConta 2: \nNome: "+contaDaKatlin.Nome+
            "\nCPF: "+contaDaKatlin.CPF+
            "\nAgência: "+contaDaKatlin.Agencia+
            "\nConta: "+contaDaKatlin.Conta+
            "\nSaldo: "+contaDaKatlin.Saldo);

            Console.WriteLine("\nConta 3: \nNome: "+contaDoKaique.Nome+
            "\nCPF: "+contaDoKaique.CPF+
            "\nAgência: "+contaDoKaique.Agencia+
            "\nConta: "+contaDoKaique.Conta+
            "\nSaldo: "+contaDoKaique.Saldo);

            Console.WriteLine("\nFuncionários: ");
            Console.WriteLine("Vendedor 1: \nNome: "+vendedorLuciano.Nome+
            "\nCPF: "+vendedorLuciano.CPF+
            "\nSalário: "+vendedorLuciano.Salario+
            "\nNúmero de clientes atendidos: "+vendedorLuciano.NumeroClientesAtendidos+
            "\nComissão: "+vendedorLuciano.Comissao+
            "\nBonificação anual: "+vendedorLuciano.Bonificacao+
            "\nRemuneração total: "+vendedorLuciano.RemuneracaoTotal(vendedorLuciano.Salario, vendedorLuciano.Bonificacao)+
            "\nDias de férias: "+vendedorLuciano.CalcularFerias());

            Console.WriteLine("\nVendedor 2: \nNome: "+vendedorNea.Nome+
            "\nCPF: "+vendedorNea.CPF+
            "\nSalário: "+vendedorNea.Salario+
            "\nNúmero de clientes atendidos: "+vendedorNea.NumeroClientesAtendidos+
            "\nComissão: "+vendedorNea.Comissao+
            "\nBonificação anual: "+vendedorNea.Bonificacao+
            "\nRemuneração total: "+vendedorNea.RemuneracaoTotal(vendedorNea.Salario, vendedorNea.Bonificacao)+
            "\nDias de férias: "+vendedorNea.CalcularFerias());

            Console.WriteLine("\nVendedor 3: \nNome: "+vendedorLazaro.Nome+
            "\nCPF: "+vendedorLazaro.CPF+
            "\nSalário: "+vendedorLazaro.Salario+
            "\nNúmero de clientes atendidos: "+vendedorLazaro.NumeroClientesAtendidos+
            "\nComissão: "+vendedorLazaro.Comissao+
            "\nBonificação anual: "+vendedorLazaro.Bonificacao+
            "\nRemuneração total: "+vendedorLazaro.RemuneracaoTotal(vendedorLazaro.Salario, vendedorLazaro.Bonificacao)+
            "\nDias de férias: "+vendedorLazaro.CalcularFerias());

            Console.WriteLine("\nGerente: \nNome: "+gerenteDouglas.Nome+
            "\nCPF: "+gerenteDouglas.CPF+
            "\nSalário: "+gerenteDouglas.Salario+
            "\nNúmero de agências: "+gerenteDouglas.NumeroAgencias+
            "\nBonificação anual: "+gerenteDouglas.Bonificacao+
            "\nRemuneração total: "+gerenteDouglas.RemuneracaoTotal(gerenteDouglas.Salario, gerenteDouglas.Bonificacao)+
            "\nDias de férias: "+gerenteDouglas.CalcularFerias());

            Console.WriteLine("\nTotal de contas criadas: "+ContaCorrente.TotalContas);
        }
    }
}