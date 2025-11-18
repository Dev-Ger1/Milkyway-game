using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UserInterfaceHandler: MonoBehaviour
{
    [SerializeField]
    private GameObject _player;
    [SerializeField]
    private Vector3 playerStartpostion = Vector3.zero;
    [SerializeField]
    private GameObject _menuUI;
    [SerializeField]
    private TextMeshProUGUI _scoreText, _bestScoreText;
    [SerializeField]
    public GameObject _restartButton;
    [SerializeField]
    public GameObject _endscreen;
    [SerializeField] 
    private AudioSource _intro;
    [SerializeField]
    private GameObject _coincounter;
    [SerializeField]
    private GameObject _difficultybutton; 
    [SerializeField]
    public AudioSource _gamemusic;
    

    
    
   
    
    private Playercontroller _playercontroller;
    private int _bestscore = 0;

    private void Start()
    {
        _intro.Play(); 
        _playercontroller = _player.GetComponent<Playercontroller>();
    }

    private void Update()
    {
        _scoreText.text = _playercontroller.Score.ToString();
        
        if (_playercontroller.Score > _bestscore)
            {
            _bestscore = _playercontroller.Score;
            _bestScoreText.text = _bestscore.ToString();
            }

      
       
    }

    public void OnStartPressed()
    {
        _coincounter.SetActive(true);
        _intro.Stop();
        _player.SetActive(true); 
        _player.transform.position = playerStartpostion;
       _menuUI.SetActive(false);
       _gamemusic.Play();
       _gamemusic.loop = true;
    }

    public void On_restartbuttonPressed()
    {
        _player.SetActive(true); 
        _player.transform.position = playerStartpostion;
        _endscreen.SetActive(false);
    }
        
    }


