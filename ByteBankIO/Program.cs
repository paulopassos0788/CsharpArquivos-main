using ByteBankIO;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
   static void Main(string[] args)
   {
        //_3_CriandoArquivo.CriandoArquivo();
        //_3_CriandoArquivo.CriarArquivoComWrite();
        //_3_CriandoArquivo.TestaEscrita();
        //_4_StreamBinario.EscritaBinaria();
        //_4_StreamBinario.LeituraBinaria();
        //_5_UsandoStreamDaConsole.UsarStreamDaConsole();

        var linhas = File.ReadAllLines("contas.txt");
        Console.WriteLine(linhas.Length);

        //foreach (var linha in linhas)
        //{
        //    Console.WriteLine(linha);
        //}

        var bytesArquivo = File.ReadAllBytes("contas.txt");
        Console.WriteLine($"Arquivo contas.txt possui {bytesArquivo.Length} bytes");

        File.WriteAllText("escrevendoComClasseFile.txt", "Testando File.WriteAllText");

        //var caminhoNovoArquivo = "TestaEscrita.txt";

        //using (var fluxoDoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        //using (var escritor = new StreamWriter(fluxoDoArquivo))
        //{
        //    escritor.WriteLine(true);
        //    escritor.WriteLine(false);
        //    escritor.WriteLine(4567890321);
        //}

        //Console.WriteLine("Aplicação finalizada...");

        Console.ReadLine();
   }
}