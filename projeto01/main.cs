using System;

class Program {
  public static void Main(){
    Console.WriteLine("bem vindo animal");
    // id e descricao do pet, primeira cçlasse especie
    Especie e1 = new Especie(1, "Cachorro");
    Especie e2 = new Especie(2, "Gato");

    // classe pet
    Pet p1 = new Pet(1, "Dog1", "Raca1", DateTime.Parse("01/01/2015"), 1);
    Pet p2 = new Pet(2, "Dog2", "Raca1", DateTime.Parse("01/01/2016"), 1);

      //especie
    Console.WriteLine(e1);
    Console.WriteLine(e2);
    // petzinho
    Console.WriteLine(p1);
    Console.WriteLine(p2);
    }
}