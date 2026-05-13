using UnityEngine;
using UnityEngine.InputSystem;
public class ProjectileSpawner : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;



    public void OnAttack()
    {
        Debug.Log("hajaja");
        Instantiate(projectilePrefab, transform.position, Quaternion.identity);
    }
    
}