using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVMConsole
{
    class SVM_Program
    {
        static void Main(string[] args)
        {
            //Setup Training Data
            //Create SVM object, set parameters
            //Train the SVM
            //Display SVM Properties
            //Use trained SVM to make prediction
        }
    }

    public class SupportVetorMachine
    {
        public double Gamma { get; private set; }
        public double Coef { get; private set; }
        public double Degree { get; private set; }

        //All member fields are declared public

        public SupportVetorMachine(string kernelType, int seed)
        {
            Gamma = 1.0;
            Coef = 0.0;
            Degree = 2.0;
        }

        public double PolyKernel(double[] v1, double[] v2)
        {
            double sum = 0.0;
            for (int i = 0; i < v1.Length; ++i)
                sum += v1[i] * v2[i];
            double z = Gamma * sum + Coef;
            return Math.Pow(z,Degree);
        }

        public double RbfKernel(double[] v1, double[] v2)
        {
            double sum = 0.0;
            for (int i = 0; i < v1.Length; ++i)
                sum += (v1[i] - v2[i]) * (v1[i] - v2[i]);
            return Math.Exp(-Gamma * sum);
        }

        public double ComputeDecision(double[] input)
        {
            return 0.0;
        }

        public int Train(double[][] x_matrix, int[] y_vector, int maxIter)
        {
            return 0;
        }

        public double Accuracy(double[][] x_matrix, int[] y_vector)
        {
            return 0.0;
        }

        public bool TakeStep(int i1, int i2, double[][] x_matrix, int[] y_vector)
        {
            return true;
        }

        private int ExamineExample(int i2, double[][] x_matrix, int[] y_vector)
        {
            return 0;
        }

        private double ComputeAll(double[] vector, double[][] x_matrix, int[] y_vector)
        {
            return 0.0;
        }
    }
}
