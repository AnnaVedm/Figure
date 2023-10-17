namespace Фигурки
{
    class Program
    {
        static void Main(string[] args)
        {
            square schet = new square();
            prymougolnik schet1 = new prymougolnik();
            krug schet2 = new krug();
            triangle schet3 = new triangle();

            while (true)
            {
                Console.WriteLine("Выберите фигуру:");
                Console.WriteLine("1. Квадрат");
                Console.WriteLine("2. Прямоугольник");
                Console.WriteLine("3. Круг");
                Console.WriteLine("4. Треугольник");
                Console.WriteLine("5. Выйти");
                int vybory = int.Parse(Console.ReadLine());

                switch (vybory)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Вы выбрали квадрат: ");
                        schet.Perimetr();
                        schet.S();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Вы выбрали прямоугольник: ");
                        schet1.Perimetr1();
                        schet1.S1();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Вы выбрали круг: ");
                        schet2.Perimetr2();
                        schet2.S2();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Вы выбрали треугольник: ");
                        schet3.Perimetr3();
                        schet3.S3();
                        break;
                    case 5:
                        Console.WriteLine("Выход.");
                        Console.Clear();
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Некорректный выбор.");
                        break;
                }
            }
        }
    }
    class square
    {
        private double perimetr;
        private double s;
        private double storona;


        public void Perimetr()
        {
            Console.Write("Введите сторону квадрата a(см): ");
            storona = Convert.ToSingle(Console.ReadLine());
            perimetr = Math.Round(4 * storona, 3);
            Console.WriteLine($"\nПериметр квадрата = {perimetr} см");
        }

        public void S()
        {
            s = Math.Round(storona * storona, 3);
            Console.WriteLine($"\nПлощадь квадрата = {s} см^2\n");
        }
    }
    class prymougolnik
    {
        private double perimetr;
        private double s;
        private double storona;
        private double storona1;

        public void Perimetr1()
        {
            Console.Write("Введите сторону прямоугольника a(см): ");
            storona = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите сторону прямоугольника b(см): ");
            storona1 = Convert.ToSingle(Console.ReadLine());

            perimetr = Math.Round(2 * (storona + storona1), 3);

            Console.WriteLine($"\nПериметр прямоугольника = {perimetr} см");
        }
        public void S1()
        {
            s = Math.Round(storona * storona1, 3);
            Console.WriteLine($"\nПлощадь прямоугольника = {s} см^2\n");
        }
    }
    class krug
    {
        private double perimetr;
        private double s;
        private double radius;
        public void Perimetr2()
        {
            Console.Write("Введите радиус круга r(см): ");
            radius = Convert.ToSingle(Console.ReadLine());

            perimetr = Math.Round(2 * Math.PI * radius, 3);

            Console.WriteLine($"\nПериметр круга = {perimetr} см");
        }
        public void S2()
        {
            s = Math.Round(Math.PI * (radius * radius), 3);
            Console.WriteLine($"\nПлощадь круга = {s} см^2\n");
        }
    }
    class triangle
    {
        private double perimetr;
        private double s;
        private double storona_a;
        private double storona_b;
        private double storona_c;
        private double summa_kvadratov1;//сторон в квадрате
        private double summa_kvadratov2;//сторон в квадрате
        private double summa1;//сумма сторон
        private double summa2;
        private double summa3;
        private double p;// Полупериметр для формулы герона
        public void Perimetr3()
        {
            Console.Write("Введите сторону треугольника a(см): ");
            storona_a = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите сторону треугольника b(см): ");
            storona_b = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите сторону треугольника с(см): ");
            storona_c = Convert.ToSingle(Console.ReadLine());

            summa_kvadratov1 = (storona_a * storona_a) + (storona_b * storona_b);
            summa_kvadratov2 = (storona_b * storona_b) + (storona_c * storona_c);
            summa1 = storona_a + storona_b;
            summa2 = storona_b + storona_c;
            summa3 = storona_a + storona_c;

            if (summa1 <= storona_c || summa2 <= storona_a || summa3 <= storona_b)
            {
                Console.WriteLine("\nТакой треугольник не существует! Попробуйте ввести данные ещё раз\n");
                Perimetr3();
            }
            else if (storona_a == storona_b && storona_b == storona_c)
            {
                Console.WriteLine("\nВаш треугольник равноcторонний!\n");
                perimetr = Math.Round(storona_a + storona_b + storona_c, 3);
                Console.WriteLine($"\nПериметр треугольника = {perimetr} см");
            }
            else if (storona_a == storona_b || storona_b == storona_c || storona_c == storona_a)
            {
                Console.WriteLine("\nВаш треугольник равнобедренный!\n");
                perimetr = Math.Round(storona_a + storona_b + storona_c, 3);
                Console.WriteLine($"\nПериметр треугольника = {perimetr} см");
            }
            else if (storona_a != storona_b || storona_b != storona_c || storona_c != storona_a)
            {
                Console.WriteLine("\nВаш треугольник разносторонний!\n");
                perimetr = Math.Round(storona_a + storona_b + storona_c, 3);
                Console.WriteLine($"\nПериметр треугольника = {perimetr} см");
            }

            if (summa_kvadratov1 == storona_c * storona_c || summa_kvadratov2 == storona_a * storona_a)
            {
                Console.WriteLine("\nВаш треугольник прямоугольный!\n");
                perimetr = Math.Round(storona_a + storona_b + storona_c, 3);
                Console.WriteLine($"\nПериметр треугольника = {perimetr} см");
            }
        }
        public void S3()
        {
            double p = (storona_a + storona_b + storona_c) / 2;
            s = Math.Round(Math.Sqrt(p * (p - storona_a) * (p - storona_b) * (p - storona_c)), 3);
            Console.WriteLine($"\nПлощадь треугольника = {s} см^2\n");
        }
    }
}