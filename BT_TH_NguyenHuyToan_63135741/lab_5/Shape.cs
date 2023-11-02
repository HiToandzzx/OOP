using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    abstract class Shape // LOP TRUU TUONG
    {
        protected string name;
        public Shape(string n = "")
        {
            name = n;
        }
        
        // TINH DIEN TICH
        public abstract float Area(); // PHUONG THUC TRUU TUONG
    }

    interface IPaint
    {
        // DONG GOI THUOC TINH DON GIA
        float Price { get; set; }

        // PHUONG THUC TINH CHI PHI VE THEO GIA VE
        float Cost();
    }
    
    // LOP HINH CHU NHAT KE THUA TU LOP SHAPE THUC THI GIAO DIEN IPAINT
    class Rectangle : Shape, IPaint, IComparable<Rectangle>
    {
        float d, r;
        float price;

        // DONG GOI THUOC TINH
        public float Price { get => price; set => price = value; }

        // KHOI TAO CO THAM SO
        public Rectangle(float d = 5, float r = 3, float p = 2, string n = "Rectangle") : base(n)
        {
            this.d = d; 
            this.r = r; 
            price = p;
        }

        // TINH DIEN TICH
        public override float Area() 
        {
            return d * r;
        }

        // TINH CHI PHI
        public float Cost()
        {
            return price * Area();
        }

        // XUAT THONG TIN
        public void Print()
        {
            Console.WriteLine($"\n{name}, Dien tich:{Area()}, Chi phi: {Cost()}");
        }

        // PHUONG THUC CUA IComparable
        public int CompareTo(Rectangle r)
        {
            if (this.Cost() < r.Cost()) 
                return 1;
            else if (this.Cost() == r.Cost()) 
                return 0;
            else 
                return -1;
        }
    }

    // DANH SACH N HCN
    class List_Rec
    {
        List<Rectangle> ls;
        int n;
        // KHOI TAO MAC DINH

        // NHAP N HCN
        public void Input()
        {
            Console.Write("\nNhap so luong hinh chu nhat: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 2 || n > 10)
            {
                Console.Write("\nNhap lai so luong hinh chu nhat: ");
            }

            // KHOI TAO DANH SACH
            ls = new List<Rectangle>();

            // NHAP N PHAN TU TRONG DANH SACH
            for (int i=0; i<n; i++)
            {
                Console.WriteLine("\nNhap chieu dai, chieu rong cua hinh thu {0}: ", i + 1);
                float d = float.Parse(Console.ReadLine());
                float r = float.Parse(Console.ReadLine());
                Rectangle rec = new Rectangle(d, r);
                ls.Add(rec);
            }
        }

        // SAP XEP DUNG PHUONG THUC SORT CUA LIST => ICOMPARABLE
        public void Sort()
        {
            ls.Sort();
        }

        // XOA HCN DAU TIEN CO DIEN TICH < X
        public void Del()
        {
            Console.Write("\nNhap dien tich can xoa: ");
            float x = float.Parse(Console.ReadLine());

            //C1: TIM PHAN TU
            //foreach (Rectangle rec in ls)
            //    if (rec.Area() < x)
            //    {
            //        ls.Remove(rec);5
            //        break;
            //    }

            //C2: TIM VI TRI CUA PHAN TU
            for (int i = 0; i < ls.Count; i++)
                if (ls[i].Area() < x)
                {
                    ls.RemoveAt(i); 
                    break;
                }
        }

        // THEM 1 HCN VAO VI TRI THU I
        public void Add()
        {
            // TAO DOI TUONG CAN THEM VAO LIST
            Console.WriteLine("\nNhap chieu dai, chieu rong cua hinh can them: ");
            float d = float.Parse(Console.ReadLine());
            float r = float.Parse(Console.ReadLine());
            Rectangle rec = new Rectangle(d, r);

            Console.Write("\nNhap vi tri muon them: ");
            int i = int.Parse(Console.ReadLine());

            // THEM VAO GIUA
            if (i >= 0 && i < ls.Count)
                ls.Insert(i, rec);
            // THEM VAO DAU
            else if (i < 0)
                ls.Insert(0, rec);
            // THEM VAO CUOI
            else
                ls.Add(rec);
        }

        // TINH TONG CHI PHI
        public float Sum_Cost()
        {
            float s = 0;

            // C1: DUYET QUA TUNG PHAN TU VA CONG DON COST VAO S
            foreach (Rectangle rec in ls)
                s += rec.Cost();

            // C2: SU DUNG SUM VOI TOAN TU LAMDA
            //s = ls.Sum(rec => rec.Cost());

            return s;
        }

        // XUAT DANH SACH
        public void Print()
        {
            foreach (Rectangle rec in ls)
                rec.Print();
        }
    }
}
