using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour {

   /* public Transform target;

    // Update is called once per frame
    void Update () {
        if (target.position.x >= transform.position.x)
            RepositionBackground();
	}

    private void RepositionBackground()
    {
        Vector2 groundOffSet = new Vector2(20, 0);
        transform.position = (Vector2)transform.position + groundOffSet;
    }*/


    public Transform cam;
    public Transform ground1;
    public Transform ground2;

    private float currentGround = 1;

    // Update is called once per frame
    void Update()
    {
        if ((currentGround == 1) && (cam.position.x >= ground2.position.x))
        {
            RepositionGround();
            currentGround = 2;
        }
        else if ((currentGround == 2) && (cam.position.x >= transform.position.x))
        {
            currentGround = 1;
        }
    }

    private void RepositionGround()
    {
        Vector2 groundOffSet = new Vector2((float)187.5, 0);
        transform.position = (Vector2)transform.position + groundOffSet;
    }
}
