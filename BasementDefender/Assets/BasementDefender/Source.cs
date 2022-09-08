using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Source : MonoBehaviour
{
    public GameObject villainBoulet;

    private float limit = 3.0f;
    private float accumulateurTemps = 0.0f;
    private float temps = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        // Pour le mettre au centre de la source
        // Instantiate pour ajouter un nouveau objet
        // Pour pas rotation (Quaternion.identity)

        // Instantiate(villainBoulet, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Chronometre old version

        
        accumulateurTemps += Time.fixedDeltaTime;

        if (accumulateurTemps > temps)
        {
            float hauteur = Random.Range(-limit, limit);
            Vector3 delta = new Vector3(0.0f, hauteur, 0.0f);
            Instantiate(villainBoulet, transform.position + delta, Quaternion.identity);
            accumulateurTemps = 0.0f;
            float ratio = Time.time+0.1f/0.5f;
            temps = Random.Range(0.3f/ratio,1.0f/ratio);
        }
    }
}
