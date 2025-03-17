using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public bool isBirdAlive = true;
    public LogicScript logicScript;

    private int pipeLayer;
    private int outOfBoundsLayer;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        pipeLayer = LayerMask.NameToLayer("Pipe");
        outOfBoundsLayer = LayerMask.NameToLayer("Out Of Bounds");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isBirdAlive)
        {
            myRigidBody.linearVelocity = Vector2.up * flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logicScript.TriggerGameOver();
        isBirdAlive = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == pipeLayer || collision.gameObject.layer == outOfBoundsLayer)
        {
            logicScript.TriggerGameOver();
            isBirdAlive = false;
        }
    }
}
