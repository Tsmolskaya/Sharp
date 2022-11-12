// Составить программу вывода на экран «столбиком» 
//пяти любых чисел, введенных пользователем с клавиатуры.

//Console.WriteLine("Hello, World!");

int firstNumber;
int secondNumber;
int thirdNumber;
int fourNumber;
int fiveNumber;

Console.WriteLine("Введите 1 число: ");
firstNumber = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine("Введите 2 число: ");
secondNumber = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine("Введите 3 число: ");
thirdNumber = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine("Введите 4 число: ");
fourNumber = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine("Введите 5 число: ");
fiveNumber = Convert.ToInt32(Console.ReadLine ());

Console.WriteLine("Выводим введённые числа: ");
Console.WriteLine("firstNumber");
Console.WriteLine("secondNumber");
Console.WriteLine("thirdNumber");
Console.WriteLine("fourNumber");
Console.WriteLine("fiveNumber");
