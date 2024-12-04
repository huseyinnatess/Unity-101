using UnityEngine;

namespace Controllers
{
    public class CannonController
    {
        #region Self Variables

        #region Private Variables

        private GameObject _cannonBase;

        #endregion

        #endregion

        public CannonController(GameObject cannonBase)
        {
            _cannonBase = cannonBase;
        }

        public void OnRotateCannonToTarget(Vector3 worldPosition)
        {
            if(worldPosition.x < _cannonBase.transform.position.x + 1) return;
            _cannonBase.transform.localEulerAngles = new Vector3(
                _cannonBase.transform.localEulerAngles.x,
                _cannonBase.transform.localEulerAngles.y,
                Mathf.Atan2((worldPosition.y - _cannonBase.transform.position.y),(worldPosition.x - _cannonBase.transform.position.x)) * Mathf.Rad2Deg
            );
        }
    }
}