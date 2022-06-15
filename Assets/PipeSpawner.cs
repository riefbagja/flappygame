using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public float timeForSpawn;
    private float timer;
    public GameObject pipe;
    public float height;
    public float timerForDestroy;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > timeForSpawn)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, timerForDestroy);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
