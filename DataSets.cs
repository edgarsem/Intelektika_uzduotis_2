using IronXL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intelektika_2_uzduotis
{
    internal class DataSets
    {
        private readonly WorkBook _trainingWorkBook;
        private readonly WorkSheet _trainingSheet;

        private readonly WorkBook _pridictWorkBook;
        private readonly WorkSheet _predictSheet;

        private Dictionary<string, int> _stringIntValues;
        private Dictionary<int, string> _intStringValues;

        public DataSets()
        {

            _trainingWorkBook = WorkBook.Load(@"C:\Users\maxim\Desktop\intelektika\Hotel Reservations.xlsx");
            _trainingSheet = _trainingWorkBook.GetWorkSheet("Hotel Reservations");

            _pridictWorkBook = WorkBook.Load(@"C:\Users\maxim\Desktop\intelektika\Hotel Reservations.xlsx");
            _predictSheet = _pridictWorkBook.GetWorkSheet("Hotel Reservations");

            _stringIntValues = new Dictionary<string, int> {
                {"Not_Canceled", 0}, {"Canceled", 1}
            };

            _intStringValues = new Dictionary<int, string>();
            foreach (var item in _stringIntValues)
            {
                _intStringValues[item.Value] = item.Key;
            }

        }

        public Dictionary<int, string> GetIntStringValues()
        {
            return _intStringValues;
        }

        public int GetStringIntValue(string key)
        {
            return _stringIntValues[key];
        }

        public string GetIntStringValue(int key)
        {
            return _intStringValues[key];
        }

        public double[][] GetTrainingInputs(int sampleSize, int sampleStart)
        {
            double[][] trainingInputs = new double[sampleSize][];
            for (int i = 0; i < sampleSize; i++)
            {
                trainingInputs[i] = new double[17];
                for (int j = 0; j < 17; j++)
                {
                    var cell = _trainingSheet.GetCellAt(i + sampleStart, j + 1);
                    trainingInputs[i][j] = cell.DoubleValue;
                }
            }
            return trainingInputs;
        }

        public int[] GetTrainingOutputs(int sampleSize, int sampleStart)
        {
            int[] trainingOutputs = new int[sampleSize];
            for (int i = 0; i < sampleSize; i++)
            {
                var cell = _trainingSheet.GetCellAt(i + sampleStart, 18);
                trainingOutputs[i] = _stringIntValues[cell.Text];
            }
            return trainingOutputs;
        }


        public double[][] GetPredictInputs(int sampleSize, int sampleStart)
        {
            double[][] predictInputs = new double[sampleSize][];
            for (int i = 0; i < sampleSize; i++)
            {
                predictInputs[i] = new double[17];
                for (int j = 0; j < 17; j++)
                {
                    var cell = _predictSheet.GetCellAt(i + sampleStart, j + 1);
                    predictInputs[i][j] = cell.DoubleValue;
                }
            }
            return predictInputs;
        }


        public string[] GetCorrectOutputs(int sampleSize, int sampleStart)
        {
            string[] correctOutputs = new string[sampleSize];
            for (int i = 0; i < sampleSize; i++)
            {
                correctOutputs[i] = _predictSheet.GetCellAt(i + 1 + sampleStart, 18).Text;
            }
            return correctOutputs;
        }
    }
}
