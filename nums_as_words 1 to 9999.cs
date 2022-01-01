using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nums_as_words
{
    /*
     * В классе Program создайте публичный статический метод GetIntAsString(), который принимает 1 целое число и возвращает строку:
     * 1) Если число от 1 до 9999 включительно – словесную форму полученного числа (Например: один (1), пятнадцать(15), одна тысяча девятьсот девяносто девять (1999))
     * 2) Если меньше 1 - "Слишком маленькое число".
     * 3) Если больше 9999 - "Слишком большое число".
     */

    public class Program
    {
        public static void Main(string[] args)
        {
             int num = Convert.ToInt32(Console.ReadLine());
             if (num > 9999)
                 Console.WriteLine("Слишком большое число");
             else if (num < 1)
                Console.WriteLine("Слишком маленькое число");
            else
                Console.WriteLine(GetIntAsString(num));
        }

        /* Добавьте свой код ниже */
        public static string OneNum(int num)
        {
            switch (num)
            {
                case 1:
                    return "один";
                case 2:
                    return "два";
                case 3:
                    return "три";
                case 4:
                    return "четыре";
                case 5:
                    return "пять";
                case 6:
                    return "шесть";
                case 7:
                    return "семь";
                case 8:
                    return "восемь";
                case 9:
                    return "девять";
                default:
                    return "";
            }
        }

        public static string teten(int num)
        {

            if (num / 100 == 0 && num / 10 > 0 && num / 10 < 10)
            {
                if (num / 10 > 0 && num / 10 < 10)
                {

                    int num_one = num / 10;
                    int num_two = num % 10;



                    if (num_one == 1)
                    {
                        if (num % 10 == 0)
                            return "десять";
                        else
                        {
                            num %= 10;
                            string end = "надцать";
                            if (num == 1 || num == 3)
                                return OneNum(num) + end;
                            else if (num == 2)
                                return "две" + end;
                            else
                            {
                                string one = OneNum(num);
                                one = one.Remove(one.Length - 1);
                                return one + end;
                            }
                        }
                    }
                    else if (num_one == 4)
                    {
                        if (num % 10 == 0)
                            return "сорок";
                        else
                            return "сорок " + OneNum(num_two);
                    }

                    else if (num_one == 9)
                    {
                        if (num_one % 10 == 0)
                            return "девяносто";
                        else
                            return "девяносто " + OneNum(num_two);
                    }

                    else if (num_one == 2 || num_one == 3)
                    {
                        if (num_one % 10 == 0)
                            return OneNum(num_one) + "дцать";
                        else
                            return OneNum(num_one) + "дцать " + OneNum(num_two);
                    }

                    else
                    {
                        if (num_one % 10 == 0)
                            return OneNum(num_one) + "десят";
                        else
                            return OneNum(num_one) + "десят " + OneNum(num_two);
                    }
                }
                else
                    return "error";
            }
            else
                return OneNum(num);
        }

        public static string kk(int num)
        {
            if (num / 1000 == 0 && num / 100 > 0 && num / 100 < 10)
            {
                if (num / 100 > 0 && num / 100 < 10)
                {
                    int num_o = num / 100;
                    int num_t = num % 100;

                    if (num_o == 1)
                    {
                        if (num_t == 0)
                            return "сто";
                        else
                            return "сто " + teten(num_t);
                    }
                    else if (num_o == 2)
                    {
                        if (num_t == 0)
                            return "двести";
                        else
                            return "двести " + teten(num_t);
                    }
                    else if (num_o == 3 || num_o == 4)
                    {
                        if (num_t == 0)
                            return OneNum(num_o) + "ста";
                        else
                            return OneNum(num_o) + "ста " + teten(num_t);
                    }
                    else
                    {
                        if (num_t == 0)
                            return OneNum(num_o) + "сот";
                        else
                            return OneNum(num_o) + "сот " + teten(num_t);
                    }
                }
                else
                    return "error";
            }
            else
                return teten(num);
        }

        public static string GetIntAsString(int num)
        {

            if (num / 10000 == 0 && num / 1000 > 0 && num / 1000 < 10)
            {
                if (num / 1000 > 0 && num / 1000 < 10)
                {
                    int num_o = num / 1000;
                    int num_t = num % 1000;

                    if (num_o == 1)
                    {
                        if (num_t == 0)
                            return "одна тысяча";
                        else
                            return "одна тысяча " + kk(num_t);
                    }
                    else if (num_o == 2)
                    {
                        if (num_t == 0)
                            return "две тысячи";
                        else
                            return OneNum(num_o) + " тысячи " + kk(num_t);
                    }
                    else if (num_o == 3 || num_o == 4) 
                    {
                        if (num_t == 0)
                            return OneNum(num_o) + " тысячи";
                        else
                            return OneNum(num_o) + " тысячи " + kk(num_t);
                    }
                    else
                    {
                        if (num_t == 0)
                            return OneNum(num_o) + " тысяч";
                        else
                            return OneNum(num_o) + " тысяч " + kk(num_t);
                    }
                }
  
                else
                    return "error";
            }
            else
                return kk(num);
        }
    }
}
