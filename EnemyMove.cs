using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private int degree;
    private float Radius = 1.8f;
    private float x, y;

    private void Start()
    {
        degree = Random.Range(0, 360);
        x = Radius * Mathf.Cos(degree);
        y = Radius * Mathf.Sin(degree);
    }
    private void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector3(x, y, 0), 1.5f * Time.deltaTime);
    }
}
