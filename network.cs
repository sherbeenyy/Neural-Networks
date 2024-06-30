class Network {
   Layer [ ] layers ;

   public Network (int [] nodes) {
      layers = new Layer[nodes.Length - 1];
      for (int i = 0; i < nodes.Length - 1; i++) {
         layers[i] = new Layer(nodes[i], nodes[i + 1]);
      }
   }

    public double [] forward (double [] input) {
        double [] output = input;
        for (int i = 0; i < layers.Length; i++) {
            output = layers[i].forward(output);
        }
        return output;
    }

    int classify (double [] input) {
        double [] output = forward(input);
        int maxIndex = 0;
        for (int i = 1; i < output.Length; i++) {
            if (output[i] > output[maxIndex]) {
                maxIndex = i;
            }
        }
        return maxIndex;
    }
}