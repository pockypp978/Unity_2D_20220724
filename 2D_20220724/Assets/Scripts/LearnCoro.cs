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
            print("�Ĥ@��");
            yield return new WaitForSeconds(1.5f);
            print("�ĤG��HAHA");
            yield return new WaitForSeconds(2.5f);
            print("thrid time");


        }
    }
}

