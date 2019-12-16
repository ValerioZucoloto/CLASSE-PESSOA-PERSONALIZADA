using System;

class MainClass {
  public static void Main (string[] args) {

    Pessoa Maria = new Pessoa("Maria", 35, 85.5, 1.75, 1995);
    Pessoa Joao = new Pessoa("João", 40, 75, 1.48, 1998);
    Console.WriteLine();

    //Retorna o IMC
    Console.WriteLine("IMC = " + Maria.IMC());
    Console.WriteLine();

    //Retorna a pessoa mais velha
    Console.WriteLine(Joao.MaisVelha(Maria));
    Console.WriteLine();

    //Diferença entre dias
    Console.WriteLine("Diferença em Dias: " + Joao.Diferenca(Maria));
    Console.WriteLine();

    //Retorna nome do pai e da mãe
    Maria.PaiMae("Josè", "Luiza");
    
    
  }
}