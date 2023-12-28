using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MathNet.Numerics.LinearAlgebra;

namespace SimpleUserInterface
{
    public partial class PredictionDataForm : Form
    {
        private DateTime[] _dateTime;
        private int[] _data;
        private string _dataName;

        public PredictionDataForm(DateTime[] dataTime, int[] data, string dataName)
        {
            InitializeComponent();
            _dateTime = dataTime;
            _data = data;
            _dataName = dataName;
        }

        private void PredictionDataForm_Load(object sender, EventArgs e)
        {
            switch (_dataName)
            {
                case "Movement":
                    PredictionDataChart.Titles[0].Text = "График прогнозирования стостояния датчика движения";
                    break;
                case "Brightness":
                    PredictionDataChart.Titles[0].Text = "График прогнозирования яркости света";
                    break;
                case "Temperature":
                    PredictionDataChart.Titles[0].Text = "График прогнозирования температуры C";
                    break;
                default:
                    PredictionDataChart.Titles[0].Text = "?";
                    break;
            }

            int trainLength = Convert.ToInt32(_dateTime.Length * 0.8);
            int testLength = Convert.ToInt32(_dateTime.Length * 0.2);

            double[] xTrain = new double[trainLength];
            double[] yTrain = new double[trainLength];
            double[] xTest = new double[testLength];
            double[] yTest = new double[testLength];

            for (int i = 0; i < xTrain.Length; i++)
            {
                xTrain[i] = i;
                yTrain[i] = Convert.ToDouble(_data[i]);
            }

            for (int i = 0; i < xTest.Length; i++)
            {
                xTest[i] = i + trainLength;
                yTest[i] = Convert.ToDouble(_data[i + trainLength]);
            }

            double[] yPredicted = new double[yTrain.Length];

            for (int i = 0; i < xTrain.Length; i++)
            {
                PredictionDataChart.Series[0].Points.AddXY(_dateTime[i], yTrain[i]);
            }

            int order = 6;//Здесь должен быть расчет бейсовского информационного критерия

            Matrix<double> a = LerningPolynomialRegression(xTrain, yTrain, order);

            for (int i = 0; i < yTrain.Length; i++)
            {
                yPredicted[i] = PolynomialRegression(a, xTrain[i], order);
                PredictionDataChart.Series[1].Points.AddXY(_dateTime[i], Math.Round(yPredicted[i], 1));
            }

            for (int i = 0; i < xTest.Length; i++)
            {
                PredictionDataChart.Series[2].Points.AddXY(_dateTime[i + trainLength], Math.Round(PolynomialRegression(a, xTest[i], order), 1));
                PredictionDataChart.Series[3].Points.AddXY(_dateTime[i + trainLength], yTest[i]);
            }
        }

        public Matrix<double> LerningPolynomialRegression(double[] xVector, double[] yVector, int polynomOrder=2)
        {
            Matrix<double> aMatrix = Matrix<double>.Build.Dense(polynomOrder + 1, 1);
            Matrix<double> xMatrix = Matrix<double>.Build.Dense(polynomOrder + 1, polynomOrder + 1);
            Matrix<double> yMatrix = Matrix<double>.Build.Dense(polynomOrder + 1, 1);

            for (int i = 0; i < yMatrix.RowCount; i++)
            {
                double sumForYMatrix = 0;
                for (int j = 0; j < yVector.Length; j++)
                {
                    sumForYMatrix += yVector[j] * Math.Pow(xVector[j], i);
                }

                yMatrix[i, 0] = sumForYMatrix;
            }

            for (int i = 0; i < xMatrix.RowCount; i++)
            {
                for (int j = 0; j < xMatrix.ColumnCount; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        xMatrix[i, j] = xVector.Length;
                        continue;
                    }

                    xMatrix[i, j] = SumOfX(xVector, j + i);
                }
            }

            aMatrix = xMatrix.Inverse() * yMatrix;

            return aMatrix;
        }

        public double PolynomialRegression(Matrix<double> a, double x, int polynomOrder)
        {
            double yPredicted = 0;

            for (int j = 0; j <= polynomOrder; j++)
            {
                yPredicted += a[j, 0] * Math.Pow(x, j);
            }

            return yPredicted;
        }

        private double SumOfX(double[] vector, int power)
        {
            double sum = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                sum += Math.Pow(vector[i], power);
            }

            return sum;
        }

        public double CalculateBIC(double[] y, double[] yPredicted)
        {
            double BIC;
            double SSE = 0;
            int n = y.Length;
            const int k = 1;

            for (int i = 0; i < y.Length; i++)
            {
                SSE += Math.Pow(y[i] - yPredicted[i], 2);
            }

            BIC = n * Math.Log(SSE) + k * Math.Log(n);

            return BIC;
        }
    }
}
