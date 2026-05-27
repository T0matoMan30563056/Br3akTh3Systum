using UnityEngine;



public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    private Rigidbody2D rb;
    private float horizontalInput;
    public float DirectionalValue;
    public float StartDirection = 1;
    public static PlayerMovement instance;
    public bool canMove = true;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
        canMove = true;

        if (instance == null)
        {
            instance = this;
        }
    }
    private void Update()
    {
        if (canMove == true)
        {
            horizontalInput = Input.GetAxisRaw("Horizontal");
            DirectionalValue = horizontalInput;

            if (Mathf.Abs(DirectionalValue) == 1)
            {
                StartDirection = DirectionalValue;
            }
        }
        else
        {
            
        }
    }

    private void FixedUpdate()
    {
        if (canMove == true)
        {
            rb.linearVelocity = new Vector2(horizontalInput * moveSpeed, rb.linearVelocity.y);
        } else
        {
            rb.linearVelocity = new Vector2(0, 0);
        }
    }


}