﻿// Имеется одномерный массив array из n элементов, требуется
//найти элемент массива, равный find
//ПЕРЕВОД: показать какой индекс (n) в массиве (array) у написанного числа (find)


//             0  1 2  3  4 5  6  7
int[] array = {1,42,3,14,54,6,77,48}; //определяем массив

int n = array.Length; //обращается к длине массива (кол-ву элементов в массиве)
int find = 77; //число в массиве
int index = 0; //индексы в массиве начинается с 0

while (index < n){
  if(array[index] == find){
    Console.WriteLine(index);
    break; //если в массиве есть одинаковые числа, он покажет оба. Чтоб этого не было, он прервется на первом
    }
  index++;
}
