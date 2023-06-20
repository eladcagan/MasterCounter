using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private GameObject _PlayerClone;
    [SerializeField]
    private float _radiusOffset;
    [SerializeField]
    private float _circleMaxValue;

    private int _cloneAmount;

    // Start is called before the first frame update
    void Start()
    {
        PerformGateAction(Gate.GateType.Add, 666);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ClonePlayer(int amountToadd)
    {
      
       
    }

    internal void PerformGateAction(Gate.GateType gateType, int value)
    {
        switch (gateType)
        {
            case Gate.GateType.Add:
                Debug.Log("passed through Add Gate");
                ClonePlayer(value);
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