using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectroPanelCode : MonoBehaviour
{
    public GameObject PointLight1;
    public GameObject PointLight2;
    public GameObject PointLight3;
    public GameObject PointLight4;
    public GameObject PointLight5;
    public GameObject LuzVermelha;
    public GameObject Monster3;
    // Start is called before the first frame update
    void Start()
    {
        Monster3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ButtonAction()
    {
        PointLight1.SetActive(true);
        PointLight2.SetActive(true);
        PointLight3.SetActive(true);
        PointLight4.SetActive(true);
        PointLight5.SetActive(true);
        LuzVermelha.SetActive(false);
        Monster3.SetActive(true);
    }
}
