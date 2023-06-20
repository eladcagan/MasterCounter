using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    [SerializeField]
    private GateType _gateType;
    [SerializeField]
    private int _gateValue;
    [SerializeField]
    private Collider _gateCollider;
    

    private Player _player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionExit(Collision collision)
    {
        _player = collision.gameObject.GetComponent<Player>();
        _player.PerformGateAction(_gateType, _gateValue);
    }

    public enum GateType
    {
        Add,
        Subtract,
        Multiply,
        Divide,
        Finish
    }
}
