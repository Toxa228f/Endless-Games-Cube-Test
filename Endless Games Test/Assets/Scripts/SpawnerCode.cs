using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SpawnerCode : MonoBehaviour
{
    [SerializeField] GameObject cube;

    [SerializeField] InputField fieldSpeed;
    [SerializeField] InputField fieldLenth;
    [SerializeField] InputField fieldTime;

    private float TimeRespawn { get; set; } = 2f;
    private float TimeRespawn_delta { get; set; }

    private float CubeSpeed { get; set; } = 1f;
    private float CubeLenth { get; set; } = 3f;



    private void Start()
    {
        TimeRespawn_delta = TimeRespawn;
        fieldSpeed.text = CubeSpeed.ToString();
        fieldLenth.text = CubeLenth.ToString();
        fieldTime.text = TimeRespawn.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeRespawn_delta <= 0)
        {
            TimeRespawn_delta = TimeRespawn;
            var cub = Instantiate(cube, Vector3.zero, Quaternion.identity);
            cub.GetComponent<CubeCode>().SetParamiters(CubeSpeed, CubeLenth);
        }
        else
        {
            TimeRespawn_delta -= Time.deltaTime;
        }
    }

    public void ChangeSpeed()
    {
        float res;
        if (float.TryParse(fieldSpeed.text, out res))
        { CubeSpeed = res; }

    }

    public void ChangeLen()
    {
        float res;
        if (float.TryParse(fieldLenth.text, out res))
        {
            CubeLenth = res;
        }

    }

    public void ChangeTime()
    {
        float res;
        if (float.TryParse(fieldTime.text, out res))
        {
            TimeRespawn = res;
        }
    }
}
