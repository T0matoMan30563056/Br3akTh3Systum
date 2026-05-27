using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    public float sightRange = 3f;

    private Rigidbody2D rb;
    private float npcDirection = 1f;
    private LayerMask layerMask;
    public Transform hackableSquare;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        layerMask = LayerMask.GetMask("Wall", "Player");
    }

    void FixedUpdate()
    {
        Vector2 rayDirection = new Vector2(npcDirection, 0f);
        Vector2 rayPos = (Vector2)transform.position + rayDirection * 0.2f;

       
        RaycastHit2D hit = Physics2D.Raycast(rayPos, rayDirection, sightRange, layerMask);

        if (hit.collider != null)
        {
            Debug.DrawRay(rayPos, rayDirection * hit.distance, Color.green);
            if (hit.collider.CompareTag("Player"))
            {
                Destroy(hit.collider.gameObject);
            }
            Flip();
        }
        else
        {
            Debug.DrawRay(rayPos, rayDirection * sightRange, Color.red);
        }

        rb.linearVelocity = new Vector2(moveSpeed * npcDirection, rb.linearVelocity.y);
    }

    void Flip()
    {
        npcDirection *= -1f;

        
        Vector3 scale = transform.localScale;
        scale.x *= -1f;
        transform.localScale = scale;

        if (hackableSquare != null)
        {
            Vector3 pos = hackableSquare.localPosition;
            pos.x *= -1f;
            hackableSquare.localPosition = pos;
        }
    }
}