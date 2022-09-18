using UnityEngine;
namespace LP 
{
    public class PlayerAttack : AttackSystem
    {
        [SerializeField, Header("��������")]
        private KeyCode keyAttack = KeyCode.Mouse0;

        private void Update()
        {
            InputCheck();
        }
        private void InputCheck()
        {
            if (Input.GetKeyDown(keyAttack))
            {
                StartAttack();
            }
        }
    }

}
