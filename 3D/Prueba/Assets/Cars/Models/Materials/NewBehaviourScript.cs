using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public Material colorInicial;
	// Use this for initialization
	void Start()
    {
        GetComponent<Renderer>().material = colorInicial;
    }

    // Update is called once per frame
    void Update()
    {
        colorInicial.color = new UnityEngine.Color(0,0,0);
    }
}
