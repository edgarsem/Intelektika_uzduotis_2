using Accord.MachineLearning.VectorMachines.Learning;
using Accord.MachineLearning.VectorMachines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.MachineLearning;
using Accord.Math.Distances;
using Accord.MachineLearning.Bayes;
using Accord.Statistics.Filters;
using System.Data;

namespace Intelektika_2_uzduotis
{
    internal static class KNN
    {
        public static int[] Trainer(double[][] trainingInputs, int[] trainingOutputs, double[][] predictInputs)
        {
            int k = 5;
            KNearestNeighbors knn = new KNearestNeighbors(k: 3);
            knn.Learn(trainingInputs, trainingOutputs);
            int[] predicted = knn.Decide(predictInputs);

            return predicted;
        }
    }
}
