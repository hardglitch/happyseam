// This must be on PlatformPrefabs Children 

using UnityEngine;

namespace Platforms
{
    [RequireComponent(typeof(Rigidbody))]
    public class Destroyable : MonoBehaviour
    {
        public void Bounce(float force, Vector3 center, float radius)
        {
            if (!TryGetComponent(out Rigidbody rb)) return;
            rb.isKinematic = false;
            rb.AddExplosionForce(force, center, radius);
        }
    }
}
