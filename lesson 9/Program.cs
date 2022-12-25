//ТИПЫ ЗНАЧЕНИЙ И ССЫЛОЧНЫЕ ТИПЫ 

//Структуры и перечисления неявно расширяют класс System.ValuueType
//public abstract class ValueType: Object
//{
//    public virtual bool Equals(object obj);
//    public virtual int GetHashCode();

//    public Type GetType();

//    public virtual string ToString();
//}

//использование типаов значений, ссылочных типов и операции присваивания 

//присваивание двух внутренних типов хначений дает 
//в результате две независемые переменные в стеke
using System.Drawing;

ValueTypeAssigment();
ValueTypeContainingRefType();


static void ValueTypeContainingRefType()
{
    //Создать первую переменную Rectangle
    Console.WriteLine("-> Creating r1");
    Rectangle r1 = new Rectangle("FistRect", 10, 10, 50, 50);

    //Присвоить новой переменной Rectangle перменную r1
    Console.WriteLine("-> r2 to r1");
    Rectangle r2 = r1;

    //Изменить значение некоторые в r2
    Console.WriteLine("-> Changing calues of r2");
    r2.RectInfo.InfoString = "This is new info";

    r2.RectBottom = 4444;

    //вывести значение из обеих переменных Rectangle 
    r1.Display();
    r2.Display();
}

static void ValueTypeAssigment()
{
    Console.WriteLine("Assinging value types\n");

    PointRef p1 = new PointRef(10, 10);
    PointRef p2 = p1;

    //вывести значение обеих перемены PointRef 
    p2.Display();
    p2.Display();

    //изменить p1.X и снова вывести значения
    p1.X = 100;
    Console.WriteLine("\n => Changed p1.X\n");
    p1.Display();
    p2.Display();
}
//классы всегда являются ссылоснычми типами 
class PointRef
{
    public int X;
    public int Y;

    //Специальный конструктор
    public PointRef(int xPos, int yPos)
    {
        X = xPos; Y = yPos;
    }
    //добавить 1 к позиции (X,Y)
    public void Increment()
    {
        X++; Y++;
    }

    //выченсть 1 из позиции (X,Y)
    public void Decrement()
    {
        X--; Y--;
    }

    //Отобразить текущую позицию
    public void Display()
    {
        Console.WriteLine("X={0}, Y={1}", X, Y);
    }

}

class ShapeInfo
{
    public string InfoString;

    public ShapeInfo(string info)
    {
        InfoString = info;
    }
}

struct Rectangle
{
    //структура Rectangle содержит члены сслочного типа 
    public ShapeInfo RectInfo;
    public int RectTop, RectLeft, RectBottom, RectRight;
    public Rectangle(string info, int top, int left, int bottom, int right)
    {
        RectInfo = new ShapeInfo(info);
        RectTop = top; RectBottom = bottom;
        RectLeft = left; RectRight = right;

    }
    
    public void Display()
    {
        Console.WriteLine("String = {0}, Top = {1}, Bottom = {2}, "+ " Left = {3}, Right = {4}", RectInfo.InfoString, RectTop, RectBottom, RectLeft, RectRight);
    }
}
