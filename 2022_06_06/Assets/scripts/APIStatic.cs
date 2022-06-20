using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Going
{
    ///<summary>
    ///API 靜態使用方式
    ///</summary>
    public class APIStatic : MonoBehaviour
    {
        private void Start()
        {
            print("平台是" + Application.platform);
            print($"總共{Camera.allCamerasCount}個相機");
            Time.timeScale = 0.5f;
            print("去除小數點" + Mathf.Floor(9.999f));
            print("去除小數點" + Mathf.FloorToInt(9.999f));
            print("距離為" + Vector3.Distance(new Vector3(1, 1, 1), new Vector3(22, 22, 22)));
        }
        private void Update()
        {
            if (Input.anyKeyDown)
            {
                print("按了");
                print(Time.unscaledTime);
            }
            if (Input.GetKeyDown(KeyCode.Space)){
                print("空白鍵");
                Application.OpenURL("https://unity.com/");
            }

        }
    }
}

