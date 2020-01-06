using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject plane;
    public GameObject spawnPoint;
    public GameObject gameOverImage;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < plane.transform.position.y - 10)
        {
            Debug.Log("position y: " + transform.position.y);
            transform.position = spawnPoint.transform.position;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
            GameOver();
    }

    void GameOver()
    {
        gameOverImage.SetActive(true);
    }
}
