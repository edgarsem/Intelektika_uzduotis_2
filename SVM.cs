using Accord.MachineLearning.VectorMachines.Learning;
using Accord.MachineLearning.VectorMachines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Statistics.Kernels;

namespace Intelektika_2_uzduotis
{
    internal static class SVM
    {
        public static int[] Trainer(double[][] trainingInputs, int[] trainingOutputs, double[][] predictInputs)
        {
            var teacher = new MulticlassSupportVectorLearning<Gaussian>()
            {
                Learner = (param) => new SequentialMinimalOptimization<Gaussian>()
                {
                    Complexity = 100
                }
            };

            MulticlassSupportVectorMachine<Gaussian> machine = teacher.Learn(trainingInputs, trainingOutputs);

            int[] predicted = predictInputs.Select(input => machine.Decide(input)).ToArray();
            return predicted;
        }
    }
}
