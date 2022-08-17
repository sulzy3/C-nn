namespace C_nn;

static class Program
{
    static void Main()
    {
        List<List<int>> data = Panda.ReadCsv("digit-recognizer/train.csv");

        var data_dev = data.Take(1000).ToList().Transpose<int>();
        List<int> y_dev = data_dev[0];
        var x_dev = data_dev.Skip(1).ToList();

        var data_train = data.Skip(1000).ToList().Transpose<int>();

    }
    
}