using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology
{
	[Serializable]
	[Token(Token = "0x2000A48")]
	public class ActiveAudioSource
	{
		[Token(Token = "0x400359D")]
		[FieldOffset(Offset = "0x10")]
		public AudioSource Source;

		[Token(Token = "0x400359E")]
		[FieldOffset(Offset = "0x18")]
		public SoundInstance InstanceHandle;

		[Token(Token = "0x400359F")]
		[FieldOffset(Offset = "0x20")]
		public Coroutine FadeCoroutine;

		[Token(Token = "0x40035A0")]
		[FieldOffset(Offset = "0x28")]
		public Transform FollowTransform;

		[Token(Token = "0x40035A1")]
		[FieldOffset(Offset = "0x30")]
		public bool CanBeKilled;

		[Token(Token = "0x600412D")]
		[Address(RVA = "0xD5B008", Offset = "0xD5B008", VA = "0xD5B008")]
		public ActiveAudioSource(AudioSource source)
		{
		}

		[Token(Token = "0x600412E")]
		[Address(RVA = "0xD5B038", Offset = "0xD5B038", VA = "0xD5B038")]
		public void CleanUp()
		{
		}
	}
}
