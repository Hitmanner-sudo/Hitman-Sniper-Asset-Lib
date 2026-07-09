using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x200031A")]
public class TriggerSpawn : GameMonoBehaviour
{
	[Token(Token = "0x200031B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5933B4", Offset = "0x5933B4")]
	private sealed class _003CSpawn_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400115D")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400115E")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400115F")]
		[FieldOffset(Offset = "0x20")]
		public TriggerSpawn _003C_003E4__this;

		[Token(Token = "0x170002CC")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001313")]
			[Address(RVA = "0xA38FA4", Offset = "0xA38FA4", VA = "0xA38FA4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002CD")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001315")]
			[Address(RVA = "0xA38FEC", Offset = "0xA38FEC", VA = "0xA38FEC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001310")]
		[Address(RVA = "0xA38D74", Offset = "0xA38D74", VA = "0xA38D74")]
		[DebuggerHidden]
		public _003CSpawn_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001311")]
		[Address(RVA = "0xA38DA0", Offset = "0xA38DA0", VA = "0xA38DA0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001312")]
		[Address(RVA = "0xA38DA4", Offset = "0xA38DA4", VA = "0xA38DA4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001314")]
		[Address(RVA = "0xA38FAC", Offset = "0xA38FAC", VA = "0xA38FAC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4001155")]
	[FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x5B4270", Offset = "0x5B4270")]
	public AICharacterSpawner[] Spawners;

	[Token(Token = "0x4001156")]
	[FieldOffset(Offset = "0x50")]
	public bool TriggerOnce;

	[Token(Token = "0x4001157")]
	[FieldOffset(Offset = "0x51")]
	public bool PickRandom;

	[Token(Token = "0x4001158")]
	[FieldOffset(Offset = "0x54")]
	public float Delay;

	[Token(Token = "0x4001159")]
	[FieldOffset(Offset = "0x58")]
	public float Cooldown;

	[Token(Token = "0x400115A")]
	[FieldOffset(Offset = "0x60")]
	public Faction Faction;

	[Token(Token = "0x400115B")]
	[FieldOffset(Offset = "0x68")]
	private float _lastSpawnTime;

	[Token(Token = "0x400115C")]
	[FieldOffset(Offset = "0x70")]
	private GameTimer _timer;

	[Token(Token = "0x600130D")]
	[Address(RVA = "0xC9F684", Offset = "0xC9F684", VA = "0xC9F684")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600130E")]
	[Address(RVA = "0xC9F7CC", Offset = "0xC9F7CC", VA = "0xC9F7CC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x616A84", Offset = "0x616A84")]
	private IEnumerator Spawn()
	{
		return null;
	}

	[Token(Token = "0x600130F")]
	[Address(RVA = "0xC9F838", Offset = "0xC9F838", VA = "0xC9F838")]
	public TriggerSpawn()
	{
	}
}
