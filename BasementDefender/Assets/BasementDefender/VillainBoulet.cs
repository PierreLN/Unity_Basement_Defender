using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillainBoulet : MonoBehaviour
{
    public float vitesse = -0.2f;
    public float limit = 0.05f;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float acceleration = Random.Range(-limit, limit);
        transform.Translate(new Vector3(vitesse+acceleration, 0.0f, 0.0f));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Regle de contact 

        // Pour activer des triggers (collision), il y a 3 conditions
        // 1- Les deux objets doivent avoir un collider 2D
        // 2- Au moins un des deux objets doit avoir un RigidBody
        // 3- Un seul objet doit etre un trigger (option dans inspecteur pour le collider 2D)

        Destroy(this.gameObject);
    }

}
