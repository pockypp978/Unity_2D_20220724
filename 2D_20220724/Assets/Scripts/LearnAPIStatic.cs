using UnityEngine;

namespace LP
{
    public class LearnAPIStatic : MonoBehaviour
    {
        private void Start()
        {
            print($"<color=green>{Random.value}</color>");
            Cursor.visible = false;
        }

        private void Update()
        {
            print(Random.Range(2,13));
        }
    }

}
