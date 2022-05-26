using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    Vector3 posicion;

    // Start is called before the first frame update
    void Start()
    {
        posicion = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "DeathWall")
        {
            transform.position = posicion;
        }    
    }

    void OnCollisionExit()
    {
        transform.position = posicion;
    }
}
