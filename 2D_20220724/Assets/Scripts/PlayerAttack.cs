using UnityEngine;
namespace LP 
{
    public class PlayerAttack : AttackSystem
    {
        [SerializeField, Header("��������")]
        private KeyCode keyAttack = KeyCode.Mouse0;
        private JumpSystem jumpSystem;
        private MoveScript moveScript;

        protected override void Awake()
        {
            base.Awake();
            jumpSystem = GetComponent<JumpSystem>();
            moveScript = GetComponent<MoveScript>();
        }
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

        //override �Ƽg�����O��virtual ����r������
        public override void StartAttack()
        {
            base.StartAttack();

            moveScript.enabled = false;
            jumpSystem.enabled = false;

        }

        protected override void StopAttack()
        {
            base.StopAttack();

            moveScript.enabled = true;
            jumpSystem.enabled = true;
        }
    }

}
