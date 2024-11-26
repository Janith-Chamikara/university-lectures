namespace bubble_sort;

public class BubbleSort {
    //get array and size in constructor
    public BubbleSort(int [] array, int N){
        int i, j, temp;
        bool swapped;

        for(i = 0 ; i < N -1 ; i++){
            swapped = false;
            for(j = 0 ; j < N - i -1 ; j++){
                if(array[j] > array[j+1]){
                    temp = array[j+1];
                    array[j+1] = array[j];
                    array[j] = temp;
                    swapped = true;
                }
            }
            if(!swapped){
                break;
            }
        }

        Print(N,array);

    }
    public void Print(int N, int [] array){
        Console.Write("[ ");
        for(int i = 0 ; i < N ; i++){
            Console.Write($"{array[i]}, ");
        }
        Console.Write(" ]");
    }
}


