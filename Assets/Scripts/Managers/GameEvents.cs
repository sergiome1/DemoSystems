using Assets.Scripts.MatchUI;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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

        public static IEnumerator RunEvents(List<Func<object[], IEnumerator>> actions, params object[] args)
        {
            for (int i = 0; i < actions.Count; i++)
            {
                if (actions[i] != null)
                {
                    yield return actions[i].Invoke(args);
                }
            }

            for (int i = actions.Count - 1; i >= 0; i--)
            {
                if (actions[i] == null)
                {
                    actions.RemoveAt(i);
                }
            }
        }

        public static IEnumerator RunEvents(List<Action<object[], Action>> actions, params object[] args)
        {
            actions.Remove(null);

            int toComplete = actions.Count;
            int completedActions = 0;

            void OnCompleteAction()
            {
                completedActions++;
            }

            for (int i = 0; i < actions.Count; i++)
            {
                if (actions[i] != null)
                {
                    actions[i].Invoke(args, OnCompleteAction);
                }
            }

            yield return new WaitUntil(() => completedActions >= actions.Count);
        }
    }
}
