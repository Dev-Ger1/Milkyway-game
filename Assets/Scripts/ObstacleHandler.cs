using UnityEngine;

public class ObstacleHander : MonoBehaviour
{
    [SerializeField]
    private float _movespeed = 10f;
    [SerializeField]
     private float _minx = -15f;

    [SerializeField] 
    public GameObject _Coin;
    
    
    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * _movespeed * Time.deltaTime;
        
        if (transform.position.x <= _minx)
        {
            Destroy(gameObject);
        }
        
        
    }
}
