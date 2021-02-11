using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask.Primitives {
	public class Circle {
		public double radius { get; private set; }

		public Circle(double radius) {
			if (radius <= 0) {
				// if radius less than 0
				this.radius = 1;
			} else {
				this.radius = radius;
			}
		}
	}
}
