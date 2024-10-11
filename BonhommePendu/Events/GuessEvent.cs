using BonhommePendu.Models;

namespace BonhommePendu.Events
{
    // Un événement à créer chaque fois qu'un utilisateur essai une "nouvelle" lettre
    public class GuessEvent : GameEvent
    {
        // TODO: Compléter
        public GuessEvent(GameData gameData, char letter) {
            GuessedLetterEvent g = new GuessedLetterEvent(gameData, letter);
            gameData.GuessedLetters.Add(letter);
            this.Events.Add(g);

            for(int i = 0; i > gameData.Word.Length-1; i++)
            {

            }
        }
    }
}
