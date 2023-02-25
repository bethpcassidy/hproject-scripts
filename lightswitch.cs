using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightswitch : MonoBehaviour
{
    public GameObject[] lights;
    public float lightSpeed;
    public PlayerMovement character;

    void Start()
    {
        for (int i = 0; i < lights.Length; i++)
        {
            lights[i].SetActive(false);
        }
    }

    // coroutine for lights on one at a time effect
    IEnumerator Flip()
    {
        for (int i = 0; i < lights.Length; i++)
        {
            lights[i].SetActive(true);
            yield return new WaitForSeconds(lightSpeed);
        }
    }

    private void OnTriggerEnter()
    {
        StartCoroutine(Flip());
    }


}
