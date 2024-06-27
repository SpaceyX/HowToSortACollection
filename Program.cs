namespace HowToSortAList;

class Program
{
    static void Main(string[] args)
    {
        // welcome to this short tutorial. Let´s find out, how to order a collection.

        // First we need some dummy data. It´s a simple class with a static function,
        // which returns the data. 

        var cars = Car.GetDummyData().OrderBy(x => x.Brand).ThenBy(x => x.ID);

        // let´s order this list by ID.

        // you can also order in descending order.

        // let´s now order the list by brand.

        // you can also order by more than one property.

        // thank you very much for watching.

        foreach (var car in cars)
            Console.WriteLine(car);
    }
}

class Car(int id, string brand, string model, int horsepower, string color, string fuelType)
{
    public int ID { get; init; } = id;
    public string Brand { get; init; } = brand;
    public string Model { get; init; } = model;
    public int Horsepower { get; init; } = horsepower;
    public string Color { get; init; } = color;
    public string FuelType { get; init; } = fuelType;

    public override string ToString()
    => $"ID: {this.ID}, Brand: {this.Brand}, Model: {this.Model}, Horsepower: {this.Horsepower}, Color: {this.Color}, FuelType: {this.FuelType}";

    public static IEnumerable<Car> GetDummyData()
    {
        return new List<Car>()
        {
            new Car(1, "BMW", "X5", 250, "Black", "Gasoline"),
            new Car(5, "Mercedes", "C-Class", 180, "Blue", "Diesel"),
            new Car(10, "Mazda", "CX-60", 205, "Silver", "Diesel"),
            new Car(6, "BMW", "X1", 140, "Lime green", "Diesel"),
            new Car(7, "Vauxhall", "Corsa", 110, "Green", "Electric"),
            new Car(9, "Mazda", "RX-8", 190, "White", "Gasoline"),
            new Car(23, "Porsche", "911", 640, "Violet", "Gasoline"),
            new Car(2, "Nissan", "Sakura", 115, "Gray", "Diesel"),
            new Car(19, "Subaru", "Forester", 120, "Light Blue", "Diesel"),
            new Car(17, "Volkswagen", "Golf", 150, "Dark Red", "Electric"),
            new Car(21, "Porsche", "718", 450, "Pink", "LPG"),
            new Car(3, "Renaul", "Clio", 90, "Rosegold", "LPG"),
            new Car(32, "Toyota", "Corolla", 110, "Blue", "Gasoline"),
            new Car(27, "Volkswagen", "Touran", 225, "Dark Gray", "Diesel"),
            new Car(11, "Mazda", "Miata", 170, "Purple", "Gasoline"),
            new Car(13, "Tesla", "Model-Y", 400, "Space Gray","Electric")
        };
    }
}