using UnityEngine;
using UnityEngine.InputSystem;
using Unity.Cinemachine;
public class Look : MonoBehaviour
{
    InputAction look;
    public Transform target;
    float yRotation;
    float xRotation;
    public CinemachineThirdPersonFollow thirdPersonCamera;
    Quaternion rotation;
    private void Awake()
    {
        look = InputSystem.actions.FindAction("Look");
    }

    void RotateCamera() 
    {
       
        xRotation -= look.ReadValue<Vector2>().y;
        yRotation += look.ReadValue<Vector2>().x;
        xRotation = Mathf.Clamp(xRotation,-30,70);
        rotation =  Quaternion.Euler(xRotation, yRotation, 0);
        target.rotation = rotation;
    }
    private void LateUpdate()
    {
       RotateCamera();
   
    }


}
