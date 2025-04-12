using System;

namespace Assets.Scripts.GameplayElements
{
    [Serializable]
    public class Card
    {
        public enum TypeCardSelection { None, HeroeLocal, HeroeRemote, Table, HandLocal, HandRemote, Pet }

        public enum Suit { All = -1, Fire, Water, Land, Air };
        public enum Value { All = -1, Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace };

        public Suit suit { get; set; }
        public Value value { get; set; }

        public Card(Suit s, Value v)
        {
            value = v;
            suit = s;
        }

        /*
         * ...
         * 
         */
    }
}