using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieShoot : MonoBehaviour

{

   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-4, 0, -1) * Time.deltaTime;
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Plant" || collision.transform.tag == "Plant1Fire" || collision.transform.tag == "Plant2Fire" || collision.transform.tag == "Plant3Fire")
        {
            Destroy(gameObject);
        }
    }
}
