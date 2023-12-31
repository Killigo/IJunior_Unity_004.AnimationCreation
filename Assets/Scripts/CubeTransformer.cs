using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTransformer : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotateSpeed;
    [SerializeField] private float _scaleSpeed;

    private bool _increase;

    private void Update()
    {
        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * _rotateSpeed * Time.deltaTime);

        if (_increase == true && transform.localScale.y < 1.5)
        {
            transform.localScale += Vector3.one * _scaleSpeed; ;
        }
        else if (_increase == false && transform.localScale.y > 1)
        {
            transform.localScale += Vector3.one * _scaleSpeed * -1;
        }
        else
        {
            _increase = !_increase;
        }
    }
}
