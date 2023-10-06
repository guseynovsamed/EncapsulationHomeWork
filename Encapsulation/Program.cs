

using Encapsulation.Controllres;
using Encapsulation.Service;
using System.Data.Common;

//CalculatorService calculatorService = new CalculatorService();


//Console.WriteLine("Birinci ededi daxil edin:");
//double a = Convert.ToDouble(Console.ReadLine());

//KenarMetod:
//Console.WriteLine("Duzgun Operator Daxil edin");

//Console.WriteLine("Operatoru daxil edin:(+,-,*,/)");
//string op = Console.ReadLine();

//Console.WriteLine("Ikinci ededi daxil edin:");
//double b  = Convert.ToDouble(Console.ReadLine());






//if(op == "+")
//{
//    Console.WriteLine("Cavab:");

//    Console.WriteLine(calculatorService.Addition(a, b));

//}
//else if(op == "-")
//{
//    Console.WriteLine("Cavab:");

//    Console.WriteLine(calculatorService.Subtraction(a, b));

//}
//else if (op == "*")
//{
//    Console.WriteLine("Cavab:");

//    Console.WriteLine(calculatorService.Multiplication(a, b));

//}else if(op == "/")
//{
//    Console.WriteLine("Cavab:");

//    Console.WriteLine(calculatorService.Division(a, b));
//}
//else 
//{

//    goto KenarMetod;
//}







//EmployeeControllers employeeControllers = new EmployeeControllers();

//employeeControllers.GetSalary();


DoctorControllers doctorControllers = new DoctorControllers();

doctorControllers.GetDoctorInfo();