using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HackProjectile : MonoBehaviour
{
    public float InitialBulletSpeed = 30f;
    public float HomingSpeed = 2f;
    private Rigidbody2D rb;
    public float DirectionalValue;
    [SerializeField] private GameObject HackPanel; 

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2(DirectionalValue, 0) * InitialBulletSpeed;
        Destroy(gameObject, 4f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Hackable"))
        {
            UIcontroller.instance.MinigameStart(gameObject);
            Destroy(gameObject);

        }
    }
}