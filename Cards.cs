public class DeckOfCards {
  		
		private List<Card> cards;
		private int currentCard;
        private const int NumberOfCards = 52;  
		private Random randomNumber;
		
        public DeckOfCards()
		{
			cards = new List<Card>;
			int i = 0;
			for (int suit = 1; suit <= 4; suit++)
				for (int rank = 1; rank <= 13; rank++)
					deckOfCards[i++] = new Card(suit, rank);
			currentCard = 0;
		}
	
		public void shuffle(int n)
		{
			int i, j;
			randNum = new Random();
			for (int k = 0; k < n; k++)
			{
				i = (int)(randNum.Next(NCARDS));
				j = (int)(randNum.Next(NCARDS));
				Card tmp = deckOfCards[i];
				deckOfCards[i] = deckOfCards[j];
				deckOfCards[j] = tmp;
			}
	
			currentCard = 0;
		}
	
		public Card deal()
		{
			if (currentCard < NCARDS)
				return (deckOfCards[currentCard++]);
			else
				return (null);
		}
}

public class Card{
    string CardType {get; set;} // diamonds, clubs, hearts..
    string Rank {get; set;} // 1,2,3... jack (11), queen(12), king(13), Ace(14). 
}