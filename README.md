# wyszukiwaniebinarne
Algorytm wyszukiwania binarnego działa na posortowanej liście danych. Jego działanie można opisać następująco:
Inicjalizacja zmiennych: 

Na początku ustalamy dwa wskaźniki, lewy (left) i prawy (right), które wskazują odpowiednio na pierwszy i ostatni element listy.
Podział przedziału: W każdej iteracji obliczamy indeks środkowy (mid) przedziału między wskaźnikami lewym i prawym.
Sprawdzenie wartości środkowej: Porównujemy wartość elementu na pozycji mid z naszym poszukiwanym celem.
Jeśli wartość array[mid] jest równa celowi, to znaczy, że znaleźliśmy cel i zwracamy indeks mid.
Jeśli wartość array[mid] jest mniejsza od celu, przesuwamy lewy wskaźnik left na pozycję mid + 1, aby kontynuować przeszukiwanie w prawej części listy.
Jeśli wartość array[mid] jest większa od celu, przesuwamy prawy wskaźnik right na pozycję mid - 1, aby kontynuować przeszukiwanie w lewej części listy.
Kontynuacja iteracji: Powyższe kroki powtarzamy, dopóki wskaźnik left nie przekroczy wskaźnika right. Jeśli nie znajdziemy celu, a left przekroczy right, to oznacza, że cel nie istnieje w liście, i zwracamy -1.
Algorytm ten jest bardzo wydajny, ponieważ w każdej iteracji redukuje liczbę możliwych pozycji o połowę, co prowadzi do czasu działania proporcjonalnego do logarytmu z liczby elementów w liście.

Napisz program, który implementuje algorytm wyszukiwania binarnego w posortowanej tablicy liczb całkowitych. Program powinien umożliwiać użytkownikowi wprowadzenie poszukiwanej liczby oraz wyświetlenie indeksu tej liczby w tablicy, jeśli zostanie znaleziona, lub informacji o jej braku.
