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
        currentLevel++;
        if (currentLevel >= levels.Count)
        {
            currentLevel = 0;

        }
        SceneManager.LoadScene(levels[currentLevel]);
    }

    void Update()
    {
        
    }



   
}
