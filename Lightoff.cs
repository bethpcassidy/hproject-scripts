using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightoff : MonoBehaviour
{
    public GameObject Flicker;
    public PlayerMovement character;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter()
    {
        Flicker.SetActive(false);
    }
}
