using UnityEngine;

public class FinishGame : MonoBehaviour
{
    private bool hasTriggered = false;

    public GameObject nextGameWindow;
    public Canvas gameCanvas;
    public GameObject gameCanvas2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasTriggered)
        {
            hasTriggered = true;
            nextGameWindow.SetActive(true);
            Time.timeScale = 0f;
            gameCanvas.enabled = false;
            gameCanvas2.SetActive(false);
            Cursor.visible = true;
        }
    }
}
