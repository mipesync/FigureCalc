using FigureCalc;
using FigureCalc.Figures;

Console.WriteLine("Вы хотите найти площадь круга или треугольника? Нажмите К или Т: ");
var keyChar = Console.ReadKey();
Console.Write("\b");

var asd = keyChar.KeyChar.ToString().ToLower();

switch (asd)
{
    case "т":
        {
            TrianlgeInfo();
            break;
        }
    case "к":
        {
            CircleInfo();
            break;
        }
}

void TrianlgeInfo()
{
    try
    {
        Console.Write("Введите первое число: ");
        var a = double.Parse(Console.ReadLine()!);
        Console.Write("Введите второе число: ");
        var b = double.Parse(Console.ReadLine()!);
        Console.Write("Введите третье число: ");
        var c = double.Parse(Console.ReadLine()!);

        Console.WriteLine($"\nПлощадь треугольника: {FigureManager.GetTriangleArea(a, b, c)}.\n" +
            $"Треугольник {(new Triangle(a, b, c).IsRight() == true ? "" : "не ")}прямоугольный.");
    }
    catch (FormatException e)
    {
        Console.WriteLine("Неправильный формат данных!");
    }
    catch (ArgumentException e)
    {
        Console.WriteLine(e.Message);
    }
}

void CircleInfo()
{
    try
    {
        Console.Write("Введите радиус: ");
        var radius = double.Parse(Console.ReadLine()!);

        var circle = new Circle(radius);

        Console.WriteLine($"\nПлощадь круга: {circle.GetArea()}.");
    }
    catch (FormatException e)
    {
        Console.WriteLine("Неправильный формат данных!");
    }
    catch (ArgumentException e)
    {
        Console.WriteLine(e.Message);
    }
}