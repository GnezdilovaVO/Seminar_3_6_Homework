using static Library;
double c1 = GetNumber("Введите b1: ");
double d1 = GetNumber("Введите k1: ");
double c2 = GetNumber("Введите b2: ");
double d2 = GetNumber("Введите k2: ");
double[] newArray = GetResult(c1, d1, c2, d2);
//Console.WriteLine(GetResult(c1, d1, c2, d2));
Console.WriteLine(PrintArray(newArray));
