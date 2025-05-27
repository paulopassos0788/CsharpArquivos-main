using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankIO;

internal class _5_UsandoStreamDaConsole
{
    public static void UsarStreamDaConsole() 
    {
        using (var fluxoDeEntrada = Console.OpenStandardInput(1024))
        using (var fs = new FileStream("entradaConsole.txt", FileMode.Create))
        {
            var buffer = new byte[1024];

            while (true)
            {
                var bytesLidos = fluxoDeEntrada.Read(buffer, 0, 1024);
                fs.Write(buffer, 0, bytesLidos);
                fs.Flush(); // Garante que os dados sejam gravados no arquivo imediatamente

                Console.WriteLine($"Bytes lidos: {bytesLidos}");
            }
        }
        
    }
}
