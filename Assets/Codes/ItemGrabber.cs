using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGrabber : MonoBehaviour
{
    public GameObject Item;
    public GameObject ItemLocation;
    
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
    public void ItemPickUp()
    {
        
       // Item.transform.SetParent(ItemLocation.transform.parent);
        Item.transform.position = ItemLocation.transform.position;
        mainCamera.GetComponent<VRSimulator>().enabled = false;
       // mainCamera.GetComponent<Raycaster>().enabled = false;
        mainCamera.GetComponent<FollowGyro>().enabled = false;
        crossHairImage.SetActive(false);
        buttonExitInspection.SetActive(true);

        Item.GetComponent<ItemRotator>().enabled = true;
        Item.GetComponent<ItemSizeIncreaser>().enabled = true;
        Item.AddComponent<ItemDestroyer>();

    }

    public void ExitInspection()
    {
        
        mainCamera.GetComponent<VRSimulator>().enabled = true;
        mainCamera.GetComponent<Raycaster>().enabled = true;
        mainCamera.GetComponent<FollowGyro>().enabled = true;
        crossHairImage.SetActive(true);
        buttonExitInspection.SetActive(false);
        Destroy(Item, 1);
    }
}
