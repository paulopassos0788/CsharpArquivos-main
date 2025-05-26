using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankIO;

internal class _1_LidandoComFileStreamDiretamente
{
    public static void LidandoComFileStreamDiretamente()
    {
        var endereco = "contas.txt";

        using (var fluxoDoArquivo = new FileStream(endereco, FileMode.Open))
        {
            var numeroBytesLidos = -1;

            var buffer = new byte[1024];

            numeroBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);

            while (numeroBytesLidos != 0)
            {
                numeroBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                Console.WriteLine($"Bytes lidos: {numeroBytesLidos}");
                EscreverBuffer(buffer, numeroBytesLidos);
            }

            Console.ReadLine();
        }

    }

    private static void EscreverBuffer(byte[] buffer, int bytesLidos)
    {
        var utfe8 = new UTF8Encoding();

        var texto = utfe8.GetString(buffer, 0, bytesLidos);
        Console.Write(texto);

        //foreach (var meuByte in buffer) 
        //{
        //    Console.Write(meuByte);
        //    Console.Write(" ");
        //}
    }
}
