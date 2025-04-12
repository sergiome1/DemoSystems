using Assets.Scripts.MatchUI;
using System;
using System.Collections;
using System.Collections.Generic;
using static Assets.Scripts.GameplayElements.Card;

namespace Assets.Scripts.Managers
{
    public static class GameEvents
    {
        public static Func<string, IEnumerator> OnCandyAbilitySuccess;
        public static Func<List<UIDeckCard>> GetUIPlayerCardLocal;

        public static Action<UICard> OnSelectableSelected;
        public static Action<TypeCardSelection, Suit, Value> ActivateSelectableCard;

        public static Action OnChangeLanguageDone;
    }
}
