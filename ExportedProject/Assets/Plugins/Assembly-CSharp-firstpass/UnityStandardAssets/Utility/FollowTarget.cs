using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x200002C")]
	public class FollowTarget : MonoBehaviour
	{
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 offset;

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x10E8B74", Offset = "0x10E8B74", VA = "0x10E8B74")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x10E8BD4", Offset = "0x10E8BD4", VA = "0x10E8BD4")]
		public FollowTarget()
		{
		}
	}
}
