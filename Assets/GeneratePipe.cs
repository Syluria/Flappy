using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class GeneratePipe : MonoBehaviour
{
    public GameObject pipe;
    float pipeTimer = 0;
    public float generateTimer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pipeTimer += Time.deltaTime;

        if (pipeTimer > generateTimer)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = new Vector3(6, Random.Range(-3f, 3f), 0);
            pipeTimer = 0;
            Destroy(newPipe, 4.0f);
        }      
    }
}
