int num1, num2;
float resultado;
int repetir;
string? menu;
bool aux=false;
repetir=0;
resultado=0;
do
{
    Console.WriteLine("ingrese la operacion que desea realizar");
    Console.WriteLine("1. suma");
    Console.WriteLine("2. resta");
    Console.WriteLine("3. multiplicacion");
    Console.WriteLine("4. division");
    menu=Console.ReadLine();
    Console.WriteLine("ingrese el primer numero");
    int.TryParse(Console.ReadLine(), out num1);
    Console.WriteLine("ingrese el segundo numero");
    int.TryParse(Console.ReadLine(), out num2);
    switch (menu)
    {
        case "suma":
            resultado=num1+num2;
            Console.WriteLine("el resultado de la suma es: "+resultado);
            break;
        case "resta":
            resultado=num1-num2;
            Console.WriteLine("el resultado de la resta es: "+resultado);
            break;
        case "multiplicacion":
            resultado=num1*num2;
            Console.WriteLine("el resultado de la multiplicacion es: "+resultado);
            break;
        case "division":
            resultado=num1/num2;
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