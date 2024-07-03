
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




}
