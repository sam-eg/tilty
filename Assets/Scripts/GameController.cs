using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int score;
    public bool gameRunning;
    public GameObject startScreen;
    public GameObject gameOverScreen;
    public GameObject platform;
    public TMP_Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        gameRunning = false;
        startScreen.GetComponentInChildren<Button>().onClick.AddListener(startGame);
        gameOverScreen.GetComponentInChildren<Button>().onClick.AddListener(resetGame);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
    }

    public void startGame()
    {
        startScreen.SetActive(false);
        platform.GetComponent<Rigidbody>().isKinematic = false;
        score = 0;
        gameRunning = true;
        
    }

    public void endGame()
    {
        gameOverScreen.SetActive(true);
        gameRunning = false;
        platform.transform.rotation.Set(0, 0, 0, 0);
        platform.GetComponent<Rigidbody>().isKinematic = true;
    }

    public void resetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
