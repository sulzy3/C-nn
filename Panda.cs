namespace C_nn{
public static class Panda{
    public static List<List<int>> ReadCsv(string filepath)
    {
        List<List<int>> data = new();
        using System.IO.StreamReader file = new System.IO.StreamReader(filepath);
        string? line = file.ReadLine();
        while ((line = file.ReadLine()) != null)
        {
            string[] values = line.Split(',');
            List<int> row = values.Select(int.Parse).ToList();
            data.Add(row);
        }
        return data;
    }
}
}