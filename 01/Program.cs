// Найти максимальное из 9 чисел


// 1 метод. Стихийный
int a = 102;
int b = 58;
int c = 41;
int d = 10;
int e = 33;
int f = 3;
int g = 96;
int h = 28;
int j = 16;

int max = a; //определяем переменную Максимум, кладем в нее значение 1го аргумента

if(b > max) max = b;
if(c > max) max = c;
if(d > max) max = d;
if(e > max) max = e;
if(f > max) max = f;
if(g > max) max = g;
if(h > max) max = h;
if(j > max) max = j;

Console.WriteLine(max);

// 2 метод. С применением функции
int a = 102;
int b = 58;
int c = 41;
int d = 10;
int e = 33;
int f = 3;
int g = 96;
int h = 280;
int j = 16;

int Max(int a, int b, int c){   //введем функцию, коорая будет сравнивать первые три числа
  int result = a; //внутренняя коробочка, где будут храниться значения
  if (b > result) result = b;
  if (c > result) result = c;
  return result;
}  

int max1 = Max(a, b, c); //промежуточные переменные, которые буду сравниваться между собой
int max2 = Max(d, e, f);
int max3 = Max(g, h, j);

int max = Max(max1, max2, max3);
Console.WriteLine(max);


//ИЛИ!!! Не вводя max1, max2, max3, просто впишем в Мax (3 метод)
int max = Max(Max(a, b, c), Max(d, e, f), Max(g, h, j));
Console.WriteLine(max);