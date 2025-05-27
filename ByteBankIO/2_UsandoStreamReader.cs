using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankIO;

internal class _1_UsandoStreamReader
{
    public static void UsandoStreamReader()
    {
        var enderecoDoArquivo = "contas.txt";

        using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var leitor = new StreamReader(fluxoDeArquivo);

            //var linha = leitor.ReadLine();

            //var texto = leitor.ReadToEnd();
            //var numero = leitor.Read();

            while (!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine();
                var contaCorrente = ConverterStringParaContaCorrente(linha);

                var linhaFormatada = $"Titular: {contaCorrente.Titular} / Agência: {contaCorrente.Agencia} / Número: {contaCorrente.Numero} / " +
                    $"Saldo: {contaCorrente.Saldo} / ";
                Console.WriteLine(linhaFormatada);
            }
        }
    }

    public static ContaCorrente ConverterStringParaContaCorrente(string linha)
    {
        var campos = linha.Split(',');

        var agenciaLinha = campos[0];
        var numeroLinha = campos[1];
        var saldoLinha = campos[2].Replace('.', ','); // Substitui ponto por vírgula para conversão correta
        var titularLinha = campos[3];

        var agencia = int.Parse(agenciaLinha);
        var numero = int.Parse(numeroLinha);
        var saldoComDouble = double.Parse(saldoLinha);

        var titular = new Cliente();
        titular.Nome = titularLinha;

        var resultado = new ContaCorrente(agencia, numero);
        resultado.Depositar(saldoComDouble);
        resultado.Titular = titular;

        return resultado;
    }
}
