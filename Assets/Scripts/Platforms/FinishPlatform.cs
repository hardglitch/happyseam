using UnityEngine;
using UnityEngine.SceneManagement;

namespace Platforms
{
    public class FinishPlatform : Platform
    {
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.TryGetComponent(out Player _))
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
