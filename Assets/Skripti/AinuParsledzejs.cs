using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AinuParsledzejs : MonoBehaviour {

	//metode lauj parslegties no UI ainas un sakuma ainu
	public void uzSakumu()
	{
		SceneManager.LoadScene("Sakums", LoadSceneMode.Single);
	}

	//Pasiem jauztaisa metode, kas parsledz no sakuma uz UI ainu

	public void uzUI()
	{
		SceneManager.LoadScene("UI elementi", LoadSceneMode.Single);
	}

	//metode kura aizver programmu ja ta ir izveidota ka .exe

	public void Apturet()
	{
		Application.Quit();
	}



}
