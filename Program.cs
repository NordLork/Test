// Запрос ручного ввода массива
string[] ReadArray(string msg)
{
  string str = string.Empty;
  while ((str == string.Empty) || (str == " "))
  {
    Console.Write(msg);
    str = Console.ReadLine() ?? " ";
  }
  string[] arr = str.Split(" ".ToArray(), StringSplitOptions.RemoveEmptyEntries).Select(x => x).ToArray();
  return arr;
}

// Вывод массива
void PrintArray(string[] arr)
{
  Console.Write("['");
  for (int i = 0; i < arr.Length - 1; i++)
  {
    Console.Write(arr[i] + "', '");
  }
  Console.WriteLine(arr[arr.Length - 1] + "']");
}

// Тест на длину строки
bool TestLength(string elem)
{
  if (elem.Length <= 3)
  {
    return true;
  }
  else
  {
    return false;
  }
}

// Создаём массив с элементами до 3-х символов включительно
string[] NeedElem(string[] arr)
{
  int res = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (TestLength(arr[i]))
    {
      res++;
    }
  }
  string[] existArr = new string[res];
  res = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (TestLength(arr[i]))
    {
      existArr[res] = arr[i];
      res++;
    }
  }
  return existArr;
}


string[] array = ReadArray("Введите элементы массива (через пробел): ");
Console.Write("Введён массив из следующих элементов: ");
PrintArray(array);
string[] result = NeedElem(array);
Console.Write("Получившийся массив из элементов до 3-х символов включительно: ");
PrintArray(result);
