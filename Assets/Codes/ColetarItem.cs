using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColetarItem : MonoBehaviour
{
    public GameObject BotaoObjeto1;
    public GameObject BotaoObjeto2;
    public GameObject BotaoObjeto3;
    // Start is called before the first frame update
    void Start()
    {
        BotaoObjeto1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonAction()
    {
        BotaoObjeto1.SetActive(true);
        
    }
}
