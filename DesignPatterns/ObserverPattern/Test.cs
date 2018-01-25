using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Test
    {
        static void Main(string[] args)
        {
            //Three student and one teacher
            SupperStar king = new SupperStar("King");
            king.AddFans(new Student() { Name = "Ocean" });
            king.AddFans(new Student() { Name = "Sky" });
            king.AddFans(new Student() { Name = "God" });

            king.AddFans(new Teacher() { Name = "WangXiaoqi" });

            string message = "Welcome to my weibo";
            king.AddWeiboMessage(message);
            king.Notify();

            message = "Welcome to my weibo !";
            king.UpdateWeiboMessage(message);

            king.Notify();
        }
    }
}
