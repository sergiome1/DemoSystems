using Assets.Scripts.Coroutines;
using Assets.Scripts.GameProcessors.DemonAbilities.GameProcessors;
using UnityEngine;

namespace Assets.Scripts.FSMs
{
    public class DemonAbilityFSM : MonoBehaviour
    {
        public enum ActionStep
        {
            None,
            StartTurn,
            ApplyAbility,
            EndTurn
        }

        private ActionStep step = ActionStep.None;

        public ActionStep Step { get { return step; } }

        public void ChangeToNone()
        {
            step = ActionStep.None;
        }

        public void ChangeToStartTurn(string data)
        {
            ChangeState(ActionStep.StartTurn, data);
        }

        public void ChangeToApplyAbility(string data)
        {
            ChangeState(ActionStep.ApplyAbility, data);
        }

        public void ChangeToEndTurn(string data)
        {
            ChangeState(ActionStep.EndTurn, data);
        }

        private void ChangeState(ActionStep step, string data)
        {
            this.step = step;

            switch (step)
            {
                case ActionStep.StartTurn:
                    OnStartTurn(data);
                    break;
                case ActionStep.ApplyAbility:
                    OnApplyAbility(data);
                    break;
                case ActionStep.EndTurn:
                    OnEndTurn(data);
                    break;
            }
        }

        private void OnStartTurn(string data)
        {
            OnStartTurn turn = new OnStartTurn();
            CoroutineManager.Instance.RunCoroutine(turn.ProcessAsync(data));
        }

        private void OnApplyAbility(string data)
        {
            OnApplyAbility turn = new OnApplyAbility();
            turn.Process(data);
        }

        private void OnEndTurn(string data)
        {
            OnEndTurn turn = new OnEndTurn();
            CoroutineManager.Instance.RunCoroutine(turn.ProcessAsync(data));
        }
    }
}
