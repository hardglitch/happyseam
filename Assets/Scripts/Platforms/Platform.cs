// This must be on "Platform" in Unity 

using UnityEngine;

namespace Platforms
{
    public class Platform : MonoBehaviour
    {
        private const float BounceForce = 50f;
        private const float BounceRadius = 50f;

        public void Break()
        {
            var destroyableElements = GetComponentsInChildren<Destroyable>();

            foreach (var element in destroyableElements)
            {
                element.Bounce(BounceForce, transform.position, BounceRadius);
            }
        }
    }
}
