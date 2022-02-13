using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._3
{
	
		public class Employee
		{
			string name;
			string lastName;
			string position;
			int experience;

			public Employee(string name, string lastName, string position, int experience)
			{
			this.name = name;
			this.lastName = lastName;
			this.position = position;
			this.experience = experience;
			}
			public void Deconstruct(out string eName, out string eLastName, out string ePosition, out int eExperience)
			{
			eName = name;
			eLastName = lastName;	
			ePosition = position;
			eExperience = experience;
			}


			public int Salary()
			{
				int salary;
				if (position == "Boss")
				{
					salary = 10000;
				return salary;
				}
				else if (position == "Worker")
				{
				salary = 7000;
				return salary;
				}
				else
				{
					salary = 3000;
				return salary;
				}
			}
			public double Oklad() 
			{
				int salary, exp, finalSalary;
				salary = Salary();
				exp = experience;
				finalSalary = salary * exp;
				return finalSalary;
			}

			public double Tax() 
			{
				double tax, procent, fs;
				fs = Oklad();
				procent = 0.18;
				tax = fs * procent;
				return tax;
			}

		}
	}

