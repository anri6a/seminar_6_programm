// Задача 3: Задайте массив. Напишите программу, которая 
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
int InputNumber (string text)
{
    Console.WriteLine (text);
    int number = new Convert.ToInt32(Console.ReadLine ());
    return number;
}
int InputNumer = InputNumber ("Введите искомое число");