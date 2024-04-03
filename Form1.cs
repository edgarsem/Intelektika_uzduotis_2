using OxyPlot.Series;
using OxyPlot.WindowsForms;
using OxyPlot;
using Size = System.Drawing.Size;
using Accord.Statistics.Analysis;
using System.Diagnostics;

namespace Intelektika_2_uzduotis
{
    public partial class Form1 : Form
    {
        DataSets dataSets;
        public Form1()
        {
            InitializeComponent();
            dataSets = new DataSets();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            correctListBox.Items.Clear();
            svmListBox.Items.Clear();
            knnListBox.Items.Clear();

            int trainingSampleSize = Int32.Parse(sampleBox.Text);
            int trainingSampleStart = Int32.Parse(startBox.Text);

            int testingSampleSize = Int32.Parse(testSampleBox.Text);
            int testingSampleStart = Int32.Parse(testStartBox.Text);


            string[] correctOutputs = new string[trainingSampleSize];
            correctOutputs = dataSets.GetCorrectOutputs(testingSampleSize, testingSampleStart);
            for (int i = 0; i < correctOutputs.Length; i++)
            {
                correctListBox.Items.Add(i + 1 + ". " + correctOutputs[i]);
            }




            double[][] trainingInputs = dataSets.GetTrainingInputs(trainingSampleSize, trainingSampleStart);
            int[] trainingOutputs = dataSets.GetTrainingOutputs(trainingSampleSize, trainingSampleStart);
            double[][] predictInputs = dataSets.GetPredictInputs(testingSampleSize, testingSampleStart);


            Stopwatch stopwatch = Stopwatch.StartNew();

            int[] predictedSvm = SVM.Trainer(trainingInputs, trainingOutputs, predictInputs);

            stopwatch.Stop();
            TimeSpan svmTs = stopwatch.Elapsed;


            stopwatch = Stopwatch.StartNew();

            int[] predictedKnn = KNN.Trainer(trainingInputs, trainingOutputs, predictInputs);

            stopwatch.Stop();
            TimeSpan knnTs = stopwatch.Elapsed;


            int[] correctOutputsInt = new int[correctOutputs.Length];

            int svmCounter = 0;
            int knnCounter = 0;
            for (int i = 0; i < correctOutputs.Length; i++)
            {
                string svmValue = dataSets.GetIntStringValue(predictedSvm[i]);
                string knnValue = dataSets.GetIntStringValue(predictedKnn[i]);
                correctOutputsInt[i] = dataSets.GetStringIntValue(correctOutputs[i]);

                if (correctOutputs[i] == svmValue)
                    svmCounter++;
                if (correctOutputs[i] == knnValue)
                    knnCounter++;

                svmListBox.Items.Add(i + 1 + ". " + svmValue);
                knnListBox.Items.Add(i + 1 + ". " + knnValue);
            }
            label1.Text = "Correct predictions: " + knnCounter;
            label2.Text = "Time taken: " + knnTs.Seconds + "." + knnTs.Milliseconds;
            label3.Text = "Correct predictions: " + svmCounter;
            label4.Text = "Time taken: " + svmTs.Seconds + "." + svmTs.Milliseconds;
            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}