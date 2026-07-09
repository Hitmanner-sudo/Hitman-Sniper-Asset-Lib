using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Effects
{
	[Token(Token = "0x200004D")]
	public class FireLight : MonoBehaviour
	{
		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x18")]
		private float m_Rnd;

		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x1C")]
		private bool m_Burning;

		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x20")]
		private Light m_Light;

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x10E8914", Offset = "0x10E8914", VA = "0x10E8914")]
		private void Start()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x10E8980", Offset = "0x10E8980", VA = "0x10E8980")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x10E8B3C", Offset = "0x10E8B3C", VA = "0x10E8B3C")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x10E8B64", Offset = "0x10E8B64", VA = "0x10E8B64")]
		public FireLight()
		{
		}
	}
}
