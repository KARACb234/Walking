using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{   
    private ScoreManager _scoreManager;
    [SerializeField]
    private int _prise;
    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreManagerObject = GameObject.FindGameObjectWithTag("ScoreManager");
        _scoreManager = scoreManagerObject.GetComponent<ScoreManager>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Connect");
        if (collision.gameObject.CompareTag("Player"))
        {
            _scoreManager.AddScore(_prise);
            Destroy(gameObject);
        }
    }
}
