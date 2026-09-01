using UnityEngine;

public class CreditsMenu : MonoBehaviour
{
    public AudioSource clickAudio;
    public Canvas creditsCanvas;

    public void CloseCredits()
    {
        clickAudio.Play();

        creditsCanvas.enabled = false;

        Destroy(gameObject, clickAudio.clip.length);
    }
}