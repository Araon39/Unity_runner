using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgraoundMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private int _pointClone = 48;
    [SerializeField] private int _pointStart= 8;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 transformPosition = transform.position;
        if (transformPosition.x >= _pointClone)
        {
            transformPosition.x = _pointStart;
            transform.position = transformPosition;
        }
        transform.Translate(new Vector3(1,0,0) * _speed);
    }
}
