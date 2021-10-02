using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1_28
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int[,] arr = GetArrFromTextBox();
            int col = FindCol(arr);
            int row = FindRow(arr);
            rowLabelResult.Text = "";
            rowLabelResult.Text += (row + 1).ToString();
            colLabelResult.Text = "";
            colLabelResult.Text += (col + 1).ToString();
            int[] vector = MakeVector(arr, row, col);
            textBox2.Text = "";
            textBox2.Text += PrintArr(vector);
        }

        private int[,] GetArrFromTextBox()
        {
            string rawText = textBox1.Text;
            string[] a1 = rawText.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            int countOfCols = a1[0].Split(' ').Length;

            foreach (string str in a1)
            {
                if (str.Split(' ').Length != countOfCols || a1.Length != countOfCols)
                {
                    MessageBox.Show("Матрица не является квадратной!");
                    this.Close();
                    throw new ArgumentException("");
                }
            }
            int[,] arr = new int[a1.Length, countOfCols];

            for (int i = 0; i < a1.Length; i++)
            {
                string[] tmp = a1[i].Split(' ');
                for (int j = 0; j < tmp.Length; j++)
                {
                    arr[i, j] = Convert.ToInt32(tmp[j]);
                }
            }
            return arr;
        }

        private int FindCol(int[,] arr)
        {
            int col = 0;
            int max = 0;
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                int comp = 0;
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (comp == 0)
                    {
                        comp += arr[j, i];
                    } else
                    {
                        comp *= arr[j, i];
                    }
                }

                if (comp > max)
                {
                    col = i;
                    max = comp;
                }
            }
            return col;
        }

        private int FindRow(int[,] arr)
        {
            int row = 0;
            int max = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int comp = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (comp == 0)
                    {
                        comp += arr[i, j];
                    }
                    else
                    {
                        comp *= arr[i, j];
                    }
                }

                if (comp > max)
                {
                    row = i;
                    max = comp;
                }
            }
            return row;
        }

        private int[] MakeVector(int[,] arr, int row, int col)
        {
            int n = arr.GetLength(0);
            int[] vector = new int[2 * n];
            int counterEven = 0;
            int counterOdd = 0;
            for (int j = 0; j < vector.Length; j++)
            {
                if (j % 2 == 0)
                {
                    vector[j] = arr[counterEven, col] - arr[row, counterEven];
                    counterEven++;
                } else
                {
                    vector[j] = arr[counterOdd, col] + arr[row, counterOdd];
                    counterOdd++;
                }
            }
            return vector;
        }

        private string PrintArr(int[] arr)
        {
            string str = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != arr.Length - 1)
                {
                    str += arr[i].ToString() + " ";
                } else
                {
                    str += arr[i].ToString();
                }
            }
            return str;
        }

        private void GenerateMatrix_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Random rand = new Random();
            int size = Convert.ToInt32(matrixSizeInput.Text);
            int[,] arr = new int [size, size];
            for (int i = 0; i < arr.GetLength(0); i++) {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(-9, 10) ;
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (j != arr.GetLength(1) - 1)
                    {
                        textBox1.Text += arr[i, j].ToString() + " ";
                    } else
                    {
                        textBox1.Text += arr[i, j].ToString() + "\r\n";
                    }
                }
            }


        }
    }
}
