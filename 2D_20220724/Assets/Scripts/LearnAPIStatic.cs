using UnityEngine;

namespace LP
{
    public class LearnAPIStatic : MonoBehaviour
    {
        private Vector3 v3A = new Vector3(1,1,1);
        private Vector3 v3B = new Vector3(22, 22, 22);
        private int Count;
        private void Start()
        {
            print($"<color=green>{Random.value}</color>");
            Cursor.visible = false;
            Count = Camera.allCameras.Length;
            print(Count);
            print($"應用程式平台{Application.platform}");
            Physics.sleepThreshold = 10;
            Time.timeScale = 0.5f;
            print(Mathf.Round(9.999f));
            print($"AB兩點距離{Vector3.Distance(v3A,v3B)}");
            Application.OpenURL("https://unity.com/");
        }

        private void Update()
        {
            print($"是否輸入任意鍵{Input.anyKey}");
            //print($"經過時間{Time.time}");
            print($"是否按下SPACE:{Input.GetKeyDown(KeyCode.Space)}");
        }
    }

}
