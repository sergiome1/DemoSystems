using Assets.Scripts.Coroutines;
using UnityEngine;
using Assets.Scripts.DemonAbilities.Implementations;
using static Assets.Scripts.DemonAbilities.Ability;

namespace Assets.Scripts.DemonAbilities
{
    public class AbilityManager : MonoBehaviour
    {
        public void RunDemonAbility(AbilityClassType abilityClassType, int targetActorNumber, string data, string tableCards)
        {
            Ability ability = GetAbility(abilityClassType);

            CoroutineManager.Instance.RunCoroutine(ability.RunAbility(targetActorNumber, data, tableCards));
        }

        private Ability GetAbility(AbilityClassType abilityType)
        {
            Ability ability = null;

            switch (abilityType)
            {
                case AbilityClassType.Armageddon:
                    ability = new Armageddon();
                    break;
                case AbilityClassType.HandSwapper: 
                    ability = new HandSwapper();
                    break;

                    /*
                     * ...
                     * 
                     */
            }

            return ability;
        }
    }
}
