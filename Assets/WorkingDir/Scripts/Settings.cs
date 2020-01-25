using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    AudioSource backgroundSound;
    public static bool playMusic = true;
    public static bool showTimer = true;
 
    // Start is called before the first frame update
    void Start()
    {
	backgroundSound = GameObject.FindWithTag("backgroundSound").GetComponent<AudioSource>();
	HandleMusic();
        DontDestroyOnLoad(backgroundSound);
    }

    // Update is called once per frame
    void Update()
    {
        HandleMusic();
    }
    public void HandleMusic()
    {
	if(playMusic)
	{
	   if (backgroundSound.isPlaying) return;
           backgroundSound.Play();
	}
	else backgroundSound.Stop();
    }

     
     public void HandleButton(string action)
     {
    	switch(action)
	{
	     case "MUSIC_ON_OFF": playMusic = !playMusic;
		                 break;
	     case "TIMER_ON_OFF": showTimer = !showTimer;
				 break;
	     default:
		     SceneManager.LoadScene("MainMenu");
		     break;
		   
	}
     }
    
}
