using static Library;
int Mm = GetM("Введите кол-во цифр: ");
int[] arrayNumbers = new int [Mm];
for (int i = 0; i < Mm; i++)
{
    arrayNumbers[i] = GetM("Введите следующую цифру: ");
}
Console.WriteLine("Ваши числа: " +PrintArray(arrayNumbers));
Console.WriteLine("Результат: " + GetPositiv(arrayNumbers));

