namespace ResponseJob
{
    /// <summary>
    /// General Figure Class
    /// </summary>
    public class Figure
    {
        /// <summary>
        /// Автоматический выбор фигуры при входных данных
        /// </summary>
        /// <param name="data">Входные данные</param>
        public Figure(int[] data)
        {
            if (data.Length == 3)
            {
                Triangle.CalculationArea(data);
            }
            else if (data.Length == 1)
            {
                Circle.CalculationArea(data[0]);
            }

            // Для вычисления площади фигуры необходимо передать в класс входной массив данных
        }

        public static class Circle 
        {   
            /// <summary>
            /// 
            /// </summary>
            /// <param name="r">Радиус круга</param>
            /// <returns></returns>
            public static double CalculationArea(int r) => Math.Round((Math.PI * r * r), 3);
        }

        public class Triangle
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="sides">Стороны треугольника</param>
            /// <returns></returns>
            /// <exception cref="Exception">Треугольник не существует</exception>
            public static double CalculationArea(int[] sides)
            {
                if (sides[2] >= sides[0] + sides[1] || sides[1] >= sides[0] + sides[2] || sides[0] >= sides[1] + sides[2] )
                {
                    throw new Exception("Треугольника несуществует");
                }

                double p = (sides[0] + sides[1] + sides[2]) / 2.0;

                // Проверка согласно условию задания, но кажется куда логичным вытянуть это все с отдельный метод, собственно его пример ниже
                if (sides[0] == sides[1] || sides[0] == sides[2] || sides[1] == sides[2])
                {
                    Console.WriteLine("Равнобедренный");
                }

                return Math.Round(Math.Sqrt(p * (p - sides[0]) * (p - sides[1]) * (p - sides[2])), 3);
            }

            private void Check(int[] data)
            {
                if (data[0] == data[1] || data[0] == data[2] || data[1] == data[2])
                {
                    Console.WriteLine("Равнобедренный");
                }
                else if(data[0] == data[1] && data[2] == data[1])
                {
                    Console.WriteLine("Равносторонний");
                }
                // etc
            }
        }
    }
}