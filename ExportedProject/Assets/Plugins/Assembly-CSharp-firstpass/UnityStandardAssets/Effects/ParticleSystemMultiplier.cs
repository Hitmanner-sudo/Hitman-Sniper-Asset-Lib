using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Effects
{
	[Token(Token = "0x200004F")]
	public class ParticleSystemMultiplier : MonoBehaviour
	{
		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x10F106C", Offset = "0x10F106C", VA = "0x10F106C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x10F11CC", Offset = "0x10F11CC", VA = "0x10F11CC")]
		public ParticleSystemMultiplier()
		{
		}
	}
}
