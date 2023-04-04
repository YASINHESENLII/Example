//1. Kiçikdən böyüyə siralanmış array-i böyükdən kiçiyə sıralayan alqoritm.
//Məsələn :numbers={1,3,4,6,8,9,11,24,56}  çevrilsin {56,24,11,9,8,6,4,3,1}

int[] numbers = new int[]{ 1, 5, 7, 9, 11, 17 };

for (int i = numbers.Length-1; i >= 0; i--)
{

    Console.WriteLine(numbers[i]); 
}




//2. Ədəd və rəqəmlərdən ibarət arrayda neçə rəqəm olduğunu ekrana çap edin 
//(Məs: {1,77,6,144} arrayında 2 rəqəm var)
int[] arr = { 1, 24 ,5,12,6,72,46,2,4};
int numbers = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] <= 9 && arr[i] >= 0)
    {
        numbers++;
    }
}
Console.WriteLine( numbers + "  reqem var");

//3. A, B ededleri arasinda 3-e tam bolunen ededleri tapan alqoritm

int a= 12;
int b = 6;
for (int i = b; i <a; i++)
{
    if (i % 3 ==0)
    {
       Console.WriteLine(i);
    }
}






//4. Verilmish ededin bolenleri sayini tapan algorithm
int num = 12;
int count = 0;
for (int i = 1; i < num; i++)
{
    if (num % i == 0)
        count++;
}

Console.WriteLine(count + "eded");
