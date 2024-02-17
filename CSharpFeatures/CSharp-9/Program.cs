using BenchmarkDotNet.Running;
using CSharp_9.CovariantReturnType;
using CSharp_9.InitOnlyProperty;
using CSharp_9.PatternMatching;
using CSharp_9.Patterns;
using CSharp_9.Record;
using CSharp_9.StaticAnonymous;
using CSharp_9.SwitchCase;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Xml.Linq;

static string Classify(double measurement) => measurement switch
{
    < -40.0 => "Too low",
    >= -40.0 and < 0 => "Low",
    >= 0 and < 10.0 => "Acceptable",
    >= 10.0 and < 20.0 => "High",
    >= 20.0 => "Too high",
    double.NaN => "Unknown",
};



static string GetCalendarSeason(DateTime date) => date.Month switch
{
    3 or 4 or 5 => "spring",
    6 or 7 or 8 => "summer",
    9 or 10 or 11 => "autumn",
    12 or 1 or 2 => "winter",
    _ => throw new ArgumentOutOfRangeException(nameof(date), $"Date with unexpected month: {date.Month}."),
};

Console.WriteLine(Classify(13));  // output: High
Console.WriteLine(Classify(-100));  // output: Too low
Console.WriteLine(Classify(5.7));  // output: Acceptable

Console.WriteLine(GetCalendarSeason(new DateTime(2021, 1, 19)));  // output: winter
Console.WriteLine(GetCalendarSeason(new DateTime(2021, 10, 9)));  // output: autumn
Console.WriteLine(GetCalendarSeason(new DateTime(2021, 5, 11)));  // output: spring

//Switch Case
Test test = new();
string result = test.GetExperienceLevel(1);
string resultWithCase = test.GetExperienceLevel(2);
Console.WriteLine(result);
Console.WriteLine(resultWithCase);

//Init-Only Properties 
Customer customer = new() //Target-typed new Expressions
{
    FirstName = "John",
    LastName = "Doe"
};
//customer.FirstName = "John Lee";
customer.Age = 3;

/*Customer customer1 = new Customer();
customer1.FirstName = "Pavan";*/


//Record
SignUpModel signUpModel = new("Supraja", "supraja@gmail.com", "1234567890", "Supraja@123", "Supraja@123");

SignUp signUp = new()
{
    UserName = "Tanya",
    Email = "tanya@gmail.com",
    Phone = "1234567890",
    Password = "1234567890",
    ConfirmPassword = "1234567890"
};

var (username, email, phone, password, confirm_password) = signUpModel;

User user = new()
{
    UserName = username,
    Email = email,
    Phone = phone,
    Password = password,
    Created_at = DateTime.Now,
};

// Old Versions
User user_ = new()
{
    UserName = signUp.UserName,
    Email = signUp.Email,
    Phone = signUp.Phone,
    Password = signUp.Password,
    Created_at = DateTime.Now,
};


// Value Equality in Records
List<Course> courses = new List<Course>()
 {
    new Course() { Title = "Django", Category = "Development", Price = 900},
    new Course() { Title = "Digital Marketing ", Category = "Marketing", Price =1500 },
    new Course() { Title = "Web Development", Category = "Development", Price = 1000}
 };

List<CourseMaterials> materials = new List<CourseMaterials>()
{
    new CourseMaterials() { Title = "Django", Category = "Development", Price = 900},
    new CourseMaterials() { Title = "Digital Marketing ", Category = "Marketing", Price =1500 },
    new CourseMaterials() { Title = "Web Development", Category = "Development", Price = 1000}
};

Course course = new()
{
    Title = "Web Development",
    Category = "Development",
    Price = 1000
};

Course course_ = new()
{
    Title = "Web Development",
    Category = "Development",
    Price = 500
};

CourseMaterials material = new()
{
    Title = "Web Development",
    Category = "Development",
    Price = 1000
};

foreach (var item in courses)
{
    if (item == course)
    {
        Console.WriteLine("Courses with specific category and price already exists");
    }
}

foreach (var item in materials)
{
    if (item.Title == material.Title && item.Category == material.Category && item.Price == material.Price)
    {
        Console.WriteLine("Courses with specific category and price already exists");
    }
}

Console.WriteLine("signup model is" + signUp + confirm_password + user + user_);
Console.WriteLine("Courses are " + (course == course_));


//Pattern Matching
// Usage:
var circle = new Circle { Sides = 0, Radius = 5 };
var square = new Square { Sides = 4, SideLength = 10 };
TypePattern pattern = new TypePattern();
Console.WriteLine(pattern.GetShapeInfo(circle)); // Output: Circle with radius 5
Console.WriteLine(pattern.GetShapeInfo(square)); // Output: Square with side length 10

RelationalPattern relationalPattern = new RelationalPattern();
Console.WriteLine(relationalPattern.EvaluateGrade(85)); //Output: B
Console.WriteLine(relationalPattern.EvaluateGrade(55)); // Output: F

LogicalPatterns logicalPatterns = new LogicalPatterns();
Console.WriteLine(logicalPatterns.GetWeatherAdvice("Sunny", false)); // Output: Enjoy the sunshine!
Console.WriteLine(logicalPatterns.GetWeatherAdvice("Rainy", true)); // Output: Remember your umbrella!



//CovariantReturnType
Book book = new("My Book", 1, "123-567-7890");
BookOrder orderBook = book.Order(2);
Music music = new("My Music", 2, Format.Mp3);
MusicOrder orderMusic = music.Order(2);


//Static Anonymous
//To avoid unnecessary and wasteful memory allocation,
//we can use the static keyword on the lambda and the
//const keyword on the variable or object that we do
//not want to be captured.
var staticObj = BenchmarkRunner.Run<Base>();
Base baseObject = new();
Console.WriteLine(baseObject.MultiplyNonStatic());
Console.WriteLine(baseObject.MultiplyNonStaticWithConst());
Console.WriteLine(baseObject.MultiplyStatic());
baseObject.Display();



//Native Size Integer
Console.WriteLine("Integer Min Value is " + int.MinValue);
Console.WriteLine("Integer Max Value is " + int.MaxValue);
Console.WriteLine();
Console.WriteLine("Long Min Value is " + long.MinValue);
Console.WriteLine("Long Max Value is " + long.MaxValue);
Console.WriteLine();
Console.WriteLine("Native signed integer size in this system is " + IntPtr.Size);
Console.WriteLine("Native signed integer min value is " + nint.MinValue);
Console.WriteLine("Native signed integer max value is " + IntPtr.MaxValue);
Console.WriteLine();
Console.WriteLine("Native unsigned integer size in this system is " + UIntPtr.Size);
Console.WriteLine("Native unsigned integer min value is " + UIntPtr.MinValue);
Console.WriteLine("Native unsigned integer max value is " + UIntPtr.MaxValue);

IntPtr a = (IntPtr)5;
IntPtr b = (IntPtr)6;
IntPtr c = new IntPtr((long)a + (long)b);
//IntPtr d = a + b;


Console.WriteLine("^^^^^^^^^^^^^^^^^^");
//Patterns
//Type Pattern
Vehicle vehicleObj = new Truck();
Console.WriteLine(TollCalculator.CalculateToll(vehicleObj));

Vehicle vehicle = new Cart();
Console.WriteLine(TollCalculator.CalculateToll(vehicle));



public class EnclosingClass
{
    public int InstanceState = 42;
    public void LambdaCapturingEnclosingInstance()
    {
        // Scenario 3: Lambda capturing an enclosing instance state (results in heap allocation)
        Func<int, int> add = y => InstanceState + y;
        int result = add(5);
    }
}



