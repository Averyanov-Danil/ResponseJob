using static ResponseJob.Figure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestFigure
{
    [TestClass]
    public class TestFigure
    {
        [TestMethod]
        public void Circl_CalcArea_Test()
        {
            List<double> expected = new();
            List<int> rad = new();
            List<double> res = new();

            // Добавление уже готового результата
            for (int i = 0; i < File.ReadAllLines(@"info\CircleExpArea.txt").Length; i++)
            {
                var temp = (File.ReadAllLines(@"info\CircleExpArea.txt"));

                expected.Add(double.Parse(temp[i]));
            }

            // Добавление радиуса
            for (int i = 0; i < File.ReadAllLines(@"info\RCircle.txt").Length; i++)
            {
                var temp = (File.ReadAllLines(@"info\RCircle.txt"));

                rad.Add(int.Parse(temp[i]));
            }

            // Занесение результата из библиотеки в лист
            foreach (var e in rad)
            {
                res.Add(Circle.CalculationArea(e));
            }

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], res[i]);
            }
        }

        [TestMethod]
        public void Triangle_CalcArea_Test()
        {
            List<double> expected = new();
            List<int[]> sides = new();
            List<double> res = new();

            // Добавление уже готового результата
            for (int i = 0; i < File.ReadAllLines(@"info\TrangleExpArea.txt").Length; i++)
            {
                var temp = (File.ReadAllLines(@"info\TrangleExpArea.txt"));

                expected.Add(double.Parse(temp[i]));
            }

            // Добавление радиуса
            for (int i = 0; i < File.ReadAllLines(@"info\TriangleSides.txt").Length; i++)
            {
                var temp = (File.ReadAllLines(@"info\TriangleSides.txt"));
                var t = (temp[i].Split(@"\"));
                int[] side = { int.Parse(t[0]), int.Parse(t[1]), int.Parse(t[2]) };


                sides.Add(side);
            }

            // Занесение результата из библиотеки в лист
            foreach (var e in sides)
            {
                res.Add(Triangle.CalculationArea(e));
            }

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], res[i]);
            }
        }
    }
}