using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detection2 : MonoBehaviour
{
    public GameObject Enemy;
    public EnemyFollow e;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Player")) { 
        EnemyFollow e = Enemy.GetComponent<EnemyFollow>();
        e.enabled = true;
    } 
        if(e.enabled == true)
        {
            Destroy(gameObject);
        }
    } 

}
