using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerator : MonoBehaviour
{
    public GameObject[] ballPrefabs;
    private GameObject temp;
    FollowPath pathScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("BallSpawner", 2, 1);
    }

    public void BallSpawner()
    {
        int index = Random.Range(0, ballPrefabs.Length);
        temp = Instantiate(ballPrefabs[index], transform.position, transform.rotation);
        pathScript = temp.GetComponent<FollowPath>();
        pathScript.enabled = true;
    }
}


