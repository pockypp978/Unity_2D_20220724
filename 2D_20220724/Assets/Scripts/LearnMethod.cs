using UnityEngine;

namespace LP
{
    public class LearnMethod : MonoBehaviour
    {
        public void Test()
        {
            print("結果："+TestTen());
        }
        private void Start()
        {
            Test();
            AddTen(10);
            Add(100, 200);
            Skill("火球術",effect:"爆炸");
            Skill("冰錐術",effect:"冰霜",sound:"鏘");
            Skill("旋風斬","咻咻咻","衝擊波");
        }
        private int TestTen()
        {
            return 10;
        }
        private void AddTen(int number) 
        {
            number = number + 20;
            print("數字加20後等於" + number);
        }
        private void Add(int numberA, int numberB) 
        {
            print("<color=green>數字相加結果" + "</color>" + (numberA + numberB));
        }
        private void Skill(string skilltype , string sound = "%%%",string effect = "碎片") 
        {
            print("施放技能:" + skilltype);
            print("技能音效:" + sound);
            print("技能特效:" + effect);
        }
    }
}

