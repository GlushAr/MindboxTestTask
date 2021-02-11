using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask;
using TestTask.Primitives;

namespace ConsoleApp3 {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine(CustomGeomety.isRightTriangle(new Triangle(3, 4, 5)));
			Console.ReadKey();
		}
	}
}
