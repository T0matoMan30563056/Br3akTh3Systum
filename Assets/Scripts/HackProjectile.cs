using UnityEngine;

public class HackProjectile : MonoBehaviour
{
    [SerializeField] private float speed = 8f;
    [SerializeField] private float homingStrength = 5f;

    private Transform target;

    private void Start()
    {
        FindClosestTarget();
    }

    private void Update()
    {
        if (target == null)
        {
            FindClosestTarget();
            if (target == null) return;
        }

        Vector2 direction = ((Vector2)target.position - (Vector2)transform.position).normalized;
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        // rotate to face target
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, angle), homingStrength);
    }

    private void FindClosestTarget()
    {
        GameObject[] targets = GameObject.FindGameObjectsWithTag("Hackable");
        float closestDistance = Mathf.Infinity;

        foreach (GameObject t in targets)
        {
            float dist = Vector2.Distance(transform.position, t.transform.position);
            if (dist < closestDistance)
            {
                closestDistance = dist;
                target = t.transform;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Hackable"))
        {
            Destroy(gameObject);
        }
    }
}