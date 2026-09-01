using UnityEngine;

public class CreditsMenu : MonoBehaviour
{
    public AudioSource clickAudio;
    public Canvas creditsCanvas;

    public void CloseCredits()
    {
        clickAudio.Play();

        // Hide the credits immediately
        creditsCanvas.enabled = false;

        // Destroy after sound finishes
        Destroy(gameObject, clickAudio.clip.length);
    }
}