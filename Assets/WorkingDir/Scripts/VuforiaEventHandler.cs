using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VuforiaEventHandler : DefaultTrackableEventHandler
{
    protected override void OnTrackingFound()
    {
        if (mTrackableBehaviour)
        {
            switch (mTrackableBehaviour.TrackableName)
            {
                case "Maze0":
                    SceneManager.LoadScene("Level_1");
                    break;
                case "Maze1":
                    SceneManager.LoadScene("Level_2");
                    break;
                case "Maze2":
                    SceneManager.LoadScene("Level_3");
                    break;
            }
        }
    }
}
