using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedratrocaCor : MonoBehaviour {

    SpriteRenderer sr;
    private Color[] colors = new Color[] { Color.red, Color.green, Color.blue };
    public int valPedra = 0;

	// Use this for initialization
	void Start () {
        sr = GetComponent<SpriteRenderer>();
	}
	
	
	void OnTriggerEnter2D (Collider2D other) {
        if (valPedra == 2)
        {
            valPedra = 0;
        }
        else
        {
            valPedra++;
        }



        if (other.gameObject.CompareTag("Player"))
        {
            sr.color = colors [valPedra];
        }
	}
}
