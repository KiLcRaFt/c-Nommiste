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
        public int Number { get; private set; }
        public Game Game { get; set; } //тип данных Гейм

        public Team(string name, int num) //зависит от строки с полем
        {
            Name = name;
            Number = num;
        }


        // конструкур
        public void StartGame(int width, int height) // генерирует позиции игроков на поле
        {
            Random rnd = new Random();
            foreach (var player in Players) // для каждого игрока
            {
                player.ClearPlayer(player);
                if (player.Team.Number == 1)
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                    player.SetPosition(
                    rnd.Next(0, width / 2),
                    rnd.Next(0, height)
                    );
                }
                else if (player.Team.Number == 2) 
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    player.SetPosition(
                    rnd.Next(width / 2, width),
                    rnd.Next(0, height)
                    );
                }
                player.DrawPlayer(player);
                Console.ForegroundColor = ConsoleColor.White;
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
            Players.ForEach(player => player.Move(player));
        }
    }
}
