using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField]
    private float forwardSpeed;
    [SerializeField]
    private float horizontalSpeed;



    private void Update()
    {
        Movement();
    }

    void Movement()
    {
        float horizontal = Input.GetAxis("Horizontal") * horizontalSpeed * Time.deltaTime;
        this.transform.Translate(horizontal, 0, forwardSpeed * Time.deltaTime);
    }

}
