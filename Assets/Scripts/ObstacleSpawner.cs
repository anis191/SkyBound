using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _obstacle;
    [SerializeField]
    // private float _yOffsetMin = 10f, _yOffsetMax = 3f;
    private float _yOffsetMax = 10f, _yOffsetMin = -5f;
    [SerializeField]
    private PlayerController _player;

    private float _spawnFrequency = 3f;
    private float _timeTillNextSpawn = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // void Start()
    // {
        // 
    // }

    // Update is called once per frame
    void Update()
    {
        if (_timeTillNextSpawn <= 0f && _player.IsActive)
        {
            Vector3 newPosition = new Vector3(transform.position.x, Random.Range(_yOffsetMin, _yOffsetMax));
            Instantiate(_obstacle, newPosition, transform.rotation);
            _timeTillNextSpawn = _spawnFrequency;
        }
        else
        {
            _timeTillNextSpawn -= Time.deltaTime;
        }
    }
}
