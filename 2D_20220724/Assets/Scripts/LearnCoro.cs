using UnityEngine;
using System.Collections;

namespace LP
{
    public class LearnCoro : MonoBehaviour
    {
        private void Awake()
        {
            StartCoroutine(Test());
        }
        private IEnumerator Test()
        {
            print("第一次");
            yield return new WaitForSeconds(1.5f);
            print("第二次HAHA");
            yield return new WaitForSeconds(2.5f);
            print("thrid time");


        }
    }
}

