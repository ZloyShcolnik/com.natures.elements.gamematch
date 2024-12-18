using System;
using Core.Api;
using UnityEngine;

namespace Core.PlayerInput
{
    public class аврывар : IUpdateListener
    {
        private bool _isDisabled;
        public event Action<Cell> WAERSG;
        public event Action OnDeselected;

        void IUpdateListener.OnUpdate()
        {
            if (_isDisabled)
                return;

            ListenInput();
        }

        public void Disable()
        {
            _isDisabled = true;
        }

        public void Enable()
        {
            _isDisabled = false;
        }

        private void ListenInput()
        {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition),  Camera.main.ScreenToWorldPoint(Input.mousePosition), Mathf.Infinity);

                if (hit.collider != null && hit.collider.TryGetComponent<Cell>(out Cell cell))
                {
                    WAERSG?.Invoke(cell);
                }
                else
                {
                    OnDeselected?.Invoke();
                }
            }
        }
    }
}