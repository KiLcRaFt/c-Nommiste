using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalgpall
{
    public class Game
    {
        public Team HomeTeam { get; } //тип данных HomeTeam
        public Team AwayTeam { get; } //тип данных AwayTeam
        public Stadium Stadium { get; } //тип данных Stadium
        public Ball Ball { get; private set; } //тип данных Ball

        //конструкор
        public Game(Team homeTeam, Team awayTeam, Stadium stadium)
        {
            HomeTeam = homeTeam;
            homeTeam.Game = this;
            AwayTeam = awayTeam;
            awayTeam.Game = this;
            Stadium = stadium;
        }

        public void Start() //настройки для старта
        {
            Ball = new Ball(Stadium.Width / 2, Stadium.Height / 2, this);
            Ball.DrawBall(Ball);
            HomeTeam.StartGame(Stadium.Width-1 / 2, Stadium.Height-1);
            AwayTeam.StartGame(Stadium.Width-1 / 2, Stadium.Height-1);
        }
        private (double, double) GetPositionForAwayTeam(double x, double y) // позиция для команды
        {
            return (Stadium.Width - x, Stadium.Height - y);
        }

        public (double, double) GetPositionForTeam(Team team, double x, double y) // позиция для команды
        {
            return team == HomeTeam ? (x, y) : GetPositionForAwayTeam(x, y);
        }

        public (double, double) GetBallPositionForTeam(Team team) // позиция мяча
        {
            return GetPositionForTeam(team, Ball.X, Ball.Y);
        }

        public void SetBallSpeedForTeam(Team team, double vx, double vy) // скорость мяча
        {
            if (team == HomeTeam)
            {
                Ball.SetSpeed(vx, vy);
            }
            else
            {
                Ball.SetSpeed(-vx, -vy);
            }
        }

        public void Move() // движение обоих команд
        {
            HomeTeam.MoveTeam();
            AwayTeam.MoveTeam();
            Ball.BallMove(Ball);
        }

        public static void MoveBalls(Ball ball)
        {
            int posX = (int)Math.Round(ball.X);
            int posY = (int)Math.Round(ball.Y);
            Console.SetCursorPosition(posX, posY);
            Console.Write(ball.sym);

        }
    }
}
