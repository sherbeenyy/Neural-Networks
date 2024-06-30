class Layer {
 int _nodesIN , _nodesOut ;
 double [,] weights;
 double [] bias;

 public Layer (int nodesIN , int nodesOut) {
  this._nodesIN = nodesIN;
  this._nodesOut = nodesOut;
  weights = new double[nodesIN , nodesOut];
  bias = new double[nodesOut];
 }

 public double [] forward (double [] input) {
  double [] output = new double[_nodesOut];
  for (int i = 0; i < _nodesOut; i++) {
   output[i] = 0;
   for (int j = 0; j < _nodesIN; j++) {
    output[i] += input[j] * weights[j , i];
   }
   output[i] += bias[i];
  }
  return output;
 }
}