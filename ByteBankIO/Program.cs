using ByteBankIO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        var endereco = "contas.txt";
        var numeroBytesLidos = -1;
        var fluxoDoArquivo = new FileStream(endereco, FileMode.Open);
        var buffer = new byte[1024];

        numeroBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
      
        while (numeroBytesLidos > 0)
        {
            EscreverBuffer(buffer);
            numeroBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
        }

        Console.ReadLine();
    }

    static void EscreverBuffer(byte[] buffer)
    {
        var utfe8 = new UTF8Encoding();

        var texto = utfe8.GetString(buffer);
        Console.Write(texto);

        //foreach (var meuByte in buffer) 
        //{
        //    Console.Write(meuByte);
        //    Console.Write(" ");
        //}
    }
}