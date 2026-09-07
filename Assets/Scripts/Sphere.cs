using UnityEngine;

public class Sphere : MonoBehaviour
{
    public GameObject sphere;
    public GameObject Canvas;
    float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        Debug.Log(timer);
        if (timer > 5)
        {
            
            sphere.GetComponent<Rigidbody>().useGravity = true;
        }
    }

    public void DestroyCanvas()
    {
        Destroy(Canvas);
    }
}
