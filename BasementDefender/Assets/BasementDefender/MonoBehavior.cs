using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoBehavior : MonoBehaviour
{
    public float vitesse = -0.0005f;
    public float limite = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 pos = transform.position;

        if (pos.x > limite){
            transform.Translate(new Vector3(vitesse, 0.0f, 0.0f));
        }
        else
        {
            transform.Translate(new Vector3(0.0f, 0.0f, 0.0f));
        }
    }
}
