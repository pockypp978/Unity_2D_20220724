using UnityEngine;
namespace LP 
{
    public class PlayerAttack : AttackSystem
    {
        [SerializeField, Header("攻擊按鍵")]
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

        //override 複寫父類別有virtual 關鍵字的成員
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
