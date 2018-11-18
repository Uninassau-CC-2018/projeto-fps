using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Atirar : MonoBehaviour {
    public Text municao;
    Armas arma = new Armas();
	// Use this for initialization
	void Start () {
        arma.Id = 10;
        Debug.Log(arma.Id);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
