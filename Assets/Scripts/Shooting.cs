using UnityEngine;
using UnityEngine.InputSystem;
public class Shooting : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 20f;

    public InputActionReference fireBtn;
    public AudioSource fireSound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnEnable()
    {
        fireBtn.action.Enable();
        fireBtn.action.performed += Fire;
    }

    private void OnDisable()
    {
        fireBtn.action.performed -= Fire;
        fireBtn.action.Disable();
    }

    void Fire(InputAction.CallbackContext context)
    {
        RaycastHit hit;

        Physics.Raycast(FirePoint.position, FirePoint.forward, 100f);

        GameObject bullet = Instantiate(bulletPrefab, FirePoint.position, Quaternion.identity);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.linearVelocity = FirePoint.forward * bulletSpeed;

        fireSound.Play();
    }
}
