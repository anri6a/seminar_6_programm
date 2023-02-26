// Задача 3: Задайте массив. Напишите программу, которая 
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
InputNumber
int InputNumber (string text)
{
    Console.WriteLine (text);
    int number = new Convert.ToInt32(Console.ReadLine ());
    return number;
}
int InputNumer = InputNumber ("Введите искомое число");


// 1. создать массив (Юлия)



// 2. заполнить рандомно (Дмитрий)
void FillArrayRandom (int[]array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(1, 1000);
  }
}
// 3. ввести искомую цифру (Андрей)
// 4. ищем число в массиве (Денис)
// 5. выводим да или нет (Санжар)
string ConsoleWrite (number)
{
if (number = 1) 
  { 
      Console.WriteLine("Yes"); 
  } 
  else 
  { 
      Console.WriteLine("No"); 
  }
}

int[]array = ;
FillArrayRandom(array);



