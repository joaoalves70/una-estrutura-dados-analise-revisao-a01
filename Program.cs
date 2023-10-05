using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Informe o seu nome:");
        string nome = Console.ReadLine();

        Console.WriteLine("Informe a sua idade:");
        int idade = int.Parse(Console.ReadLine());

        int probabilidade = 0;

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("Seu cartão de vacina está em dia? (SIM/NAO)");
            string resposta = Console.ReadLine().ToUpper();

            if (resposta == "NAO")
            {
                probabilidade += 10;
                break;
            }
            else if (resposta == "SIM")
            {
                probabilidade += 0;
                break;
            }
            else
            {
                Console.WriteLine("Resposta inválida. Por favor, tente novamente.");
            }
        }

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("Teve algum destes sintomas recentemente? (dor de cabeça, febre, náusea, dor articular, gripe ) (SIM/NAO)");
            string resposta = Console.ReadLine().ToUpper();

            if (resposta == "SIM")
            {
                probabilidade += 30;
                break;
            }
            else if (resposta == "NAO")
            {
                probabilidade += 0;
                break;
            }
            else
            {
                Console.WriteLine("Resposta inválida. Por favor, tente novamente.");
            }
        }

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("Teve contato com pessoas com sintomas gripais nos últimos dias? (SIM/NAO)");
            string resposta = Console.ReadLine().ToUpper();

            if (resposta == "SIM")
            {
                probabilidade += 30;
                break;
            }
            else if (resposta == "NAO")
            {
                probabilidade += 0;
                break;
            }
            else
            {
                Console.WriteLine("Resposta inválida. Por favor, tente novamente.");
            }
        }

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("Está retornando de viagem realizada no exterior? (SIM/NAO)");
            string resposta = Console.ReadLine().ToUpper();

            if (resposta == "SIM")
            {
                probabilidade += 30;
                break;
            }
            else if (resposta == "NAO")
            {
                probabilidade += 0;
                break;
            }
            else
            {
                Console.WriteLine("Resposta inválida. Por favor, tente novamente.");
            }
        }

        string orientacao;
        if (probabilidade <= 30)
        {
            orientacao = "Paciente sob observação. Caso apareça algum sintoma, gentileza buscar assistência médica.";
        }
        else if (probabilidade <= 60)
        {
            orientacao = "Paciente com risco de estar infectado. Gentileza aguardar em lockdown por 02 dias para ser acompanhado.";
        }
        else if (probabilidade <= 89)
        {
            orientacao = "Paciente com alto risco de estar infectado. Gentileza aguardar em lockdown por 05 dias para ser acompanhado.";
        }
        else
        {
            orientacao = "Paciente crítico! Gentileza aguardar em lockdown por 10 dias para ser acompanhado.";
        }

        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Cartão de vacina em dia: " + (probabilidade <= 30 ? "SIM" : "NAO"));
        Console.WriteLine("Teve sintomas recentemente: " + (probabilidade <= 30 ? "NAO" : "SIM"));
        Console.WriteLine("Teve contato com pessoas com sintomas gripais nos últimos dias: " + (probabilidade <= 30 ? "NAO" : "SIM"));
        Console.WriteLine("Retornando de viagem: " + (probabilidade <= 30 ? "NAO" : "SIM"));
        Console.WriteLine("probabilidade de infecção: " + probabilidade + "%");
        Console.WriteLine(orientacao);

        Console.ReadLine();
    }
}