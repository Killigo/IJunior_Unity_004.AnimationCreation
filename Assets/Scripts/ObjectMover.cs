using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    [SerializeField] GameObject _sphere;
    [SerializeField] GameObject _cube;
    [SerializeField] GameObject _capsule;
    [SerializeField] GameObject _cube2;

    [SerializeField] private float _rotateSpeed;
    [SerializeField] private float _scaleSpeed;
    [SerializeField] private float _moveSpeed;


    private bool _increase;
    private bool _isForwardMove;

    private void Update()
    {
        ObjectMove(_sphere);
        ObjectRotate(_cube);
        ObjectScale(_capsule);
        AllTransform(_cube2);
    }

    private void ObjectMove(GameObject _object)
    {
        if (_isForwardMove == true && _object.transform.position.x < 1)
        {
            _object.transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
        }
        else if (_isForwardMove == false && _object.transform.position.x > -1)
        {
            _object.transform.Translate(Vector3.back * _moveSpeed * Time.deltaTime);
        }
        else
        {
            _isForwardMove = !_isForwardMove;
        }
    }

    private void ObjectRotate(GameObject _object)
    {
        _object.transform.Rotate(Vector3.up * _rotateSpeed * Time.deltaTime);
    }

    private void ObjectScale(GameObject _object)
    {
        if (_increase == true && _object.transform.localScale.y < 1.5)
        {
            _object.transform.localScale += Vector3.one * _scaleSpeed; ;
        }
        else if (_increase == false && _object.transform.localScale.y > 1)
        {
            _object.transform.localScale += Vector3.one * _scaleSpeed * -1;
        }
        else
        {
            _increase = !_increase;
        }
    }

    private void AllTransform(GameObject _object)
    {
        _object.transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
        ObjectRotate(_cube2);
        ObjectScale(_cube2);
    }
}
