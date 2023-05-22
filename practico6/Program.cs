int x;
int z;
int r;
double c=0;
string y;
Console.WriteLine("ingrese un numero");
bool control=int.TryParse(Console.ReadLine(), out x);
if (control && x>0)
{
    y=Convert.ToString(x);
    Console.WriteLine(y);
    z=y.Length;
    while (x>=10)
    {
        r=x%10;
        c=c+(r*Math.Pow(10, z-1));
        x=x/10;
        z=z-1;
    }
    if (x<10)
    {
        c=c+x;
    }
    Console.WriteLine(c);
}