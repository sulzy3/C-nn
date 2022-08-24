namespace C_nn
{
    public class Connection
    {
        public double weight { get; set; }
        public Node node { get; set; }
    
    public Connection(Node node)
    {
        var rand = new Random();
        this.weight = rand.NextDouble();
        this.node = node;
    }

    }
}