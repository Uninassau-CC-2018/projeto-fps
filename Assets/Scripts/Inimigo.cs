using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour {
    int hp=100;
    
    string nome;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
	}

    void onCollisionEnter(Collision collision)
    {
        hp -= 50;
        Debug.Log("teste");
    }
}
