
float num, num1, num2;
int num3, num4;
float resultado;
int repetir;
string? menu;
bool aux=false;
repetir=0;
resultado=0;
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
do
{
    Console.WriteLine("ingrese la operacion que desea realizar");
    Console.WriteLine("1. suma");
    Console.WriteLine("2. resta");
    Console.WriteLine("3. multiplicacion");
    Console.WriteLine("4. division");
    menu=Console.ReadLine();
    Console.WriteLine("ingrese el primer numero");
    int.TryParse(Console.ReadLine(), out num3);
    Console.WriteLine("ingrese el segundo numero");
    int.TryParse(Console.ReadLine(), out num4);
    switch (menu)
    {
        case "suma":
            resultado=num3+num4;
            Console.WriteLine("el resultado de la suma es: "+resultado);
            break;
        case "resta":
            resultado=num3-num4;
            Console.WriteLine("el resultado de la resta es: "+resultado);
            break;
        case "multiplicacion":
            resultado=num3*num4;
            Console.WriteLine("el resultado de la multiplicacion es: "+resultado);
            break;
        case "division":
            resultado=num3/num4;
            Console.WriteLine("el resultado de la division es: "+resultado);
            break;
        default:
            Console.WriteLine("no se reconoce la palabra ingresada");
            break;
    }
    Console.WriteLine("si desea realizar otra operacion ingrese 1");
    Console.WriteLine("si desea salir precione 0");
    int.TryParse(Console.ReadLine(), out repetir);
    if (repetir==1)
    {
        aux=true;
    }else
    {
        aux=false;
    }
} while (aux);

