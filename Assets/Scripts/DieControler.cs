using System;
using UnityEngine;

public class DieControler : MonoBehaviour
{
    [SerializeField] private GameObject GameOver;
    [SerializeField] private Animator _die;

    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "Obstacles")
        {
            _die.SetBool("Death_b", true);
            Invoke(nameof(Die), 1);
        }
    }

    private void Die()
    {
        GameOver.SetActive(true);
        Time.timeScale = 0;
    }
}
