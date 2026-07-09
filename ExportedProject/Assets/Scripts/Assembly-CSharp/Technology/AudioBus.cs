using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology
{
	[Serializable]
	[Token(Token = "0x2000A45")]
	public class AudioBus
	{
		[Token(Token = "0x2000A46")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597930", Offset = "0x597930")]
		private sealed class _003C_003Ec__DisplayClass19_0
		{
			[Token(Token = "0x400359A")]
			[FieldOffset(Offset = "0x10")]
			public AudioClip clip;

			[Token(Token = "0x6004128")]
			[Address(RVA = "0x92552C", Offset = "0x92552C", VA = "0x92552C")]
			public _003C_003Ec__DisplayClass19_0()
			{
			}

			[Token(Token = "0x6004129")]
			[Address(RVA = "0x925534", Offset = "0x925534", VA = "0x925534")]
			internal bool _003CIsSoundCurrentlyPlaying_003Eb__0(ActiveAudioSource r)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x2000A47")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597940", Offset = "0x597940")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x400359B")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x400359C")]
			[FieldOffset(Offset = "0x8")]
			public static Func<ActiveAudioSource, bool> _003C_003E9__21_0;

			[Token(Token = "0x600412B")]
			[Address(RVA = "0x92550C", Offset = "0x92550C", VA = "0x92550C")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x600412C")]
			[Address(RVA = "0x925514", Offset = "0x925514", VA = "0x925514")]
			internal bool _003CStopOldest_003Eb__21_0(ActiveAudioSource a)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400358E")]
		[FieldOffset(Offset = "0x10")]
		public int maxNumOfSounds;

		[Token(Token = "0x400358F")]
		[FieldOffset(Offset = "0x18")]
		public AudioSource alternateAudioSource;

		[Token(Token = "0x4003590")]
		[FieldOffset(Offset = "0x20")]
		private Queue<ActiveAudioSource> freeAudioSources;

		[Token(Token = "0x4003591")]
		[FieldOffset(Offset = "0x28")]
		private List<ActiveAudioSource> currentlyUsedAudioSources;

		[Token(Token = "0x4003592")]
		[FieldOffset(Offset = "0x30")]
		private List<ActiveAudioSource> _audioSources;

		[Token(Token = "0x4003593")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BBD04", Offset = "0x5BBD04")]
		private ReadOnlyCollection<ActiveAudioSource> _003CAudioSources_003Ek__BackingField;

		[Token(Token = "0x4003594")]
		[FieldOffset(Offset = "0x40")]
		[Decibels]
		public float Volume;

		[Token(Token = "0x4003595")]
		[FieldOffset(Offset = "0x44")]
		private float _pitch;

		[Token(Token = "0x4003596")]
		[FieldOffset(Offset = "0x48")]
		public bool KillOldestSound;

		[Token(Token = "0x4003597")]
		[FieldOffset(Offset = "0x49")]
		public bool Mute;

		[Token(Token = "0x4003598")]
		[FieldOffset(Offset = "0x4A")]
		public bool Solo;

		[Token(Token = "0x4003599")]
		[FieldOffset(Offset = "0x4B")]
		public bool IgnoreListenerPause;

		[Token(Token = "0x1700084E")]
		public ReadOnlyCollection<ActiveAudioSource> AudioSources
		{
			[Token(Token = "0x600411C")]
			[Address(RVA = "0xC07CA4", Offset = "0xC07CA4", VA = "0xC07CA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625418", Offset = "0x625418")]
			get
			{
				return null;
			}
			[Token(Token = "0x600411D")]
			[Address(RVA = "0xC07CAC", Offset = "0xC07CAC", VA = "0xC07CAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625428", Offset = "0x625428")]
			private set
			{
			}
		}

		[Token(Token = "0x1700084F")]
		public float Pitch
		{
			[Token(Token = "0x600411E")]
			[Address(RVA = "0xC07CB4", Offset = "0xC07CB4", VA = "0xC07CB4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600411F")]
			[Address(RVA = "0xC07CBC", Offset = "0xC07CBC", VA = "0xC07CBC")]
			set
			{
			}
		}

		[Token(Token = "0x6004120")]
		[Address(RVA = "0xC07D78", Offset = "0xC07D78", VA = "0xC07D78")]
		public void InitializeAudioSourcePools(GameObject parent)
		{
		}

		[Token(Token = "0x6004121")]
		[Address(RVA = "0xC080B4", Offset = "0xC080B4", VA = "0xC080B4")]
		private bool IsSoundCurrentlyPlaying(AudioClip clip)
		{
			return default(bool);
		}

		[Token(Token = "0x6004122")]
		[Address(RVA = "0xC081A0", Offset = "0xC081A0", VA = "0xC081A0")]
		public void FreeAudioSource(ActiveAudioSource audioSource)
		{
		}

		[Token(Token = "0x6004123")]
		[Address(RVA = "0xC0828C", Offset = "0xC0828C", VA = "0xC0828C")]
		public void StopOldest()
		{
		}

		[Token(Token = "0x6004124")]
		[Address(RVA = "0xC08428", Offset = "0xC08428", VA = "0xC08428")]
		public ActiveAudioSource GetAudioSource(SoundInstance caller)
		{
			return null;
		}

		[Token(Token = "0x6004125")]
		[Address(RVA = "0xC08508", Offset = "0xC08508", VA = "0xC08508")]
		public bool AllowedToPlay()
		{
			return default(bool);
		}

		[Token(Token = "0x6004126")]
		[Address(RVA = "0xC08790", Offset = "0xC08790", VA = "0xC08790")]
		public void SetMute(bool mute)
		{
		}

		[Token(Token = "0x6004127")]
		[Address(RVA = "0xC08A24", Offset = "0xC08A24", VA = "0xC08A24")]
		public AudioBus()
		{
		}
	}
}
