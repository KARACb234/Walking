using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] obstacle;
    [SerializeReference]
    private float minX;
    [SerializeField]
    private float maxX;
    [SerializeField]
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", 2, 3.5f);
    }

    // Update is called once per frame
    private void SpawnObstacle()
    {
        if (gameManager.isGameOver == false)
        {
            float randomX = Random.Range(minX, maxX);
            Vector3 randomPosition = new Vector3(randomX, transform.position.y, transform.position.z);
            int randomIndex = Random.Range(0, obstacle.Length);
            Instantiate(obstacle[randomIndex], randomPosition, Quaternion.identity);
        }
    }
}
