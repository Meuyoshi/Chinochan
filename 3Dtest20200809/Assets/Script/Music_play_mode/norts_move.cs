using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class norts_move : MonoBehaviour
{

    //// 変化量
    float speed = 10.0f;//ノーツスピード oosawa20200812


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //ノーツの向かうオブジェクトを取得 oosawa20200812
        Vector3 direction = GameObject.Find("EndLine2").transform.position;//ここ修正が必要な気がする oosawa20200812

        //ノーツの移動 oosawa20200812
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, direction, step);
    }
}
