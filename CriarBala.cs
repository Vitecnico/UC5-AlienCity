using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriarBala : MonoBehaviour
{

    public GameObject bala;
    public GameObject spawner;
    public Transform spawnerrrrr;
    public Transform jogador;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per framehhh
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }

        if (jogador.localScale.x > 0)
        {
            spawnerrrrr.transform.eulerAngles = new Vector3(0, 0, 0);
        }

        else if (jogador.localScale.x < 0)
        {
            spawnerrrrr.transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }
    void Fire()
    {


        spawner = Instantiate(bala, spawnerrrrr.position, spawnerrrrr.rotation);
    }
}
