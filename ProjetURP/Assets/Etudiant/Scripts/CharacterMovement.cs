using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StudioXP.Scripts.Events;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private GameObject head;
    [SerializeField] private InputEvent[] inputs;

    private float _headTilt = 0;

    private CharacterController _characterController;

    private Vector3 _movementX;
    private Vector3 _movementZ;
    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        foreach(var input in inputs)
             input.Update();

        Vector3 movement = (_movementX +_movementZ).normalized;

        _characterController.Move(Physics.gravity * Time.deltaTime);
        _characterController.Move(movement * Time.deltaTime * 6);
    }

    public void TilitHead (float mouseYValue)
    {
         _headTilt -= mouseYValue;
         head.transform.localRotation = Quaternion.Euler(_headTilt,0 ,0);
    }

    public void RotateY(float mouseXValue)
    {
        transform.Rotate(0, mouseXValue, 0);
    }

    public void SetMovementX(float horizontalValue)
    {
       _movementX = transform.right * horizontalValue;
    }

    public void SetMovementZ(float verticalValue)
    {
        _movementZ = transform.forward * verticalValue;
    }
}
