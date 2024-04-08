using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver = false;
    [SerializeField]
    private GameObject winCanvas;
    [SerializeField]
    private GameObject defeatCanvas;
    [SerializeField]
    private GameObject exitCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OpenPanel();
        }
    }
    public void Win()
    {
        isGameOver = true;
        winCanvas.SetActive(true);
    }
    public void Defeat()
    {
        isGameOver = true;
        defeatCanvas.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OpenPanel()
    {
        exitCanvas.SetActive(true);
        Time.timeScale = 0.1f;
    }  
    public void ClosePanel()
    {
        exitCanvas.SetActive(false);
        Time.timeScale = 1;
    }
    public void Exit()
    {
        Application.Quit();
    }

}
