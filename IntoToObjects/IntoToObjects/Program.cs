using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntoToObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //create 2 new objects of the Deck Class- Call One Player1 and the other Player2
            Deck Player1 = new Deck();
            Deck Player2 = new Deck();
            //create a list of Cards called cardsInPlay
            List<Card> cardsInPlay = new List<Card> {};
            //shuffle player1's deck
            Player1.ShuffleAll();
            //clear player2's deck
            Player2.ClearDeck();
            //remove 26 cards from player1's deck and add them to player2's deck
          
            for (int c = 0; c < 26; c++)
            {

                Player2.AddCardToDeck(Player1.DrawCard());

            }
            //Do the following until one of the players have 0 cards in Discard pile or deck
            Card PlayerCard = Player1.DrawCard();
            Card Player2Card = Player2.DrawCard();
            //draw card from player1 add to cardsInPlay list
            cardsInPlay.Add(PlayerCard);
            cardsInPlay.Add(Player2Card);
            //draw card from player2
            
            //while last card drawn values match 
            while(PlayerCard.GetValue() == Player2Card.GetValue())
            {
                for(int i = 0; i < 4; i++)
                {
                    PlayerCard = Player1.DrawCard();
                    cardsInPlay.Add(PlayerCard);
                    Player2Card = Player2.DrawCard();
                    cardsInPlay.Add(Player2Card);
                }
                

            }

            if (PlayerCard.GetValue() > Player2Card.GetValue())
            {

                for (int i = 0; i < cardsInPlay.Count; i++) {

                    Player1.DiscardCard(cardsInPlay[i]);
                }

            }

            else if (PlayerCard.GetValue() > Player2Card.GetValue())
            {

                for (int i = 0; i < cardsInPlay.Count; i++)
                {

                    Player2.DiscardCard(cardsInPlay[i]);
                }

            }
            // draw 4 more cards(or as many that the player has) from player1 and player2 and add to cardsInPlay
            //Add all cards in the cardsInPlay list to the player's discard pile who had the higher value card
        }
    }
}
