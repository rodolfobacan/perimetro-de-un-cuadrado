using System;

class Program {
  static double lado(double a){
      double perimetro;
      if(a<=0){
        Console.WriteLine("Error, no puede ser un numero negativo");
        perimetro = 0;
      }
      else{
        perimetro=4*a;
      }
      return perimetro;
    }

  public static void Main (string[] args) {
    double ladoA, Perimetros;
    Console.WriteLine ("ingrese ladoA");
    ladoA= double.Parse(Console.ReadLine());
    Perimetros= lado(ladoA);

    Console.WriteLine("el valor del perimetro es: " + Perimetros);

    
  }
}