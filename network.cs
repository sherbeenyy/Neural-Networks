class Network {
    double weight1_1 , weight1_2 , weight2_1 , weight2_2 ;
    double bias1 , bias2; // bais gives the network the ability to shift the activation function to the left or right


    public int classify(double x1, double x2) {
        double output1 = x1 * weight1_1 + x2 * weight1_2 + bias1;
        double output2 = x1 * weight2_1 + x2 * weight2_2 + bias2;

        return( output1 > output2 )? 1 : 2;
  
    }
}