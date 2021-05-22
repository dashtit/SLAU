using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace MethodsSLAU
{
    class SLAU
    {
        private float[,] Matrix; // наша матрица 
        public float E; // точность

        //Конструкторы
        public SLAU(float[,] matr, float e) // контруктор в который передали матрицу и точность которые мы ввели
        {

            Matrix =  matr; // присваиваем значения матрицы и точности для этого класса
            E = e;

        }
        //public SLAU(ushort RowCol) 
        //{
        //    Matrix = new float[RowCol, RowCol + 1];
        //    for (int i = 0; i < RowCol; i++)
        //    {
        //        for (int j = 0; j < RowCol + 1; j++)
        //        {
        //            Console.Write((j < RowCol) ? "M[{0}, {1}] = " : "MResult[{0}, {1}] = ", i + 1, j + 1);
        //            Matrix[i, j] = Convert.ToSingle(Console.ReadLine());
        //        }
        //    }
        //}


        //Метод приближенного решения
        public float[] MethZeygAndIter(char flag) // этот метод считает методом простых итераций 
        {
            
            float[] Xnew = new float[Matrix.GetLength(0)], // создаем новуб матрицу с такой же длиной что и та которая на входе
                    Xold = new float[Xnew.Length];

            do
            {
                Xnew.CopyTo(Xold, 0); // копируем значения

                for (int i = 0; i < Xnew.Length; i++) // зацикливаем для каждого элемента и отправляем считать в метод elX 
                    if (flag == 'i') 
                    {
                        Xnew[i] = elX(Xold, i) / Matrix[i, i];
                    }
                    else
                    { 
                        Xnew[i] = elX(Xnew, i) / Matrix[i, i];
                    }

            } while (!StopIter(Xold, Xnew));

            return Xnew;
        }
        //Поиск нового элемента х в методе приближенных итераций 
        private float elX(float [] X, int index)
        {
            float ResX = Matrix[index, Matrix.GetLength(1) - 1];

            for (int i = 0; i < X.Length; i++)
            {
                if (i == index) continue;
                ResX -= Matrix[index, i] * X[i];
            }

            return ResX;
        }

        //Проверка на необходимость завершения расчета новых Х
        private bool StopIter(float[] Xold, float[] Xnew)
        {
           
            for (int i = 0; i < Xnew.Length; i++)
            {
                if ((Math.Abs(Xnew[i] - Xold[i])) > E) return false;
            }
            return true;
        }
    }
}
