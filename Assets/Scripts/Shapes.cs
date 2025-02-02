using UnityEngine;

public class Shapes : MonoBehaviour
{
    [SerializeField] protected string shapeName;

    public Rigidbody2D rb;
    public Vector2 velocity;

    protected virtual void Start()
    {
        Debug.Log("Hello, my shape is " + shapeName);
        rb.linearVelocity = velocity;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
