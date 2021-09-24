using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelScript : MonoBehaviour
{

    [SerializeField] private List<string> levelList;
    private int currentLevel;


    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            GameManager.instance.GoToNextlevel();
        }

    }

}
