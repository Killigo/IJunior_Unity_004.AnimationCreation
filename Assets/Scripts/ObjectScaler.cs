using UnityEngine;

public class ObjectScaler : MonoBehaviour
{
    [SerializeField] private float _speed;

    private bool _increase;

    private void Update()
    {
        if (_increase == true && transform.localScale.y < 1.5)
        {
            transform.localScale += Vector3.one * _speed; ;
        }
        else if (_increase == false && transform.localScale.y > 1)
        {
            transform.localScale += Vector3.one * _speed * -1;
        }
        else
        {
            _increase = !_increase;
        }
    }
}