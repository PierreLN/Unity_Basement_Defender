using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defenseur : MonoBehaviour
{
    public float vitesse = 0.1f;
    public float limite = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // input manager pour gerer le clavier / souris
        float vertical = Input.GetAxis("Vertical");

        // Debug.Log(vertical);

        // fixedDeltaTime pour diviser par 1/30 de sec
        transform.Translate(new Vector3(0.0f, vitesse * Time.fixedDeltaTime * vertical, 0.0f));

        Vector3 pos = transform.position;
        pos.y = Mathf.Clamp(pos.y, -limite, limite);

        transform.position = pos;
    }
}
