//Programa que genera un número aleatorio y el usuario tiene que adivinarlo.
//Declarando variables
Random nRandom = new Random();
int numMachine = nRandom.Next(1, 10);
int numUser = 0;
int vidas = 5;
//Inicio del programa
Console.WriteLine("------------------- Bienvenido a GuessNumber -------------------");
Console.WriteLine("------- Tienes 5 intentos para adivinar el número que la máquina generó y ganar -------");
Console.WriteLine("------- Escribe un número entero del 1 al 10 -------");
numUser = Convert.ToInt32(Console.ReadLine());
if (numUser < 1 || numUser > 10)
{
    Console.WriteLine("Recuerda es un número entero dentro del 1 y el 10");
    return;
}
{

}
for (int i = 1; i < vidas; i++)
{
    if (numUser == numMachine)
    {
        Console.WriteLine($"Has ganado, tu numero {numUser} y el de la maquina {numUser} coinciden.");
        return;
    }
    else if(numUser < numMachine)
    {
        Console.WriteLine("Intenta de nuevo, pista: El numero de la maquina es mayor.");
        numUser = Convert.ToInt32(Console.ReadLine());
    }
    else if (numUser > numMachine)
    {
        Console.WriteLine("Intenta de nuevo, pista: El numero de la maquina es menor.");
        numUser = Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine($"Tus vidas se han acabado y no has adivinado, el numero de la maquina era {numMachine}, reinicia el juego.");