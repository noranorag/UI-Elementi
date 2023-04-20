using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VardaParadisana : MonoBehaviour {
	private string teksts;
	public GameObject ievadesLauks;
	public GameObject tekstaAttelosana;
	private string[] fragmenti = {"Sveiks ", "Jauku dienu ", "Prieks tevi redzēt ", "Uzredzēšanos " };
	int indekss;
	public void UzglabatTekstu()
	{
		indekss = Random.Range(0, fragmenti.Length);
		teksts = ievadesLauks.GetComponent<InputField>().text;
		tekstaAttelosana.GetComponent<Text>().text = fragmenti[indekss] + teksts.ToUpper() + "!";
	}

	
}
