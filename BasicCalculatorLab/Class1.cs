using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

public class Class1
{
	public Class1();
	
		private double num1;
	private double num2;
	private string op; 
	public Class1()
    {
    }
	public double addition(double a, double a)
    {
		double result = a + b;
		return result;
    }
	public double multiplication(double a, double b)
    {
		double result = a * b;
		return result;
    }
	public double division(double a, double b)
    {
		double result = a / b;
		return result;
    }
	public bool checkInput(double a, double a, string c)
	{
		double result();
		if (c.Equals("+"))
		{
			result = addition(a, b);
			Console.WriteLine("resul of your operation is" + result);
		}
		else if (c.Equals("*"))
		{
			result = multiplicaton(a, b);
			Console.WriteLine("result of your multiplication is" + result);
		}
		else if (c.Equals("/"))
		{
			result = division(a, b);
			Console.WriteLine("result of your operation is" + result);
		}
		else
		{
			Console.WriteLine("error: wrong input");
		}
    }
	 
	}

