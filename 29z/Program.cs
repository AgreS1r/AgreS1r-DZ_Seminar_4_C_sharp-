Console.WriteLine("Будет создан массив длиной A в диапвзоне 0-A");
Console.Write("Введите любое число (A): ");
Numbers = Convert.ToInt32(Console.ReadLine());

int[] array = new int[Numbers];

for (int i = 0; i < Numbers; i++)
{
    array[i] = new Random().Next(Numbers+1);
    Console.Write(array[i] + "; ");
}
