using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask.Primitives {
	public class Triangle {
		public double a { get; private set; }
		public double b { get; private set; }
		public double c { get; private set; }

		public Triangle(double a, double b, double c) {
			if (a >= b + c ||
				b >= a + c ||
				c >= a + b) {
				// if the triangle is degenerate
				this.a = 1;
				this.b = 1;
				this.c = 1;
			} else {
				this.a = a;
				this.b = b;
				this.c = c;
			}
		}
	}
}
