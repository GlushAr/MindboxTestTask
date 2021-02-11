using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestTask;
using TestTask.Primitives;

namespace UnitTest {
	[TestClass]
	public class CustomGeometyTests {
		[TestMethod]
		public void getCircleSquareTest() {
			Circle circle = new Circle(1);
			double expected = 3.1415;

			double actual = CustomGeomety.getCircleSquare(circle);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void getTriangleSquareTest() {
			Triangle triangle = new Triangle(1.5, 2, 2.5);
			double expected = 1.5;

			double actual = CustomGeomety.getTriangleSquare(triangle);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void isRightTriangleTest() {
			Triangle triangle = new Triangle(3, 4, 5);
			bool expected = true;

			bool actual = CustomGeomety.isRightTriangle(triangle);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void isNotRightTriangleTest() {
			Triangle triangle = new Triangle(1, 1, 1.5);
			bool expected = false;

			bool actual = CustomGeomety.isRightTriangle(triangle);

			Assert.AreEqual(expected, actual);
		}
	}
}
