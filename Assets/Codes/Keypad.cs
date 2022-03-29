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


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Number(int number)
    {
        Ans.text += number.ToString();
    }

    public void Execute()
    {
        if(Ans.text == Answer)
        {
            Ans.text = "Correto";
            CanvasSenha.SetActive(false);
        }
        else
        {
            Ans.text = "Incorreto";
        }
    }
}
