using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace AllCardsOnDeckCSRemake
{
  class Program
  {
    static void Main(string[] args)
    {
      var deck = new List<string>() { };
      var suits = new List<string>() { "Hearts", "Diamonds", "Clubs", "Spades" };
      var ranks = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

      // Create a deck of cards
      foreach (var suit in suits)
      {
        foreach (var rank in ranks)
        {
          deck.Add(rank + " of " + suit);
        }
      }

      // Shuffle the deck
      var random = new Random();
      for (int i = 0; i < deck.Count; i++)
      {
        int j = random.Next(i, deck.Count);
        var temp = deck[i];
        deck[i] = deck[j];
        deck[j] = temp;
      }

      // Display top 2 cards
      Console.WriteLine("Top 2 cards:");
      for (int i = 0; i < 2; i++)
      {
        Console.WriteLine(deck[i]);
      }
    }
  }
}
