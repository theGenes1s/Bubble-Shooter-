using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class FollowPath : MonoBehaviour
{
    private  PathCreator pathCreator;
    float distance;
    public float speed = 2;

    private void Start()
    {
        pathCreator = GameObject.Find("Path").GetComponent<PathCreator>();
    }

    // Update is called once per frame
    void Update()
    {
        distance += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distance);
    }
}
