//Создание метода viod, FillArray, PrintArray c использованием генерирования случайных чисел

void FillArray(int[] collection){
  int length = collection.Length;
  int index = 0;
  while(index < length){
    collection[index] = new Random().Next (1, 10);
    index++;
  }

}
void PrintArray(int[] col){
  int count = col.Length;
  int position = 0;
  while(position < count){
    Console.WriteLine(col[position]);
    position++;
  }
}
int[] array = new int[10]; //в массиве 10 элементов
FillArray(array); //заполнил массив
PrintArray(array); // распечатал массив
