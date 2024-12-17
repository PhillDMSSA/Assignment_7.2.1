namespace Shell_Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 5;

            Console.WriteLine("Enter 5 numbers to get them sorted out: ");
            string[] nums = Console.ReadLine().Split(' ');

            int[] array = new int[size];

            for (int i = 0; i < size;  i++)
            {
                array[i] = Convert.ToInt32(nums[i]);
            }

            ShellSort(array);

            foreach(int num in array)
            {
                Console.Write(num + " ");
            }
           
        }
        static void ShellSort(int[] array)
        {
            int n = array.Length;
            
            //i = gap
            for (int i = n / 2; i > 0; i /= 2)
            {
                for (int j = i; j < n; j += 1)
                {
                    int temp = array[j];

                    int k;
                    for (k = j; k >= i && array[k - i] > temp; k -= i)

                        array[k] = array[k - i];

                    array[k] = temp;
                } 
            }
            
        }
    }
}
