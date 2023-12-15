using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossFight
{
    public class GameCharacter
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public int CurrentStamina { get; set; }
        public int MaxStamina { get; set; }

        public GameCharacter(string name, int health, int strength, int stamina)
        {
            Name = name;
            Health = health;
            Strength = strength;
            CurrentStamina = stamina;
            MaxStamina = stamina;
        }

        public void Fight(GameCharacter _character, GameCharacter _enemy)
        {
            if (CurrentStamina < 10)
            {
                Console.WriteLine($"{_character.Name.ToUpper()}: Not enough stamina, recharging...");
                Recharge(_character);
            }
            else
            {
                CurrentStamina -= 10;
                Console.WriteLine($"{_character.Name.ToUpper()}: The {_character.Name} hits the {_enemy.Name} for {_character.Strength} Damage.");
                Console.WriteLine($"      The {_enemy.Name} now has {_enemy.Health -= _character.Strength} health left.");
            }
        }
        public void Recharge(GameCharacter _character)
        {
            _character.CurrentStamina = MaxStamina;
        }
        public bool isDead(GameCharacter _character, GameCharacter _enemy)
        {
            if (_character.Health <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"The {_character.Name} has died\nThe {_enemy.Name} has won!");
                Console.ResetColor();
                return true;
            }
            else
                return false;
        }
    }
}
