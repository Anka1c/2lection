// Найти максисмальное из 9 чисел с помощью массива

int Max(int a, int b, int c){   //введем функцию, коорая будет сравнивать первые три числа
  int result = a; //внутренняя коробочка, где будут храниться значения
  if (b > result) result = b;
  if (c > result) result = c;
  return result;
} 
//    индексы   0  1   2   3   4   5   6  7  8
int [] array = {5, 96, 52, 36, 12, 54, 1, 3, 89};

int result = Max (
  Max(array[0], array[1], array[2]),
  Max(array[3], array[4], array[5]),
  Max(array[6], array[7], array[8]));

Console.WriteLine(result);