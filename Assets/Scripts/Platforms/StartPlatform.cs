// This must be on StartPlatform Prefab in Unity 

using UnityEngine;

namespace Platforms
{
    public class StartPlatform : Platform
    {
        [SerializeField] private Player player;
        [SerializeField] private Transform startPoint;
        
        private void Start()
        {
            print(startPoint.position);
            var b = Instantiate(player, startPoint.position, Quaternion.identity);
            print(b.transform.position);
        }
    }
}
