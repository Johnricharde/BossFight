using BossFight;

namespace BossFightTest
{
    public class UnitTest1
    {
        [Fact]
        public void InitializeGameCharacter()
        {
            var character = new GameCharacter("character", 15, 30, 60);

            Assert.Equal(15, character.Health);
            Assert.Equal(30, character.Strength);
            Assert.Equal(60, character.CurrentStamina);
        }
        [Fact]
        public static void CheckIfRandomIsWithinRanger()
        {
            int randomNumber = Program.RandomNumber(0, 31);

            Assert.InRange(randomNumber, 0, 31);
        }
        [Fact]
        public void CheckIfFightDepletesStamina()
        {
            var character = new GameCharacter("character", 15, 15, 15);
            var enemy = new GameCharacter("enemy", 15, 15, 15);

            character.Fight(character, enemy);

            Assert.Equal(5, character.CurrentStamina);
        }
        [Fact]
        public void FightDoesNotAffectMaxStamina()
        {
            var character = new GameCharacter("character", 15, 15, 15);
            var enemy = new GameCharacter("enemy", 15, 15, 15);

            character.Fight(character, enemy);

            Assert.Equal(5, character.CurrentStamina);
            Assert.Equal(15, character.MaxStamina);
        }
        [Fact]
        public void RechargeSetsStaminaToMax()
        {
            var character = new GameCharacter("character", 15, 15, 15);
            var enemy = new GameCharacter("enemy", 15, 15, 15);

            character.Fight(character, enemy);
            Assert.Equal(5, character.CurrentStamina);

            character.Recharge(character);
            Assert.Equal(15, character.CurrentStamina);
        }
    }
}