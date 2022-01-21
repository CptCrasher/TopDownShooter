using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class dash2 : MonoBehaviour
{


    private float aCounter;
    private float dCounter;
    private float wCounter;
    private float sCounter;

    private float time;
    public float timeStart;

    private float dashTime;
    public float startDashTime;
    public float dashSpeed;
    private Rigidbody2D rb;

    private float dashInterval;
    public float dashIntervalStart;

    public GameObject TrailRenderer;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        time = timeStart;
        dashTime = startDashTime;
        dashInterval = dashIntervalStart;
    }

    // Update is called once per frame
    void Update()
    {
        dashInterval -= Time.deltaTime;


        if (dashInterval <= 0)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                aCounter += 1;
                if (aCounter >= 2)
                {
                    
                    if (dashTime <= 0)
                    {
                        TrailRenderer.GetComponent<TrailRenderer>().emitting = false;
                        dashTime = startDashTime;
                        rb.velocity = Vector2.zero;
                    }
                    else
                    {
                        TrailRenderer.GetComponent<TrailRenderer>().emitting = true;
                        dashTime -= Time.deltaTime;
                        rb.velocity = Vector2.left * dashSpeed;

                    }
                    aCounter = 0;
                    dashInterval = dashIntervalStart;
                }
            }

            else if (Input.GetKeyDown(KeyCode.D))
            {
                dCounter += 1;
                if (dCounter >= 2)
                {
                    
                    if (dashTime <= 0)
                    {
                        TrailRenderer.GetComponent<TrailRenderer>().emitting = false;
                        dashTime = startDashTime;
                        rb.velocity = Vector2.zero;
                    }
                    else
                    {
                        TrailRenderer.GetComponent<TrailRenderer>().emitting = true;
                        dashTime -= Time.deltaTime;
                        rb.velocity = Vector2.right * dashSpeed;

                    }
                    dCounter = 0;
                    dashInterval = dashIntervalStart;
                }
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                wCounter += 1;
                if (wCounter >= 2)
                {
                    
                    if (dashTime <= 0)
                    {
                        TrailRenderer.GetComponent<TrailRenderer>().emitting = false;
                        dashTime = startDashTime;
                        rb.velocity = Vector2.zero;
                    }
                    else
                    {
                        TrailRenderer.GetComponent<TrailRenderer>().emitting = true;
                        dashTime -= Time.deltaTime;
                        rb.velocity = Vector2.up * dashSpeed;

                    }
                    wCounter = 0;
                    dashInterval = dashIntervalStart;
                }
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                sCounter += 1;
                if (sCounter >= 2)
                {
                    
                    if (dashTime <= 0)
                    {
                        TrailRenderer.GetComponent<TrailRenderer>().emitting = false;
                        dashTime = startDashTime;
                        rb.velocity = Vector2.zero;
                    }
                    else
                    {
                        TrailRenderer.GetComponent<TrailRenderer>().emitting = true;
                        dashTime -= Time.deltaTime;
                        rb.velocity = Vector2.down * dashSpeed;

                    }
                    sCounter = 0;
                    dashInterval = dashIntervalStart;
                }
            }
           
            time -= Time.deltaTime;
            if (time <= 0)
            {
                TrailRenderer.GetComponent<TrailRenderer>().emitting = false;
                aCounter = 0;
                dCounter = 0;
                wCounter = 0;
                sCounter = 0;
                time = timeStart;
            }


        }

    }
}
