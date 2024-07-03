
class Program
{
    static void Main()
    {
        int [] layers = [2, 3, 2]; // 2 input nodes, 3 hidden nodes, 1 output node
        Network n = new Network(layers);  
        n.display_weights();

        Console.WriteLine("Bias:");
        n.display_bias();
        

    }
}



