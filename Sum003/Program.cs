int numberA = new Random().Next(1, 10);  // 1 2 3 4 .... 9
Console.WriteLine($"{numberA}, числоА ");
int numberB = new Random().Next(1, 10);
Console.WriteLine($"{numberB}, числоВ");
int result = numberA + numberB;
Console.Write($"{result}, ");