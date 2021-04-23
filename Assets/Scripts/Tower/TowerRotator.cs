//This must be on "Towers" in Unity

using UnityEngine;

namespace Tower
{
    [RequireComponent(typeof(Rigidbody))]
    public class TowerRotator : MonoBehaviour
    {
        [SerializeField] private float rotateSpeed;
        private Rigidbody _rigidbody;
        private Controllers _playerController;

        private void OnEnable() => _playerController.Enable();
        private void OnDisable() => _playerController.Disable();

        private void Awake()
        {
            _playerController = new Controllers();
            _playerController.TowerRotator.RotateTouch.performed += _ => RotateTower();
            OnEnable();
        }

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void FixedUpdate()
        {
            RotateTower();
        }

        private void RotateTower()
        {
            var touchInput = _playerController.TowerRotator.RotateTouch.ReadValue<Vector2>();
            var torque = touchInput.x * Time.fixedDeltaTime * rotateSpeed;
            
            if (touchInput.x > 0)
            {
                _rigidbody.AddTorque(Vector3.up * torque);
            }
            else
            if (touchInput.x < 0)
            {
                _rigidbody.AddTorque(Vector3.up * torque);
            }
        }
    }
}