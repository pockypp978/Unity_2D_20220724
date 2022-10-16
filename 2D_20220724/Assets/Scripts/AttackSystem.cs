using UnityEngine;
using System.Collections;
namespace LP
{
	public class AttackSystem : MonoBehaviour
	{
		[SerializeField, Header("�������")]
		private AttackData attackData;
		[SerializeField, Header("��������")]
		private AudioClip soundAttack;

		private Animator ani;
		private bool isAttacking;
		private void OnDrawGizmos()
		{
			Gizmos.color = attackData.attackAreaColor;
			Gizmos.DrawCube(
				transform.position +
				transform.TransformDirection(attackData.attackAreaOffset),
				attackData.attackAreaSize);
		}

		private void CheckAttackArea()
		{
			Collider2D hit = Physics2D.OverlapBox(
				transform.position +
				transform.TransformDirection(attackData.attackAreaOffset),
				attackData.attackAreaSize, 0, attackData.attackAreaLayer);
			//rint("������" + hit);

			if(hit)hit.GetComponent<HealthSystem>().Hurt(attackData.attack);
		}

		protected virtual void Awake()
		{
			ani = GetComponent<Animator>();
		}
		// virtual �����G���\�l���O�ϥνƼg����r override
		/// <summary>
		/// �}�l����
		/// </summary>
		public virtual void StartAttack()
		{
			if (isAttacking) return;

			isAttacking = true;
			ani.SetTrigger(attackData.parAttack);
			StartCoroutine(Attacking());

			SoundManager.instance.PlaySound(soundAttack, new Vector2(1.8f, 2f));
		}
		/// <summary>
		/// ������
		/// </summary>
		private IEnumerator Attacking()
		{
			yield return new WaitForSeconds(attackData.delaySendDmage);
			CheckAttackArea();
			yield return new WaitForSeconds(attackData.attackTime);
			isAttacking = false;
			StopAttack();
		}
		//protected �O�@�ŧO�G���\�l���O�s���νƼg
		protected virtual void StopAttack()
		{

		}
	}

}
