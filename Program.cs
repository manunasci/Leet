using System;

namespace Leet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu texto para se cliptografado");
            string textoCliptografado = Console.ReadLine();
            Console.WriteLine(textoCliptografado.Replace("A","9")
                                                .Replace("a","9")
                                                .Replace("B","W")
                                                .Replace("b","w")
                                                .Replace("C","Z")
                                                .Replace("c","z")
                                                .Replace("D","Y")
                                                .Replace("d","y")
                                                .Replace("E","8")
                                                .Replace("e","8")
                                                .Replace("F","X")
                                                .Replace("f","x")
                                                .Replace("G","V")
                                                .Replace("g","v")
                                                .Replace("H","T")
                                                .Replace("h","t")
                                                .Replace("I","7")
                                                .Replace("i","7")
                                                .Replace("J","S")
                                                .Replace("j","s")
                                                .Replace("K","R")
                                                .Replace("k","r")
                                                .Replace("L","Q")
                                                .Replace("l","q")
                                                .Replace("M","P")
                                                .Replace("m","p")
                                                .Replace("N","4")
                                                .Replace("n","4")
                                                .Replace("O","6")
                                                .Replace("o","6")
                                                .Replace("P","N")
                                                .Replace("p","n")
                                                .Replace("Q","M")
                                                .Replace("q","m")
                                                .Replace("R","L")
                                                .Replace("r","l")
                                                .Replace("S","K")
                                                .Replace("s","k")
                                                .Replace("T","J")
                                                .Replace("t","j")
                                                .Replace("U","5")
                                                .Replace("u","5")
                                                .Replace("V","H")
                                                .Replace("v","h")
                                                .Replace("X","G")
                                                .Replace("x","g")
                                                .Replace("W","F")
                                                .Replace("w","f")
                                                .Replace("Y","D")
                                                .Replace("y","d")
                                                .Replace("Z","C")
                                                .Replace("z","c"));     
        }
    }
}
