using System.Collections.Generic;
using Interfaces;
using UnityEngine;

namespace Command
{
    public class PoolCommand : IPoolable
    {
        #region Self Variables

        #region Private Variables

        private List<GameObject> _poolList = new();
        private GameObject _prefab;
        private GameObject _tempPrefab;

        #endregion

        #endregion

        public PoolCommand(GameObject prefab, int initialSize)
        {
            _prefab = prefab;
            for (int i = 0; i < initialSize; i++)
            {
                _tempPrefab = Object.Instantiate(prefab);
                _tempPrefab.SetActive(false);
                _poolList.Add(_tempPrefab);
            }
        }

        public GameObject Execute()
        {
            for (int i = 0; i < _poolList.Count; i++)
            {
                if (_poolList[i].activeInHierarchy) continue;
                _poolList[i].SetActive(true);
                return _poolList[i];
            }

            IncrementList();
            _tempPrefab = _poolList[^1];
            _tempPrefab.SetActive(true);
            return _tempPrefab;
        }

        public void Undo(GameObject prefab)
        {
            prefab.SetActive(false);
        }

        private void IncrementList()
        {
            int currentCount = _poolList.Count;

            for (int i = 0; i < currentCount; i++)
            {
                _tempPrefab = Object.Instantiate(_prefab);
                _tempPrefab.SetActive(false);
                _poolList.Add(_tempPrefab);
            }
        }
    }
}