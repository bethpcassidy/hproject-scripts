using UnityEngine;

public class dumpster : MonoBehaviour
{
    public GameObject Object;
    public PlayerMovement character;
    public GameObject Ui;

    public bool Switch;
    public bool Switch2;
    public GameObject Objective;
    void Start()
    {
        Object.SetActive(true);

        Ui.SetActive(false);
        Switch = false;
        Objective.SetActive(false);
        Switch2 = true;
    }



    void OnTriggerEnter()
    {
        if (Switch2 == true)
        {
            Switch = true;
        }
    }
    void Update()
    {
        if (Switch == true)
        {
            Ui.SetActive(true);

            if (Input.GetMouseButtonDown(0))
            {
                Ui.SetActive(false);

                Object.SetActive(false);
                Switch2 = false;
                Switch = false;
                Objective.SetActive(true);
            }
        }

    }




    void OnTriggerExit()
    {
        Ui.SetActive(false);

    }
}