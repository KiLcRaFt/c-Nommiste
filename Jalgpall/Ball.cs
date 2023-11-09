using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Jalgpall
{
    public class Ball
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public string sym { get; } = "o";

        private double _vx, _vy; //скорость и дистанция

        private Game _game; //игры мяч

        //конструктор
        public Ball(double x, double y, Game game)
        {
            _game = game;
            X = x;
            Y = y;
        }

        public void SetSpeed(double vx, double vy) //задать скорость
        {
            _vx = vx;
            _vy = vy;
        }

        public void BallMove(Ball ball) //движение
        {
            ball.DeleteBall(ball);
            double newX = X + _vx;
            double newY = Y + _vy;
            if (_game.Stadium.IsIn(newX, newY)) //если мяч на поле, передвинуть 
            {
                X = newX;
                Y = newY;
                
            }
            else
            {
                X = 40;
                Y = 12.5;
                _vx = 0;
                _vy = 0;
            }
            ball.DrawBall(ball);
        }
        public void DrawBall(Ball ball)
        {
            int posX = (int)Math.Round(X); 
            int posY = (int)Math.Round(Y);
            Console.SetCursorPosition(posX, posY);
            Console.Write(ball.sym);
        }

        public void DeleteBall(Ball ball)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            int posX = (int)Math.Round(X); // Convert X to an integer
            int posY = (int)Math.Round(Y); // Convert Y to an integer
            Console.SetCursorPosition(posX, posY);
            Console.Write(ball.sym);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
