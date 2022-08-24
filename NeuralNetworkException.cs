[System.Serializable]
public class NeuralNetworkException : System.Exception
{
    public NeuralNetworkException() { }

    public NeuralNetworkException(string message) : base(message) { }
    public NeuralNetworkException(string message, System.Exception inner) : base(message, inner) { }
    protected NeuralNetworkException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}