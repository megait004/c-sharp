using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace bt4gacsharp
{
    internal class Program
    {
        static void Main(string[] args)
           
        {// bai tập tìm x và y khi biết tổng và hiệu 
            // x+y =tong ;
            // x-y = hieu;
            
            float tong, hieu,x,y;
           
            Console.WriteLine("moi nhap vao tong : ");
            tong=float.Parse(Console.ReadLine());
            Console.WriteLine("moi nhap vao hieu : ");
            hieu=float.Parse(Console.ReadLine());
            x=(tong+hieu)/2;
            y = tong - x;
            Console.WriteLine(" gia trị cua x la:{0}",x);
            Console.WriteLine(" gia trị cua y la:{0}", y);
            Console.ReadKey();

            















        }
    }
}
