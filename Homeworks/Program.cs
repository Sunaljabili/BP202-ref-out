using System;

namespace Homeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task-1
            //int[] arr = { 12, 23, 34 };
            //int number = 9;
            //AdditionNum(ref arr, number);


            //Task-2
            //string name = "salam 1 2 3";
            //WithoutSpace(ref name);
            //Console.WriteLine(name);


            //Task-3
            //int[] numArray = { 1, 2, 3, 4, 5, 6, 7 };
            //SwapMaxMin(numArray);

            int[] values = { 1, 1, 2, 3, 4, 3, 5, 7, 3, 4 };
            Count(ref values);
            Console.WriteLine(values);

            #region Homeworks

            #region Task-1

            // 1. Parameter olaraq integer array variable-i ve bir integer
            // value qebul eden ve hemin integer value-nu integer array-e yeni
            //element kimi elave eden metod.
            //Misal üçün int[] nums = { 1, 5, 7 } deyə bir variable-mız var.
            //yazdığımız metodu çağırıb arqument olaraq nums və 3 göndərsək nums arrayının dəyəri  { 1,5,7,3}
            //olmalıdır.



            static void AdditionNum(ref int[] arr, int number)
            {

                int[] newArr = new int[arr.Length + 1];
                newArr[arr.Length] = number;

                for (int i = 0; i < arr.Length; i++)
                {

                    newArr[i] = arr[i];
                }

                arr = newArr;

                foreach (var item in arr)
                {
                    Console.WriteLine(item);

                }

            }

            #endregion


            #region Task-2
            //2. Parametr olaraq 1 string dəyər qəbul edən və həmin string
            //dəyəri icində bosluqlar qalmayacaq
            //hala gətirən metod.Misal olaraq, name = " Hikmet  Abbasov " deyə bir variable-mız varsa onu yaratdigimiz
            //metoda göndərdikdə variable-daki dəyər "HikmətAbbasov" olmalıdır.

            static void WithoutSpace(ref string word)
            {
                string empty = "";
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] != ' ')
                    {
                        empty += word[i];
                    }

                }
                word = empty;

            }

            #endregion

            #endregion



            #region Classworks


            #region Task-1
            // 1.Array-deki En Boyuk ededle en kicik ededin yerini deyishen method yazın.
            //[-12, 23, 43, 54, 65, 76]=>[76,23,43,54,65,76];


            //static void SwapMaxMin(int[] numbers)
            //{
            //    //int temp = 0;
            //    int max = numbers[0];
            //    int min = numbers[0];
            //    int maxIndex = 0;
            //    int minIndex = 0;
            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        if (numbers[i] > max)
            //        {
            //            max = numbers[i];
            //            maxIndex = i;
            //        }

            //        if (numbers[i] < min)
            //        {
            //            min = numbers[i];
            //            minIndex = i;
            //        }
            //    }

            //    //temp = numbers[minIndex];
            //    //numbers[minIndex] = numbers[maxIndex];
            //    //numbers[maxIndex] = temp;

            //    numbers[maxIndex] = min;
            //    numbers[minIndex] = max;

            //    foreach (var item in numbers)
            //    {
            //        Console.WriteLine(item);
            //    }

            //}

            #endregion

            //2.Verilmish array - de tekrar olunan ededlerin
            //sayini cixardan method yazın.
            // { 1,2,4,5,2,3,3}

            static void Count(ref int[] numbers)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    int count = 0;
                    
                    
                        for (int j = 0; j < numbers.Length; j++)
                        {
                            if (numbers[i]==numbers[j])
                            {
                                count++;
                            }
                        }

                    
                    if(count>1)
                        Console.WriteLine(numbers[i] + " elementi " + count + " defe tekrar olunub.");
                }
            }


            #endregion



        }
    }
}
