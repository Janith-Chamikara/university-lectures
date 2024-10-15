namespace DynamicArrayNamespace;

public class DynamicArray{
    private int size;
    private int count;
    private int[] array; 

    public DynamicArray(){
        size = 1;
        count = 0;
        array = new int[1];
    }

    public void Print(){
        for(int i = 0; i < size ; i++){
            Console.WriteLine($"{i}-{array[i]}");
        }
    }

    public void Add(int argItem){
        if(count == size ){
            Expand();
        }
        array[count] = argItem;
        count++;
    }

    public void RemoveAt(int argIndex){
        if(count < size / 4){
            Shrink();
        }

        if(argIndex < 0 || argIndex >= count){
            Console.WriteLine("Invalid Index");
            return;
        }

        for(int i = argIndex ; i < count - 1 ; i++){
            array[i] = array[i+1];
        }
        count--;
        
    }

    public void Shrink(){
        size = size  / 2;
        int [] tempArray = new int[size];
        Array.Copy(array, tempArray, count);
        array = tempArray;
    }

    public void Expand(){
        size = size * 2;
        int [] tempArray = new int[size];
        
        // for(int i = 0 ; i < count ; i++){
        //     tempArray[i] = array[i];
        // }

        Array.Copy(array, tempArray, count);
        array = tempArray; 
    }


}