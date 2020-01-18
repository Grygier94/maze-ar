using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            transform.position = spawnPoint.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
            GameOver();

        if (other.CompareTag("Spikes"))
            SceneManager.LoadScene("Level0");
    }

    void GameOver()
    {
        if (SceneManager.GetActiveScene().name == "Level0")
        {
            SceneManager.LoadScene("Level1");
        }
        else
        {
            gameOverImage.SetActive(true);
            Destroy(gameObject);
        }
    }
}
