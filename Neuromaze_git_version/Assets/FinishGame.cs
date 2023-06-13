using UnityEngine;

public class FinishGame : MonoBehaviour
{
    private bool hasTriggered = false;

    public GameObject nextGameWindow;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasTriggered)
        {
            hasTriggered = true;
            nextGameWindow.SetActive(true);
            Time.timeScale = 0f;
            Cursor.visible = true;            
        }
    }
}
