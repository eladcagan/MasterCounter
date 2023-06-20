using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private GameObject _PlayerClone;

    private int _cloneAmount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void PerformGateAction(Gate.GateType gateType)
    {
        switch (gateType)
        {
            case Gate.GateType.Add:
                Debug.Log("passed through Add Gate");
                break;
            case Gate.GateType.Subtract:
                Debug.Log("passed through Substract Gate");
                break;
            case Gate.GateType.Multiply:
                Debug.Log("passed through Multiplie Gate");
                break;
            case Gate.GateType.Divide:
                Debug.Log("passed through Devide Gate");
                break;
            default:
                break;
        }
    }
}