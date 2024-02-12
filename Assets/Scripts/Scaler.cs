using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _newScale = new Vector3(2f, 2f, 2f);

    void Update()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, _newScale, _speed * Time.deltaTime);
    }
}
