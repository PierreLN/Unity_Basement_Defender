using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Balle : MonoBehaviour
{
    public float vitesse = 0.1f;
    public float variation = 0.1f;
    public Renderer cetBalle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float red = Random.Range(150, 190);
        float green = Random.Range(150, 190);
        float blue = Random.Range(150, 190);

        float decente = Random.Range(-variation, variation);
        transform.Translate(new Vector3(vitesse, decente, 0.0f));
        cetBalle = GetComponent<Renderer>();
            cetBalle.material.color = new Color(1, red, green, blue);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
    }
}
