// See https://aka.ms/new-console-template for more information




//Console.WriteLine("Hello, World!");


/* Модификаторы доступа Полей и классов
 * 
 * 
 internl - Это поля доступные только текущей сборке!

Сборка в C# - это проект, который содержит исходный код, ресурсы и метаданные,
используемые для создания исполняемого файла. Сборка может включать в себя один или несколько классов,
интерфейсы, структуры, делегаты, перечисления, атрибуты, события, методы и поля.

Когда вы создаете проект в Visual Studio, он автоматически создает сборку. Вы можете также создавать сборки вручную,
используя инструменты командной строки, такие как csc.exe или dotnet build.
................................................

В C# сборки имеют строгую систему безопасности, которая предотвращает выполнение вредоносного кода. Кроме того,
сборки могут быть подписаны с использованием сертификатов, чтобы подтвердить их подлинность и целостность.

internl - Это только доступ в нутри сборки.

static  - Поле доступное 
........................................

Поле static в C# указывает, что данное поле или метод является общим для всех объектов класса.
Статические поля и методы не привязаны к конкретному экземпляру класса, а существуют в единственном экземпляре для всего класса.

Статические поля объявляются с ключевым словом static и инициализируются только один раз - при первом обращении к ним.
Они сохраняют свои значения между вызовами методов класса.

Примеры использования static полей и методов:

– Инициализация глобальных переменных и констант.
– Использование в качестве “пустых” методов, которые не принимают и не возвращают значения. 
Такие методы могут быть использованы для реализации паттерна “Шаблонный метод”.
– Создание статических фабрик для создания объектов класса без необходимости создавать экземпляр класса.
– Хранение общей информации для всех экземпляров класса.



 */

// Модификаторы доступа
//class Program
//{
//    public readonly int sum; //- Только можно читать 
//    // поля public пишутся для каждого поля.


//    static void Main(string[] args)
//    {

//    }
//}

// Конструкторы - Для инициализации полей и классов.

//class Program
//{
//    public readonly int sum;
//    public Program() // Конструктор может быть простым и статическим. 
//    { }
//    static Program() // Конструктор  статическим  В него не передаются Аргументы  Это и есть Делегирующий конструктор.
//    { }   // Имеет доступ только к статическим членам класса.    

//    static void Main(string[] args)
//    {

//    }
//}


// Метод класса this - Это просто ссылка.
//class Program
//{
//    public int sum;
//    public int age;
//    public Program(int sum, int age)  
//    {
//        this.age = age;//  В С# this - это просто ссылка.
//        this.sum = sum;
//    }

//    static void Main(string[] args)
//    {


//    }
//}

// Ссылка - Это адрес в памяти где храниться значение.
// Простые типы данных передаются по ссылке А Объекты передаются по значению

//class Program
//{
//    public int sum;
//    public int age;
//    public Program(int sum, int age)
//    {
//        this.age = age;
//        this.sum = sum;
//    }

//    // чтобы передать ссылку в public int Summ() мы использкем метод ref 
//    public int Summ(ref int a, ref int b) { // Тут мы передаем ссылки
//        int ans = a + b;
//        return ans;
//    }

//    static void Main(string[] args)
//    {


//    }
//}

// модификатор out - Это модификатор - Равнозначно return 

//class Program
//{
//    public int sum;
//    public int age;
//    public Program(int sum, int age)
//    {
//        this.age = age;
//        this.sum = sum;
//    }

//    // чтобы передать ссылку в public int Summ() мы использкем метод ref 
//    public void Summ(ref int a, ref int b, out int ans)
//    { // Тут мы передаем ссылки
//        ans = a + b;      
//    }

//    static void Main(string[] args)
//    {


//    }
//}

//Вывод аргументов в Main()

//class Program
//{
//    public int sum;
//    public int age;
//    public Program(int sum, int age)
//    {
//        this.age = age;
//        this.sum = sum;
//    }

//    // чтобы передать ссылку в public int Summ() мы использкем метод ref 
//    public void Summ( int a,  int b, out int ans)
//    { // Тут мы передаем ссылки
//        ans = a + b;
//    }

//    static void Main(string[] args)
//    {
//        int num;
//        Program p = new Program(10, 10);
//        p.Summ(10, 10, out num);

//    }
//}


// Partial - Это реализация одного и того же класса в разных файлах ( Но лучше его не испоьлзоваь 
// Лучше каждый класс должен быть в отдельном файле и должен называтьсы так же)
// partial class Program
//{
//    public int sum;
//    public int age;
//    public Program(int sum, int age)
//    {
//        this.age = age;
//        this.sum = sum;
//    }

//    // чтобы передать ссылку в public int Summ() мы использкем метод ref 
//    public void Summ(int a, int b, out int ans)
//    { // Тут мы передаем ссылки
//        ans = a + b;
//    }

//    static void Main(string[] args)
//    {
//        int num;
//        Program p = new Program(10, 10);
//        p.Summ(10, 10, out num);

//    }
//}


// Get и Set namespace



//partial class Program
//{
//    namespace.class.method;// Так пишем за место std::
//    public int sum;
//    public int age;



//    public int _sum;
//    {
//        get { return _sum; }
//        set{ _sum = value; }
//    }
//    public Program(int sum, int age)
//    {
//        this.age = age;
//        this.sum = sum;
//    }


//    public void Summ(int a, int b, out int ans)
//    { 
//        ans = a + b;
//    }

//    static void Main(string[] args)
//    {
//        int num;
//        Program p = new Program(10, 10);
//        p.Summ(10, 10, out num);

//        p._sum = Convert.ToInt32(Console.ReadLine());
//    }
//}

//namespace ConsoleApp1
//{ 
//class MyClass
//{
//        public int a;
//}
//    struct Student
//    {
//        public int a;   
//    }

//partial class Program
//{

//    public int sum;
//public int age;


//public Program(int sum, int age)
//{
//    this.age = age;
//    this.sum = sum;
//}

//public void Summ(int a, int b, out int ans)
//{
//    ans = a + b;
//}

//    public void Asd(MyClass cass) {
//        cass.a = 100;
//    }
//    public void Asd2(ref MyClass cs)
//    {
//        cs.a = 100;
//    }

//static void Main(string[] args)
//{
//    int num;
//    Program p = new Program(10, 10);
//    p.Summ(10, 10, out num);

//    

//    MyClass cl = new ();
//    p.Asd(cl);
//    p.Asd2(ref cl);
//    Console.WriteLine(cl.a);
//p.sum = Convert.ToInt32(Console.ReadLine());
//  p.sum(10);

//}
//}
//}

// Задача

//namespace ConsoleApp1
//{
//    class Person
//    {
//        private string _fullName;
//        private DateTime _birthDate;
//        private string _contactPhone;
//        private string _workEmail;
//        private string _position;
//        private string _jobDescription;

//       public Person(string _fullName, DateTime birthDate, string contactPhone, string workEmail, string position, string jobDescription)
//        {
//            this._fullName = _fullName;
//            this._birthDate = birthDate;
//            this._contactPhone = contactPhone;  
//            this._workEmail = workEmail;
//            this._position = position;
//            this._jobDescription = jobDescription;
//        }

//       public string FullName
//        {
//            get { return _fullName; }
//            set { _fullName = value; }  
//        }

//        public DateTime DateTime { 
//            get { return _birthDate; }
//            set { _birthDate = value; }
//        }

//        public string ContactPhone { 
//            get{ return _contactPhone; }
//            set { _contactPhone = value; }
//        }
//        public string WorkEmail { 
//            get { return _workEmail; }
//            set { _workEmail = value; }
//        }

//        public string Position { 
//            get { return _position;}
//            set { _position = value; }
//        }
//        public string JobDescription {
//            get { return _jobDescription; }
//            set { _jobDescription = value; }
//        }            

//        static void Main(string[] args)
//        {


//        }
//    }
//}

// Задача

using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    class Figure
    {

        public double Area(int a)
        {
            
            return 6 * Math.Pow(a , 2);

        }

        public double Area(int a, int b, int c)
        {            
            return a * 2 + a * c + b * c;
        }

    
        static void Main(string[] args)
        {
            Figure f = new Figure();
            f.Area(10);
            f.Area(20, 30, 40);
        }
    }
}