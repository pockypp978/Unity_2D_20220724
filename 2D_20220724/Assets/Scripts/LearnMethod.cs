using UnityEngine;

namespace LP
{
    public class LearnMethod : MonoBehaviour
    {
        public void Test()
        {
            print("���G�G"+TestTen());
        }
        private void Start()
        {
            Test();
        }
        private int TestTen()
        {
            return 10;
        }
    }
}

