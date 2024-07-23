int a, b;

Console.WriteLine("Digite dois valores positivos: ");
a = Convert.ToInt32(Console.ReadLine());    
b = Convert.ToInt32(Console.ReadLine());


switch ((a, b))
{
    case  (> 0, > 0) when a == b:
        Console.WriteLine($"Os valores são válidos e iguais {a}.");
        break;

    case ( > 0, > 0):
        Console.WriteLine($"valores válidos distindos a = {a} , b =  {b}.");
        break;

    default:
        Console.WriteLine("Um ou os dois valores não são positivos");
        break;
}


