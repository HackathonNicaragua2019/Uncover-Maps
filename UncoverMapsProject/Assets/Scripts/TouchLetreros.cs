using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchLetreros : MonoBehaviour
{
    public GameObject letreroAzul1, letreroAzul2, letreroAzul3, letreroAzul4;
    public GameObject letreroRojo1, letreroRojo2, letreroRojo3;
    public GameObject letreroVerde1;
    public GameObject panel1, panel2, panel3, panel4, panel5, panel6, panel7, panel8;
    public GameObject btnCerrarP1;

    bool test1, test2, test3, test4, test5, test6, test7, test8;
    string nombreLetrero, cerrar;
    float velocidadRotacion = -944, limiteGiro = 180;
    int contadorY;

    //// Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Touch();

        if (test1)
        {
            Rotacion1();
        }
        else if (test2)
        {
            Rotacion2();
        }
        else if (test3)
        {
            Rotacion3();
        }
        else if (test4)
        {
            Rotacion4();
        }
        else if (test5)
        {
            Rotacion5();
        }
        else if (test6)
        {
            Rotacion6();
        }
        else if (test7)
        {
            Rotacion7();
        }
        else if (test8)
        {
            Rotacion8();
        }
    }

    public void Touch()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began && !panel1.activeInHierarchy)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                nombreLetrero = hit.transform.name;
                switch (nombreLetrero)
                {
                    case "PlanoTouch1":
                        test1 = true;
                        break;
                    case "PlanoTouch2":
                        test2 = true;
                        break;
                    case "PlanoTouch3":
                        test3 = true;
                        break;
                    case "PlanoTouch4":
                        test4 = true;
                        break;
                    case "PlanoTouch5":
                        test5 = true;
                        break;
                    case "PlanoTouch6":
                        test6 = true;
                        break;
                    case "PlanoTouch7":
                        test7 = true;
                        break;
                    case "PlanoTouch8":
                        test8 = true;
                        break;
                }
            }
        }
    }

    public void Rotacion1()
    {
        if (letreroAzul1.transform.localEulerAngles.y < limiteGiro)
        {
            contadorY += 1;
        }

        if (contadorY <= 15)
        {
            letreroAzul1.transform.Rotate(new Vector3(0, velocidadRotacion, 0) * Time.deltaTime);
        }
        else
        {
            test1 = false;
            contadorY = 0;
            panel1.SetActive(true);
            btnCerrarP1.SetActive(true);
        }
    }

    public void Rotacion2()
    {
        if (letreroAzul2.transform.localEulerAngles.y < limiteGiro)
        {
            contadorY += 1;
        }

        if (contadorY <= 15)
        {
            letreroAzul2.transform.Rotate(new Vector3(0, velocidadRotacion, 0) * Time.deltaTime);
        }
        else
        {
            test2 = false;
            contadorY = 0;
            panel1.SetActive(true);
            btnCerrarP1.SetActive(true);
        }
    }

    public void Rotacion3()
    {
        if (letreroRojo1.transform.localEulerAngles.y < limiteGiro)
        {
            contadorY += 1;
        }

        if (contadorY <= 15)
        {
            letreroRojo1.transform.Rotate(new Vector3(0, velocidadRotacion, 0) * Time.deltaTime);
        }
        else
        {
            test3 = false;
            contadorY = 0;
            panel1.SetActive(true);
            btnCerrarP1.SetActive(true);
        }
    }

    public void Rotacion4()
    {
        if (letreroRojo2.transform.localEulerAngles.y < limiteGiro)
        {
            contadorY += 1;
        }

        if (contadorY <= 15)
        {
            letreroRojo2.transform.Rotate(new Vector3(0, velocidadRotacion, 0) * Time.deltaTime);
        }
        else
        {
            test4 = false;
            contadorY = 0;
            panel1.SetActive(true);
            btnCerrarP1.SetActive(true);
        }
    }

    public void Rotacion5()
    {
        if (letreroAzul3.transform.localEulerAngles.y < limiteGiro)
        {
            contadorY += 1;
        }

        if (contadorY <= 15)
        {
            letreroAzul3.transform.Rotate(new Vector3(0, velocidadRotacion, 0) * Time.deltaTime);
        }
        else
        {
            test5 = false;
            contadorY = 0;
            panel1.SetActive(true);
            btnCerrarP1.SetActive(true);
        }
    }

    public void Rotacion6()
    {
        if (letreroRojo3.transform.localEulerAngles.y < limiteGiro)
        {
            contadorY += 1;
        }

        if (contadorY <= 15)
        {
            letreroRojo3.transform.Rotate(new Vector3(0, velocidadRotacion, 0) * Time.deltaTime);
        }
        else
        {
            test6 = false;
            contadorY = 0;
            panel1.SetActive(true);
            btnCerrarP1.SetActive(true);
        }
    }

    public void Rotacion7()
    {
        if (letreroAzul4.transform.localEulerAngles.y < limiteGiro)
        {
            contadorY += 1;
        }

        if (contadorY <= 15)
        {
            letreroAzul4.transform.Rotate(new Vector3(0, velocidadRotacion, 0) * Time.deltaTime);
        }
        else
        {
            test7 = false;
            contadorY = 0;
            panel1.SetActive(true);
            btnCerrarP1.SetActive(true);
        }
    }

    public void Rotacion8()
    {
        if (letreroVerde1.transform.localEulerAngles.y < limiteGiro)
        {
            contadorY += 1;
        }

        if (contadorY <= 15)
        {
            letreroVerde1.transform.Rotate(new Vector3(0, velocidadRotacion, 0) * Time.deltaTime);
        }
        else
        {
            test8 = false;
            contadorY = 0;
            panel1.SetActive(true);
            btnCerrarP1.SetActive(true);
        }
    }
}
