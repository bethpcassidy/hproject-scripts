using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicoff : MonoBehaviour
{
    public GameObject Sound;
    public PlayerMovement character;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter()
    {
        Sound.SetActive(false);
    }


}
