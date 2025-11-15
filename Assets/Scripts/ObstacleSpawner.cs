using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _obstacle;

    [SerializeField]
    private float _yoffssetmin = 1f, _yoffsetmax = 3f;
    [SerializeField]
    private Playercontroller _player;

    private float _spawnfrequency = 3f;

    private float _timeTillnextspawn = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_timeTillnextspawn <= 0f && _player.isAlvie)
        {
            Vector3 newpositon = new Vector3(transform.position.x, Random.Range(_yoffssetmin, _yoffsetmax ));
            Instantiate(_obstacle, newpositon, transform.rotation);
            _timeTillnextspawn = _spawnfrequency;
        }
        else
        {
            _timeTillnextspawn -= Time.deltaTime;
        }
         
    }
}
