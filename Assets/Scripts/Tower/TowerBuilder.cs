// This must be on "Tower" in Unity 

using Platforms;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Tower
{
    public class TowerBuilder : MonoBehaviour
    {
        [SerializeField] private Beam.Beam beamPrefab;
        [SerializeField] private StartPlatform startPlatformPrefab;
        [SerializeField] private FinishPlatform finishPlatformPrefab;
        [SerializeField] private Platform[] basicPlatformPrefabs;
        private int _platformCount;

        private void Awake()
        {
            BuildTower();
        }

        private void BuildTower()
        {
            _platformCount = Random.Range(10, 20);
            var beam = Instantiate(beamPrefab, transform);
            beam.transform.localScale = new Vector3(1, _platformCount / 2f, 1);

            var platformPos = beam.transform.position;
            var startPlatformPos = platformPos;
            var finishPlatformPos = platformPos;
        
            platformPos.y += beam.transform.localScale.y - 1.5f;
            startPlatformPos.y = platformPos.y + 1;
            finishPlatformPos.y = -startPlatformPos.y;

            CreatePlatform(startPlatformPrefab, ref startPlatformPos, beam.transform);
        
            for (var i = 0; i < _platformCount - 2; i++)
            {
                CreatePlatform(
                    basicPlatformPrefabs[Random.Range(0, basicPlatformPrefabs.Length)],
                    ref platformPos,
                    beam.transform);
            }

            CreatePlatform(finishPlatformPrefab, ref finishPlatformPos, beam.transform);
        }

        private void CreatePlatform(Platform platformPrefab, ref Vector3 platformPos, Transform platformParent)
        {
            var newPlatform = Instantiate(platformPrefab,
                                          platformPos,
                                          Quaternion.Euler(0,Random.Range(0, 360),0),
                                          platformParent);
            platformPos.y -= 1;
            newPlatform.transform.SetParent(transform);
            newPlatform.transform.localScale = new Vector3(1, 1, 1);
        }
    }
}