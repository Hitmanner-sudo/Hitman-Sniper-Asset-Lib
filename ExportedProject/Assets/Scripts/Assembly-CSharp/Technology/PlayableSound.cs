using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology
{
	[Serializable]
	[Token(Token = "0x2000A4C")]
	public class PlayableSound
	{
		[Token(Token = "0x40035B2")]
		[FieldOffset(Offset = "0x10")]
		[HideInInspector]
		[SerializeField]
		private Sound _sound;

		[Token(Token = "0x40035B3")]
		[FieldOffset(Offset = "0x18")]
		[HideInInspector]
		[SerializeField]
		private SoundContainer _soundContainer;

		[Token(Token = "0x17000851")]
		public bool IsValid
		{
			[Token(Token = "0x600413F")]
			[Address(RVA = "0xB826AC", Offset = "0xB826AC", VA = "0xB826AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600413D")]
		[Address(RVA = "0xB82494", Offset = "0xB82494", VA = "0xB82494")]
		public PlayableSound()
		{
		}

		[Token(Token = "0x600413E")]
		[Address(RVA = "0xB824BC", Offset = "0xB824BC", VA = "0xB824BC")]
		public PlayingSound Play(AudioBus audioBus, TimeReferential timer, Transform sourceLocation, float volume, float delay, float fadeInTime, float fadeOutTime, bool loop, bool bypassEffects, bool canBeKilled, Sound.SoundStoppedDelegate onSoundStopped)
		{
			return null;
		}

		[Token(Token = "0x6004140")]
		[Address(RVA = "0xB8275C", Offset = "0xB8275C", VA = "0xB8275C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
