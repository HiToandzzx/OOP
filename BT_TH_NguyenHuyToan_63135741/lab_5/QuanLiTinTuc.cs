using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    interface INews
    {
        int id { get; set; }
        string title { get; set; }
        string author { get; set; }

        void Display();
    }

    class News : INews
    {
        public int id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public DateTime publicDate { get; set; }
        public string content { get; set; }
        public List<float> avgRate { get; set; }

        public News()
        {
            avgRate = new List<float>();
        }

        public News(int id, string title, string author, DateTime publicDate, string content, List<float> avgRate)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.publicDate = publicDate;
            this.content = content;
            this.avgRate = avgRate;
        }

        public void Display()
        {
            Console.WriteLine($"id: {id}, title: {title}, author: {author}, public date: {publicDate}, content: {content}");
        }

        public float Cal_Avg()
        {
            float sum = 0;
            foreach (float rate in avgRate)
            {
                sum += rate;
            }
            return sum / avgRate.Count;
        }

    }

    class ListNews
    {
        public int n { get; set; }
        public List<News> list { get; set; }

        public ListNews()
        {
            n = 0;
            list = new List<News>();
        }

        public void Input()
        {
            Console.Write("Nhap so luong tin tuc: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"\nNhap thong tin cua tin tuc thu {i + 1}:");
                Console.Write("\nNhap id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nhap tieu de tin tuc: ");
                string title = Console.ReadLine();
                Console.Write("Nhap ten tac gia tin tuc: ");
                string author = Console.ReadLine();
                Console.Write("Nhap ngay dang tin (yyyy/mm/dd): ");
                DateTime publicDate = DateTime.Parse(Console.ReadLine());
                Console.Write("Nhap noi dung tin tuc: ");
                string content = Console.ReadLine();
                List<float> avgRate = new List<float>();
                Console.Write("Nhap diem danh gia cua nguoi doc: ");
                int numRate = int.Parse(Console.ReadLine());
                for (int j = 0; j < numRate; j++)
                {
                    Console.Write($"Nhap muc do {j + 1}: ");
                    float rate = float.Parse(Console.ReadLine());
                    avgRate.Add(rate);
                }

                News news = new News(id, title, author, publicDate, content, avgRate);
                list.Add(news);
            }
        }

        public void Output()
        {
            Console.WriteLine("Danh sach tin tuc:");
            foreach (News news in list)
            {
                news.Display();
            }
        }

        public void AverageRate()
        {
            Console.WriteLine("\nDanh sach tin tuc va muc do danh gia:");
            foreach (News news in list)
            {
                news.Display();
                Console.WriteLine($"Muc do danh gia: {news.Cal_Avg()}");
            }
        }

        // THEM TIN TUC MOI
        public void Insert_News()
        {
            Console.WriteLine("Nhap thong tin cho tin tuc:");
            Console.Write("\nNhap id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Nhap tieu de tin tuc: ");
            string title = Console.ReadLine();
            Console.Write("Nhap ten tac gia tin tuc: ");
            string author = Console.ReadLine();
            Console.Write("Nhap ngay dang tin (yyyy/mm/dd): ");
            DateTime publicDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhap noi dung tin tuc: ");
            string content = Console.ReadLine();
            List<float> avgRate = new List<float>();
            Console.Write("Nhap diem danh gia cua nguoi doc: ");
            int numRate = int.Parse(Console.ReadLine());
            for (int j = 0; j < numRate; j++)
            {
                Console.Write($"Nhap muc do {j + 1}: ");
                float rate = float.Parse(Console.ReadLine());
                avgRate.Add(rate);
            }
            News n = new News(id, title, author, publicDate, content, avgRate);
            list.Add(n);
            Console.WriteLine("\nThem vao tin tuc moi thanh cong!");
        }
    }
}
