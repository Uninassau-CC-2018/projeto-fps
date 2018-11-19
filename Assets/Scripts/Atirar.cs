using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Atirar : MonoBehaviour {
    public GameObject balaPrefab;
    public Transform balaSpawn;
    public Text municao;
    public Text maxMunicao;
    Armas arma = new Armas();
	// Use this for initialization
	void Start () {
        arma.Id = 10;
        arma.QtdMaxBalas = 90;
        arma.QtdAtualBalas = 30;
        arma.Dano = 50;
        arma.QtdMaxRecarga = 30;
        Debug.Log(arma.Id);
	}
	
	// Update is called once per frame
	void Update () {
        maxMunicao.text = arma.QtdMaxBalas.ToString();
        municao.text = arma.QtdAtualBalas.ToString() +"/"+arma.QtdMaxRecarga;
        if (arma.QtdAtualBalas > 0)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Fire();
            }
        }

        if (Input.GetButtonDown("Recarregar"))
        {
            Recarregar();
        }
    }

    void Fire()
    {
        var bullet = (GameObject)Instantiate(
            balaPrefab,
            balaSpawn.position,
            balaSpawn.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 10;
        arma.QtdAtualBalas--;
        Destroy(bullet, 3.0f);
    }

    public void Recarregar()
    {
        if (arma.QtdMaxBalas > 0)
        {
            arma.QtdMaxBalas += -(arma.QtdMaxRecarga - arma.QtdAtualBalas);
            arma.QtdAtualBalas += arma.QtdMaxRecarga-arma.QtdAtualBalas;
        }
    }

}
