using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private bool _isForwardMove = true;

    private void Update()
    {
        if (_isForwardMove == true && transform.position.x < 2)
        {
            transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
        }
        else if (_isForwardMove == false && transform.position.x > -2)
        {
            transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime * -1);
        }
        else
        {
            _isForwardMove = !_isForwardMove;
        }
    }
}