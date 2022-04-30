using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public Button startButton;
    public Button restartButton;

    public GameObject panelStart;
    public GameObject panelGameOver;
    public GameObject panelWin;
    public GameObject panelRestartButton;

    [SerializeField]
    private TextMeshProUGUI _score;
    [SerializeField]
    public GameObject _enemy;

    PlayerFeatures myPlayer;
    //PlayerLife myPlayer;

    // Start is called before the first frame update
    void Start()
    {
        myPlayer = FindObjectOfType<PlayerFeatures>();

        // Apagar panel
        panelGameOver.SetActive(false);
        panelRestartButton.SetActive(false);
        panelWin.SetActive(false);

        // Enciendo panel
        panelStart.SetActive(true);
        // Detener tiempo
        Time.timeScale = 0;
        // Acciones de botones
        startButton.onClick.AddListener(StartGame);
        restartButton.onClick.AddListener(RestartGame);
    }

    // Update is called once per frame
    void Update()
    {
        // Si life es <= 0, game over!
        if (myPlayer.playerLife <= 0)
        {
            EndGameOver();
        }

        if (currentPoint > 30)
        {
           
            EndGameWin();
        }

    }

    void StartGame()
    {
        Time.timeScale = 1f;
        panelStart.SetActive(false);
    }

    public void EndGameOver()
    {
        Time.timeScale = 0.3f;
        panelGameOver.SetActive(true);
        panelRestartButton.SetActive(true);
    }


    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }

    private int currentPoint = 0;
    //private const float val = 1.5f;
    public void GetPoint(int value)
    {

        var num = CalculateTotalPoints(value);
        _score.SetText(num.ToString());
 

    }

    private int CalculateTotalPoints(int value)
    {

        return currentPoint += value;

       
    }
    public void EndGameWin()
    {

        Time.timeScale = 0.3f;
        panelWin.SetActive(true);
        panelRestartButton.SetActive(true);
    }
}
