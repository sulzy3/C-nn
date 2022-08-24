namespace C_nn{
    public class NeuralNetwork{
        
        public List<List<Neuron>> layers = new();
        public List<InputNeuron> inputs { get; set; }
         public Func<double, double> activationFunction = ActivationFunctions.sigmoid;

         public void setActivationFunction(Func<double, double> activationFunction){
             this.activationFunction = activationFunction;
         }
        public NeuralNetwork(List<int> input)
        {
            this.inputs = input.Select(i => new InputNeuron(i)).ToList();
        }

        public void AddLayer(int size)
        {
            var layer = new List<Neuron>();
            IEnumerable<Node>? neurons = !layer.Any()? this.inputs: this.layers?.Last();
            for (int i = 0; i < size; i++)
            {
                var newNeuron = new Neuron(neurons);
                layer.Add(newNeuron);
            }
            this.layers?.Add(layer);
        } 
        public void train(List<double> expectedOutput){
            var results = this.run();
            var error = expectedOutput.Zip(results, (expected, actual) => expected - actual).ToList();

        }
        public List<double> run()
        {
            if(this.layers == null)
            {
                throw new NeuralNetworkException();
            }
            foreach (var layer in layers)
            {
                if(layer == null)
                    continue;
                
                foreach (var neuron in layer)
                {
                    neuron.run();
                }
            }
            return this.layers?.Last().Select(n => this.activationFunction(n.value)).ToList();
        }
    }
}