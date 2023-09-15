using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalgpall
{
    public class Player
    {
        //пол/отребуты/характеристики
        public string Name { get; } //имя
        public double X { get; private set; } //координата по X
        public double Y { get; private set; } //координата по Y
        private double _vx, _vy; //расстояние до мяча по X и Y
        public Team? Team { get; set; } = null;  //отношение к команде

        private const double MaxSpeed = 5; //макс скорость
        private const double MaxKickSpeed = 25; //макс скорость удара
        private const double BallKickDistance = 10; //длинна удара

        private Random _random = new Random(); //рандом

        //конструкторы
        public Player(string name) //зависит от строки с полем
        {
            Name = name;
        }

        public Player(string name, double x, double y, Team team) //информация об игроке на поле
        {
            Name = name;
            X = x;
            Y = y;
            Team = team;
        }

        public void SetPosition(double x, double y) // установить позицию игрока
        {
            X = x;
            Y = y;
        }

        public (double, double) GetAbsolutePosition() //устанавливает позицию в игре
        {
            return Team!.Game.GetPositionForTeam(Team, X, Y);
        }

        public double GetDistanceToBall() //дистанция до мяча
        {
            var ballPosition = Team!.GetBallPosition();
            var dx = ballPosition.Item1 - X;
            var dy = ballPosition.Item2 - Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public void MoveTowardsBall() // движение в сторону мяча
        {
            var ballPosition = Team!.GetBallPosition();
            var dx = ballPosition.Item1 - X;
            var dy = ballPosition.Item2 - Y;
            var ratio = Math.Sqrt(dx * dx + dy * dy) / MaxSpeed;
            _vx = dx / ratio;
            _vy = dy / ratio;
        }

        public void Move() //движение относительно мяча
        {
            if (Team.GetClosestPlayerToBall() != this) //сохранять позицию, если не заданы параметры
            {
                _vx = 0;
                _vy = 0;
            }

            if (GetDistanceToBall() < BallKickDistance) // если дистанция до мяча меньше расстояния удара, то расчтываем удар
            {
                Team.SetBallSpeed(
                    MaxKickSpeed * _random.NextDouble(),
                    MaxKickSpeed * (_random.NextDouble() - 0.5)
                    );
            }

            var newX = X + _vx;
            var newY = Y + _vy;
            var newAbsolutePosition = Team.Game.GetPositionForTeam(Team, newX, newY);
            if (Team.Game.Stadium.IsIn(newAbsolutePosition.Item1, newAbsolutePosition.Item2)) // если да, то новая позиция для игрока
            {
                X = newX;
                Y = newY;
            }
            else
            {
                _vx = _vy = 0;
            }
        }
    }
}
