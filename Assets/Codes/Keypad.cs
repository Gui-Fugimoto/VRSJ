using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keypad : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Text Ans;

    private string Answer = "375";

    public GameObject CanvasSenha;

    public float delay = 2f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SumirCanvasCorreto()
    {
        yield return new WaitForSeconds(2);
        CanvasSenha.SetActive(false);
    }

    IEnumerator SumirCanvasIncorreto()
    {
        yield return new WaitForSeconds(2);
        CanvasSenha.SetActive(false);
        Ans.text = "";
    }

    public void Number(int number)
    {
        Ans.text += number.ToString();
    }

    public void Execute()
    {
        if(Ans.text == Answer)
        {
            StartCoroutine(SumirCanvasCorreto());
            Ans.text = "Correto";
            //CanvasSenha.SetActive(false);
        }
        else
        {
            
            Ans.text = "Incorreto";
            StartCoroutine(SumirCanvasIncorreto());
           // Ans.text = "";

        }
    }
}
