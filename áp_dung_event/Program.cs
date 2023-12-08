using System.Diagnostics;

namespace áp_dung_event
{
    internal class Program
    {
        public class nhanvat
        {
            public delegate void chuyendong(string a);
            public event chuyendong chuyendonghientai;
            public void kiemtrachuyendong(string a)
            {
                chuyendonghientai?.Invoke(a);
            }
            public void kiemtrachuyendong1(string a)
            {
                chuyendonghientai?.Invoke(a);
            }

        }
        public class nguoichoi 
        {
            int so ;
            public nguoichoi(int so, nhanvat nhanvat1)
            {
                this.so = so;
                nhanvat1.chuyendonghientai += dachuyendong;
               
                
            }
            public void dachuyendong(string a)
            {
                Console.WriteLine("nhan vat {0} da chuyen dong , dang hang dong la :{1} ",so,a);
            }
        }

        static void Main(string[] args)
        {
            // tao 1 doi tg cho lop nhan vat - pub 
            // tao 1 doi tg lop nguoi choi - sub 
            nhanvat nv = new nhanvat();
            // truyen vao nv 
            nguoichoi nc1 = new nguoichoi(1, nv);
            // kiem tra loai event 
            nv.kiemtrachuyendong("nhay"); // suy ra + dachuyendong
            nv.kiemtrachuyendong1("chay");// suyra + dachuyendong1
            Console.ReadLine();
        }
    }
}
