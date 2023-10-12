using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalgpall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Team t1 = new Team("Bogemic", 1);
            Team t2 = new Team("Dueches Commandos", 2);
            Stadium stadium = new(81, 26);
            Game game = new Game(t1, t2, stadium);
            Ball ball = new Ball(40, 12.5, game);
            stadium.Draw();
            for (int i = 0;i<1 ;i++) 
            {
                Player t1p1 = new Player("Ivan", "x");
                t1.AddPlayer(t1p1);

                Player t2p1 = new Player("Nicolas", "x");
                t2.AddPlayer(t2p1);
            }
            
            
            game.Start();
            while (true)
            {
               
                Console.SetCursorPosition(0, 27);
                game.Move();
                Console.WriteLine(" ");
                Console.ReadLine();
                
            }
        }
    }
}