using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteracoesBotoes : MonoBehaviour
{
    public GameObject isqueiro;
    public GameObject itemLocator;
    public GameObject CanvasInventario;
    public GameObject CanvasBotaoInventario;



    public Button botaoObjeto1;
    public Button botaoObjeto2;
    public Button botaoObjeto3;

    public GameObject ObjetoInspecao1;
    // Start is called before the first frame update
    void Start()
    {
        botaoObjeto1.onClick = new Button.ButtonClickedEvent();
        botaoObjeto1.onClick.AddListener(() => Funcao1());

        botaoObjeto2.onClick = new Button.ButtonClickedEvent();
        botaoObjeto2.onClick.AddListener(() => Funcao2());

        botaoObjeto3.onClick = new Button.ButtonClickedEvent();
        botaoObjeto3.onClick.AddListener(() => Funcao3());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Funcao1()
    {
        Debug.Log("Inspecao1");
        GameObject dota = Instantiate(isqueiro, itemLocator.transform.position, transform.rotation);
        CanvasInventario.SetActive(false);
        CanvasBotaoInventario.SetActive(false);

    }


    public void Funcao2()
    {
        Debug.Log("Inspecao2");
    }

    public void Funcao3()
    {
        Debug.Log("Inspecao3");
    }

}
