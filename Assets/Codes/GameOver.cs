using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Character")
        {
            SceneManager.LoadScene("Menu");
            Debug.Log("GG");
        }

    }

    // Update is called once per frame


}