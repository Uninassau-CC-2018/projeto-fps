using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armas : MonoBehaviour {
    private int qtdMaxBalas;
    private int id;
    private int dano;
    private int alcance;
    private int qtdAtualBalas;

    public int tdMaxBalas
    {
        get
        {
            return qtdMaxBalas;
        }
        set
        {
            qtdMaxBalas = value;
        }
    }

    public int Id
    {
        get
        {
            return id;
        }
        set
        {
            id = value;
        }
    }

    public int Dano
    {
        get
        {
            return dano;
        }
        set
        {
            dano = value;
        }
    }

    public int Alcance
    {
        get
        {
            return alcance;
        }
        set
        {
            alcance = value;
        }
    }

    public int QtdAtualBalas
    {
        get
        {
            return qtdAtualBalas;
        }
        set
        {
            qtdAtualBalas = value;
        }
    }

}
