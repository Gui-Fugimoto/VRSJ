using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FPSWalk : MonoBehaviour
{
    public AudioSource steps;
    public CharacterController character;
    public Vector3 positionToGo;
    bool safe = false;
    float counttodie=5;
    public AudioSource warning;
    public GameObject SaldaLuz;
    public GameObject PointLight1;
    public GameObject PointLight2;
    public GameObject PointLight3;
    public GameObject PointLight4;
    //public GameObject LuzVermelha;

    // Start is called before the first frame update
    void Start()
    {
        positionToGo = transform.position;
        PointLight1.SetActive(true);
        PointLight2.SetActive(true);
        PointLight3.SetActive(true);
        PointLight4.SetActive(true);
        //LuzVermelha.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 diftowalk = positionToGo - transform.position;

        character.SimpleMove(diftowalk.normalized);
       
        steps.volume = diftowalk.magnitude-1;

        if (!safe)
        {
            counttodie -= Time.deltaTime;
            warning.volume += Time.deltaTime / 5;
            if (counttodie < 0)
            {
                SceneManager.LoadScene("Menu");
            }
        }
        else
        {
            counttodie = 15;
            warning.volume = Mathf.Lerp(warning.volume, 0, Time.deltaTime);
        }

        

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "SaldaLuz")
        {
            Debug.Log("Encostou");
            PointLight1.SetActive(false);
            PointLight2.SetActive(false);
            PointLight3.SetActive(false);
            PointLight4.SetActive(false);
            //LuzVermelha.SetActive(true);
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Walkable"))
        {
            print("Safe");
            safe = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Walkable"))
        {
            print("notSafe");
            safe = false;
        }
    }
}
