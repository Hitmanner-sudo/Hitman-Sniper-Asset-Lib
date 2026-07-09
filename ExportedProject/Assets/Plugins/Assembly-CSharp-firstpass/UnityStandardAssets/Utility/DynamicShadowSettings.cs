using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000027")]
	public class DynamicShadowSettings : MonoBehaviour
	{
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x18")]
		public Light sunLight;

		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x20")]
		public float minHeight;

		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x24")]
		public float minShadowDistance;

		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x28")]
		public float minShadowBias;

		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x2C")]
		public float maxHeight;

		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x30")]
		public float maxShadowDistance;

		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x34")]
		public float maxShadowBias;

		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x38")]
		public float adaptTime;

		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x3C")]
		private float m_SmoothHeight;

		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x40")]
		private float m_ChangeSpeed;

		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x44")]
		private float m_OriginalStrength;

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x10DFCF0", Offset = "0x10DFCF0", VA = "0x10DFCF0")]
		private void Start()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x10DFD24", Offset = "0x10DFD24", VA = "0x10DFD24")]
		private void Update()
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x10DFEE0", Offset = "0x10DFEE0", VA = "0x10DFEE0")]
		public DynamicShadowSettings()
		{
		}
	}
}
