using Unity.Hierarchy;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class NPC : MonoBehaviour
{

    LayerMask layerMask;
    public float SightRange;
    void Awake()
    {
        layerMask = LayerMask.GetMask("Wall", "Player");
    }

    void FixedUpdate()
    {

        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.TransformDirection(new Vector3(1, 0, 0)), SightRange, layerMask);
        if (hit)
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(new Vector3(1, 0, 0)) * hit.distance, Color.green);
            Debug.Log("Did Hit");
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(new Vector3(1, 0, 0)) * SightRange, Color.red);

        }
        
    }
}
