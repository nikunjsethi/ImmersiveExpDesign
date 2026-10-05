using UnityEngine;
using UnityEngine.InputSystem;

public class Instantiate : MonoBehaviour
{
    public InputActionReference instantiateBtn;
    public GameObject spawnobject;

    private void OnEnable()
    {
        instantiateBtn.action.Enable();
        instantiateBtn.action.performed += InstantiateObject;
    }

    private void OnDisable()
    {
        instantiateBtn.action.performed -= InstantiateObject;
        instantiateBtn.action.Disable();
    }

    void InstantiateObject(InputAction.CallbackContext context)
    {
        Instantiate(spawnobject, transform.position, Quaternion.identity);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
