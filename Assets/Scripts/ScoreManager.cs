using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    private GameManager _gameManager;
    [SerializeField]
    private int _score;
    [SerializeField]
    private TextMeshProUGUI _scoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreText();
        GameObject gameManagerObject = GameObject.FindGameObjectWithTag("GameManager");
        _gameManager = gameManagerObject.GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void AddScore(int prise)
    {
        _score += prise;
        CheckGameEnd();
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        _scoreText.text = "Score:  " + _score;
    }

    private void CheckGameEnd()
    {
        if (_score >= 100)
        {
            _gameManager.Win();
        }
        if (_score <= -10)
        {
            _gameManager.Defeat();
        }
    }

}
