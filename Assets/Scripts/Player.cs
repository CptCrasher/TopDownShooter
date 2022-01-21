using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector3 tempPos;
    public float speed;
    public float sprintSpeed;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    { 
        move();
        faceMouse();
    }

    // This will be used to move the character in the x and y axis
    void move()
    {
        tempPos = transform.position;
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        tempPos.x += x;
        float y = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        tempPos.y += y;
        transform.position = tempPos;
    }
    void Sprint()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = sprintSpeed;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 5f;
        }
    }


    // This will be used to allow the character to face the cursor
    void faceMouse()
    {
        var addAngle = 270;
        Vector3 direction = Input.mousePosition;
        direction = direction - Camera.main.WorldToScreenPoint(transform.position);
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + addAngle;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }



}
