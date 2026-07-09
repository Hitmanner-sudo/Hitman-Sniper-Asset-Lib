using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology
{
	[Serializable]
	[Token(Token = "0x2000A59")]
	public class SoundContainer : ScriptableObject
	{
		[Token(Token = "0x2000A5A")]
		public enum PlayModes
		{
			[Token(Token = "0x4003603")]
			Sequence = 0,
			[Token(Token = "0x4003604")]
			Random = 1,
			[Token(Token = "0x4003605")]
			Multi = 2,
			[Token(Token = "0x4003606")]
			IntroLoop = 3,
			[Token(Token = "0x4003607")]
			RandomAutoRestart = 4
		}

		[Serializable]
		[Token(Token = "0x2000A5B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5979C4", Offset = "0x5979C4")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4003608")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4003609")]
			[FieldOffset(Offset = "0x8")]
			public static Func<PlayableSound, bool> _003C_003E9__28_0;

			[Token(Token = "0x400360A")]
			[FieldOffset(Offset = "0x10")]
			public static Func<PlayableSound, bool> _003C_003E9__28_1;

			[Token(Token = "0x400360B")]
			[FieldOffset(Offset = "0x18")]
			public static Func<PlayableSound, bool> _003C_003E9__34_0;

			[Token(Token = "0x6004196")]
			[Address(RVA = "0xA5107C", Offset = "0xA5107C", VA = "0xA5107C")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6004197")]
			[Address(RVA = "0xA51084", Offset = "0xA51084", VA = "0xA51084")]
			internal bool _003Cget_IsValid_003Eb__28_0(PlayableSound sound)
			{
				return default(bool);
			}

			[Token(Token = "0x6004198")]
			[Address(RVA = "0xA5109C", Offset = "0xA5109C", VA = "0xA5109C")]
			internal bool _003Cget_IsValid_003Eb__28_1(PlayableSound sound)
			{
				return default(bool);
			}

			[Token(Token = "0x6004199")]
			[Address(RVA = "0xA510B4", Offset = "0xA510B4", VA = "0xA510B4")]
			internal bool _003CPlay_003Eb__34_0(PlayableSound s)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000A5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5979D4", Offset = "0x5979D4")]
		private sealed class _003CLoopSequence_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400360C")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400360D")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400360E")]
			[FieldOffset(Offset = "0x20")]
			public SoundContainer _003C_003E4__this;

			[Token(Token = "0x400360F")]
			[FieldOffset(Offset = "0x28")]
			public AudioBus audioBus;

			[Token(Token = "0x4003610")]
			[FieldOffset(Offset = "0x30")]
			public TimeReferential timer;

			[Token(Token = "0x4003611")]
			[FieldOffset(Offset = "0x38")]
			public Transform sourceLocation;

			[Token(Token = "0x4003612")]
			[FieldOffset(Offset = "0x40")]
			public float volume;

			[Token(Token = "0x4003613")]
			[FieldOffset(Offset = "0x44")]
			public float delay;

			[Token(Token = "0x4003614")]
			[FieldOffset(Offset = "0x48")]
			public float fadeInTime;

			[Token(Token = "0x4003615")]
			[FieldOffset(Offset = "0x4C")]
			public float fadeOutTime;

			[Token(Token = "0x4003616")]
			[FieldOffset(Offset = "0x50")]
			public bool bypassEffects;

			[Token(Token = "0x4003617")]
			[FieldOffset(Offset = "0x58")]
			public Sound.SoundStoppedDelegate onSoundStopped;

			[Token(Token = "0x4003618")]
			[FieldOffset(Offset = "0x60")]
			public PlayingSoundContainer playingContainer;

			[Token(Token = "0x4003619")]
			[FieldOffset(Offset = "0x68")]
			private PlayingSound _003CcurrentSound_003E5__2;

			[Token(Token = "0x17000868")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600419D")]
				[Address(RVA = "0xA51838", Offset = "0xA51838", VA = "0xA51838", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000869")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600419F")]
				[Address(RVA = "0xA51880", Offset = "0xA51880", VA = "0xA51880", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600419A")]
			[Address(RVA = "0xA516F0", Offset = "0xA516F0", VA = "0xA516F0")]
			[DebuggerHidden]
			public _003CLoopSequence_003Ed__36(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600419B")]
			[Address(RVA = "0xA5171C", Offset = "0xA5171C", VA = "0xA5171C", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600419C")]
			[Address(RVA = "0xA51720", Offset = "0xA51720", VA = "0xA51720", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600419E")]
			[Address(RVA = "0xA51840", Offset = "0xA51840", VA = "0xA51840", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x2000A5D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5979E4", Offset = "0x5979E4")]
		private sealed class _003C_003Ec__DisplayClass37_0
		{
			[Token(Token = "0x400361A")]
			[FieldOffset(Offset = "0x10")]
			public bool wentToBackground;

			[Token(Token = "0x60041A0")]
			[Address(RVA = "0xA510C0", Offset = "0xA510C0", VA = "0xA510C0")]
			public _003C_003Ec__DisplayClass37_0()
			{
			}

			[Token(Token = "0x60041A1")]
			[Address(RVA = "0xA510C8", Offset = "0xA510C8", VA = "0xA510C8")]
			internal void _003CIntroLoop_003Eb__0(bool paused)
			{
			}
		}

		[Token(Token = "0x2000A5E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5979F4", Offset = "0x5979F4")]
		private sealed class _003CIntroLoop_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400361B")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400361C")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400361D")]
			[FieldOffset(Offset = "0x20")]
			public SoundContainer _003C_003E4__this;

			[Token(Token = "0x400361E")]
			[FieldOffset(Offset = "0x28")]
			public AudioBus audioBus;

			[Token(Token = "0x400361F")]
			[FieldOffset(Offset = "0x30")]
			public TimeReferential timer;

			[Token(Token = "0x4003620")]
			[FieldOffset(Offset = "0x38")]
			public Transform sourceLocation;

			[Token(Token = "0x4003621")]
			[FieldOffset(Offset = "0x40")]
			public float volume;

			[Token(Token = "0x4003622")]
			[FieldOffset(Offset = "0x44")]
			public float delay;

			[Token(Token = "0x4003623")]
			[FieldOffset(Offset = "0x48")]
			public float fadeInTime;

			[Token(Token = "0x4003624")]
			[FieldOffset(Offset = "0x4C")]
			public float fadeOutTime;

			[Token(Token = "0x4003625")]
			[FieldOffset(Offset = "0x50")]
			public bool bypassEffects;

			[Token(Token = "0x4003626")]
			[FieldOffset(Offset = "0x58")]
			public Sound.SoundStoppedDelegate onSoundStopped;

			[Token(Token = "0x4003627")]
			[FieldOffset(Offset = "0x60")]
			public PlayingSoundContainer playingContainer;

			[Token(Token = "0x4003628")]
			[FieldOffset(Offset = "0x68")]
			private _003C_003Ec__DisplayClass37_0 _003C_003E8__1;

			[Token(Token = "0x4003629")]
			[FieldOffset(Offset = "0x70")]
			private PlayingSound _003CcurrentPlayingSound_003E5__2;

			[Token(Token = "0x400362A")]
			[FieldOffset(Offset = "0x78")]
			private AudioSource _003CcurrentSource_003E5__3;

			[Token(Token = "0x400362B")]
			[FieldOffset(Offset = "0x80")]
			private PlayingSound _003CnextPlayingSound_003E5__4;

			[Token(Token = "0x400362C")]
			[FieldOffset(Offset = "0x88")]
			private Action<bool> _003ConApplicationPause_003E5__5;

			[Token(Token = "0x1700086A")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60041A5")]
				[Address(RVA = "0xA516A0", Offset = "0xA516A0", VA = "0xA516A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700086B")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60041A7")]
				[Address(RVA = "0xA516E8", Offset = "0xA516E8", VA = "0xA516E8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60041A2")]
			[Address(RVA = "0xA510D4", Offset = "0xA510D4", VA = "0xA510D4")]
			[DebuggerHidden]
			public _003CIntroLoop_003Ed__37(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60041A3")]
			[Address(RVA = "0xA51100", Offset = "0xA51100", VA = "0xA51100", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60041A4")]
			[Address(RVA = "0xA51104", Offset = "0xA51104", VA = "0xA51104", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60041A6")]
			[Address(RVA = "0xA516A8", Offset = "0xA516A8", VA = "0xA516A8", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x2000A5F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597A04", Offset = "0x597A04")]
		private sealed class _003CRandomAutoRestart_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400362D")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400362E")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400362F")]
			[FieldOffset(Offset = "0x20")]
			public SoundContainer _003C_003E4__this;

			[Token(Token = "0x4003630")]
			[FieldOffset(Offset = "0x28")]
			public AudioBus audioBus;

			[Token(Token = "0x4003631")]
			[FieldOffset(Offset = "0x30")]
			public TimeReferential timer;

			[Token(Token = "0x4003632")]
			[FieldOffset(Offset = "0x38")]
			public Transform sourceLocation;

			[Token(Token = "0x4003633")]
			[FieldOffset(Offset = "0x40")]
			public float volume;

			[Token(Token = "0x4003634")]
			[FieldOffset(Offset = "0x44")]
			public float fadeInTime;

			[Token(Token = "0x4003635")]
			[FieldOffset(Offset = "0x48")]
			public float fadeOutTime;

			[Token(Token = "0x4003636")]
			[FieldOffset(Offset = "0x4C")]
			public bool bypassEffects;

			[Token(Token = "0x4003637")]
			[FieldOffset(Offset = "0x50")]
			public Sound.SoundStoppedDelegate onSoundStopped;

			[Token(Token = "0x4003638")]
			[FieldOffset(Offset = "0x58")]
			public PlayingSoundContainer playingContainer;

			[Token(Token = "0x4003639")]
			[FieldOffset(Offset = "0x60")]
			private PlayingSound _003CcurrentSound_003E5__2;

			[Token(Token = "0x1700086C")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60041AB")]
				[Address(RVA = "0xA519F4", Offset = "0xA519F4", VA = "0xA519F4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700086D")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60041AD")]
				[Address(RVA = "0xA51A3C", Offset = "0xA51A3C", VA = "0xA51A3C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60041A8")]
			[Address(RVA = "0xA51888", Offset = "0xA51888", VA = "0xA51888")]
			[DebuggerHidden]
			public _003CRandomAutoRestart_003Ed__38(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60041A9")]
			[Address(RVA = "0xA518B4", Offset = "0xA518B4", VA = "0xA518B4", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60041AA")]
			[Address(RVA = "0xA518B8", Offset = "0xA518B8", VA = "0xA518B8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60041AC")]
			[Address(RVA = "0xA519FC", Offset = "0xA519FC", VA = "0xA519FC", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x40035EE")]
		private const float SOUND_SPEED = 343.2f;

		[Token(Token = "0x40035EF")]
		[FieldOffset(Offset = "0x18")]
		public PlayModes PlayMode;

		[Token(Token = "0x40035F0")]
		[FieldOffset(Offset = "0x1C")]
		public bool Loop;

		[Token(Token = "0x40035F1")]
		[FieldOffset(Offset = "0x20")]
		[Decibels]
		public float Volume;

		[Token(Token = "0x40035F2")]
		[FieldOffset(Offset = "0x24")]
		public float FadeInTime;

		[Token(Token = "0x40035F3")]
		[FieldOffset(Offset = "0x28")]
		public float FadeOutTime;

		[Token(Token = "0x40035F4")]
		[FieldOffset(Offset = "0x2C")]
		public float IntroCrossFadeTime;

		[Token(Token = "0x40035F5")]
		[FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public float MinimumDelay;

		[Token(Token = "0x40035F6")]
		[FieldOffset(Offset = "0x34")]
		[HideInInspector]
		public float MaximumDelay;

		[Token(Token = "0x40035F7")]
		[FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public bool NoDelayOnStart;

		[Token(Token = "0x40035F8")]
		[FieldOffset(Offset = "0x3C")]
		public int NoRepeat;

		[Token(Token = "0x40035F9")]
		[FieldOffset(Offset = "0x40")]
		public bool BypassEffects;

		[Token(Token = "0x40035FA")]
		[FieldOffset(Offset = "0x41")]
		public bool DelayDistanceFirstSound;

		[Token(Token = "0x40035FB")]
		[FieldOffset(Offset = "0x48")]
		public AnimationCurve PlayChance;

		[Token(Token = "0x40035FC")]
		[FieldOffset(Offset = "0x50")]
		public AudioBusName AudioBusName;

		[Token(Token = "0x40035FD")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private bool _canBeKilled;

		[Token(Token = "0x40035FE")]
		[FieldOffset(Offset = "0x58")]
		private SlowMorphRandom _random;

		[Token(Token = "0x40035FF")]
		[FieldOffset(Offset = "0x60")]
		private int _index;

		[Token(Token = "0x4003600")]
		[FieldOffset(Offset = "0x68")]
		[HideInInspector]
		[SerializeField]
		private List<PlayableSound> Sounds;

		[Token(Token = "0x4003601")]
		[FieldOffset(Offset = "0x70")]
		private int _numSoundsPlayed;

		[Token(Token = "0x17000865")]
		public int Index
		{
			[Token(Token = "0x6004184")]
			[Address(RVA = "0xA6DD44", Offset = "0xA6DD44", VA = "0xA6DD44")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000866")]
		public int NumberOfSounds
		{
			[Token(Token = "0x6004185")]
			[Address(RVA = "0xA6DD4C", Offset = "0xA6DD4C", VA = "0xA6DD4C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000867")]
		public bool IsValid
		{
			[Token(Token = "0x6004188")]
			[Address(RVA = "0xA6DFAC", Offset = "0xA6DFAC", VA = "0xA6DFAC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6004186")]
		[Address(RVA = "0xA6DD98", Offset = "0xA6DD98", VA = "0xA6DD98")]
		public void ResetNumSoundsPlayed()
		{
		}

		[Token(Token = "0x6004187")]
		[Address(RVA = "0xA6DDA0", Offset = "0xA6DDA0", VA = "0xA6DDA0")]
		private PlayingSound PlayNext(AudioBus audioBus, TimeReferential timer, Transform sourceLocation, float volume, float delay, float fadeInTime, float fadeOutTime, bool loop, bool bypassEffects, Sound.SoundStoppedDelegate onSoundStopped)
		{
			return null;
		}

		[Token(Token = "0x6004189")]
		[Address(RVA = "0xA6E19C", Offset = "0xA6E19C", VA = "0xA6E19C")]
		private AudioBus GetAudioBus()
		{
			return null;
		}

		[Token(Token = "0x600418A")]
		[Address(RVA = "0xA6E344", Offset = "0xA6E344", VA = "0xA6E344")]
		public PlayingSoundContainer Play(TimeReferential timer, Transform sourceLocation)
		{
			return null;
		}

		[Token(Token = "0x600418B")]
		[Address(RVA = "0xA6E34C", Offset = "0xA6E34C", VA = "0xA6E34C")]
		public PlayingSoundContainer Play(TimeReferential timer, Transform sourceLocation, Sound.SoundStoppedDelegate onSoundStopped)
		{
			return null;
		}

		[Token(Token = "0x600418C")]
		[Address(RVA = "0xA6E440", Offset = "0xA6E440", VA = "0xA6E440")]
		public float GetDelayTime()
		{
			return default(float);
		}

		[Token(Token = "0x600418D")]
		[Address(RVA = "0xA6E884", Offset = "0xA6E884", VA = "0xA6E884")]
		public float GetLoopDelayTime()
		{
			return default(float);
		}

		[Token(Token = "0x600418E")]
		[Address(RVA = "0xA6E454", Offset = "0xA6E454", VA = "0xA6E454")]
		public PlayingSoundContainer Play(AudioBus audioBus, TimeReferential timer, Transform sourceLocation, float volume, float delay, float fadeInTime, float fadeOutTime, bool bypassEffects, Sound.SoundStoppedDelegate onSoundStopped)
		{
			return null;
		}

		[Token(Token = "0x600418F")]
		[Address(RVA = "0xA6E9C8", Offset = "0xA6E9C8", VA = "0xA6E9C8")]
		private float GetExtraTime(Transform sourceLocation)
		{
			return default(float);
		}

		[Token(Token = "0x6004190")]
		[Address(RVA = "0xA6ECA4", Offset = "0xA6ECA4", VA = "0xA6ECA4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6256F8", Offset = "0x6256F8")]
		private IEnumerator LoopSequence(PlayingSoundContainer playingContainer, AudioBus audioBus, TimeReferential timer, Transform sourceLocation, float volume, float delay, float fadeInTime, float fadeOutTime, bool bypassEffects, Sound.SoundStoppedDelegate onSoundStopped)
		{
			return null;
		}

		[Token(Token = "0x6004191")]
		[Address(RVA = "0xA6EBD0", Offset = "0xA6EBD0", VA = "0xA6EBD0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x625758", Offset = "0x625758")]
		private IEnumerator IntroLoop(PlayingSoundContainer playingContainer, AudioBus audioBus, TimeReferential timer, Transform sourceLocation, float volume, float delay, float fadeInTime, float fadeOutTime, bool bypassEffects, Sound.SoundStoppedDelegate onSoundStopped)
		{
			return null;
		}

		[Token(Token = "0x6004192")]
		[Address(RVA = "0xA6E8F8", Offset = "0xA6E8F8", VA = "0xA6E8F8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6257B8", Offset = "0x6257B8")]
		private IEnumerator RandomAutoRestart(PlayingSoundContainer playingContainer, AudioBus audioBus, TimeReferential timer, Transform sourceLocation, float volume, float fadeInTime, float fadeOutTime, bool bypassEffects, Sound.SoundStoppedDelegate onSoundStopped)
		{
			return null;
		}

		[Token(Token = "0x6004193")]
		[Address(RVA = "0xA6ED78", Offset = "0xA6ED78", VA = "0xA6ED78")]
		private bool HasValidSound(PlayingSound playingSound)
		{
			return default(bool);
		}

		[Token(Token = "0x6004194")]
		[Address(RVA = "0xA6EE08", Offset = "0xA6EE08", VA = "0xA6EE08")]
		public SoundContainer()
		{
		}
	}
}
