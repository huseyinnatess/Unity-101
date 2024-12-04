using Interfaces;
using UnityEngine;

namespace Command
{
    public class BulletCommand
    {
        #region Self Variables

        #region Private Variables

        private readonly IPoolable _pool;
        private GameObject _bulletObject;
        private readonly Transform _createPoint;
        
        #endregion

        #endregion

        public BulletCommand(IPoolable pool, Transform createPoint)
        {
            _pool = pool;
            _createPoint = createPoint;
        }

        public void Execute(float bulletForce)
        {
            _bulletObject = _pool.Execute();
            _bulletObject.transform.position = _createPoint.transform.position + _createPoint.transform.right * 1.5f;
            _bulletObject.GetComponent<Rigidbody>().AddForce(_createPoint.transform.right * bulletForce);
        }

        public void Undo()
        {
            _pool.Undo(_bulletObject);
        }
    }
}