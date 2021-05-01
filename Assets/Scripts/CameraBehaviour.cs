// This must be on "Main Camera" in Unity 

using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    [SerializeField] private Vector3 directionOffset;
    [SerializeField] private float viewDistance;
    private Player _player;
    private Beam.Beam _beam;
    private Vector3 _cameraPos, _minPlayerPos; 

    private void Start()
    {
        _player = FindObjectOfType<Player>();
        _beam = FindObjectOfType<Beam.Beam>();
        _minPlayerPos = _player.transform.position;;
    }

    private void Update()
    {
        if (!(_player.transform.position.y < _minPlayerPos.y)) return;
        PlayerTracking();
        _minPlayerPos = _player.transform.position;
    }

    private void PlayerTracking()
    {
        var beamPos = _beam.transform.position;
        beamPos.y = _player.transform.position.y;
        _cameraPos = _player.transform.position;
        var direction = (beamPos - _player.transform.position).normalized + directionOffset;
        _cameraPos -= direction * viewDistance;
        transform.position = _cameraPos;
        transform.LookAt(_player.transform);
    }
}
