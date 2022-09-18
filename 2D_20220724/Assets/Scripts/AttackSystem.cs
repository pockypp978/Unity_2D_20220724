using UnityEngine;
using System.Collections;
namespace LP
{
	public class AttackSystem : MonoBehaviour
	{
		[SerializeField, Header("攻擊資料")]
		private AttackData attackData;

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
				attackData.attackAreaSize,0,attackData.attackAreaLayer);
			print("攻擊到" + hit);
		}

		private void Awake()
		{
			ani = GetComponent<Animator>();
		}
		/// <summary>
		/// 開始攻擊
		/// </summary>
		public void StartAttack() 
		{
			if (isAttacking) return;

			isAttacking = true;
			ani.SetTrigger(attackData.parAttack);
			StartCoroutine(Attacking());
		}
		/// <summary>
		/// 攻擊中
		/// </summary>
		private IEnumerator Attacking() 
		{
			yield return new WaitForSeconds(attackData.delaySendDmage);
			CheckAttackArea();
			yield return new WaitForSeconds(attackData.attackTime);
			isAttacking = false;
		}
	}

}
