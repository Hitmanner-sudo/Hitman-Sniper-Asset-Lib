using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000037")]
	public class SmoothFollow : MonoBehaviour
	{
		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float distance;

		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float height;

		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float rotationDamping;

		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float heightDamping;

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x10F1B68", Offset = "0x10F1B68", VA = "0x10F1B68")]
		private void Start()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x10F1B6C", Offset = "0x10F1B6C", VA = "0x10F1B6C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x10F1E14", Offset = "0x10F1E14", VA = "0x10F1E14")]
		public SmoothFollow()
		{
		}
	}
}
