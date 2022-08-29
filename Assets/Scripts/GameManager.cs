using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject congrats;
    public Transform frog; 
    public TextMeshProUGUI scoreText;
    public static GameManager Instance;
    [HideInInspector] public int score = 0;
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    private void Update()
    {
        if (score == 1000)
        {
            GameWin();
            Invoke("RestartGame", 3f);
        }

        if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void GameWin()
    {
        congrats.SetActive(true);
    }
}
