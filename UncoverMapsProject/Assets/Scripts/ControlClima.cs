using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlClima : MonoBehaviour
{
    public GameObject luna, sol, nubesClaras;
    Animation animacionSol, animacionLuna, animacionNubesClaras;
    public AnimationClip solIn, solOut, lunaIn, lunaOut, nubesClarasIn, nubesClarasOut;
    int count = 0;
    bool inSol = false, outSol = false, inLuna = false, outLuna = false, inNubes = false, outNubes = false;

    // Start is called before the first frame update
    void Start()
    {
        initialObject();
        animacionSol = sol.AddComponent<Animation>();
        animacionSol.AddClip(solIn, "solIN");
        animacionSol.AddClip(solOut, "solOut");
        animacionLuna = luna.AddComponent<Animation>();
        animacionLuna.AddClip(lunaIn, "lunaIn");
        animacionLuna.AddClip(lunaOut, "lunaOut");
        animacionNubesClaras = nubesClaras.AddComponent<Animation>();
        animacionNubesClaras.AddClip(nubesClarasIn, "nubesIn");
        animacionNubesClaras.AddClip(nubesClarasOut, "nubesOut");

    }

    // Update is called once per frame
    void Update()
    {
        count++;
        if (count == 100)
        {
            Debug.Log("sol true");
            inSol = true;

        }
        if (count == 200)
        {
            Debug.Log("luna true");
            inLuna = true;


        }
        if (count == 300)
        {
            Debug.Log("nubes true");
            inNubes = true;
            count = 0;

        }

        if (inSol)
        {
            inSol = false;
            outSol = true;
            animacionSol.Play("solIN");
        }
        if (outSol)
        {
            outSol = false;
            animacionSol.Play("solOut");
        }
        if (inLuna)
        {
            inLuna = false;
            outLuna = true;
            animacionLuna.Play("lunaIn");
        }
        if (outLuna)
        {
            outLuna = false;
            animacionLuna.Play("lunaOut");
        }
        if (inNubes)
        {
            inNubes = false;
            outNubes = true;
            animacionNubesClaras.Play("nubesIn");
        }
        if (outNubes)
        {
            outNubes = false;
            animacionNubesClaras.Play("nubesOut");
        }
    }

    public void initialObject()
    {
        luna.GetComponent<Renderer>().material.color = new Color(luna.GetComponent<Renderer>().material.color.r,
            luna.GetComponent<Renderer>().material.color.g, luna.GetComponent<Renderer>().material.color.b, 0.0f);
        sol.GetComponent<Renderer>().material.color = new Color(sol.GetComponent<Renderer>().material.color.r,
            sol.GetComponent<Renderer>().material.color.g, sol.GetComponent<Renderer>().material.color.b, 0.0f);
        nubesClaras.GetComponent<Renderer>().material.color = new Color(nubesClaras.GetComponent<Renderer>().material.color.r,
            nubesClaras.GetComponent<Renderer>().material.color.g, nubesClaras.GetComponent<Renderer>().material.color.b, 0.0f);
    }
}
