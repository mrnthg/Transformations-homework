using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllMovement : MonoBehaviour
{
    [SerializeField] private float _speedMovement;
    [SerializeField] private float _speedScale;

    private Vector3 _newScale = new Vector3(1.5f, 1.5f, 1.5f);

    private void Update()
    {
        transform.Translate(Vector3.forward * _speedMovement * Time.deltaTime);
        transform.localScale = Vector3.Lerp(transform.localScale, _newScale, _speedScale * Time.deltaTime);
    }

}
