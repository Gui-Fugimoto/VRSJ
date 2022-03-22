using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderLuz : MonoBehaviour
{
    public GameObject CuboAtivaLuz;
    public GameObject PointLight1;
    public GameObject PointLight2;
    public GameObject PointLight3;
    public GameObject PointLight4;
    public GameObject PointLight5;
    public GameObject LuzVermelha;

    // Start is called before the first frame update
    void Start()
    {
        PointLight1.SetActive(true);
        PointLight2.SetActive(true);
        PointLight3.SetActive(true);
        PointLight4.SetActive(true);
        PointLight5.SetActive(true);
        LuzVermelha.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider character)
    {
        if (character.tag == "Character")
        {
            Debug.Log("Encostou");
            PointLight1.SetActive(false);
            PointLight2.SetActive(false);
            PointLight3.SetActive(false);
            PointLight4.SetActive(false);
            PointLight5.SetActive(false);
            LuzVermelha.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}
