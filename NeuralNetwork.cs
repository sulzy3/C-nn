namespace C_nn{
    public class NeuralNetwork{
        
        public List<Layer>? layers = new List<Layer>();
        public List<InputNeuron>? inputs { get; set; }
        public NeuralNetwork(List<int> input)
        {
            this.inputs = input.Select(i => new InputNeuron(i)).ToList();
        }

        public void AddLayer(int size)
        {
            var layer = new Layer();
            IEnumerable<Node>? neurons = layer.neurons == null ? this.inputs: this.layers?.Last().neurons;
            for (int i = 0; i < size; i++)
            {
                layer.neurons?.Add(new Neuron(neurons));
            }
            this.layers?.Add(layer);
        }
        public void run()
        {
            if(this.layers == null)
            {
                return;
            }
            foreach (var layer in layers)
            {
                if(layer.neurons == null)
                    continue;
                
                foreach (var neuron in layer.neurons)
                {
                    neuron.run();
                }
            }
        }
    }
}