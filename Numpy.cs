namespace C_nn{
    public static class Numpy{
        public static List<List<T?>> Transpose<T>(this List<List<T>> inputLists)
    {
        int maxCount = inputLists.Max(l => l.Count);

        var result = Enumerable.Range(0, maxCount)
            .Select(index => inputLists.Select(list => list.ElementAtOrDefault(index))
                                       .ToList())
            .ToList();
        return result;
    }
    }
}