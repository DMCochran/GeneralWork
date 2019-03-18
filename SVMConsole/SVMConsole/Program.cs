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
        public double Gamma = 1.0;
        public double Coef = 0.0;
        public double Degree = 2.0;
        private object supportVectors;

        public double[] Alpha { get; private set; }
        public double[] Errors { get; private set; }
        public double Complexity { get; private set; }
        public double[] weights { get; private set; }

        //All member fields are declared public

        public SupportVetorMachine(string kernelType, int seed)
        {

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
            int N = x_matrix.Length;
            Alpha = new double[N];
            Errors = new double[N];
            int numChanged = 0;
            bool examineAll = true;
            int iter = 0;

            while(iter<maxIter && numChanged>0 || examineAll==true)
            {
                ++iter;
                numChanged = 0;
                if(examineAll==true)
                {
                    for (int i = 0; i < N; ++i)
                        numChanged += ExamineExample(i, x_matrix, y_vector);
                }else
                {
                    for (int i = 0; i < N; ++i)
                        if (Alpha[i] != 0 && Alpha[i] != Complexity)
                            numChanged += ExamineExample(i, x_matrix, y_vector);
                }
                if (examineAll == true)
                    examineAll = false;
                else if (numChanged == 0)
                    examineAll = true;
            }

            List<int> indices = new List<int>();
            for (int i = 0; i < N; ++i)
            {
                if (Alpha[i] > 0) indices.Add(i);
            }

            int num_supp_vectors = indices.Count;
            weights = new double[num_supp_vectors];
            for(int i=0;i<num_supp_vectors,++i)
            {
                int j = indices[i];
                supportVectors
            }
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
