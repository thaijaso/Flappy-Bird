using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    public float heightOffset = 10;

    private float timer = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        } 
        else
        {
            spawnPipe();
            timer = 0;
        }    
    }

    void spawnPipe()
    {
        Instantiate(pipe, getRandomSpawnPosition(), transform.rotation);
    }

    private Vector3 getRandomSpawnPosition()
    {
        float minHeight = transform.position.y - heightOffset;
        float maxHeight = transform.position.y + heightOffset;
        float randomHeight = Random.Range(minHeight, maxHeight);
        Vector3 spawnPosition = new Vector3(transform.position.x, randomHeight, transform.position.z);
        return spawnPosition;
    }
}
