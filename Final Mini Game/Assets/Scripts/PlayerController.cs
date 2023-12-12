using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;

    private float _horizontalInput;
    private float _forwardInput;
    private Rigidbody _playerRb;

    // Start is called before the first frame update
    void Start()
    {
        _playerRb = Getcomponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _fprwardInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(_horizontalInput, 0f, _forwardInput);
        _playerRb.Addforce(moveDirection * speed);
    }
}
