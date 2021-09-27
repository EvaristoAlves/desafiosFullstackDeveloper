using System; 

class ValorVetor
{

    static void Main(string[] args) 
    { 

            int valorLido = int.Parse(Console.ReadLine());
            int[] N = new int[10];
            N[0] = valorLido;
            Console.WriteLine("N["+ 0 +"] = " + N[0]);
            for (int i = 1; i < 10; i ++)
            {
              N[i] = N[i-1]*2; 
              Console.WriteLine( "N["+ i +"] = " + N[i]);
              
            }
          

    }

}