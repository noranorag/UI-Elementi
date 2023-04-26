using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour {
    public GameObject binsImg;
    public GameObject lacitisImg;
    public GameObject omeImg;
    public GameObject masinaImg;
    public GameObject paKreisiPoga;
    public GameObject paLabiPoga;
    public GameObject mainigaisAttels;
    public Sprite[] atteluMasivs;
    public GameObject izmSlaideris;
    public GameObject rotSlaideris;

    public void binaAttelosana(bool vertiba)
    {
        binsImg.SetActive(vertiba);
        paKreisiPoga.GetComponent<Toggle>().interactable = vertiba;
        paLabiPoga.GetComponent<Toggle>().interactable = vertiba;


    }

    public void lacisaAttelosana(bool vertiba)
    {
        lacitisImg.SetActive(vertiba);
    }

    public void omesAttelosana(bool vertiba)
    {
        omeImg.SetActive(vertiba);
    }

    public void masinasAttelosana(bool vertiba)
    {
        masinaImg.SetActive(vertiba);
    }

    public void paKreisiBins()
    {
        binsImg.transform.localScale = new Vector2(1, 1);

    }

    public void paLabiBins()
    {
        binsImg.transform.localScale = new Vector2(-1, 1);

    }

    public void izkritosais(int skaitlis)
    {
        if(skaitlis == 0)
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];

        else if (skaitlis == 1)
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];

        else if (skaitlis == 2)
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[2];
        Debug.Log("Nav piesaistīts attēls!");
    }

    public void mainitLielumu()
    {
        float pasreizejaVertiba = izmSlaideris.GetComponent<Slider>().value;
        mainigaisAttels.transform.localScale = new Vector2(1f * pasreizejaVertiba, 1f * pasreizejaVertiba);
    }

    public void mainitRotaciju()
    {
        float pasreizejaVertiba = rotSlaideris.GetComponent<Slider>().value;
        mainigaisAttels.transform.localRotation = Quaternion.Euler(0, 0, pasreizejaVertiba * 360);
    }


}
