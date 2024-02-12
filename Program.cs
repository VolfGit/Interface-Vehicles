//Задание:
//Создайте интерфейс IVehicle, который будет описывать основные методы, связанные с 
//    транспортными средствами. Включите в интерфейс следующие методы:

//void Start(): метод, который запускает транспортное средство.
//void Stop(): метод, который останавливает транспортное средство.
//void Accelerate(int speed): метод, который ускоряет транспортное средство до определенной скорости.
//Далее создайте два класса, реализующих интерфейс IVehicle:

//Car: класс, представляющий автомобиль.Реализуйте методы интерфейса для управления автомобилем.
//Motorcycle: класс, представляющий мотоцикл. Также реализуйте методы интерфейса для управления мотоциклом.
//Создайте экземпляры обоих классов и вызовите их методы, чтобы продемонстрировать использование 
//    интерфейса для управления разными транспортными средствами.



//Задание 1:
//Добавьте новый класс, например, Bicycle, который также реализует интерфейс IVehicle. 
//Реализуйте методы интерфейса для управления велосипедом. 
//Создайте экземпляр класса Bicycle и вызовите его методы.

//    Задание 2:
//Добавьте новый метод в интерфейс IVehicle:
//Обновите реализацию метода в каждом из ваших классов (Car, Motorcycle, и,
//если вы выполнили первое задание, 
//    Bicycle).
//Метод Brake должен выводить сообщение о том, что транспортное средство тормозит.


//    Задание 3:
//Создайте интерфейс IDrivable, который будет описывать метод Drive,
//представляющий движение транспортного средства.
//Интерфейс IDrivable должен быть реализован в классе Car.

//Задание 4:
//Измените класс Program так, чтобы он использовал и демонстрировал методы обоих интерфейсов (IVehicle и IDrivable) для объектов Car.

//Задание 5:
//Добавьте в интерфейс IVehicle новое свойство:

//csharp
//Copy code
//string VehicleType { get; }
//Обновите реализацию свойства в каждом из ваших классов. VehicleType должен возвращать тип транспортного средства ("Car", "Motorcycle", и т. д.).

//Эти задания помогут вам лучше понять, как использовать интерфейсы для добавления функциональности к различным классам и расширять возможности вашего кода.



//Задание:
//Интерфейсы и полиморфизм:

//Создайте интерфейс IDrivable с методом Drive().
//Создайте интерфейс IVehicle с методами Start(), Stop(), Accelerate(int speed), Brake() и свойством VehicleType.
//Реализация интерфейсов:

//Создайте три класса: Car, Motorcycle и Bicycle, которые реализуют интерфейс IVehicle.
//Класс Car также должен реализовывать интерфейс IDrivable.
//Полиморфизм:

//В классе Car реализуйте метод Drive интерфейса IDrivable, который выводит сообщение о том, что машина управляется.
//Полиморфное использование:

//В методе Main создайте массив IVehicle[] и наполните его объектами классов Car, Motorcycle и Bicycle.
//В цикле foreach вызовите методы Start(), Accelerate(30), Brake(), Stop() и Drive() (если применимо) для каждого объекта в массиве.
//Выведите тип каждого транспортного средства.
//Результат:

//Убедитесь, что каждый объект корректно реализует методы интерфейсов и полиморфизм применяется при использовании массива интерфейсов.



//Интерфейсы и полиморфизм:

//Создайте интерфейс ITransportable с методами LoadCargo(int weight) и UnloadCargo().
//Расширьте интерфейс IVehicle новыми методами.
//В классе Car реализуйте методы из обоих интерфейсов. В этом случае, Car будет реализовывать интерфейсы IVehicle и ITransportable.
//Реализация интерфейсов:

//Добавьте новый класс Truck, представляющий грузовик. Грузовик должен реализовывать интерфейсы IVehicle и ITransportable.
//Использование в программе:

//В методе Main создайте массив ITransportable[], содержащий объекты Car и Truck.
//В цикле foreach вызовите методы LoadCargo(500) и UnloadCargo() для каждого объекта в массиве.
//Выведите тип каждого объекта.

interface IDrivable
{

    void Drive();

}

interface IVehicle
{
    string VehicleType { get; }
    public int speed { get; set; }
    void Start()
    {
     
    }
    void Stop()
    {
     
    }
    void Accelerate(int speed)
    {

        this.speed = speed;
        Console.WriteLine(speed);
    }
    void Brake()
    { 
       
    }
}

class Car:IVehicle, IDrivable
{
    public string VehicleType
    {
        get { return "Car"; }
       
    }


    

    public void Drive()
    {
        Console.WriteLine("Mashina upravljatesja") ;

    }
    public int speed { get; set; }
    public void Start()
    {
        Console.WriteLine("Masniva vrum vrum");
    }
    public  void Stop()
    {
        Console.WriteLine("Mashina stoit");
    }
    public  void Accelerate(int speed)
    {

        this.speed = speed;
        Console.WriteLine(speed);

    }
    void Brake()
    {
        Console.WriteLine("Mashina tormozit");
    }
}
class Motorcycle:IVehicle
{
    public string VehicleType
    {
        get { return "Motorcycle"; }

    }


    public int speed { get; set; }
    public void Start()
    {
        Console.WriteLine("Motik vrum vrum vrum vrum");
    }
   public void Stop()
    {
        Console.WriteLine("Motik stoit");
    }
    public void Accelerate(int speed)
    {

        this.speed = speed;
        Console.WriteLine(speed);

    }
    void Brake()
    {
        Console.WriteLine("Motik tormozit");
    }
}

class Bicycle : IVehicle
{
    public string VehicleType
    {
        get { return "Bicycle"; }

    }
    public int speed { get; set; }
    public void Start()
    {
        Console.WriteLine("Velik vrum vrum");
    }
    public void Stop()
    {
        Console.WriteLine("Velik stoit");
    }
    public void Accelerate(int speed)
    {

        this.speed = speed;
        Console.WriteLine(speed);

    }

    void Brake()
    {
        Console.WriteLine("Velik tormozit");
    }
}
class Program
{


    public static void Main()
    {

        Car car = new Car();
        car.Start();
        car.Stop();
        car.Drive();
        car.Accelerate(50);
        Console.WriteLine(car.VehicleType);

        Motorcycle motorcycle = new Motorcycle();
        motorcycle.Start();
        motorcycle.Stop();
        motorcycle.Accelerate(40);
        Console.WriteLine(motorcycle.VehicleType);

        Bicycle bicycle = new Bicycle();
        bicycle.Start();
        bicycle.Stop();
        bicycle.Accelerate(10);
        Console.WriteLine(bicycle.VehicleType);

        IVehicle[] ivehicle = { car, bicycle, motorcycle };
        Console.WriteLine(" ");
        foreach (IVehicle vehicle in ivehicle)
        { Console.WriteLine(vehicle.VehicleType); }
    }
}