using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMover : MonoBehaviour
{
    [SerializeField] private Vector3 _movementDirection;

    private bool _isForwardMove = true;

    private void Update()
    {
        if (_isForwardMove == true && transform.position.x < 1)
        {
            transform.Translate(_movementDirection);
        }
        else if (_isForwardMove == false && transform.position.x > -1)
        {
            transform.Translate(_movementDirection * -1);
        }
        else
        {
            _isForwardMove = !_isForwardMove;
        }
    }
}
