using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Liquid : MonoBehaviour
{
    public Color _color;
    public Shader _test;

    void Start()
    {
        _test = this.gameObject.GetComponent<Shader>();
    }
}