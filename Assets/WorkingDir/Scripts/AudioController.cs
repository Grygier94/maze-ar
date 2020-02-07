using UnityEngine;

public class AudioController : MonoBehaviour
{
    AudioSource backgroundSound;
    
    // Pole reprezentujące czy muzyka powinna grać
    public static bool playMusic = true;

    void Start()
    {
        // Pobierz obiekt audio
        backgroundSound = GameObject.FindWithTag("backgroundSound").GetComponent<AudioSource>();
        // Spraw, aby obiekt muzki nie niszczył się po zmianie sceny
        DontDestroyOnLoad(backgroundSound);
        HandleMusic();
    }

    void Update()
    {
        HandleMusic();
    }

    public void HandleMusic()
    {
        // Sprawdź czy muzyka powinna grać
        if (playMusic)
        {
            // Sprwadź czy muzyka gra - jeśli nie to uruchom
            if (!backgroundSound.isPlaying)
                backgroundSound.Play();
        }
        else
        {
            // Jeśli muzyka ma nie grać to ją wyłącz
            backgroundSound.Stop();
        }
    }

    // Zmien stan dźwięku (włącz / wyłącz)
    public void TriggerMusic()
    {
        playMusic = !playMusic;
    }

}
