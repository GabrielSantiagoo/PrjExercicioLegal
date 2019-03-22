using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prjSeiLa : MonoBehaviour {

    public int nivel;
    public int poder;
    public int atk;
    int modificador = 1;
    public bool critico;
    int dano;
    public int numero = 0;

	// Use this for initialization
	void Start () {

        estranho();

	}

    void ThunderPunch()
    {
        

        dano = ((((2 * nivel) / 5) + (2 * poder * atk) / 50) + 2) * modificador;

        if (critico)
        {
            dano = dano * 2;
        }

        Debug.Log("dano = " + dano);
    }

    void estranho()
    {
        int resul;

        resul = numero % 2;

        if (resul == 0)
        {
            if (numero >= 6 && numero <= 20)
            {
                Debug.Log("Estranho");
            }
            else if (numero > 20)
            {
                Debug.Log("Não Estranho");
            }
            else if (numero >= 2 && numero <= 5)
            {
                Debug.Log("Não Estranho");
            }

        }
        else
        {
            Debug.Log("Estranho");
        }
    }
}
