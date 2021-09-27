using System;

class Desafio 
{
    static void Main()
    {
        float vx= 60;
        float vy= 90;
        float res= vy-vx;
        int quilometros =Convert.ToInt32(Console.ReadLine());
        float minutos= (quilometros/(vy-vx))*60;
        
        
        Console.WriteLine(minutos + " minutos");
    }
}
