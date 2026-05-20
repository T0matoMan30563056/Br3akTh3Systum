using UnityEngine;

public class SecurityCamera : MonoBehaviour
{
    private float timeInside = 0f;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;

        timeInside += Time.deltaTime;

        if (timeInside >= 0.1f)
        {
            Destroy(other.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player")) timeInside = 0f;
    }
}