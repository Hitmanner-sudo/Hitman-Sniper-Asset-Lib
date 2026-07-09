using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Effects
{
	[Token(Token = "0x2000051")]
	public class WaterHoseParticles : MonoBehaviour
	{
		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x0")]
		public static float lastSoundTime;

		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x18")]
		public float force;

		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x20")]
		private List<ParticleCollisionEvent> m_CollisionEvents;

		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x28")]
		private ParticleSystem m_ParticleSystem;

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x18BD8FC", Offset = "0x18BD8FC", VA = "0x18BD8FC")]
		private void Start()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x18BD950", Offset = "0x18BD950", VA = "0x18BD950")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x18BDBC4", Offset = "0x18BDBC4", VA = "0x18BDBC4")]
		public WaterHoseParticles()
		{
		}
	}
}
