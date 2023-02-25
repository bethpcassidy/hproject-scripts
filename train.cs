using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class train : MonoBehaviour
{
    public GameObject Train;
    public PlayerMovement character;
    // Start is called before the first frame update
    void Start()
    {
        Train.SetActive(false);
    }

    void OnTriggerEnter()
    {
        Train.SetActive(true);
    }

}
