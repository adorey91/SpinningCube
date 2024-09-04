using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinning : MonoBehaviour
{
    [SerializeField] private int x;
    [SerializeField] private int y;
    [SerializeField] private int z;

    private void Update()
    {
        transform.Rotate(new Vector3(x, y, z) * Time.deltaTime);
    }
}
