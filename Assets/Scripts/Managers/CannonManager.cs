using Controllers;
using Signals;
using UnityEngine;

namespace Managers
{
    public class CannonManager : MonoBehaviour
    {
        #region Self Variables

        #region Serializefield Variables

        [SerializeField] private GameObject cannonBase;

        #endregion

        #region Private Variables

        private CannonController _cannonController;

        #endregion

        #endregion

        private void Awake()
        {
            CreateController();
        }

        private void CreateController()
        {
            _cannonController = new CannonController(cannonBase);
        }

        private void OnEnable()
        {
            SubscribeEvents();
        }

        private void SubscribeEvents()
        {
            CannonSignals.Instance.onCannonRotated += _cannonController.OnRotateCannonToTarget;
        }

        private void OnDisable()
        {
            UnsubscribeEvents();
        }

        private void UnsubscribeEvents()
        {
            CannonSignals.Instance.onCannonRotated -= _cannonController.OnRotateCannonToTarget;
        }
    }
}