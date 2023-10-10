// See https://aka.ms/new-console-template for more information
//Verilmiş arrayı tərsinə çevirib yeni array yaradın

int[] oldarray= { 23, 4, 64, 2, 67, 53 };
int extent = oldarray.Length;
int[] newarray = new int[extent];
for (int i = 0; i < oldarray.Length; i++)
{
    newarray[i] = oldarray[extent-1-i];
    Console.Write(newarray[i]+" ");
}
