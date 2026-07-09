using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Effects
{
	[Token(Token = "0x2000045")]
	[Attribute(Name = "RequireComponent", RVA = "0x6F9058", Offset = "0x6F9058")]
	public class AfterburnerPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0x18")]
		public float effectAngle;

		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x1C")]
		public float effectWidth;

		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x20")]
		public float effectDistance;

		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x24")]
		public float force;

		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x28")]
		private Collider[] m_Cols;

		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x30")]
		private SphereCollider m_Sphere;

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x10D6EC4", Offset = "0x10D6EC4", VA = "0x10D6EC4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x10D6F64", Offset = "0x10D6F64", VA = "0x10D6F64")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x10D735C", Offset = "0x10D735C", VA = "0x10D735C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x10D77E0", Offset = "0x10D77E0", VA = "0x10D77E0")]
		public AfterburnerPhysicsForce()
		{
		}
	}
}
