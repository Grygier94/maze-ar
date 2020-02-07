using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    // Mnożnik prędkości (pozwala na manipulowanie przyśpieszeniem piłki)
    float speed = 3000;
    public GameObject gameOverImage;

    // Update wywoływany jest co klatkę
    void Update()
    {
        // Stwórz nowy wektor bazując na wartościach pobranych z akceleratora
        Vector3 movement = new Vector3(Input.acceleration.x, 0.0f, Input.acceleration.y);

        // Zaaplikuj siłę do piłki bazując na poprzednio zdefiniowanym wektorze 
        // biorąc pod uwagę wartość przyśpieszenia (speed) oraz delta time 
        // (czas pomiędzy klatkami - sprawia, że gra działa z tą samą prędkością niezależnie od FPS)
        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
    }

    // Funkcja wywoływana podczas gdy piłka wejdzie w inny obiekt (obiekt other)
    private void OnTriggerEnter(Collider other)
    {
        // Weryfikacja obiektu, z którym piłka koliduje na podstawie przypisanego tagu
        // W przypadku dotarcia do końca - wyświetl ekran końcowy
        if (other.CompareTag("Finish"))
            GameOver();

        // Podczas kolizji z kolcami zresetuj scene
        if (other.CompareTag("Spikes"))
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void GameOver()
    {
        // Uaktywnij (pokaż) obraz Game Over
        gameOverImage.SetActive(true);
        // Zniszcz piłkę
        Destroy(gameObject);
    }
}
