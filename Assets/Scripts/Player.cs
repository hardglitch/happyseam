// This must be on "Player" in Unity 

using HUD;
using Platforms;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(AudioSource))]
public class Player : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    [SerializeField] private AudioClip breakSound;
    [SerializeField] private int award = 10;
    private AudioSource _audioSource;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.TryGetComponent(out Destroyable _))
        {
            _rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            _audioSource.Play();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out Destroyable _))
        {
            other.gameObject.GetComponentInParent<Platform>().Break();
            _audioSource.PlayOneShot(breakSound);
            UI.LevelScore += award;
            UI.ShowScoreUI();
        }
    }
    
    
}
