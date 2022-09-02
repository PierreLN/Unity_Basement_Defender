using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Source : MonoBehaviour
{
    public GameObject villainBoulet;

    // Start is called before the first frame update
    void Start()
    {
        // Pour le mettre au centre de la source
        // Instantiate pour ajouter un nouveau objet
        Instantiate(villainBoulet, transform.position, );
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
