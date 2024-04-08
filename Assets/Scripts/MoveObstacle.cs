using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacle : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float zBorder;
    private GameManager _gameManager;
    // Start is called before the first frame update
    void Start()
    {
        GameObject gameManagerObject = GameObject.FindGameObjectWithTag("GameManager");
        _gameManager = gameManagerObject.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_gameManager.isGameOver == false)
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        if (transform.position.z <= zBorder)
        {
            Destroy(gameObject);
        }
    }
}