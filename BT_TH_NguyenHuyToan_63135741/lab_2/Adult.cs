using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class Adult
    {
        string name;
        float weight, height;


        public Adult()
        {
            name = "Nguyễn Huy Toàn";
            weight = 90;
            height = 1.7f;
        }
            
        public Adult(string name, float weight, float height)
        {
            this.name = name;
            this.weight = weight;
            this.height = height;
        }

        public Adult(Adult a)
        {
            name = a.name;
            weight = a.weight;
            height = a.height;
        }

        //IN RA MAN HINH
        public void Info()
        {
            float BMI = weight / (height * height);
            if (BMI < 18.5)
                Console.WriteLine("Thiếu cân!");
            else if (BMI <= 25)
                Console.WriteLine("Bình thường!");
            else if (BMI < 30)
                Console.WriteLine("Thừa cân!");
            else 
                Console.WriteLine("Béo phì!");
        }

        //DIEU CHINH CAN NANG
        public void Inc_Dec_W()
        {
            float BMI = weight / (height * height);
            float weight1, weight2;

            if(BMI > 25)
            {
                weight1 = 25 / (height * height);
                weight2 = 18.5f / (height * height);
                Console.WriteLine($"Bạn cần giảm từ {weight - weight1}kg đến {weight - weight2}kg"); 
            }
            else if(BMI < 18.5f){
                weight1 = 18.5f / (height * height);
                weight2 = 25 / (height * height);
                Console.WriteLine($"Bạn cần tăng từ {weight - weight1}kg đến {weight - weight2}kg");
            }
        }
    }
}
