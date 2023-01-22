using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlayer : MonoBehaviour
{
    [SerializeField] private Animator _run;
    [SerializeField] private float _speed;
    void Start()
    {
        _run.SetFloat("Speed_f",_speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
