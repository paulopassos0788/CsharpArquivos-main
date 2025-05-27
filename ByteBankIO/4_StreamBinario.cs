using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankIO;

internal class _4_StreamBinario
{
    public static void EscritaBinaria()
    {
        using (var fs= new FileStream("contaCorrente.txt", FileMode.Create))
        using (var escritor = new BinaryWriter(fs, Encoding.UTF8))
        {
            escritor.Write(456);
            escritor.Write(7895);
            escritor.Write(4785.40);
            escritor.Write("Gustavo Santos");
        }
    }

    public static void LeituraBinaria()
    {
        using (var fs = new FileStream("contaCorrente.txt", FileMode.Open))
        using (var leitor = new BinaryReader(fs, Encoding.UTF8))
        {
            var agencia = leitor.ReadInt32();
            var numero = leitor.ReadInt32();
            var saldo = leitor.ReadDouble();
            var titular = leitor.ReadString();

            Console.WriteLine($"Agência: {agencia}, Número: {numero}, Saldo: {saldo}, Titular: {titular}");

        }
    }
}
