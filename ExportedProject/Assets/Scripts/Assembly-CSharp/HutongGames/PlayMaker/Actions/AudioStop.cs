using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F2C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59BDF8", Offset = "0x59BDF8")]
	[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x59BDF8", Offset = "0x59BDF8")]
	public class AudioStop : ComponentAction<AudioSource>
	{
		[Token(Token = "0x2000F2D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59BE48", Offset = "0x59BE48")]
		private sealed class _003CVolumeFade_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40047A1")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40047A2")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40047A3")]
			[FieldOffset(Offset = "0x20")]
			public float fadeDuration;

			[Token(Token = "0x40047A4")]
			[FieldOffset(Offset = "0x28")]
			public AudioSource audioSource;

			[Token(Token = "0x40047A5")]
			[FieldOffset(Offset = "0x30")]
			public AudioStop _003C_003E4__this;

			[Token(Token = "0x40047A6")]
			[FieldOffset(Offset = "0x38")]
			public float endVolume;

			[Token(Token = "0x40047A7")]
			[FieldOffset(Offset = "0x3C")]
			private float _003CstartTime_003E5__2;

			[Token(Token = "0x17000C22")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6005D0A")]
				[Address(RVA = "0x925750", Offset = "0x925750", VA = "0x925750", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000C23")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6005D0C")]
				[Address(RVA = "0x925798", Offset = "0x925798", VA = "0x925798", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6005D07")]
			[Address(RVA = "0x9255E4", Offset = "0x9255E4", VA = "0x9255E4")]
			[DebuggerHidden]
			public _003CVolumeFade_003Ed__5(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005D08")]
			[Address(RVA = "0x925610", Offset = "0x925610", VA = "0x925610", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6005D09")]
			[Address(RVA = "0x925614", Offset = "0x925614", VA = "0x925614", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6005D0B")]
			[Address(RVA = "0x925758", Offset = "0x925758", VA = "0x925758", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x400479E")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CheckForComponentAttribute", RVA = "0x5CBC14", Offset = "0x5CBC14")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5CBC14", Offset = "0x5CBC14")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400479F")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5CBCA8", Offset = "0x5CBCA8")]
		public FsmFloat fadeTime;

		[Token(Token = "0x40047A0")]
		[FieldOffset(Offset = "0x78")]
		private float volume;

		[Token(Token = "0x6005D03")]
		[Address(RVA = "0xC0A0A0", Offset = "0xC0A0A0", VA = "0xC0A0A0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005D04")]
		[Address(RVA = "0xC0A0A8", Offset = "0xC0A0A8", VA = "0xC0A0A8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005D05")]
		[Address(RVA = "0xC0A1D4", Offset = "0xC0A1D4", VA = "0xC0A1D4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x62BF70", Offset = "0x62BF70")]
		private IEnumerator VolumeFade(AudioSource audioSource, float endVolume, float fadeDuration)
		{
			return null;
		}

		[Token(Token = "0x6005D06")]
		[Address(RVA = "0xC0A264", Offset = "0xC0A264", VA = "0xC0A264")]
		public AudioStop()
		{
		}
	}
}
