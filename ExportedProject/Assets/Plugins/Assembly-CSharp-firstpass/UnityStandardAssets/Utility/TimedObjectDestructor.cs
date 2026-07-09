using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x200003F")]
	public class TimedObjectDestructor : MonoBehaviour
	{
		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_TimeOut;

		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_DetachChildren;

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x18BBE98", Offset = "0x18BBE98", VA = "0x18BBE98")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x18BBEEC", Offset = "0x18BBEEC", VA = "0x18BBEEC")]
		private void DestroyNow()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x18BBF88", Offset = "0x18BBF88", VA = "0x18BBF88")]
		public TimedObjectDestructor()
		{
		}
	}
}
