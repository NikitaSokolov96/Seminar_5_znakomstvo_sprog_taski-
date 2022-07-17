static void DifOfMinAndMax(string[] args)

{
double dif = 0;

double sum = 0;

int max;

int min;

Console.WriteLine("Enter how many numbers u want");

int size = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[size];

max = arr[0];

min = arr[0];

for (int i = 0; i < size; i++)

{

arr[i] = (new Random()).Next(1,100);

if(arr[i] > max)

{

max=arr[i];

}

if (arr[i] < max)

{

    min = arr[i];

}
sum += arr[i];

Console.WriteLine(arr[i] + " ");
}

sum = sum - max - min;
dif = max - min;
Console.WriteLine("sum = {0}, difference = {1}, max = {2}, min = {3}", sum, dif, max, min);
}

DifOfMinAndMax(args);