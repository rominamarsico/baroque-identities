using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenueController : MonoBehaviour
{
    // Menü
	public GameObject Cube;
    public GameObject Cube1;

    public void HideMenue(){
        Debug.Log("Menü zu");
        Cube.SetActive(true);
        Cube1.SetActive(false);
    }

	public void BaseMenue(){
		Debug.Log("Menü offen");
	}

    public void restart()
    {
        Debug.Log("Scene 'Initialisierung' will be loaded");
    }

    public void loadMain()
    {
        Debug.Log("Scene 'Main' will be loaded");
    }
}


