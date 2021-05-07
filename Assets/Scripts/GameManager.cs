using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
      public static GameManager instance;
      bool gameOver=false;
      int score=0;
      public Text scoreText;
      public Text scoreTextPanel;

      public GameObject gameOverPanel;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void Awake()
    {
      if(instance == null)
      {
        instance =this;
      }
    }
    public void GameOver()
    {
      gameOver=true;

      GameObject.Find("EnemySpawn").GetComponent<EnemySpawn>().StopSpawning();
      scoreTextPanel.text="Score: "+score;
      gameOverPanel.SetActive(true);

    }
    public void IncrementScore()
    {
      if(!gameOver)
      {
        score++;
        print(score);
        scoreText.text= score.ToString();
      }

    }
    public void MainMenu()
    {
      SceneManager.LoadScene("Menu");
    }
    public void Restart()
    {
      SceneManager.LoadScene("Game");

    }
}
