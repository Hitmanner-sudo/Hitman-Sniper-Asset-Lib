using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology
{
	[Serializable]
	[Token(Token = "0x2000A57")]
	public class SoundInstance
	{
		[Token(Token = "0x2000A58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5979B4", Offset = "0x5979B4")]
		private sealed class _003CFade_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40035EB")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40035EC")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40035ED")]
			[FieldOffset(Offset = "0x20")]
			public SoundInstance _003C_003E4__this;

			[Token(Token = "0x17000863")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004181")]
				[Address(RVA = "0xA51BB8", Offset = "0xA51BB8", VA = "0xA51BB8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000864")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004183")]
				[Address(RVA = "0xA51C00", Offset = "0xA51C00", VA = "0xA51C00", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600417E")]
			[Address(RVA = "0xA51A44", Offset = "0xA51A44", VA = "0xA51A44")]
			[DebuggerHidden]
			public _003CFade_003Ed__13(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600417F")]
			[Address(RVA = "0xA51A70", Offset = "0xA51A70", VA = "0xA51A70", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004180")]
			[Address(RVA = "0xA51A74", Offset = "0xA51A74", VA = "0xA51A74", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6004182")]
			[Address(RVA = "0xA51BC0", Offset = "0xA51BC0", VA = "0xA51BC0", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x40035E3")]
		[FieldOffset(Offset = "0x10")]
		public ActiveAudioSource SourceHandle;

		[Token(Token = "0x40035E4")]
		[FieldOffset(Offset = "0x18")]
		public bool Stop;

		[Token(Token = "0x40035E5")]
		[FieldOffset(Offset = "0x19")]
		public bool Finished;

		[Token(Token = "0x40035E6")]
		[FieldOffset(Offset = "0x1A")]
		public bool StopImmediate;

		[Token(Token = "0x40035E7")]
		[FieldOffset(Offset = "0x20")]
		private Coroutine _fadeCoroutine;

		[Token(Token = "0x40035E8")]
		[FieldOffset(Offset = "0x28")]
		private float _fadeFrom;

		[Token(Token = "0x40035E9")]
		[FieldOffset(Offset = "0x2C")]
		private float _fadeTo;

		[Token(Token = "0x40035EA")]
		[FieldOffset(Offset = "0x30")]
		private ContinuousTimer _timer;

		[Token(Token = "0x17000861")]
		public bool IsValid
		{
			[Token(Token = "0x6004179")]
			[Address(RVA = "0xA6DC54", Offset = "0xA6DC54", VA = "0xA6DC54")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000862")]
		public bool IsStopped
		{
			[Token(Token = "0x600417A")]
			[Address(RVA = "0xA6F184", Offset = "0xA6F184", VA = "0xA6F184")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600417B")]
		[Address(RVA = "0xA6F1CC", Offset = "0xA6F1CC", VA = "0xA6F1CC")]
		public void Fade(float wantedVolume, float duration)
		{
		}

		[Token(Token = "0x600417C")]
		[Address(RVA = "0xA6F38C", Offset = "0xA6F38C", VA = "0xA6F38C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x625648", Offset = "0x625648")]
		private IEnumerator Fade()
		{
			return null;
		}

		[Token(Token = "0x600417D")]
		[Address(RVA = "0xA6D924", Offset = "0xA6D924", VA = "0xA6D924")]
		public SoundInstance()
		{
		}
	}
}
