using MonoSingleton;
using UnityEngine;
using UnityEngine.Events;

namespace Signals
{
    public class CannonSignals : MonoSingleton<CannonSignals>
    {
        public UnityAction<Vector3> onCannonRotated = delegate { };
    }
}