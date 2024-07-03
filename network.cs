
class Network {

private Neuron [] input_layer;
private Neuron [] hidden_layer;
private Neuron [] output_layer;


public Network(int numOfInputs, int numOfHidden, int numOfOutputs){
    {
        input_layer = new Neuron[numOfInputs];
        hidden_layer = new Neuron[numOfHidden];
         output_layer = new Neuron[numOfOutputs];

        for (int i = 0; i < numOfInputs; i++)
        {
            input_layer[i] = new Neuron(1); 
        }
        for (int i = 0; i < numOfHidden; i++)
        {
            hidden_layer[i] = new Neuron(numOfInputs);
        }
        for (int i = 0; i < numOfOutputs; i++)
        {
            output_layer[i] = new Neuron(numOfHidden);
        }
    }
}

private double sigmoid(double function)
{
    return 1 / (1 + Math.Exp(-function));
}

private double sigmoid_derivative(double function)
{
    return function * (1 - function);
}

private double reLU(double function)
{
    return Math.Max(0, function);
}

private double reLU_derivative(double function)
{
    return function > 0 ? 1 : 0;
}


public double[] feedForward(double[] inputs)
{
    
    for (int i = 0; i < hidden_layer.Length; i++)
    {
        double sum = 0;
        for (int j = 0; j < inputs.Length; j++)
        {
            sum += inputs[j] * hidden_layer[i].Weights[j];
        }
        sum += hidden_layer[i].Bias;
        hidden_layer[i].Output = sigmoid(sum);
    }
    return hidden_layer.Select(neuron => neuron.Output).ToArray();
}
}