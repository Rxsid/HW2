Console.WriteLine("Введите номер дня недели");
int n = Convert.ToInt32(Console.ReadLine());
if(n >5 && n <8)
    {
    Console.WriteLine("Выходной");
    }
else if(n > 0 && n <6)
    {
    Console.WriteLine("Рабочий день");
    }
else 
    {
    Console.WriteLine("Не существующий номер дня недели");
    }