using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Effects
{
	[Token(Token = "0x200004E")]
	public class Hose : MonoBehaviour
	{
		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x18")]
		public float maxPower;

		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x1C")]
		public float minPower;

		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x20")]
		public float changeSpeed;

		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x28")]
		public ParticleSystem[] hoseWaterSystems;

		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x30")]
		public Renderer systemRenderer;

		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x38")]
		private float m_Power;

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x10EF4A0", Offset = "0x10EF4A0", VA = "0x10EF4A0")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x10EF61C", Offset = "0x10EF61C", VA = "0x10EF61C")]
		public Hose()
		{
		}
	}
}
