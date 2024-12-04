
using UnityEngine;

namespace Interfaces
{
    public interface IPoolable
    {
        GameObject Execute();
        void Undo(GameObject prefab);
    }
}