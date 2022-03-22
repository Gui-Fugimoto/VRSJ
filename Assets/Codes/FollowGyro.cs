using UnityEngine;

public class FollowGyro : MonoBehaviour
{
    [Header("Tweaks")]
    [SerializeField] private Quaternion baseRotation = new Quaternion(0, 0, 1, 0);
    private void Start()
    {
        GyroscopeManager.Instance.EnableGyro();
    }

    private void Update()
    {
        transform.localRotation = GyroscopeManager.Instance.GetGyroRotation() * baseRotation;
    }
}
