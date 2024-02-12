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
//Обновите реализацию метода в каждом из ваших классов (Car, Motorcycle, и, если вы выполнили первое задание, 
//    Bicycle).
//Метод Brake должен выводить сообщение о том, что транспортное средство тормозит.


//    Задание 3:
//Создайте интерфейс IDrivable, который будет описывать метод Drive, представляющий движение транспортного средства. Интерфейс IDrivable должен быть реализован в классе Car.

//Задание 4:
//Измените класс Program так, чтобы он использовал и демонстрировал методы обоих интерфейсов (IVehicle и IDrivable) для объектов Car.

//Задание 5:
//Добавьте в интерфейс IVehicle новое свойство:

//csharp
//Copy code
//string VehicleType { get; }
//Обновите реализацию свойства в каждом из ваших классов. VehicleType должен возвращать тип транспортного средства ("Car", "Motorcycle", и т. д.).

//Эти задания помогут вам лучше понять, как использовать интерфейсы для добавления функциональности к различным классам и расширять возможности вашего кода.




interface IVehicle
{

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
}

class Car:IVehicle
{

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
}
class Motorcycle:IVehicle
{

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

}

class Program
{


    public static void Main()
    {

        Car car = new Car();
        car.Start();
        car.Stop();
        car.Accelerate(50);

        Motorcycle motorcycle = new Motorcycle();
        motorcycle.Start();
        motorcycle.Stop();
        motorcycle.Accelerate(40);
    }
}