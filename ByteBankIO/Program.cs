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
        _4_StreamBinario.EscritaBinaria();
        _4_StreamBinario.LeituraBinaria();

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