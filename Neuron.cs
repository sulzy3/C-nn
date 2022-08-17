namespace C_nn
{
    public interface Node{
        public double? value { get; set; }
       
    }
    public class Neuron : Node
    {
        public List<Connection>? connections { get; set; }
        public double? bias { get; set; }
        public double? value { get; set; }

        public Neuron(IEnumerable<Node>? neurons)
        {
            this.connections = neurons?.Select(n => new Connection(n)).ToList();
            this.bias = new Random().NextDouble();
        }


        public void run()
        => value = connections?.Select((connection) => connection?.node?.value * connection?.weight).Sum() + bias;
    }
    public class InputNeuron : Node
    {
        public double? value { get; set; }
        public InputNeuron(int value)
        {
            this.value = value;
        }
    }
}