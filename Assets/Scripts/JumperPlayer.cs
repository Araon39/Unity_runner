using UnityEngine;

public class JumperPlayer : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float _speedForce;
    private bool _canJump;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_canJump)
            {
                _canJump = false;
                rb.AddForce(Vector3.up * _speedForce);
            }
        }
    }


    private void OnCollisionEnter(Collision other)
    {
        _canJump = true;
    }
}