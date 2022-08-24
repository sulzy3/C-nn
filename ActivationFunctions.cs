namespace C_nn{
    public class ActivationFunctions{
        public static double sigmoid(double x){
            return 1 / (1 + Math.Exp(-x));
        }
        public static double sigmoidDerivative(double x){
            return x * (1 - x);
        }
        public static double tanh(double x){
            return Math.Tanh(x);
        }
        public static double tanhDerivative(double x){
            return 1 - Math.Pow(x, 2);
        }
        public static double relu(double x){
            return Math.Max(0, x);
        }
        public static double reluDerivative(double x){
            return x > 0 ? 1 : 0;
        }
        public static double leakyRelu(double x){
            return x > 0 ? x : 0.01 * x;
        }
        public static double leakyReluDerivative(double x){
            return x > 0 ? 1 : 0.01;
        }
        
    }
        
}