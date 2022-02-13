using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._3
{

	public class Program
	{
		public static void Main(string[] args)
		{

			Employee firstEmp = new Employee("Lina", "Zlenko", "Boss", 3);

			
			(string name, string lastName, string position, int experience) = firstEmp;
			double oklad = firstEmp.Oklad();
			double tax = firstEmp.Tax();
			Console.WriteLine($"Iм'я: {name}; Прiзвище: {lastName}; Посада: {position}; Оклад: {oklad}; Податковий збiр: {tax}");
			
			
			Employee secondEmp = new Employee("Vasia", "Pupkin", "Worker", 4);


			(string sname, string slastName, string sposition, int sexperience) = secondEmp;
			double soklad = secondEmp.Oklad();
			double stax = secondEmp.Tax();
			Console.WriteLine($"Iм'я: {sname}; Прiзвище: {slastName}; Посада: {sposition}; Оклад: {soklad}; Податковий збiр: {stax}");
			Console.ReadKey();

		}
	}
}
