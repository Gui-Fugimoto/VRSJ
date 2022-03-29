using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitInspectionButton : MonoBehaviour
{

    public GameObject mainCamera;
    public GameObject crossHairImage;
    public GameObject buttonExitInspection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExitInspection()
    {

        mainCamera.GetComponent<VRSimulator>().enabled = true;
        mainCamera.GetComponent<Raycaster>().enabled = true;
        mainCamera.GetComponent<FollowGyro>().enabled = true;
        crossHairImage.SetActive(true);
        buttonExitInspection.SetActive(false);

        FindObjectOfType<ItemDestroyer>().DestroyItem();
        
    }
}
