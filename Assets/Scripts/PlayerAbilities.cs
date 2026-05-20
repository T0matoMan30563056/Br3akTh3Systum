using UnityEngine;
using UnityEngine.InputSystem;

public class ProjectileSpawner : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;
    
    public void OnAttack()
    {

        GameObject Drone = Instantiate(projectilePrefab, transform.position, Quaternion.identity);

        Drone.GetComponent<HackProjectile>().DirectionalValue = PlayerMovement.instance.StartDirection;
    }
}