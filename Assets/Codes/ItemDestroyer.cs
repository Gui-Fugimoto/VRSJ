using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    public void DestroyItem()
    {
        Destroy(gameObject);
    }
}
