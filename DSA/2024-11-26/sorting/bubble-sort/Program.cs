using bubble_sort;


int [] arrayToBeSorted = {1,23,56,2,34,1,34,9};
Console.Write("[ ");
for(int i = 0 ; i < 8; i++){
    Console.Write($"{arrayToBeSorted[i]} ,");
}
Console.WriteLine(" ]");

BubbleSort sorted_array = new BubbleSort(arrayToBeSorted,8);