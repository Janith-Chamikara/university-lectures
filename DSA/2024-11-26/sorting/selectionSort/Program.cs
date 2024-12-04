class SelectionSort {
    static void Sort(int [] array){
        int N = array.Length;
        
        for(int i = 0;  i < N -1 ; i++){
            int minIdx = i;

            for( int j = i + 1; j < N; j++ ){
                if(array[j] < array[minIdx]){
                    minIdx = j;
                }
            }

            int temp = array[i];
            array[i] = array[minIdx];
            array[minIdx] = temp;

        }
    }

    static void PrintArray(int [] array){
        Console.Write("[ ");
        foreach(int val in array){
            Console.Write($"{val} ,");
        }
        Console.Write(" ]");

    }


    public static void Main(string [] args){
        int[] array =  {12, 34, 45, 2, 34, 34 };
        Sort(array);
        PrintArray(array);
    }
}