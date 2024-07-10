using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugFile1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            //nhập vào số lượng phần tử của mảng, nếu <= 0 thì nhập lại
            do
            {
                Console.Write("\nNhap vao so luong phan tu cua mang: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);
            //khai báo mảng intArray
            int[] intArray = new int[n];
            Console.WriteLine("Nhap vao cac phan tu cua mang: ");
            //sử dụng vòng lặp for để nhập các phần tử cho mảng
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = int.Parse(Console.ReadLine());
            }
            //gọi hàm sắp xếp SortMethod và truyền vào các tham số tương ứng
            SortMethod(intArray, 0, n - 1);
            Console.Write("Cac phan tu sau khi sap xep: ");
            //in mảng sau khi sắp xếp
            foreach (int item in intArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
        //hàm chia các phần tử trong mảng
        static public void MergeMethod(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, left_end, num_elements, tmp_pos;
            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);
            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }
            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];
            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];
            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }
        //hàm sắp xếp các phần tử sao khi chia
        static public void SortMethod(int[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                SortMethod(numbers, left, mid);
                SortMethod(numbers, (mid + 1), right);
                MergeMethod(numbers, left, (mid + 1), right);
            }
        }
        }
}
