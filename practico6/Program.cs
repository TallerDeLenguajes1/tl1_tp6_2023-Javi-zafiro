float num, num1, num2;
Console.WriteLine("ingrese un numero");
float.TryParse(Console.ReadLine(), out num);
Console.WriteLine("el numero ingresado es: "+num);
Console.WriteLine("el valor absoluto del numero es: "+Math.Abs(num));
Console.WriteLine("el cuadrado del numero es: "+Math.Pow(num, 2));
if (num>=0)
{
    Console.WriteLine("la raiz cuadrada del numero es: "+Math.Sqrt(num));
}else
{
    Console.WriteLine("el numero es negativo no se puede calcular su raiz cuadrada");
}
Console.WriteLine("el seno del numero es: "+Math.Sin(num));
Console.WriteLine("el coseno del numero es: "+Math.Cos(num));
Console.WriteLine("la parte entera del numero es: "+Math.Floor(num));
Console.WriteLine("vamos a comparar 2 numeros");
Console.WriteLine("ingrese el primer numero");
float.TryParse(Console.ReadLine(), out num1);
Console.WriteLine("ingrese el segundo numero");
float.TryParse(Console.ReadLine(), out num2);
if (num1<num2)
{
    Console.WriteLine("el numero "+num2+" es mas grande que el numero"+num1);
}else
{
    if (num1>num2)
    {
        Console.WriteLine("el numero "+num1+" es mas grande que el numero"+num2);
    }else
    {
        Console.WriteLine("los numeros "+num1+" "+num2+" son iguales");
    }
}