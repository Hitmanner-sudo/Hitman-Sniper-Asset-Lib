using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20008F9")]
public class AndroidDynamicDeviceQuality : MonoBehaviour
{
	[Token(Token = "0x20008FA")]
	public enum eSamplingFrameRateState
	{
		[Token(Token = "0x400317D")]
		eLevelLoading = 0,
		[Token(Token = "0x400317E")]
		eLevelReady = 1,
		[Token(Token = "0x400317F")]
		eSampling = 2,
		[Token(Token = "0x4003180")]
		eComplete = 3
	}

	[Token(Token = "0x20008FB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x596DD4", Offset = "0x596DD4")]
	private sealed class _003CLoadNextScene_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003181")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003182")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x17000745")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60039A0")]
			[Address(RVA = "0x9190DC", Offset = "0x9190DC", VA = "0x9190DC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000746")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60039A2")]
			[Address(RVA = "0x919124", Offset = "0x919124", VA = "0x919124", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600399D")]
		[Address(RVA = "0x918F30", Offset = "0x918F30", VA = "0x918F30")]
		[DebuggerHidden]
		public _003CLoadNextScene_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600399E")]
		[Address(RVA = "0x918F5C", Offset = "0x918F5C", VA = "0x918F5C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600399F")]
		[Address(RVA = "0x918F60", Offset = "0x918F60", VA = "0x918F60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60039A1")]
		[Address(RVA = "0x9190E4", Offset = "0x9190E4", VA = "0x9190E4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4003171")]
	[FieldOffset(Offset = "0x18")]
	public float m_SecondsToMeasureFPS;

	[Token(Token = "0x4003172")]
	[FieldOffset(Offset = "0x1C")]
	public float m_SecondsToDelayBeforeTest;

	[Token(Token = "0x4003173")]
	[FieldOffset(Offset = "0x20")]
	public int m_Target1FPSForFast;

	[Token(Token = "0x4003174")]
	[FieldOffset(Offset = "0x24")]
	public int m_Target2FPSForSimple;

	[Token(Token = "0x4003175")]
	[FieldOffset(Offset = "0x28")]
	public int m_Target3FPSForGood;

	[Token(Token = "0x4003176")]
	[FieldOffset(Offset = "0x2C")]
	public int m_Target4FPSForBeautiful;

	[Token(Token = "0x4003177")]
	[FieldOffset(Offset = "0x30")]
	public int m_Target5FPSForFantastic;

	[Token(Token = "0x4003178")]
	[FieldOffset(Offset = "0x34")]
	private int m_FPSCounterFrames;

	[Token(Token = "0x4003179")]
	[FieldOffset(Offset = "0x38")]
	private float m_fSampleStartTime;

	[Token(Token = "0x400317A")]
	[FieldOffset(Offset = "0x3C")]
	private float m_fModulestartTime;

	[Token(Token = "0x400317B")]
	[FieldOffset(Offset = "0x40")]
	private eSamplingFrameRateState m_eSamplingState;

	[Token(Token = "0x6003996")]
	[Address(RVA = "0xD6C084", Offset = "0xD6C084", VA = "0xD6C084")]
	private void OnLevelWasLoaded(int level)
	{
	}

	[Token(Token = "0x6003997")]
	[Address(RVA = "0xD6C144", Offset = "0xD6C144", VA = "0xD6C144")]
	private void Update()
	{
	}

	[Token(Token = "0x6003998")]
	[Address(RVA = "0xD6C490", Offset = "0xD6C490", VA = "0xD6C490")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x624610", Offset = "0x624610")]
	private IEnumerator LoadNextScene()
	{
		return null;
	}

	[Token(Token = "0x6003999")]
	[Address(RVA = "0xD6C1FC", Offset = "0xD6C1FC", VA = "0xD6C1FC")]
	private void TickSamplingFrameRate()
	{
	}

	[Token(Token = "0x600399A")]
	[Address(RVA = "0xD6C1C8", Offset = "0xD6C1C8", VA = "0xD6C1C8")]
	public void StartSamplingFrameRate()
	{
	}

	[Token(Token = "0x600399B")]
	[Address(RVA = "0xD6C4EC", Offset = "0xD6C4EC", VA = "0xD6C4EC")]
	public void StopSamplingFrameRate()
	{
	}

	[Token(Token = "0x600399C")]
	[Address(RVA = "0xD6C4FC", Offset = "0xD6C4FC", VA = "0xD6C4FC")]
	public AndroidDynamicDeviceQuality()
	{
	}
}
