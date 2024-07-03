class Network {

Random rand = new Random();
double [][][] weights;
double [] bias;
int [] neurons;
int [] layers;


public Network( int [] layers)
{
    this.layers = layers;
    initWeights();
    initBias();

}

private void initWeights()
    {
        weights = new double[layers.Length - 1][][];
        for (int i = 0; i < weights.Length; i++)
        {
            weights[i] = new double[layers[i + 1]][];
            for (int j = 0; j < layers[i + 1]; j++)
            {
                weights[i][j] = new double[layers[i]];
                for (int k = 0; k < layers[i]; k++)
                {
                        weights[i][j][k] = rand.NextDouble();
                }
            }
        }
    }

private initBias(){

    bias = new double[layers.Length - 1];
    for (int i = 0; i < bias.Length; i++)
    {
        bias[i] = rand.NextDouble();
    }
}

public void display_weights()
{
    for (int i = 0; i < weights.Length; i++)
    {
        for (int j = 0; j < weights[i].Length; j++)
        {
            for (int k = 0; k < weights[i][j].Length; k++)
            {
                Console.WriteLine(weights[i][j][k]);

            }
        }
    }
}
}