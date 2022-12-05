using System;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    public float BallScale = 1.5f;
    private Vector3 spawnPoint = new Vector3(0f,2f,0f);

    private void OnEnable()
    {
        transform.localScale = new Vector3(BallScale, BallScale, BallScale);
    }

    void Update()
    {
        if (this.transform.position.y < -1.5f)
        {
            this.transform.position = spawnPoint;
        }
    }
}
