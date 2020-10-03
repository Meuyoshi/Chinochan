using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btn_start : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    //スタートボタンクリック処理
    public void OnClickBtnStart()
    {
        SceneManager.LoadScene("Select");
    }


    ////ボタンを押した時の処理
    //public void PushButton()
    //{
    //    SceneManager.LoadScene("Select");
    //}
}
