using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology
{
	[Serializable]
	[Token(Token = "0x2000A52")]
	public class Sound
	{
		[Token(Token = "0x2000A53")]
		public class SoundEventArgs : EventArgs
		{
			[Token(Token = "0x40035C4")]
			[FieldOffset(Offset = "0x10")]
			public string Name;

			[Token(Token = "0x6004168")]
			[Address(RVA = "0xA50710", Offset = "0xA50710", VA = "0xA50710")]
			public SoundEventArgs()
			{
			}
		}

		[Token(Token = "0x2000A54")]
		public delegate void SoundStoppedDelegate(Sound sound, string ClipName);

		[Token(Token = "0x2000A55")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597994", Offset = "0x597994")]
		private sealed class _003CFade_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40035C5")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40035C6")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40035C7")]
			[FieldOffset(Offset = "0x20")]
			public AudioBus audioBus;

			[Token(Token = "0x40035C8")]
			[FieldOffset(Offset = "0x28")]
			public float volume;

			[Token(Token = "0x40035C9")]
			[FieldOffset(Offset = "0x30")]
			public SoundInstance audioInstance;

			[Token(Token = "0x40035CA")]
			[FieldOffset(Offset = "0x38")]
			public TimeReferential timeReferential;

			[Token(Token = "0x40035CB")]
			[FieldOffset(Offset = "0x40")]
			public float fadeInTime;

			[Token(Token = "0x40035CC")]
			[FieldOffset(Offset = "0x48")]
			public Sound _003C_003E4__this;

			[Token(Token = "0x40035CD")]
			[FieldOffset(Offset = "0x50")]
			public SoundStoppedDelegate onSoundStopped;

			[Token(Token = "0x40035CE")]
			[FieldOffset(Offset = "0x58")]
			public float fadeOutTime;

			[Token(Token = "0x40035CF")]
			[FieldOffset(Offset = "0x5C")]
			private float _003ClastBusVolume_003E5__2;

			[Token(Token = "0x40035D0")]
			[FieldOffset(Offset = "0x60")]
			private float _003CinitialVolume_003E5__3;

			[Token(Token = "0x40035D1")]
			[FieldOffset(Offset = "0x68")]
			private Timer _003Ctimer_003E5__4;

			[Token(Token = "0x40035D2")]
			[FieldOffset(Offset = "0x70")]
			private float _003CfadeStartVolume_003E5__5;

			[Token(Token = "0x1700085D")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004170")]
				[Address(RVA = "0xA50B08", Offset = "0xA50B08", VA = "0xA50B08", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700085E")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004172")]
				[Address(RVA = "0xA50B50", Offset = "0xA50B50", VA = "0xA50B50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600416D")]
			[Address(RVA = "0xA4FE58", Offset = "0xA4FE58", VA = "0xA4FE58")]
			[DebuggerHidden]
			public _003CFade_003Ed__16(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600416E")]
			[Address(RVA = "0xA4FE84", Offset = "0xA4FE84", VA = "0xA4FE84", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600416F")]
			[Address(RVA = "0xA4FE88", Offset = "0xA4FE88", VA = "0xA4FE88", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6004171")]
			[Address(RVA = "0xA50B10", Offset = "0xA50B10", VA = "0xA50B10", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x2000A56")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5979A4", Offset = "0x5979A4")]
		private sealed class _003CPlayDelayed_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40035D3")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40035D4")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40035D5")]
			[FieldOffset(Offset = "0x20")]
			public TimeReferential timer;

			[Token(Token = "0x40035D6")]
			[FieldOffset(Offset = "0x28")]
			public float delay;

			[Token(Token = "0x40035D7")]
			[FieldOffset(Offset = "0x30")]
			public Sound _003C_003E4__this;

			[Token(Token = "0x40035D8")]
			[FieldOffset(Offset = "0x38")]
			public SoundInstance audioInstance;

			[Token(Token = "0x40035D9")]
			[FieldOffset(Offset = "0x40")]
			public AudioBus audioBus;

			[Token(Token = "0x40035DA")]
			[FieldOffset(Offset = "0x48")]
			public Transform sourceLocation;

			[Token(Token = "0x40035DB")]
			[FieldOffset(Offset = "0x50")]
			public float volume;

			[Token(Token = "0x40035DC")]
			[FieldOffset(Offset = "0x54")]
			public bool loop;

			[Token(Token = "0x40035DD")]
			[FieldOffset(Offset = "0x55")]
			public bool bypassEffects;

			[Token(Token = "0x40035DE")]
			[FieldOffset(Offset = "0x56")]
			public bool canBeKilled;

			[Token(Token = "0x40035DF")]
			[FieldOffset(Offset = "0x58")]
			public float fadeInTime;

			[Token(Token = "0x40035E0")]
			[FieldOffset(Offset = "0x5C")]
			public float fadeOutTime;

			[Token(Token = "0x40035E1")]
			[FieldOffset(Offset = "0x60")]
			public SoundStoppedDelegate onSoundStopped;

			[Token(Token = "0x40035E2")]
			[FieldOffset(Offset = "0x68")]
			private float _003CendTime_003E5__2;

			[Token(Token = "0x1700085F")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004176")]
				[Address(RVA = "0xA50F30", Offset = "0xA50F30", VA = "0xA50F30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000860")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004178")]
				[Address(RVA = "0xA50F78", Offset = "0xA50F78", VA = "0xA50F78", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6004173")]
			[Address(RVA = "0xA50B58", Offset = "0xA50B58", VA = "0xA50B58")]
			[DebuggerHidden]
			public _003CPlayDelayed_003Ed__17(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004174")]
			[Address(RVA = "0xA50B84", Offset = "0xA50B84", VA = "0xA50B84", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004175")]
			[Address(RVA = "0xA50B88", Offset = "0xA50B88", VA = "0xA50B88", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6004177")]
			[Address(RVA = "0xA50F38", Offset = "0xA50F38", VA = "0xA50F38", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x40035C2")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private LazyAudioClip Clip;

		[Token(Token = "0x40035C3")]
		[FieldOffset(Offset = "0x18")]
		private string _clipName;

		[Token(Token = "0x1700085B")]
		public string ClipName
		{
			[Token(Token = "0x600415F")]
			[Address(RVA = "0xA6D528", Offset = "0xA6D528", VA = "0xA6D528")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700085C")]
		public bool IsValid
		{
			[Token(Token = "0x6004162")]
			[Address(RVA = "0xA6DA30", Offset = "0xA6DA30", VA = "0xA6DA30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x140000B6")]
		public static event EventHandler<SoundEventArgs> OnSoundPlay
		{
			[Token(Token = "0x600415B")]
			[Address(RVA = "0xA6D230", Offset = "0xA6D230", VA = "0xA6D230")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625498", Offset = "0x625498")]
			add
			{
			}
			[Token(Token = "0x600415C")]
			[Address(RVA = "0xA6D2EC", Offset = "0xA6D2EC", VA = "0xA6D2EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6254A8", Offset = "0x6254A8")]
			remove
			{
			}
		}

		[Token(Token = "0x140000B7")]
		public static event EventHandler<SoundEventArgs> OnSoundStop
		{
			[Token(Token = "0x600415D")]
			[Address(RVA = "0xA6D3A8", Offset = "0xA6D3A8", VA = "0xA6D3A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6254B8", Offset = "0x6254B8")]
			add
			{
			}
			[Token(Token = "0x600415E")]
			[Address(RVA = "0xA6D468", Offset = "0xA6D468", VA = "0xA6D468")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6254C8", Offset = "0x6254C8")]
			remove
			{
			}
		}

		[Token(Token = "0x6004160")]
		[Address(RVA = "0xA6D5AC", Offset = "0xA6D5AC", VA = "0xA6D5AC")]
		public Sound(LazyAudioClip clip)
		{
		}

		[Token(Token = "0x6004161")]
		[Address(RVA = "0xA6D69C", Offset = "0xA6D69C", VA = "0xA6D69C")]
		public SoundInstance Play(AudioBus audioBus, TimeReferential timer, Transform sourceLocation, float volume, float delay, float fadeInTime, float fadeOutTime, bool loop, bool bypassEffects, bool canBeKilled, SoundStoppedDelegate onSoundStopped)
		{
			return null;
		}

		[Token(Token = "0x6004163")]
		[Address(RVA = "0xA6DA80", Offset = "0xA6DA80", VA = "0xA6DA80")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6254D8", Offset = "0x6254D8")]
		private IEnumerator Fade(AudioBus audioBus, SoundInstance audioInstance, TimeReferential timeReferential, float fadeInTime, float fadeOutTime, float volume, SoundStoppedDelegate onSoundStopped)
		{
			return null;
		}

		[Token(Token = "0x6004164")]
		[Address(RVA = "0xA6D934", Offset = "0xA6D934", VA = "0xA6D934")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x625538", Offset = "0x625538")]
		private IEnumerator PlayDelayed(AudioBus audioBus, SoundInstance audioInstance, TimeReferential timer, Transform sourceLocation, float volume, float delay, float fadeInTime, float fadeOutTime, bool loop, bool bypassEffects, bool canBeKilled, SoundStoppedDelegate onSoundStopped)
		{
			return null;
		}

		[Token(Token = "0x6004165")]
		[Address(RVA = "0xA6DB3C", Offset = "0xA6DB3C", VA = "0xA6DB3C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6004166")]
		[Address(RVA = "0xA6DBB4", Offset = "0xA6DBB4", VA = "0xA6DBB4")]
		private void AdjustVolumeWithBusVolume(float initialVolume, ref float currentVolume, float currentBusVolume, ref float lastBusVolume, SoundInstance audioInstance)
		{
		}

		[Token(Token = "0x6004167")]
		[Address(RVA = "0xA6DCD8", Offset = "0xA6DCD8", VA = "0xA6DCD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625598", Offset = "0x625598")]
		private SoundEventArgs _003CPlay_003Eb__13_0()
		{
			return null;
		}
	}
}
