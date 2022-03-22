using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroscopeManager : MonoBehaviour
{

    #region Instance
    private static GyroscopeManager instance;
    public static GyroscopeManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GyroscopeManager>();
                if (instance == null)
                {
                    instance = new GameObject("Spawned GyroscopeManager", typeof(GyroscopeManager)).GetComponent<GyroscopeManager>();
                }
            }
            return instance;
        }
        set
        {
            instance = value;
        }
    }
    #endregion

    [Header("Logic")]
    private Gyroscope gyro;
    private Quaternion rotation;
    private bool gyroActive;

    public void EnableGyro()
    {
        if (gyroActive)
        {
            return;
        }
        if (SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;
            gyroActive = gyro.enabled;
        }
    }

    private void Update()
    {
        if (gyroActive)
        {
            rotation = gyro.attitude;
            
        }
    }
    public Quaternion GetGyroRotation()
    {
        return rotation;
    }
}
