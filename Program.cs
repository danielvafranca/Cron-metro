
using System.Threading;
using Microsoft.VisualBasic;
Menu(); 

static void Start(int time)
{
    
    int currentTime = 0;

    while(currentTime != time)
    {
        Console.Clear();
        currentTime ++;
        Console.WriteLine(currentTime); 
        Thread.Sleep(1000);

    }
    Console.Clear();
    Console.WriteLine("Tempo Finalizado."); 
    Thread.Sleep(2500); 
}

static void Menu()

{
    Console.Clear();
    Console.WriteLine("[S] - SEGUNDOS\n[M] - MINUTOS\n[0] - SAIR");
    Console.WriteLine("MANUAL:\n \nEXEMPLOS --> Digite o tempo que deseja e em seguida digite se quer em Minutos ou Segundos.\n Ex: 40s ou  20m");

    string data = Console.ReadLine().ToLower();
    char type = char.Parse(data.Substring(data.Length-1,1));// Pegar o ultimo caracter
    int time = int.Parse(data.Substring(0, data.Length -1));// Pega do caracter  meno 1

    int multiplier = 1;

    if(type == 'm')
    {
        multiplier = 60; 
    };

    if(time == 0)
    {
        System.Environment.Exit(0); 
    };

    PreStart(time * multiplier);

};
static void PreStart(int time)
{
    Console.Clear();
    Console.WriteLine("Preparando...");
    Thread.Sleep(1000);
    Console.WriteLine("Go");
    Thread.Sleep(2000);
    Start(time);
    

}; 