using System;

class GFG {
    
    // Returns index of x if it is present in arr[]
    static int binarySearch(int[] arr, int x)
    {
        int low = 0, high = arr.Length - 1;
        while (low <= high) {
            int mid = low + (high - low) / 2;

            // Check if x is present at mid
            if (arr[mid] == x)
                return mid;

            // If x greater, ignore left half
            if (arr[mid] < x)
                low = mid + 1;

            // If x is smaller, ignore right half
            else
                high = mid - 1;
        }

        // If we reach here, then element was
        // not present
        return -1;
    }

    // Driver code
    public static void Main()
    {
        int[] arr = { 2, 3, 4, 10, 40 };
        int n = arr.Length;

        Console.WriteLine("Array: [" + string.Join(", ", arr) + "]");

        Console.Write("Enter the number you want to search for: ");
        int x = Convert.ToInt32(Console.ReadLine());

        int result = binarySearch(arr, x);

        if (result == -1)
            Console.WriteLine("Element is not present in array");
        else
            Console.WriteLine("Element is present at index " + result);

        // Simple graphical representation of the binary search process
        Console.WriteLine("\nBinary Search Process:");
        Console.WriteLine("------------------------");
        Console.WriteLine("Low  | High  | Mid  | Result");
        Console.WriteLine("------------------------");

        int low = 0, high = n - 1;
        while (low <= high) {
            int mid = low + (high - low) / 2;

            Console.WriteLine(low + "    | " + high + "    | " + mid + "    | ");

            if (arr[mid] == x) {
                Console.WriteLine("Element found at index " + mid);
                break;
            }
            else if (arr[mid] < x) {
                low = mid + 1;
                Console.WriteLine("Ignoring left half...");
            }
            else {
                high = mid - 1;
                Console.WriteLine("Ignoring right half...");
            }
        }
    }
}
