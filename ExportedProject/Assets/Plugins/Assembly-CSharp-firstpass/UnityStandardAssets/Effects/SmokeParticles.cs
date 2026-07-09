using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Effects
{
	[Token(Token = "0x2000050")]
	public class SmokeParticles : MonoBehaviour
	{
		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x18")]
		public AudioClip[] extinguishSounds;

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x10F1AA4", Offset = "0x10F1AA4", VA = "0x10F1AA4")]
		private void Start()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x10F1B60", Offset = "0x10F1B60", VA = "0x10F1B60")]
		public SmokeParticles()
		{
		}
	}
}
