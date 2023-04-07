using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumsOfDiagonalsOfMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // Yêu cầu nhập dữ liệu từ người dùng
            Console.Write("Nhap vao kich thuoc cua ma tran vuong: ");
            int h = Convert.ToInt32(Console.ReadLine());

            // Tạo một ma trận với các phần tử ngẫu nhiên dựa trên kích thước
            Random random = new Random();
            int[,] matrix = new int[h, h];

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    matrix[i, j] = random.Next(0, 100);
                }
            }

            /* Tạo một ma trận với các phần tử được nhập từ người dùng dựa trên kích thước
             
            int[,] matrix = new int[h, h];
            for (int i = 0; i < h; ++i)
            {
                for (int j = 0; j < h; ++j)
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            */

            // Xuất ma trận ra màn hình
            Console.WriteLine();
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    Console.Write(matrix[i, j] + ", ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Tính tổng các phần tử của đường chéo chính và xuất ra màn hình
            int sums = 0;
            for (int i = 0; i < h; i++)
            {
                sums += matrix[i, i];
            }
            Console.WriteLine("Tong cac phan tu cua duong cheo chinh: " + sums);
            Console.WriteLine();
        }
    }
}