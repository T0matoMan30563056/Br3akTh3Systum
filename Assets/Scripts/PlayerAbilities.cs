using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAbilities : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;

    public static PlayerAbilities instance;
    public bool canAttack = true;

    void Awake()
    {
        instance = this;
    }
    public void OnAttack()
    {
        if (!canAttack) return;

        GameObject Drone = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        Drone.GetComponent<HackProjectile>().DirectionalValue = PlayerMovement.instance.StartDirection;
    }
}