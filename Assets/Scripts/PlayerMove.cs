using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private float _playerSpeed;
    [SerializeField]
    private Joystick _joystick;
    private float _horizontalInput;
    // Start is called before the first frame update
   
    // Update is called once per frame
    void FixedUpdate()
    {
        _horizontalInput = _joystick.Horizontal;
        transform.Translate(Vector3.forward * Time.deltaTime * _playerSpeed, Space.World);
        if(_horizontalInput > 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * _playerSpeed, Space.World);
        }
        if (_horizontalInput < 0) // swipe left
        {
            transform.Translate(Vector3.left * Time.deltaTime * _playerSpeed, Space.World);
        }
    }
}
