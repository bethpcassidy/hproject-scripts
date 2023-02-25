using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Jumpscare : MonoBehaviour
{
    public PlayerMovement character;
    public GameObject Object;
    public GameObject Light;
    public GameObject Sound;
    public bool Switch;
    // public GameObject ActivateObject;
    // public TextAsset TextFileAsset;




    void Start()
    {
        Object.SetActive(false);
        Sound.SetActive(false);
        Switch = true;
    }

    void OnTriggerEnter()
    {
        //Character.canMove = false;
        if (Switch == true)
        {
            Object.SetActive(true);
            Light.SetActive(true);
            Sound.SetActive(true);
        }
    }




    void OnTriggerExit()
    {
        Object.SetActive(false);
        Light.SetActive(false);
        Switch = false;
    }


}