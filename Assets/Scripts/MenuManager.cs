using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject creditsPrefab;

    public void OpenCredits()
    {
        Instantiate(creditsPrefab);
    }

    public void ExitGame()
    {
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #else
        Application.Quit();
    #endif
    }
}