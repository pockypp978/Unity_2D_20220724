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
            AddTen(10);
            Add(100, 200);
            Skill("���y�N",effect:"�z��");
            Skill("�B�@�N",effect:"�B��",sound:"��");
            Skill("�ۭ���","������","�����i");
        }
        private int TestTen()
        {
            return 10;
        }
        private void AddTen(int number) 
        {
            number = number + 20;
            print("�Ʀr�[20�ᵥ��" + number);
        }
        private void Add(int numberA, int numberB) 
        {
            print("<color=green>�Ʀr�ۥ[���G" + "</color>" + (numberA + numberB));
        }
        private void Skill(string skilltype , string sound = "%%%",string effect = "�H��") 
        {
            print("�I��ޯ�:" + skilltype);
            print("�ޯ୵��:" + sound);
            print("�ޯ�S��:" + effect);
        }
    }
}

