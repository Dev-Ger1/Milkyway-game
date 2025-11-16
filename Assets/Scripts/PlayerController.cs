using System;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    [SerializeField]
    private float jumpforce = 10f;

    [SerializeField]
    private GameObject _menu;

    [SerializeField]
    public GameObject _endscreen;

    [SerializeField]
    private AudioSource _coinsound;

    [SerializeField] 
    private SkyController _skyController;
    [SerializeField]
    private AudioSource _jumpsound;

    [SerializeField]
    private AudioSource _deathsound;
    
    
    private Rigidbody2D _rigidbody;
    private int _score = 0;

    public int Score
    {
        get
        {
            return _score;
        }
    }

    public bool isAlvie
    {
        get
        {
            return gameObject.activeSelf;
        }
    }
   

  
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _rigidbody.linearVelocityY = jumpforce;
            _jumpsound.Play();
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.SetActive(false);
        _endscreen.SetActive(true);
        _score = 0;
        _deathsound.Play();
        var obstacles = FindObjectsOfType<ObstacleHander>();
        for(int i = 0; i < obstacles.Length; i++)
            Destroy(obstacles[i].gameObject);
    }
    

    private void OnTriggerEnter2D(Collider2D collison)
    {
        _score += 1;
        Destroy(collison.transform.parent.gameObject.GetComponent<ObstacleHander>()._Coin);
        _coinsound.Play();
        if(_score % 10 == 0)
        {
           _skyController.NextSky(); 
        }
    }
}


