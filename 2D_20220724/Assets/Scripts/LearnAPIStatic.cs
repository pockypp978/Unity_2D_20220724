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
            print($"���ε{�����x{Application.platform}");
            Physics.sleepThreshold = 10;
            Time.timeScale = 0.5f;
            print(Mathf.Round(9.999f));
            print($"AB���I�Z��{Vector3.Distance(v3A,v3B)}");
            Application.OpenURL("https://unity.com/");
        }

        private void Update()
        {
            print($"�O�_��J���N��{Input.anyKey}");
            //print($"�g�L�ɶ�{Time.time}");
            print($"�O�_���USPACE:{Input.GetKeyDown(KeyCode.Space)}");
        }
    }

}
