using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Defenseur : MonoBehaviour
{
    public float vitesse = 0.1f;
    public float limite = 3.0f;
    public GameObject balle;

    public float delayInput = 0.2f;
    public float timer = 0.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // input manager pour gerer le clavier / souris
        float vertical = Input.GetAxis("Vertical") * 200;
        Vector3 delta = new Vector3(1.0f, 0.0f, 0.0f);

        if (Input.GetButton("Fire1") && timer <= 0.0f)
        {
            Instantiate(balle, transform.position + delta, Quaternion.identity);
            timer = delayInput;
        }
        timer -= Time.deltaTime;
            
        // Debug.Log(vertical);

        // fixedDeltaTime pour diviser par 1/30 de sec
        transform.Translate(new Vector3(0.0f, vitesse * Time.fixedDeltaTime * vertical, 0.0f));

        Vector3 pos = transform.position;
        pos.y = Mathf.Clamp(pos.y, -limite, limite);

        transform.position = pos;




    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("test1");
        
    }
}
