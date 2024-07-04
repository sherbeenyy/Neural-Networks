class Neuron
{
    public double[] Weights;
    public double Bias;
    public double Output;
    public Neuron(int numOfInputs)
    {
        Random r = new Random();
        Weights = new double[numOfInputs];
        for (int i = 0; i < numOfInputs; i++)
        {
            Weights[i] = r.NextDouble();
        }
        Bias = r.NextDouble()+6;
    }
}