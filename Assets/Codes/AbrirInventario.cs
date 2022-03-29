using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbrirInventario : MonoBehaviour
{
    public GameObject CanvasInventario;

    public Button BotaoInventario;

    public Button BotaoFecharInventario;
    // Start is called before the first frame update
    void Start()
    {
        BotaoInventario.onClick = new Button.ButtonClickedEvent();
        BotaoInventario.onClick.AddListener(() => Abrir());

        BotaoFecharInventario.onClick = new Button.ButtonClickedEvent();
        BotaoFecharInventario.onClick.AddListener(() => Fechar());

        CanvasInventario.SetActive(false);

        BotaoFecharInventario.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Abrir()
    {
        CanvasInventario.SetActive(true);
        BotaoInventario.gameObject.SetActive(false);
        BotaoFecharInventario.gameObject.SetActive(true);

    }

    public void Fechar()
    {
        CanvasInventario.SetActive(false);
        BotaoInventario.gameObject.SetActive(true);
        BotaoFecharInventario.gameObject.SetActive(false);

    }
}
