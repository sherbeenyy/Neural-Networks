
class Network {

Random rand = new Random();
float [][][] weights;
float [][][] bias;
int [] layers;


public Network( int [] layers)
{
    this.layers = layers;
    initWeights();
    initBias();

}

private void initWeights()
    {
        weights = new float[layers.Length - 1][][];
        for (int i = 0; i < weights.Length; i++)
        {
            weights[i] = new float[layers[i + 1]][];
            for (int j = 0; j < layers[i + 1]; j++)
            {
                weights[i][j] = new float[layers[i]];
                for (int k = 0; k < layers[i]; k++)
                {
                        weights[i][j][k] = (float)rand.NextDouble();
                }
            }
        }
    }
private  void initBias(){
    bias = new float[layers.Length - 1][][];
        for (int i = 0; i < weights.Length; i++)
        {
            bias[i] = new float[layers[i + 1]][];
            for (int j = 0; j < layers[i + 1]; j++)
            {
                bias[i][j] = new float[layers[i]];
                for (int k = 0; k < layers[i]; k++)
                {
                        bias[i][j][k] = (float)rand.NextDouble();
                }
            }
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
public void display_bias()
{
    for (int i = 0; i < bias.Length; i++)
    {
        for (int j = 0; j < bias[i].Length; j++)
        {
            for (int k = 0; k < bias[i][j].Length; k++)
            {
                Console.WriteLine(bias[i][j][k]);

            }
        }
    }
}


}
