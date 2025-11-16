using System;
using UnityEngine;

public class SkyController : MonoBehaviour
{
    [SerializeField] private GameObject[] skyObjects;
    [SerializeField] private int currentIndex;

    private void Awake()
    {
        DisableAll();
    }

    private void Start()
    {
        DisableAll();
        if (skyObjects.Length > 0) skyObjects[0].SetActive(true);
        
    }

    public void resetsky()
    {
        currentIndex = 0;
        DisableAll();
        if (skyObjects.Length > 0) skyObjects[0].SetActive(true);
    }

    private void DisableAll()
    {
        for (int i = 0; i < skyObjects.Length; i++)
        {
            skyObjects[i].SetActive(false);
        }
    }

    public void NextSky()
    {
        if (skyObjects.Length == 0) return;
        DisableAll();
        currentIndex++;

        if (currentIndex >= skyObjects.Length) currentIndex = 0;

        skyObjects[currentIndex].SetActive(true);
    }
}