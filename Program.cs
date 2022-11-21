/*int data = 15;
Console.Write("Good morning! Today is " +data+ " november "); //(""+....+"")

Console.Write($"Good morning! Today is {data} november "); //($"...{...}...{...}..")
*/

//Напишите программу, которая получает на вход дузначное число и показывает наибольшую цифру числа.

/*int Digits(int number) //Объявление метода Digit: получает целое число, возвращает число
{
    int ed = number % 10; //поиск единиц в числе
    int dec = number / 10; //поиск десятков в числе
    int result;
    if(ed > dec){   //сравнение десятки и единицы
        result = ed;  //Завершение метода возвращение в программу десятки
    }
    else result = dec;
    return result;

}
Console.Write("input your 2bigit number: ");
int user_num = Convert.ToInt32(Console.ReadLine());
int res = Digits(user_num); //вызов метоода с аргументом user_num
Console.Write($"The biggest digit is {res}");
*/

//Напишите программу которая выводит случайное число из отрезка(10, 99)
//и показывает наибольшую цифру числа
/*int Digits() //Объявление метода Digit: получает целое число, возвращает целое число
{
    int randomNum = new Random().Next(10, 100);//генерация двузначно числа(число 100 не включается)
    Console.WriteLine("Your number is" + randomNum);

    int ed = randomNum % 10; //поиск единиц в числе
    int dec = randomNum / 10; //поиск десятков в числе
    int result;
    if(ed > dec){   //сравнение десятки и единицы
        result = ed;  //Завершение метода возвращение в программу десятки
    }
    else result = dec;
    return result;
}
Console.Write("The biggest digit is" +Digits());
*/

//Программа которая принимает на вход число и проверяет, кратно ли оно
//одновременно а и b.

/*void Cratnost(int num, int a, int b)
{
    if(num % a == 0 && num % b == 0)
    {
        Console.WriteLine($"Your number {num} is multirle of {a} и {b}");
    }
    else Console.WriteLine($"Your number {num} is not multirle of {a} и {b}");
}
Console.Write("Enter your number: ");
int user_num = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter your 1 divider: ");
int divider1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter your 2 divider: ");
int divider2 = Convert.ToInt32(Console.ReadLine());
Cratnost(user_num, divider1, divider2);
*/

//Программа, которая выводит случайное трехзначное число и удаляет
//вторую цифру этого числа

/*int deleteDec()
{
    int randomNum = new Random().Next(100,1000);
    Console.WriteLine("your number is" + randomNum);
    int fut_dec = randomNum / 100;//деление нацело
    int fut_ed = randomNum % 10;// деление с остатком
    
    int new_num = fut_dec * 10 + fut_ed;
    return new_num;
}
Console.WriteLine($"your new number is {deleteDec()}");
*/

//Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

/*int center ()
{
    int randomNum = new Random().Next(1, 1000);
    Console.WriteLine("your number is" + randomNum);
    int result = ((randomNum / 10)% 10);
    return result;
}
Console.WriteLine($"Вторая цифра введённого числа: {center()}");
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или 
//сообщает, что третьей цифры нет.

/*int thirdFig(int number)
{
    int c = number;
    int result = ((number / 10)% 10);
    if (number <= result)
    {
        Console.WriteLine($"Третья цифра: ");
    }
    return result; 
}
*/
//Не могу разобрать что дальше?

//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

/*void day(int num, int D, int W)
{
    if (D >= 1 && D <= 5)
    {
    Console.WriteLine($"Это будни {D} ");
    }
    if (W >= 6 && W <= 7)
    {
    Console.WriteLine($"Это выходной {W} ");
    }
}
Console.Write("Enter your day: ");
int num = Convert.ToInt32(Console.ReadLine());
*/

 

