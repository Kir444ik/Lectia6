// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.WriteLine(" What you want enter number ?");
int kol = Convert.ToInt32(Console.ReadLine());
int  integers = 0;
int[] array = FillingMassiv(kol);

int[] FillingMassiv( int size ){
    int[] arr = new int[size]; 
    for( int i = 0 ; i < size ; i++){
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}
Console.WriteLine("Your massiv");
for ( int i = 0 ; i < kol ; i++)
{   
    if (array[i] > 0 ) integers+=1;
    Console.Write($" {array[i]} " );
}
Console.Write($" ----> {integers} ");
