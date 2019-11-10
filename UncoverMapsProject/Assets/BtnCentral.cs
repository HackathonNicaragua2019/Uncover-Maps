using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class BtnCentral : MonoBehaviour, IPointerDownHandler
{
    bool transicion = false, clickBus = false, clickTelefono = false, clickComida = false, clickCampamento = false, clickBtnIzquierdo = false;
    public GameObject btnBus, btnCampamento, btnComida, btnTelefono, btnMenu, btnMenuIzquierda, panelBus, panelTelefono, panelComida, panelCampamento;
    float y1, y2, y3, y4, y, x, x1;
    float velocidadMovimiento = 20;
    string btnName;

    // Start is called before the first frame update
    void Start()
    {
        llenadoVariablesXYZ();
        btnBus.transform.position = new Vector2(x, y);
        btnCampamento.transform.position = new Vector2(x, y);
        btnComida.transform.position = new Vector2(x, y);
        btnTelefono.transform.position = new Vector2(x, y);
        btnMenuIzquierda.transform.position = new Vector2(x, y);
    }

    // Update is called once per frame
    void Update()
    {
        if (transicion)
        {
            despliegeMenu();
        }
        else
        {
            retraerMenu();
        }

        if (clickBus)
        {
            transicion = false;
            btnBus.transform.SetAsLastSibling();
            if (btnBus.transform.position.y <= btnMenuIzquierda.transform.position.y)
            {
                if (btnMenuIzquierda.transform.position.x > x1)
                {
                    btnMenuIzquierda.transform.position = new Vector2(btnMenuIzquierda.transform.position.x - velocidadMovimiento, y);
                }
                else
                {
                    panelBus.SetActive(true);
                    clickBus = false;
                }
            }
        }

        if (clickTelefono)
        {
            transicion = false;
            btnTelefono.transform.SetAsLastSibling();
            if (btnTelefono.transform.position.y <= btnMenuIzquierda.transform.position.y)
            {
                if (btnMenuIzquierda.transform.position.x > x1)
                {
                    btnMenuIzquierda.transform.position = new Vector2(btnMenuIzquierda.transform.position.x - velocidadMovimiento, y);
                }
                else
                {
                    panelTelefono.SetActive(true);
                    clickTelefono = false;
                }
            }
        }

        if (clickCampamento)
        {
            transicion = false;
            btnCampamento.transform.SetAsLastSibling();
            if (btnCampamento.transform.position.y <= btnMenuIzquierda.transform.position.y)
            {
                if (btnMenuIzquierda.transform.position.x > x1)
                {
                    btnMenuIzquierda.transform.position = new Vector2(btnMenuIzquierda.transform.position.x - velocidadMovimiento, y);
                }
                else
                {
                    panelCampamento.SetActive(true);
                    clickCampamento = false;
                }
            }
        }

        if (clickComida)
        {
            transicion = false;
            btnComida.transform.SetAsLastSibling();
            if (btnComida.transform.position.y <= btnMenuIzquierda.transform.position.y)
            {
                if (btnMenuIzquierda.transform.position.x > x1)
                {
                    btnMenuIzquierda.transform.position = new Vector2(btnMenuIzquierda.transform.position.x - velocidadMovimiento, y);
                }
                else
                {
                    panelComida.SetActive(true);
                    clickComida = false;
                }
            }
        }

        if (clickBtnIzquierdo)
        {
            if (btnMenuIzquierda.transform.position.x < x)
            {
                btnMenuIzquierda.transform.position = new Vector2(btnMenuIzquierda.transform.position.x + velocidadMovimiento, y);
            }
            else
            {
                panelBus.transform.position = new Vector2(panelBus.transform.position.x, panelBus.transform.position.y - 700);
                panelTelefono.transform.position = new Vector2(panelTelefono.transform.position.x, panelTelefono.transform.position.y - 700);
                panelCampamento.transform.position = new Vector2(panelCampamento.transform.position.x, panelCampamento.transform.position.y - 700);
                panelComida.transform.position = new Vector2(panelComida.transform.position.x, panelComida.transform.position.y - 700);

                panelBus.SetActive(false);
                panelTelefono.SetActive(false);
                panelCampamento.SetActive(false);
                panelComida.SetActive(false);

                clickBtnIzquierdo = false;
                btnMenu.transform.SetAsLastSibling();
            }
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if ("BtnCentral".Equals(eventData.pointerCurrentRaycast.gameObject.name))
        {
            if (transicion)
            {
                transicion = false;
            }
            else
            {
                transicion = true;
            }
        }

        if ("BtnTransporte".Equals(eventData.pointerCurrentRaycast.gameObject.name))
        {
            if (!clickBus)
            {
                clickBus = true;
            }
        }

        if ("BtnLlamadas".Equals(eventData.pointerCurrentRaycast.gameObject.name))
        {
            if (!clickTelefono)
            {
                clickTelefono = true;
            }
        }

        if ("BtnRestaurante".Equals(eventData.pointerCurrentRaycast.gameObject.name))
        {
            if (!clickComida)
            {
                clickComida = true;
            }
        }

        if ("BtnHospedaje".Equals(eventData.pointerCurrentRaycast.gameObject.name))
        {
            if (!clickCampamento)
            {
                clickCampamento = true;
            }
        }

        if ("BtnRegresar".Equals(eventData.pointerCurrentRaycast.gameObject.name))
        {
            if (!clickBtnIzquierdo)
            {
                clickBtnIzquierdo = true;
            }
        }

    }

    public void llenadoVariablesXYZ()
    {
        x = btnMenu.transform.position.x;
        y = btnMenu.transform.position.y;

        x1 = btnMenuIzquierda.transform.position.x;

        y1 = btnBus.transform.position.y;
        y2 = btnCampamento.transform.position.y;
        y3 = btnComida.transform.position.y;
        y4 = btnTelefono.transform.position.y;
    }

    public void desplegarBotonInicioIzquierda()
    {
        if (btnMenuIzquierda.transform.position.x > x1)
        {
            btnMenuIzquierda.transform.position = new Vector2(btnMenuIzquierda.transform.position.x - velocidadMovimiento, y);
        }
    }

    public void retraerBotonInicioIzquierda()
    {
        if (btnMenuIzquierda.transform.position.x < x)
        {
            btnMenuIzquierda.transform.position = new Vector2(btnMenuIzquierda.transform.position.x + velocidadMovimiento, y);
        }
    }

    public void despliegeMenu()
    {

        if (btnBus.transform.position.y < y1)
        {
            btnBus.transform.position = new Vector2(btnMenu.transform.position.x, btnBus.transform.position.y + velocidadMovimiento);
        }
        if (btnCampamento.transform.position.y < y2)
        {
            btnCampamento.transform.position = new Vector2(btnMenu.transform.position.x, btnCampamento.transform.position.y + velocidadMovimiento);
        }
        if (btnComida.transform.position.y < y3)
        {
            btnComida.transform.position = new Vector2(btnMenu.transform.position.x, btnComida.transform.position.y + velocidadMovimiento);
        }
        if (btnTelefono.transform.position.y < y4)
        {
            btnTelefono.transform.position = new Vector2(btnMenu.transform.position.x, btnTelefono.transform.position.y + velocidadMovimiento);
        }
    }

    public void retraerMenu()
    {
        if (btnBus.transform.position.y > y)
        {
            btnBus.transform.position = new Vector2(btnMenu.transform.position.x, btnBus.transform.position.y - velocidadMovimiento);
        }
        if (btnCampamento.transform.position.y > y)
        {
            btnCampamento.transform.position = new Vector2(btnMenu.transform.position.x, btnCampamento.transform.position.y - velocidadMovimiento);
        }
        if (btnComida.transform.position.y > y)
        {
            btnComida.transform.position = new Vector2(btnMenu.transform.position.x, btnComida.transform.position.y - velocidadMovimiento);
        }
        if (btnTelefono.transform.position.y > y)
        {
            btnTelefono.transform.position = new Vector2(btnMenu.transform.position.x, btnTelefono.transform.position.y - velocidadMovimiento);
        }
    }

}
