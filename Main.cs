using System;

class MainClass {

public static void Main (string[] args)
{
  string[] notasFaDoSol = new string[]{"Sol", "Ré", "Lá", "Mi", "Si", "Fá#", "Dó#"};
  int[] numDeAcidentes = new int[]{1,2,3,4,5,6,7};
  string[] notasSiMila = new string[]{"Fá", "Sib", "Mib", "Láb", "Réb", "Solb", "Dób"};
  int aleatorio;
  int meuNumero = 1;

  while(meuNumero != 0)
  {
    aleatorio = RandomNumber(0,2);
    if(aleatorio == 0)
    {
      aleatorio = RandomNumber(0,7);
      Console.WriteLine("Quantos sustenidos tem a escala maior de " + notasFaDoSol[aleatorio] + "?");
    }
    else
    {
      aleatorio = RandomNumber(0,7);
      Console.WriteLine("Quantos bemois tem a escala maior de " + notasSiMila[aleatorio] + "?");
    }
    meuNumero = Convert.ToInt32(Console.ReadLine());

    if(numDeAcidentes[aleatorio] == meuNumero)
      Console.WriteLine("Acertou!");
    else if(meuNumero == 0)
      Console.WriteLine("Volte sempre!");
    else
      Console.WriteLine("Errou, tente outra vez");

  }

}

  private static int RandomNumber(int min, int max) 
  {
    Random random = new Random();
    return random.Next(min, max);
  }

}
