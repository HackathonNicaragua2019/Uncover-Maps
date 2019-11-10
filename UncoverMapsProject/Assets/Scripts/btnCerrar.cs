using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class btnCerrar : MonoBehaviour, IPointerDownHandler
{
    public GameObject panelCerrar1, panelCerrar2, panelCerrar3, panelCerrar4, panelCerrar5, panelCerrar6, panelCerrar7, panelCerrar8;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if ("btnCerrarP1".Equals(eventData.pointerCurrentRaycast.gameObject.name))
        {
            Debug.Log(gameObject.name);
            panelCerrar1.SetActive(false);
        }
        if ("btnCerrarP1".Equals(eventData.pointerCurrentRaycast.gameObject.name))
        {
            Debug.Log(gameObject.name);
            panelCerrar2.SetActive(false);
        }
        if ("btnCerrarP1".Equals(eventData.pointerCurrentRaycast.gameObject.name))
        {
            Debug.Log(gameObject.name);
            panelCerrar3.SetActive(false);
        }
        if ("btnCerrarP1".Equals(eventData.pointerCurrentRaycast.gameObject.name))
        {
            Debug.Log(gameObject.name);
            panelCerrar4.SetActive(false);
        }
        if ("btnCerrarP1".Equals(eventData.pointerCurrentRaycast.gameObject.name))
        {
            Debug.Log(gameObject.name);
            panelCerrar5.SetActive(false);
        }
        if ("btnCerrarP1".Equals(eventData.pointerCurrentRaycast.gameObject.name))
        {
            Debug.Log(gameObject.name);
            panelCerrar6.SetActive(false);
        }
        if ("btnCerrarP1".Equals(eventData.pointerCurrentRaycast.gameObject.name))
        {
            Debug.Log(gameObject.name);
            panelCerrar7.SetActive(false);
        }
        if ("btnCerrarP1".Equals(eventData.pointerCurrentRaycast.gameObject.name))
        {
            Debug.Log(gameObject.name);
            panelCerrar8.SetActive(false);
        }
    }
}
