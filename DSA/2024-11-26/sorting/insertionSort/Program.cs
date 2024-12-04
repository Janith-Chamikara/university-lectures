class InsertionSort {
    public void Sort(int [] array ){
        int N = array.Length;
        int [] sorted;

        //Loop the array starting from index 1 ie second element
        for(int i = 1 ; i < N ; i++){ // [10, 4 ,5]
            int key = array[i]; //4
            int j = i - 1;  //array[0] = 10

            while( j >= 0 && array[j] > key ){
                array[ j + 1 ] = array[j];
                j -= 1;
            } 
            array[ j + 1 ] = key;
        } 
    }

    static void PrintArray(int [] array){
        int N = array.Length;
        
        Console.Write("[ ");
        for(int i = 0 ; i < N ; i++ ){
            Console.Write($"{array[i]}{(i != N -1 ? ", " : "")}");
        }
        Console.WriteLine(" ]");
    }

    public static void Main(string [] args){
        int [] array = { 11, 34, 32, 5, 67, 8};
        InsertionSort obj = new InsertionSort();
        obj.Sort(array);
        PrintArray(array);
    }
}