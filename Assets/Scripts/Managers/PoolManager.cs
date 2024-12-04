using Command;
using Signals;
using UnityEngine;

namespace Managers
{
    public class PoolManager : MonoBehaviour
    {
        #region Self Variables

        #region Serializefield Variables

        [SerializeField] private GameObject bulletPrefab;
        [SerializeField] private Transform createPoint;
        [SerializeField] private int initialSize;
        
        #endregion

        #region Private Variables
        
        private BulletCommand _bulletCommand;

        #endregion

        #endregion

        private void Awake()
        {
            CreatePool();
        }

        private void CreatePool()
        {
            _bulletCommand = new BulletCommand(new PoolCommand(bulletPrefab, initialSize), createPoint);
        }

        private void OnEnable()
        {
            SubscribeEvents();
        }

        private void SubscribeEvents()
        {
            PoolSignals.Instance.onFireBullet += _bulletCommand.Execute;
            PoolSignals.Instance.OnDeactivateBullet += _bulletCommand.Undo;
        }
        
        private void OnDisable()
        {
            UnsubscribeEvents();
        }

        private void UnsubscribeEvents()
        {
            PoolSignals.Instance.onFireBullet -= _bulletCommand.Execute;
            PoolSignals.Instance.OnDeactivateBullet -= _bulletCommand.Undo;
        }
    }
}