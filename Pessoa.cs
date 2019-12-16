using System;

class Pessoa{

  private string nome;
  private int idade;
  private double altura;
  private double peso;
  private int dataNascimento;
  private Pessoa pai;
  private Pessoa mae;


  //Construtor
  public Pessoa(string nome, int idade, double peso, double altura, int dataNascimento){
    this.nome = nome;
    this.idade = idade;
    this.altura = altura;
    this.peso = peso;
    this.dataNascimento = dataNascimento;
  }

  //Metodo Pai e Mae
  public void PaiMae(string pai, string mae){
    Console.WriteLine("Filho: " + nome + "\n" + "Nome do Pai: " + pai + "\n" + "Nome da Mãe: " + mae);
  }


  //Metodo Diferenca
  public int Diferenca(Pessoa outra){
    int resultado = ((this.idade * 365) - (outra.idade * 365));
    return resultado;
  } 

  //Pessoa Mais Velha
  public bool MaisVelha(Pessoa outra){
    if(this.idade > outra.idade){
      return true;
    }else{
      return false;
    }
  }


  //Metodo IMC
  public double IMC(){
  double resultado = peso / (altura * altura);
  return resultado;
}

  //Get e Set
  public string GetNome(){
    return nome;
  }

  public string SetNome(string n){
    return nome = n;
  }

}