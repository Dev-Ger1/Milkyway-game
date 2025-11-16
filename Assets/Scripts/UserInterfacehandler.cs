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
    
    
   
    
    private Playercontroller _playercontroller;
    private int _bestscore = 0;

    private void Start()
    {
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
        _player.SetActive(true); 
        _player.transform.position = playerStartpostion;
       _menuUI.SetActive(false);
    }

    public void On_restartbuttonPressed()
    {
        _player.SetActive(true); 
        _player.transform.position = playerStartpostion;
        _endscreen.SetActive(false);
    }
    
    
}
