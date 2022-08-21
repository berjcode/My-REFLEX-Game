using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public void Awake()
    {
        instance = this;
    }
    public Text healtText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameOver();
    }

    public void gameOver()
    {
        if(Enemy.Instance.health<=0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
