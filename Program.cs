namespace L20250217
{
    internal class Program
    {
        class Singleton
        {
            private Singleton()
            {
            }

            static Singleton instance;

            
            static public Singleton Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }

                    return instance;
                }
            }
        }

        static void Main(string[] args)
        {
            //Engine.Instance.Load();
            //Engine.Instance.Run(); 

            // 1 ->> 10 ascending order
            // 10 ->> 1 descending order

            int[] numbers = {6,5,2,3,1,7,8,10,9};

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i] + ", ");
            }

            //engine.Stop();
        }
    }
}
