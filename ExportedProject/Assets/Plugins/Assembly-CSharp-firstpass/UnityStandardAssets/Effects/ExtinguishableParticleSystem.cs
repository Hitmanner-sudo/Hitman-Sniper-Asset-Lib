using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Effects
{
	[Token(Token = "0x200004C")]
	public class ExtinguishableParticleSystem : MonoBehaviour
	{
		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x20")]
		private ParticleSystem[] m_Systems;

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x10E8488", Offset = "0x10E8488", VA = "0x10E8488")]
		private void Start()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x10E84DC", Offset = "0x10E84DC", VA = "0x10E84DC")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x10E8568", Offset = "0x10E8568", VA = "0x10E8568")]
		public ExtinguishableParticleSystem()
		{
		}
	}
}
