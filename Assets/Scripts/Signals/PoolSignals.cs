using MonoSingleton;
using UnityEngine;
using UnityEngine.Events;

namespace Signals
{
    public class PoolSignals : MonoSingleton<PoolSignals>
    {
        public UnityAction< float> onFireBullet = delegate { };
        public UnityAction OnDeactivateBullet = delegate { };
    }
}