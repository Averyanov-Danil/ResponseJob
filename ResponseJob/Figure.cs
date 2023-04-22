namespace ResponseJob
{
    /// <summary>
    /// General Figure Class
    /// </summary>
    public class Figure
    {
        public static class Circle 
        {   
            public static double CalculationArea(int r) => Math.Round((Math.PI * r * r), 3);
        }

        public class Triangle
        {
            public static double CalculationArea(int[] data)
            {
                if (data[2] >= data[0] + data[1] || data[1] >= data[0] + data[2] || data[0] >= data[1] + data[2] )
                {
                    throw new Exception("Треугольника несуществует");
                }

                double p = (data[0] + data[1] + data[2]) / 2.0;

                // Проверка согласно условию задания, но кажется куда логичным вытянуть это все с отдельный метод, собственно его пример ниже
                if (data[0] == data[1] || data[0] == data[2] || data[1] == data[2])
                {
                    Console.WriteLine("Равнобедренный");
                }

                return Math.Round(Math.Sqrt(p * (p - data[0]) * (p - data[1]) * (p - data[2])), 3);
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