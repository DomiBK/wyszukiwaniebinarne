using System;

class BinarySearch
{
    // Metoda realizująca algorytm wyszukiwania binarnego
    static int BinarySearchAlgorithm(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            // Sprawdzenie czy znaleziono cel
            if (arr[mid] == target)
                return mid;

            // Jeśli element w środku jest mniejszy od celu, przesuwamy lewy wskaźnik
            if (arr[mid] < target)
                left = mid + 1;
            // W przeciwnym razie przesuwamy prawy wskaźnik
            else
                right = mid - 1;
        }

        // Jeśli nie znaleziono celu, zwracamy -1
        return -1;
    }

    static void Main()
    {
        // Tablica liczb całkowitych - zakładamy, że jest posortowana
        int[] arr = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };

        Console.Write("Podaj liczbę do wyszukania: ");
        int target = Convert.ToInt32(Console.ReadLine());

        // Wywołanie algorytmu wyszukiwania binarnego
        int result = BinarySearchAlgorithm(arr, target);

        // Wyświetlenie wyniku
        if (result != -1)
        {
            Console.WriteLine("Liczba znajduje się na indeksie: " + result);
        }
        else
        {
            Console.WriteLine("Liczba nie została znaleziona w tablicy.");
        }
    }
}
