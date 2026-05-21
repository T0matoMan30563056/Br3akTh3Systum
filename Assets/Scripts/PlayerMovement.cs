using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    private Rigidbody2D rb;
    private float horizontalInput;
    public float DirectionalValue;
    public float StartDirection = 1;
    public static PlayerMovement instance;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;

        if (instance == null)
        {
            instance = this;
        }
    }
    private void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        DirectionalValue = horizontalInput;

        if (Mathf.Abs(DirectionalValue) == 1)
        {
            StartDirection = DirectionalValue;
        }
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(horizontalInput * moveSpeed, rb.linearVelocity.y);
    }


}