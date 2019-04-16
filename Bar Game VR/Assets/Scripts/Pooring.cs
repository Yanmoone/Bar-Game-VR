using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pooring : MonoBehaviour
{
    [SerializeField]
    private GameObject _water;

    [SerializeField]
    private Transform _pooringPosition;

    void Update()
    {
        if (transform.eulerAngles.x > 80 && transform.eulerAngles.x < 280 || transform.eulerAngles.z > 80 && transform.eulerAngles.z < 280)
        {
            Debug.Log("klunk");
            Instantiate(_water, _pooringPosition.position, transform.rotation);

        }
    }
}
