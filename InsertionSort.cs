class Solution{
    void InsertionSort(int[] arr){
        int n = arr.Length;

        for(int i = 1 ; i < n ; i++){
            int j = i;
            while(j>0 && arr[j]<arr[j-1]){
                int temp = arr[j];
                arr[j] = arr[j-1];
                arr[j-1] = temp;
                j = j-1;
            }
        }
    }

    public static void main(){
        int[] ar = new int[5]{9,8,7,6,5};
        InsertionSort(ar);
        for(int i = 0 ; i < ar.Length ; i++){
            Console.Write(arr[i]+" ");
        }
        Console.ReadLine();
    }
}