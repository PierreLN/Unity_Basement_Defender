using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoBehavior : MonoBehaviour
{
    public float vitesse = -0.0005f;
    public float limite = 16.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(new Vector3(vitesse, 0.0f, 0.0f));
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, limite, 1000000.0f);
        transform.position = pos;
        
    }
}
