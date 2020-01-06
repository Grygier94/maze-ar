using UnityEngine;
using UnityEngine.Video;
using Vuforia;

public class virtual_btn : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject virtualButton;
    public VideoPlayer videoPlayer;

    void Start()
    {
        virtualButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.LogWarning("Pressed");
        videoPlayer.Play();
        Debug.LogWarning("asdf");

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.LogWarning("Released");
    }
}
