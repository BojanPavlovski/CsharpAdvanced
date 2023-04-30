using Task_1.Database;
using Task_1.Extensions;
using Task_1.Models;


GenericDb<Circle> circleDb = new GenericDb<Circle>()
{
    Items = new List<Circle>()
    {
        new Circle(){Id = 1, Radius = 5},
        new Circle(){Id = 2, Radius = 10},
        new Circle(){Id = 3, Radius = 20}
    }
};
Console.WriteLine("Areas for circles:");
circleDb.PrintArea();

Console.WriteLine("Perimeters for circles:");
circleDb.PrintPerimeter();


GenericDb<Rectangle> rectangleDb = new GenericDb<Rectangle>()
{
    Items = new List<Rectangle>()
    {
        new Rectangle(){Id = 1, sideA = 5, sideB = 10},
        new Rectangle(){Id = 2, sideA = 10, sideB = 20},
        new Rectangle(){Id = 3, sideA = 20, sideB = 40}
    }
};

Console.WriteLine("Areas for rectangles:");
rectangleDb.PrintArea();

Console.WriteLine("Perimeters for rectangles:");
rectangleDb.PrintPerimeter();


//EXTENSION METHODS
ExtensionMethods.InfoForCircles(circleDb);
ExtensionMethods.InfoForRectangles(rectangleDb);
