// task 10 sem#2 C#

/*
void second_digit (int arg)
{ int y;
    if (99 < arg && arg <= 999)
    {
        y = arg / 10;
        y = y % 10;
        Console.WriteLine("Второй разряд введённого числа = " + y);
    }
    else 
    Console.WriteLine("Введённое значение вне диапазона от 100 до 999");
}

Console.WriteLine("Введите целое число от 100 до 999");
int entervalue = Convert.ToInt32 (Console.ReadLine());//ввод параметра и приведение его к int32
second_digit(entervalue);//вызов метода без возвращения параметра (сразу выводит в консоль)
*/




// task 13 sem#2 C#

/*
void second_digit (int arg)
{ int y;
    if (99 < arg )
    {
        y = arg / 100;
        y = y % 10;
        Console.WriteLine("Третий разряд введённого числа = " + y);
    }
    else 
    Console.WriteLine("Введённое значение несодержит третьего разряда или вы ввели число в формате 001");
}

Console.WriteLine("Введите целое число");
int entervalue = Convert.ToInt32 (Console.ReadLine());//ввод параметра и приведение его к int32
second_digit(entervalue);
*/




// task 13 sem#2 C#

/*
void weekEnd (int arg)
{ 
    if ( arg < 1 || arg > 7 )
    {
        Console.WriteLine(arg + " - такого дня недели нет))) В неделе всего 7 дней!");
    }
    
    if ( arg > 0 && arg < 6)
    {
    Console.WriteLine(arg + " - это будний день! Извини, но собирайся на работу!))");
    }
    if (arg == 6 || arg == 7)    Console.WriteLine(arg + " - можешь не вставать - сегодня выходной!!");
        
}

Console.WriteLine("Введите целое число от 1 до 7");
int entervalue = Convert.ToInt32 (Console.ReadLine());//ввод параметра и приведение его к int32
weekEnd(entervalue);
*/ 