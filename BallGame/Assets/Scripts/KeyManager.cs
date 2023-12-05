using UnityEngine;

public class KeyManager : MonoBehaviour
{
    public Material yellow;
   // public Material white;
    bool isYellow;
    private float tiempoAcumulado = 0f;
     float intervalo = 0.5f;
    public static bool keyTocuhed = false;

    private void Awake()
    {
        if (gameObject.GetComponent<Renderer>().material.name == yellow.name + " (Instance)")
            isYellow = true;
        else
            isYellow = false;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Material metal = gameObject.GetComponent<Renderer>().material;
            //var player = GameObject.FindGameObjectWithTag("Player");
            //Renderer keyMaterial = player.GetComponent<Renderer>();
            //keyMaterial.sharedMaterial = metal;
            keyTocuhed = true;
            GameObject.Find("Lock").SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Material metal = gameObject.GetComponent<Renderer>().material;
            //var player = GameObject.FindGameObjectWithTag("Player");
            //Renderer keyMaterial = player.GetComponent<Renderer>();
            //keyMaterial.sharedMaterial = metal;
            keyTocuhed = true;
            GameObject.Find("Lock").SetActive(false);
            this.gameObject.SetActive(false);
        }
    }

    private void FixedUpdate()
    {
        tiempoAcumulado += Time.deltaTime;

        if (Play.play && tiempoAcumulado >= intervalo && AudioManager.playerMov)
        {
            test();
            tiempoAcumulado = 0f; // Reiniciar el tiempo acumulado
        }

    }
        void test()
        {
            if (!isYellow)
            {
                this.gameObject.GetComponent<Renderer>().material = yellow;
                isYellow = true;
            }
            else
            {
               // this.gameObject.GetComponent<Renderer>().material = white;
               // isYellow = false;
            }
        }
    
}
