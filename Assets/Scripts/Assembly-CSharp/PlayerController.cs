using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using SystemInfo;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5.0f;
    public float mouseSensitivity = 100.0f;

    private CharacterController characterController;
    private Transform cameraTransform;

    public bool mobileInput = true;
    public float mobileMoveSensitivity = 0.5f;
    public float mobileCameraSensitivity = 0.25f;
    public RectTransform LeftJoystick; // should be handle
    public RectTransform RightJoystick; // should be handle

    private float xRotation = 0f;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        cameraTransform = Camera.main.transform;

        Cursor.lockState = CursorLockMode.Locked;

        cameraTransform.localRotation = new Quaternion(0,0,0,0);

        if (SystemInfo.deviceType == DeviceType.Desktop) {
            mobileInput = false;
            LeftJoystick.parent.parent.gameObject.SetActive(false);
        }
        else {
            mobileInput = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        if (mobileInput) {
            x = LeftJoystick.anchoredPosition.x / LeftJoystick.rect.width;
            x *= mobileMoveSensitivity;
            z = LeftJoystick.anchoredPosition.y / LeftJoystick.rect.height;
            z *= mobileMoveSensitivity;
        }

        Vector3 move = transform.right * x + transform.forward * z;
        characterController.Move(move * speed * Time.deltaTime);

        // �������ӽ�
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        if (mobileInput) {
            mouseX = RightJoystick.anchoredPosition.x / RightJoystick.rect.width;
            mouseX *= mobileCameraSensitivity;
            mouseY = RightJoystick.anchoredPosition.y / RightJoystick.rect.height;
            mouseY *= mobileCameraSensitivity;
        }

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        cameraTransform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.Rotate(Vector3.up * mouseX);
    }
}
