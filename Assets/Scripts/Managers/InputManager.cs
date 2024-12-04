using System;
using Signals;
using UnityEngine;

namespace Managers
{
    public class InputManager : MonoBehaviour
    {
        #region Self Variables

        #region Private Variables

        private Vector2 _mousePosition;
        private Vector2 _worldPosition;
        [SerializeField] private Camera gameCamera;

        #endregion

        #endregion

        private void Update()
        {
            _mousePosition = Input.mousePosition;
            _worldPosition = gameCamera.ScreenToWorldPoint(new Vector3(_mousePosition.x,_mousePosition.y,transform.position.z - gameCamera.transform.position.z));
            
            CannonSignals.Instance.onCannonRotated?.Invoke(_worldPosition);

            if (Input.GetMouseButtonDown(0))
            {
                PoolSignals.Instance.onFireBullet?.Invoke(200);
            }
        }
    }
}