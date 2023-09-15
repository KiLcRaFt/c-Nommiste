using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalgpall
{
    public class Team
    {
        public List<Player> Players { get; } = new List<Player>(); // список объектов Плейер
        public string Name { get; private set; }
        public Game Game { get; set; } //тип данных Гейм

        public Team(string name) //зависит от строки с полем
        {
            Name = name;
        }

        // конструкур
        public void StartGame(int width, int height) // генерирует позиции игроков на поле
        {
            Random rnd = new Random();
            foreach (var player in Players) // для каждого игрока
            {
                player.SetPosition(
                    rnd.NextDouble() * width,
                    rnd.NextDouble() * height
                    );
            }
        }

        public void AddPlayer(Player player) //добавляет человека в команде
        {
            if (player.Team != null) return;
            Players.Add(player);
            player.Team = this;
        }

        public (double, double) GetBallPosition() //позиция мяча
        {
            return Game.GetBallPositionForTeam(this);
        }

        public void SetBallSpeed(double vx, double vy) //скорость мяча
        {
            Game.SetBallSpeedForTeam(this, vx, vy);
        }

        public Player GetClosestPlayerToBall() //ближайший игрок к мячу
        {
            Player closestPlayer = Players[0];
            double bestDistance = Double.MaxValue;
            foreach (var player in Players)
            {
                var distance = player.GetDistanceToBall();
                if (distance < bestDistance)
                {
                    closestPlayer = player;
                    bestDistance = distance;
                }
            }

            return closestPlayer;
        }

        public void Move() //ищет ближайшего игрока и двигает его ещё ближе
        {
            GetClosestPlayerToBall().MoveTowardsBall();
            Players.ForEach(player => player.Move());
        }
    }
}
