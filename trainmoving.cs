using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trainmoving : MonoBehaviour
{
    //    [SerializeField] float distanceToCover;
    //    [SerializeField]float speed;
    public Transform target;
    public float t;
    public float speed;
    public GameObject self;
    private Vector3 startingPosition;

    // Start is called before the first frame update
    void Start()
    {
//        startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //        Vector3 v = startingPosition;
        //        v.z += distanceToCover * Mathf.Sin(Time.time * speed);
        //        transform.position = v;
        Vector3 a = transform.position;
        Vector3 b = target.position;
        transform.position = Vector3.MoveTowards(a, b, speed);
        if (transform.position == target.position )
        {
            self.SetActive(false);
        }

    }
}
