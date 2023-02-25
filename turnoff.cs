using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnoff : MonoBehaviour
{
    public GameObject Ceiling;
    public GameObject Ceiling2;
    public GameObject Ceiling3;
    public GameObject Ceiling4;
    public PlayerMovement character;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void OnTriggerEnter()
    {
        Ceiling.SetActive(false);
        Ceiling2.SetActive(false);
        Ceiling3.SetActive(false);
        Ceiling4.SetActive(false);
    }
}
