using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     transform.localPosition = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 randomWalk = new Vector3(Random.Range(-1f, 1f),Random.Range(-1f,1f),Random.Range(-1f, 1f));
        transform.Translate(randomWalk.x * Time.deltaTime,randomWalk.y * Time.deltaTime,randomWalk.z * Time.deltaTime);
    }
}
