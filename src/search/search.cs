public static class Search
{
    public static int binarySearch(int[] arr, int l, int r, int h)
    {
        // Pokud zbývá jeden prvek končíme
        if (r >= l)
        {
            // Zjistíme střed vybrané části
            int mid = l + (r - l) / 2;

            // Pokud byl prvek nalezen, končíme
            if (arr[mid] == h)
                return mid;

            // Pokud je středový prvek větší než hledaný. Prvek musí být v na levé straně pole
            if (arr[mid] > h)
                return binarySearch(arr, l, mid - 1, h);


            // Pokud je středový prvek menší než hledaný. Prvek musí být v na pravé straně pole
            return binarySearch(arr, mid + 1, r, h);
        }

        // Prvek nebyl nalezen
        return -1;
    }
    public static int Linear<T>(IEnumerable<T> arr, T h)
    {
        int index = 0;
        // Procházím pole hledám prvek
        foreach (var t in arr)
        {
            //Nasel jsem prvek vrátím index
            if (h.Equals(t)) { return index; }
            //Zvětšuji index s každým průchodem
            index++;
        }
        // Prvek nebyl nalezen
        return -1;
    }
}