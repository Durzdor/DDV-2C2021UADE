using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private List<string> levels = new List<string>();
    [SerializeField] private int currentLevel;
    [SerializeField] private int currentCoinCount;
    public bool CanTeleport => currentCoinCount >= coins[currentLevel];

    [SerializeField] private List<int> coins;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }
        else
            Destroy(gameObject);
        DontDestroyOnLoad(this);
    }

    void Start()
    {
       
    }

    public void GoToNextlevel()
    {
        
        if (!CanTeleport) return;
            
        currentLevel++;
        if (currentLevel >= levels.Count)
        {
            currentLevel = 0;

        }
        currentCoinCount = 0;
        SceneManager.LoadScene(levels[currentLevel]);
    }

    void Update()
    {
        
    }

    
   public void CollectCoins()
    {
        currentCoinCount++;
    }


   
}
