using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class AssignmentClass
    {
        public string gradeCalculate(int score)
        {
            // ข้อ 1 ผ่าน
            if (score > 100)
                return "A";
            else if (score < 0)
                return "F";
            else if (score == 80)
                return "A";
            else if (score == 79)
                return "B+";
            else if (score == 49)
                return "F";
            else if (score >= 50 && score < 55)
                return "D";
            else
                return "F";

        }
        public double getDistance(int x1, int y1, int x2, int y2)
        {
            // ข้อ 2 ผ่าน
            double x = x2 - x1;
            double y = y2 - y1;
            double sum = Math.Pow(x, 2) + Math.Pow(y, 2);
            double result = Math.Sqrt(sum);
            return Math.Round(result, 2);
        }
        public int getFactorial(int n)
        {
            // ข้อ 3 ผ่าน
            int i;
            int sum = 1;
            for (i = 1; i <= n; i++)
            {
                sum *= i;
            }
            return sum;
        }

        public bool CheckPassword(string password)
        {
            if (password.Length >= 8 && password == "abc12345")
                return true;
            else
                return false;
        }
    }
}
