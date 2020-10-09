using System;

namespace oop3_laba
{
    class Time
    {
        public static int eq = 100;
        private int number;
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
        private sbyte sec;
        public sbyte Sec
        {
            get
            {
                return sec;
            }

            set
            {
                if (sec > 60 && sec < 0)
                {
                    Console.WriteLine("Секунды не могут быть больше 60 и меньше 0");
                }
                else
                {
                    sec = value;
                }
            }
        }

        private sbyte minutes;
        public sbyte Minutes
        {
            get
            {
                return minutes;
            }

            set
            {
                if (minutes > 60 && minutes < 0)
                {
                    Console.WriteLine("Минуты не могут быть больше 60 и меньше 0");
                }
                else
                {
                    minutes = value;
                }
            }
        }

        private ushort hours;
        public ushort Hours
        {
            get
            {
                return hours;
            }

            set
            {
                if (hours > 24 && sec < 0)
                {
                    Console.WriteLine("Часы не могут быть больше 24 и меньше 0");
                }
                else
                {
                    hours = value;
                }
            }
        }

        const int amount = 24;
        private readonly int ID;
        public static int kolvo = 0;
        public Time()
        {
            Sec = 0;
            Minutes = 50;
            Hours = 9;
            Number = kolvo + 1;
            kolvo++;
        }

        public Time(sbyte a, sbyte b, ushort c)
        {
            Sec = a;
            Minutes = b;
            Hours = c;
            Number = kolvo + 1;
            kolvo++;
        }

  //     public Time(sbyte a = 6, ushort c = 8)
  //      {
  //          Sec = a;
  //          Hours = c;
  //          Number = kolvo + 1;
  //          kolvo++;
  //      }

        static Time()
        {
            Console.WriteLine("Статический конструктор");
            kolvo++;
        }

        public static int AmountOut(ref int amount, out int Output)
        {
            return Output = amount;
        }

        static string info = "Класс, для представления информации о времени";
        public static string GetInfo()
        {
            return info;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Time ti = obj as Time;
            if (ti as Time == null)
                return false;

            return ti.number == this.number;
        }
        public override int GetHashCode()
        {
            int hours1;
            if (hours == 10)
                hours1 = 1;
            else hours1 = 2;
            return (int)amount + hours1;
        }
        public override string ToString()
        {
            return $"{hours} {minutes} {sec}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int u = Time.eq;
            Time tim1 = new Time(16,17,5);
            Time tim2 = new Time(10, 20, 11);
            Time tim3 = new Time(15, 12, 17);
            Console.WriteLine(Time.kolvo);
            Console.WriteLine(tim1.GetType());
            Time[] times = new Time[] { tim1, tim2, tim3 };
            int hour = Convert.ToInt32(Console.ReadLine());
            for (int i = 0;i<times.Length;i++)
            {
                if(times[i].Hours== hour)
                {
                    Console.WriteLine(times[i]);
                }
            }
            for (int i = 0;i<times.Length;i++)
            {
                if(times[i].Hours<6)
                {
                    Console.WriteLine(times[i] + " это ночь");
                }
                else if (times[i].Hours<12 && times[i].Hours>6)
                {
                    Console.WriteLine(times[i] + " это утро");
                }
                else if(times[i].Hours<18 && times[i].Hours>12)
                {
                    Console.WriteLine(times[i] + " это день");
                }
                else
                {
                    Console.WriteLine(times[i] + "это вечер");
                }
            }
            var time = new { sec = 7, minutes = 14, hours = 21 };
            Console.WriteLine($"{time.hours} {time.minutes} {time.sec}");
        }
    }
    // статика
    // методы класса System.object
    // ref  out 
    // аноннимный тип
}
