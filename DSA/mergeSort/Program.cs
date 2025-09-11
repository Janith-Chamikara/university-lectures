class MergeSort {

     static void Merge(int [] array , int left, int middle, int right){
        //Find the sizes of the sub arrays to be merge
        int n1 = middle - left + 1;
        int n2 = right - middle;

        //Create temp arrays
        int [] L = new int[n1];
        int [] R = new int [n2];
        int i,j;

        //Copy data to temp arrays
        for(i = 0 ; i < n1; i++){
            L[i] = array[left + i];
        }
        for(j = 0 ; j < n2; j++){
            R[j] = array[middle+1+j];
        }

        i = 0;
        j = 0;

        int k = left;
        while( i < n1 && j < n2){
            if(L[i] <= R[j]){
                array[k] = L[i];
                i++;
            }else{
                array[k] = R[j];
                j++;
            }
            k++;
        }

        //Copy remaining element
        while(i < n1){
            array[k] = L[i];
            i++;
            k++;
        }

        while(j < n2){
            array[k] = R[j];
            j++;
            k++;
        }

     }
     static public int[] Sort(int [] array, int left, int right){
        if(right > left){
            int middle = left + (right - left) / 2;

            Sort(array, left, middle);
            Sort(array, middle, right);
            Merge(array, left, middle + 1, right);
        }

        return array;
    }

    static void Print(int [] array){
            int size = array.Length;

            for(int i = 0 ; i < size; i++){
                Console.Write($" {array[i]} ");
            }
    }

    static void Main(string[] args){
        int [] arr = {12,23,2,4,56,2,12,34,23,345,2,1,45,23,2};
        Sort(arr,0,arr.Length-1);
        Print(arr);
    }
}