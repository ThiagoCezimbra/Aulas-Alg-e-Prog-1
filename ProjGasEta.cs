using System;

class Program {
  public static void Main (string[] args) {
  var reiniciar = true;
  double gas1;
  double eta1;
  double res1;
  double den1;
    string resa;
  den1 = (0.7);
  while(reiniciar){
    Console.WriteLine ("Olá! Digite o valor da gasolina.");
  gas1 = double.Parse(Console.ReadLine());
    Console.WriteLine ("Digite o valor do etanol");
  eta1 = double.Parse(Console.ReadLine());
  res1 = (eta1/gas1);
    if( den1<res1 ){
      Console.WriteLine("Melhor abastecer com gasolina");
    }
    if(den1>res1){
      Console.WriteLine("Melhor abastecer com etanol");
    }
    if(den1==res1){
      Console.WriteLine("Tanto faz abastecer com gasolina ou etanol");
    }
    Console.WriteLine("Deseja fazer novo calculo?");
    Console.WriteLine("S/N");
    if(Console.ReadLine()=="N")
       {      
      Console.WriteLine("Obrigado por usar o programa!");
      reiniciar = false;
    }
    else{
      Console.WriteLine ("Reinicializando...");
    }
    }
}
}