using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animaciones : MonoBehaviour
{

    public GameObject letreroAzul1, letreroAzul2, letreroAzul3, letreroAzul4;
    public GameObject letreroRojo1, letreroRojo2, letreroRojo3;
    public GameObject letreroVerde1;

    int contador = 0, contadorY = 0;
    float velocidadGiro = -144f, limiteGiro = 180f;
    bool test = false;
    

    // Start is called before the first frame update
    void Start()
    {
        componentesTransparentes();
        inicializacionIconosGiro();
    }

    // Update is called once per frame
    void Update()
    {
        if (contador < 60)
        {
            contador += 1;
        }
        else { 
            fadeTransition();
            giroIconos();
        }
    }

    public void componentesTransparentes() 
    {
        letreroAzul1.GetComponent<Renderer>().material.color = new Color(
            letreroAzul1.GetComponent<Renderer>().material.color.r,
            letreroAzul1.GetComponent<Renderer>().material.color.g,
            letreroAzul1.GetComponent<Renderer>().material.color.b,            
            0.0f);
        letreroAzul2.GetComponent<Renderer>().material.color = new Color(
            letreroAzul2.GetComponent<Renderer>().material.color.r,
            letreroAzul2.GetComponent<Renderer>().material.color.g,
            letreroAzul2.GetComponent<Renderer>().material.color.b,            
            0.0f);
        letreroAzul3.GetComponent<Renderer>().material.color = new Color(
            letreroAzul3.GetComponent<Renderer>().material.color.r,
            letreroAzul3.GetComponent<Renderer>().material.color.g,
            letreroAzul3.GetComponent<Renderer>().material.color.b,            
            0.0f);
        letreroAzul4.GetComponent<Renderer>().material.color = new Color(
            letreroAzul4.GetComponent<Renderer>().material.color.r,
            letreroAzul4.GetComponent<Renderer>().material.color.g,
            letreroAzul4.GetComponent<Renderer>().material.color.b,            
            0.0f);
        letreroRojo1.GetComponent<Renderer>().material.color = new Color(
            letreroRojo1.GetComponent<Renderer>().material.color.r,
            letreroRojo1.GetComponent<Renderer>().material.color.g,
            letreroRojo1.GetComponent<Renderer>().material.color.b,            
            0.0f);
        letreroRojo2.GetComponent<Renderer>().material.color = new Color(
            letreroRojo2.GetComponent<Renderer>().material.color.r,
            letreroRojo2.GetComponent<Renderer>().material.color.g,
            letreroRojo2.GetComponent<Renderer>().material.color.b,            
            0.0f);
        letreroRojo3.GetComponent<Renderer>().material.color = new Color(
            letreroRojo3.GetComponent<Renderer>().material.color.r,
            letreroRojo3.GetComponent<Renderer>().material.color.g,
            letreroRojo3.GetComponent<Renderer>().material.color.b,
            0.0f);
        letreroVerde1.GetComponent<Renderer>().material.color = new Color(
            letreroVerde1.GetComponent<Renderer>().material.color.r,
            letreroVerde1.GetComponent<Renderer>().material.color.g,
            letreroVerde1.GetComponent<Renderer>().material.color.b,
            0.0f);
    }

    public void fadeTransition() 
    {
        if (letreroVerde1.GetComponent<Renderer>().material.color.a < 1f) 
        {
            letreroAzul1.GetComponent<Renderer>().material.color = new Color(
                letreroAzul1.GetComponent<Renderer>().material.color.r,
                letreroAzul1.GetComponent<Renderer>().material.color.g,
                letreroAzul1.GetComponent<Renderer>().material.color.b,
                letreroAzul1.GetComponent<Renderer>().material.color.a + 0.03f);
            letreroAzul2.GetComponent<Renderer>().material.color = new Color(
                letreroAzul2.GetComponent<Renderer>().material.color.r,
                letreroAzul2.GetComponent<Renderer>().material.color.g,
                letreroAzul2.GetComponent<Renderer>().material.color.b,
                letreroAzul2.GetComponent<Renderer>().material.color.a + 0.02f);
            letreroAzul3.GetComponent<Renderer>().material.color = new Color(
                letreroAzul3.GetComponent<Renderer>().material.color.r,
                letreroAzul3.GetComponent<Renderer>().material.color.g,
                letreroAzul3.GetComponent<Renderer>().material.color.b,
                letreroAzul3.GetComponent<Renderer>().material.color.a + 0.015f);
            letreroAzul4.GetComponent<Renderer>().material.color = new Color(
                letreroAzul4.GetComponent<Renderer>().material.color.r,
                letreroAzul4.GetComponent<Renderer>().material.color.g,
                letreroAzul4.GetComponent<Renderer>().material.color.b,
                letreroAzul4.GetComponent<Renderer>().material.color.a + 0.015f);
            letreroRojo1.GetComponent<Renderer>().material.color = new Color(
                letreroRojo1.GetComponent<Renderer>().material.color.r,
                letreroRojo1.GetComponent<Renderer>().material.color.g,
                letreroRojo1.GetComponent<Renderer>().material.color.b,
                letreroRojo1.GetComponent<Renderer>().material.color.a + 0.014f);
            letreroRojo2.GetComponent<Renderer>().material.color = new Color(
                letreroRojo2.GetComponent<Renderer>().material.color.r,
                letreroRojo2.GetComponent<Renderer>().material.color.g,
                letreroRojo2.GetComponent<Renderer>().material.color.b,
                letreroRojo2.GetComponent<Renderer>().material.color.a + 0.012f);
            letreroRojo3.GetComponent<Renderer>().material.color = new Color(
                letreroRojo3.GetComponent<Renderer>().material.color.r,
                letreroRojo3.GetComponent<Renderer>().material.color.g,
                letreroRojo3.GetComponent<Renderer>().material.color.b,
                letreroRojo3.GetComponent<Renderer>().material.color.a + 0.010f);
            letreroVerde1.GetComponent<Renderer>().material.color = new Color(
                letreroVerde1.GetComponent<Renderer>().material.color.r,
                letreroVerde1.GetComponent<Renderer>().material.color.g,
                letreroVerde1.GetComponent<Renderer>().material.color.b,
                letreroVerde1.GetComponent<Renderer>().material.color.a + 0.01f);
        }
    }

    public void inicializacionIconosGiro() 
    {
        letreroAzul1.transform.Rotate(new Vector3(0, 80f, 0));
        letreroAzul2.transform.Rotate(new Vector3(0, 95f, 0));
        letreroAzul3.transform.Rotate(new Vector3(0, 110f, 0));
        letreroAzul4.transform.Rotate(new Vector3(0, 110f, 0));
        letreroRojo1.transform.Rotate(new Vector3(0, 125f, 0));
        letreroRojo2.transform.Rotate(new Vector3(0, 155f, 0));
        letreroRojo3.transform.Rotate(new Vector3(0, 165f, 0));
        letreroVerde1.transform.Rotate(new Vector3(0, 175f, 0));
    }

    public void giroIconos() 
    {
        if (letreroAzul1.transform.localEulerAngles.y < limiteGiro) 
        {
            letreroAzul1.transform.Rotate(new Vector3(0, velocidadGiro, 0) * Time.deltaTime);
        }

        if(letreroAzul2.transform.localEulerAngles.y < limiteGiro)
        {
            letreroAzul2.transform.Rotate(new Vector3(0, velocidadGiro, 0) * Time.deltaTime);
        }

        if(letreroAzul3.transform.localEulerAngles.y < limiteGiro)
        {
            letreroAzul3.transform.Rotate(new Vector3(0, velocidadGiro, 0) * Time.deltaTime);
        }

        if(letreroAzul3.transform.localEulerAngles.y < limiteGiro)
        {
            letreroAzul4.transform.Rotate(new Vector3(0, velocidadGiro, 0) * Time.deltaTime);
        }

        if(letreroRojo1.transform.localEulerAngles.y < limiteGiro)
        {
            letreroRojo1.transform.Rotate(new Vector3(0, velocidadGiro, 0) * Time.deltaTime);
        }

        if(letreroRojo2.transform.localEulerAngles.y < limiteGiro)
        {
            letreroRojo2.transform.Rotate(new Vector3(0, velocidadGiro, 0) * Time.deltaTime);
        }

        if(letreroRojo3.transform.localEulerAngles.y < limiteGiro)
        {
            letreroRojo3.transform.Rotate(new Vector3(0, velocidadGiro, 0) * Time.deltaTime);
        }

        if(letreroVerde1.transform.localEulerAngles.y < limiteGiro)
        {
            letreroVerde1.transform.Rotate(new Vector3(0, velocidadGiro, 0) * Time.deltaTime);
        }
    }
}
