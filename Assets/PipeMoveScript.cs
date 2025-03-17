using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;

    private float deadZoneX = -40;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * Time.deltaTime * moveSpeed);

        if (transform.position.x < deadZoneX)
        {
            Destroy(gameObject);
        }
    }
}
