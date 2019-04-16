using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mixing : MonoBehaviour
{
    [SerializeField]
    private Material _material;

    [SerializeField]
    [Range(0,1)]
    private float _maxSize = 0.8f;

    [SerializeField]
    private float _capacity = 20;

    [SerializeField]
    private GameObject _water;

    private Color _color;
    private int _liquidCount;

    void OnTriggerEnter(Collider CEnter)
    {
        Liquid liquid = CEnter.GetComponent<Liquid>();

        if (liquid == null)
        {
            return;
        }

        if (_capacity == _liquidCount)
        {
            return;
        }
        Debug.Log("slurp");
        _liquidCount++;
        _color = ((_color * _liquidCount) + liquid._color) / (_liquidCount + 1);
        _material.color = _color;
        _water.transform.localScale += new Vector3(0, _maxSize/_capacity, 0);
        _water.transform.position += new Vector3(0, (_maxSize/_capacity)/2, 0);
    }
}
