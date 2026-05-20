using UnityEngine;

public class HackProjectile : MonoBehaviour
{
    public float InitialBulletSpeed = 30f;
    public float HomingSpeed = 2f;
    private Rigidbody2D rb;
    public float DirectionalValue;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2(1, 1) * InitialBulletSpeed * DirectionalValue;
    }
    void Update()
    {
        


    }
}
