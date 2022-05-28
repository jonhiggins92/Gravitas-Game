using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformController : MonoBehaviour
{

    public Animator animator;
    public bool platSwitch = true;
    public float startTime = 2;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("platformSwitch", startTime, 2);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void platformSwitch()
    {
        Debug.Log("tick");

        if(platSwitch == true)
        {
            animator.SetBool("Switch", false);
            platSwitch = false;
            GetComponent<BoxCollider2D>().enabled = false;
        }
        else if (platSwitch == false)
        {
            animator.SetBool("Switch", true);
            platSwitch = true;
            GetComponent<BoxCollider2D>().enabled = true;
        }
        
        
    }
}
