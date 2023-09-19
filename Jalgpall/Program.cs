using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalgpall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Snowflake");
            Team t1 = new Team("Bogemic");   
            Player t1p1 = new Player("Ivan");
            t1.AddPlayer(t1p1);
            Player t1p2 = new Player("Magamed");
            t1.AddPlayer(t1p2);

            Team t2 = new Team("Dueches Commandos");
            Player t2p1 = new Player("Nicolas");
            t2.AddPlayer(t2p1);
            Player t2p2 = new Player("Adolf");
            t2.AddPlayer(t2p2);
    
            Stadium stadik = new Stadium(400, 300);
            Game game = new Game(t1, t2, stadik);
            game.Start();
            stadik.Draw();
            
        }
    }
}