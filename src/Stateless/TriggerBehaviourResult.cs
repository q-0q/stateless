using System.Collections.Generic;

namespace Stateless
{
    public partial class StateMachine<TState, TTrigger>
    {
        internal class TriggerBehaviourResult
        {
            public TriggerBehaviourResult(TriggerBehaviour handler, ICollection<string> unmetGuardConditions, int priority = 0)
            {
                Handler = handler;
                UnmetGuardConditions = unmetGuardConditions;
                Priority = priority;

            }
            public TriggerBehaviour Handler { get; }
            public ICollection<string> UnmetGuardConditions { get; }
            
            public int Priority { get; }
        }
    }
}
