using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirPorta : MonoBehaviour {

    public GameObject porta;
    public GameObject sinal;
    public GameObject portaFechada;

    private bool Aberto = false;

    private PedratrocaCor pc1;
    private PedratrocaCor pc2;
    private PedratrocaCor pc3;

    private AudioSource aSource;

    // Use this for initialization
    void Start () {
        aSource = GetComponent<AudioSource>();

        GameObject pedraCorObject = GameObject.FindWithTag("Pedra1");
        if (pedraCorObject != null) 
        {
            pc1 = pedraCorObject.GetComponent<PedratrocaCor>();
        }
         pedraCorObject = GameObject.FindWithTag("Pedra2");
        if (pedraCorObject != null)
        {
            pc2 = pedraCorObject.GetComponent<PedratrocaCor>();
        }
         pedraCorObject = GameObject.FindWithTag("Pedra3");
        if (pedraCorObject != null)
        {
            pc3 = pedraCorObject.GetComponent<PedratrocaCor>();
        }
        
    }
	
	// Update is called once per frame
	void OnTriggerEnter2D  (Collider2D other) {
        if (pc1.valPedra == 1 && pc2.valPedra == 2 && pc3.valPedra == 0 && !Aberto)
        {
            Vector3 spawPos = new Vector3(7.32f, -3.41f, -0.5f);
            Quaternion spawnRot = Quaternion.identity;
            Instantiate(porta, spawPos, spawnRot);

           

            spawPos = new Vector3(6f, -4f, -0.5f);
            spawnRot = Quaternion.identity;
            Instantiate(sinal, spawPos, spawnRot);

            Aberto = true;

            if (portaFechada != null)
            {
                portaFechada.SetActive(false);
            }

        }
	}

   void Update()
    {
        if (pc1.valPedra == 1 && pc2.valPedra == 2 && pc3.valPedra == 0 && !Aberto)
        {
            aSource.Play ();

        }
    }
}
