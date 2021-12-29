using System;
using System.Linq;

namespace Arrays_1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            // readAndPrintElementsOfArray();
            // readNValuesAndDisplayTheReverse();
            // getSumOfAllElementsInArray();
            // copyElementsFromOneArrayToAnother();
            // getTotalNumberOfDuplicates();
            // getUniqueElementsOfArray();
            // mergeTwoArraysOfSameSizeInAscendingOrder();
            // mergeTwoArraysOfSameSizeInAscendingOrder();
            countTheFrequencyOfEachElementOfAnArray();
            findMinAndMaxElementOfArray();
            seperateOddAndEvenIntegers();
            Console.ReadLine();
        }

        static int getUserInput() => Convert.ToInt32(Console.ReadLine());

        //program to store elements in an array and print it.
        static void readAndPrintElementsOfArray()
        {

            int[] array1 = new int[10];

            Console.Write("\n\nRead and Print elements of an array : ");
            Console.Write("\n\n-----------------------------------------");

            Console.Write("\n\nInput 10 elements in the array : \n\n");
            for (int i = 1; i <= array1.Length; i++)
            {
                int index = i - 1;
                Console.Write("element-{0} - ", i);
                array1[index] = getUserInput();
            }

            Console.Write("\n\nElements in array are : ");
            foreach (int j in array1)
            {
                Console.Write("\t{0}", j);
            }

        }

        //program to read n number of values in an array and display it in reverse order
        static void readNValuesAndDisplayTheReverse()
        {

            int[] array1 = new int[0];

            Console.Write("\n\nInput the number of elements to store in array : ");
            int n = getUserInput();
            Array.Resize(ref array1, n);
            Console.Write("\n\n-----------------------------------------");

            Console.Write("\n\nInput {0} elements in the array : \n\n", n);
            for (int i = 1; i <= array1.Length; i++)
            {
                int index = i - 1;
                Console.Write("element-{0} - ", i);
                array1[index] = getUserInput();
            }

            Console.Write("\n\nThe values stored into the array are : ");
            foreach (int j in array1)
            {
                Console.Write("\t{0}", j);
            }

            Console.Write("\n\nThe values stored into the array in reverse are : ");
            Array.Reverse(array1);
            foreach (int k in array1)
            {
                Console.Write("\t{0}", k);
            }

        }

        //prorgram to find the sum of all elements of the array1,
        static void getSumOfAllElementsInArray()
        {

            int sum = 0;
            int[] array1 = new int[0];

            Console.Write("\n\nInput the number of elements to store in array : ");
            int n = getUserInput();
            Array.Resize(ref array1, n);
            Console.Write("\n\n-----------------------------------------");

            Console.Write("\n\nInput {0} elements in the array : \n\n", n);
            for (int i = 1; i <= array1.Length; i++)
            {
                int index = i - 1;
                Console.Write("element-{0} - ", i);
                int input = getUserInput();
                array1[index] = input;
                sum += input;
            }

            Console.Write("\n\nSum of all elements stored in array is : {0}", sum);
        }

        //program to copy the elements one array into another array
        static void copyElementsFromOneArrayToAnother()
        {
            int[] array1 = new int[0];
            int[] array2 = new int[0];

            Console.Write("\n\nInput the number of elements to store in array : ");
            int n = getUserInput();
            Array.Resize(ref array1, n);
            Console.Write("\n\n-----------------------------------------");

            Console.Write("\n\nInput {0} elements in the array : \n\n", n);
            for (int i = 1; i <= array1.Length; i++)
            {
                int index = i - 1;
                Console.Write("element-{0} - ", i);
                int input = getUserInput();
                array1[index] = input;
            }

            Console.Write("\n\nThe elements stored into the first array are : ");
            Array.Resize(ref array2, array1.Length);
            for (int j = 0; j < array1.Length; j++)
            {
                int itemFromArray1 = array1[j];
                Console.Write("\t{0}", itemFromArray1);
                array2[j] = itemFromArray1;
            }

            Console.Write("\n\nThe elements copied into the second array are : ");
            foreach (int j in array2)
            {
                Console.Write("\t{0}", j);
            }
        }

        //program to count a total number of duplicate elements in an array1,
        static void getTotalNumberOfDuplicates()
        {
            int totalDuplicates = 0;

            int[] array1 = new int[1];
            int[] array2 = new int[1];
            int[] array3 = new int[1];
            int[] array4 = new int[1];

            Console.Write("\n\nCount total number of duplicate elements in an array : ");
            Console.Write("\n\n-------------------------------------------------");

            Console.Write("\n\nInput the number of elements to be stored in the array : ");
            int n = getUserInput();

            Array.Resize(ref array1, n);
            Array.Resize(ref array2, n);
            Array.Resize(ref array3, n);
            Array.Resize(ref array4, n);

            Console.Write("\n\nInput {0} elements in the array : ", n);
            Console.Write("\n\n");

            for (int i = 0; i < n; i++)
            {
                Console.Write("element - {0} - ", i);
                int element = getUserInput();
                array1[i] = element;
            }

            for (int j = 0; j < n; j++)
            {
                int arrayElement = array1[j];
                if (!array2.Contains(arrayElement))
                {
                    array2[j] = arrayElement;
                }
                else
                {
                    array3[j] = arrayElement;
                }
            }

            for (int i = 0; i < n; i++)
            {
                int arrayElement = array3[i];
                if (!array4.Contains(arrayElement))
                {
                    array4[i] = arrayElement;
                    totalDuplicates++;
                }
            }

            Console.Write("\n\nThe number of duplicate elements is : {0}", totalDuplicates);
        }

        static void getUniqueElementsOfArray()
        {
            int[] array1 = new int[1];
            int[] array2 = new int[1];
            int[] array3 = new int[1];
            int[] array4 = new int[1];

            Console.Write("\n\nGet unique elements from an array : ");
            Console.Write("\n\n-------------------------------------------------");

            Console.Write("\n\nInput the number of elements to be stored in the array : ");
            int n = getUserInput();

            Array.Resize(ref array1, n);
            Array.Resize(ref array2, n);
            Array.Resize(ref array3, n);
            Array.Resize(ref array4, n);

            Console.Write("\n\nInput {0} elements in the array : ", n);
            Console.Write("\n\n");

            for (int i = 0; i < n; i++)
            {
                Console.Write("element - {0} - ", i);
                int element = getUserInput();
                array1[i] = element;
            }

            for (int j = 0; j < n; j++)
            {
                int arrayElement = array1[j];
                if (!array2.Contains(arrayElement))
                {
                    array2[j] = arrayElement;
                }
                else
                {
                    array3[j] = arrayElement;
                }
            }

            for (int i = 0; i < n; i++)
            {
                int arrayElement = array3[i];
                if (!array4.Contains(arrayElement))
                {
                    array4[i] = arrayElement;
                }
            }

            Console.Write("\n\nThe unique elements found in the array are  : ");

            for (int i = 0; i < n; i++)
            {
                int array1Element = array1[i];
                int array4Element = array4[i];
                bool isArray1ElementContainedInArray4 = array4.Contains(array1Element);
                if (!isArray1ElementContainedInArray4)
                {
                    int uniqueElement = array1[i];
                    Console.Write("{0}, ", uniqueElement);
                }
            }


        }

        //program to merge two arrays of same size sorted in ascending order
        static void mergeTwoArraysOfSameSizeInAscendingOrder()
        {
            int[] array1 = new int[0];
            int[] array2 = new int[0];
            int[] mergedArray = new int[0];
            Console.Write("\n\nMerge two arrays of same size sorted in ascending order.");
            Console.Write("\n\n------------------------------------------------------------");

            Console.Write("\n\nInput the number of elements to be stored in the first array :");
            int n = getUserInput();
            int doubleTheInput = n * 2;

            Array.Resize(ref array1, n);
            Array.Resize(ref array2, n);
            Array.Resize(ref mergedArray, doubleTheInput);

            Console.Write("\n\nInput {0} elements in the array : \n\n", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                int input = getUserInput();
                array1[i] = input;
            }

            Console.Write("\n\nInput {0} elements in the second array : \n\n", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                int input = getUserInput();
                array2[i] = input;
            }

            mergedArray = array1.Concat(array2).ToArray();
            Array.Sort(mergedArray);
            Console.Write("\n\nThe merged array in ascending order is : ");
            string mergedArrayAsString = String.Join(" ", mergedArray);
            Console.Write("{0}", mergedArrayAsString);
        }

        //program to count the frequency of each element of an array.
        static void countTheFrequencyOfEachElementOfAnArray()
        {
            int[] userInput = new int[1];
            int[] frequencyOfElements = new int[1];
            int[] elementsAlreadyCounted = new int[1];

            Console.Write("\n\nCount the frequency of each element of an array : ");
            Console.Write("\n\n-------------------------------------------------");

            Console.Write("\n\nInput the number of elements to be stored in the array : ");
            int n = getUserInput();

            Array.Resize(ref userInput, n);
            Array.Resize(ref elementsAlreadyCounted, n);
            Array.Resize(ref frequencyOfElements, n);

            Console.Write("\n\nInput {0} elements in the array : ", n);
            Console.Write("\n\n");

            for (int i = 0; i < n; i++)
            {
                Console.Write("element - {0} - ", i);
                int element = getUserInput();
                userInput[i] = element;
            }

            Console.Write("\n");

            for (int j = 0; j < n; j++)
            {
                int arrayElement = userInput[j];
                int count = 0;
                for (int k = 0; k < n; k++)
                {
                    int item = userInput[k];
                    if (arrayElement == item)
                    {
                        count++;
                        if (!elementsAlreadyCounted.Contains(arrayElement))
                        {
                            Array.Resize(ref elementsAlreadyCounted, elementsAlreadyCounted.Length + 1);
                            Array.Resize(ref frequencyOfElements, frequencyOfElements.Length + 1);
                            elementsAlreadyCounted[j] = arrayElement;
                        }
                    }
                }
                int indexOf = Array.IndexOf(elementsAlreadyCounted, arrayElement);
                frequencyOfElements[indexOf] = count;
            }

            for (int i = 0; i < elementsAlreadyCounted.Length; i++)
            {
                int element = elementsAlreadyCounted[i];
                int count = frequencyOfElements[i];
                if (element != 0)
                {
                    Console.Write("\n{0} - {1} Occurence(s)", element, count);
                }

            }

        }

        //program to find maximum and minimum element in an array.
        static void findMinAndMaxElementOfArray()
        {
            int[] userInput = new int[1];
            Console.Write("\n\nTo find minimum and maximum element in an array : ");
            Console.Write("\n\n-------------------------------------------------");

            Console.Write("\n\nInput the number of elements to be stored in the array : ");
            int n = getUserInput();

            Array.Resize(ref userInput, n);

            Console.Write("\n\nInput {0} elements in the array : ", n);
            Console.Write("\n\n");

            for (int i = 0; i < n; i++)
            {
                Console.Write("element - {0} - ", i);
                int element = getUserInput();
                userInput[i] = element;
            }

            Array.Sort(userInput);

            int min = userInput.First();
            int max = userInput.Last();

            Console.Write("\n\nMinimum element is : {0}\n\nMaximum element is : {1}", min, max);

        }

        //program to separate odd and even integers in separate arrays
        static void seperateOddAndEvenIntegers()
        {
            int[] userInput = new int[1];

            Console.Write("\n\nTo seperate odd and even integers and store in seperate arrays : ");
            Console.Write("\n\n-------------------------------------------------");

            Console.Write("\n\nInput the number of elements to be stored in the array : ");
            int n = getUserInput();

            Array.Resize(ref userInput, n);

            Console.Write("\n\nInput {0} elements in the array : ", n);
            Console.Write("\n\n");

            for (int i = 0; i < n; i++)
            {
                Console.Write("element - {0} - ", i);
                int element = getUserInput();
                userInput[i] = element;
            }

            int[] odd = userInput.Where((i) => (i % 2 == 0)).ToArray();
            int[] even = userInput.Where((i) => (i % 2 != 0)).ToArray();

            string oddIntsAsString = String.Join(", ", odd);
            string evenIntsAsString = String.Join(", ", even);

            Console.Write("\n\nOdd numbers - {0}", oddIntsAsString);
            Console.Write("\n\nEven numbers - {0}", evenIntsAsString);
        }
    }
}
