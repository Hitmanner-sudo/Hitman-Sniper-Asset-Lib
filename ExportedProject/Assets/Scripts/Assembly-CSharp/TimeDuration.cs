using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x200042A")]
public class TimeDuration : Perk
{
	[Token(Token = "0x200042B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593C00", Offset = "0x593C00")]
	private sealed class _003CCheckDuration_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400171B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400171C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400171D")]
		[FieldOffset(Offset = "0x20")]
		public TimeDuration _003C_003E4__this;

		[Token(Token = "0x17000417")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60019A0")]
			[Address(RVA = "0xA37478", Offset = "0xA37478", VA = "0xA37478", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000418")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60019A2")]
			[Address(RVA = "0xA374C0", Offset = "0xA374C0", VA = "0xA374C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600199D")]
		[Address(RVA = "0xA372CC", Offset = "0xA372CC", VA = "0xA372CC")]
		[DebuggerHidden]
		public _003CCheckDuration_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600199E")]
		[Address(RVA = "0xA372F8", Offset = "0xA372F8", VA = "0xA372F8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600199F")]
		[Address(RVA = "0xA372FC", Offset = "0xA372FC", VA = "0xA372FC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60019A1")]
		[Address(RVA = "0xA37480", Offset = "0xA37480", VA = "0xA37480", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4001715")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	private float _durationInMinutes;

	[Token(Token = "0x4001716")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private ModelContainer _modelContainer;

	[Token(Token = "0x4001717")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private bool _requiresPerfectEfficiency;

	[Token(Token = "0x4001718")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	private ContractDataModel.DifficultyType _difficultyType;

	[Token(Token = "0x4001719")]
	[FieldOffset(Offset = "0x68")]
	private Coroutine _checkDurationCoroutine;

	[Token(Token = "0x400171A")]
	[FieldOffset(Offset = "0x70")]
	private GameTimer _gameTimer;

	[Token(Token = "0x17000416")]
	public override string GetDescription
	{
		[Token(Token = "0x6001995")]
		[Address(RVA = "0xACF418", Offset = "0xACF418", VA = "0xACF418", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001996")]
	[Address(RVA = "0xACF4C8", Offset = "0xACF4C8", VA = "0xACF4C8", Slot = "10")]
	public override void DoStart()
	{
	}

	[Token(Token = "0x6001997")]
	[Address(RVA = "0xACF698", Offset = "0xACF698", VA = "0xACF698", Slot = "11")]
	public override void DoStop()
	{
	}

	[Token(Token = "0x6001998")]
	[Address(RVA = "0xACF760", Offset = "0xACF760", VA = "0xACF760")]
	private void OnGameStarted(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6001999")]
	[Address(RVA = "0xACF9D4", Offset = "0xACF9D4", VA = "0xACF9D4")]
	private void OnGameEnded(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x600199A")]
	[Address(RVA = "0xACF590", Offset = "0xACF590", VA = "0xACF590")]
	private void CleanUp()
	{
	}

	[Token(Token = "0x600199B")]
	[Address(RVA = "0xACF968", Offset = "0xACF968", VA = "0xACF968")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x617744", Offset = "0x617744")]
	private IEnumerator CheckDuration()
	{
		return null;
	}

	[Token(Token = "0x600199C")]
	[Address(RVA = "0xACF9D8", Offset = "0xACF9D8", VA = "0xACF9D8")]
	public TimeDuration()
	{
	}
}
