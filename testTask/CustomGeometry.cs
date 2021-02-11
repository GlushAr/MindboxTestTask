using System;
using System.Collections.Generic;
using System.Text;
using TestTask.Primitives;

namespace TestTask {
	public class CustomGeomety {
		public const double pi = 3.1415;

		public static double getCircleSquare(Circle circle) {
			return pi * circle.radius * circle.radius;
		}

		public static double getTriangleSquare(Triangle triangle) {
			double a = triangle.a;
			double b = triangle.b;
			double c = triangle.c;

			double perimeter = a + b + c;
			double p = perimeter / 2;
			double square = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

			return square;
		}

		public static bool isRightTriangle(Triangle triangle) {
			double a = triangle.a;
			double b = triangle.b;
			double c = triangle.c;
			double max = 0;

			if (a > max) {
				max = a;
			}
			if (b > max) {
				max = b;
			}
			if (c > max) {
				max = c;
			}

			if (max == a) {
				if (a == Math.Sqrt(b * b + c * c)) {
					return true;
				}
			} else if (max == b) {
				if (b == Math.Sqrt(a * a + c * c)) {
					return true;
				}
			} else if (max == c) {
				if (c == Math.Sqrt(a * a + b * b)) {
					return true;
				}
			}

			return false;
		}
	}
}
