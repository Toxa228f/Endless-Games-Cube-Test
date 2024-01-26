using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCode : MonoBehaviour
{

    private float Speed { get; set; }

    private float Lenth { get; set; }

    public void SetParamiters(float Speed, float Lenth)
    {
        this.Speed = Speed;
        this.Lenth = Lenth;
        if (Speed > 0 && Lenth > 0)
        {
            float time = Lenth / Speed;
            Destroy(gameObject, time);
        }
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        print(Speed);
    }
}
