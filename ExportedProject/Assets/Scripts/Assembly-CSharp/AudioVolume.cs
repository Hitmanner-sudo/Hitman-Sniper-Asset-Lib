using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x200013E")]
public class AudioVolume : CompositeTrigger, AStarSearch<AudioVolume, AudioVolume.SearchContext>.ISearchNode
{
	[Token(Token = "0x200013F")]
	public class SearchContext
	{
		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x925ADC", Offset = "0x925ADC", VA = "0x925ADC")]
		public SearchContext()
		{
		}
	}

	[Token(Token = "0x2000140")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5925EC", Offset = "0x5925EC")]
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		[Token(Token = "0x40006DD")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 position;

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x9257A0", Offset = "0x9257A0", VA = "0x9257A0")]
		public _003C_003Ec__DisplayClass9_0()
		{
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x9257A8", Offset = "0x9257A8", VA = "0x9257A8")]
		internal bool _003CGetVolumesAt_003Eb__0(AudioVolume x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000141")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5925FC", Offset = "0x5925FC")]
	private sealed class _003CGetConnections_003Ed__10 : IEnumerable<AStarSearch<AudioVolume, SearchContext>.Connection>, IEnumerable, IEnumerator<AStarSearch<AudioVolume, SearchContext>.Connection>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006DE")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40006DF")]
		[FieldOffset(Offset = "0x18")]
		private AStarSearch<AudioVolume, SearchContext>.Connection _003C_003E2__current;

		[Token(Token = "0x40006E0")]
		[FieldOffset(Offset = "0x28")]
		private int _003C_003El__initialThreadId;

		[Token(Token = "0x40006E1")]
		[FieldOffset(Offset = "0x30")]
		public AudioVolume _003C_003E4__this;

		[Token(Token = "0x40006E2")]
		[FieldOffset(Offset = "0x38")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x1700016A")]
		private AStarSearch<AudioVolume, SearchContext>.Connection System_002ECollections_002EGeneric_002EIEnumerator_003CTechnology_002EAStarSearch_003CAudioVolume_002CAudioVolume_002ESearchContext_003E_002EConnection_003E_002ECurrent
		{
			[Token(Token = "0x60008A7")]
			[Address(RVA = "0x925984", Offset = "0x925984", VA = "0x925984", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(AStarSearch<AudioVolume, SearchContext>.Connection);
			}
		}

		[Token(Token = "0x1700016B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60008A9")]
			[Address(RVA = "0x9259D0", Offset = "0x9259D0", VA = "0x9259D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x9257CC", Offset = "0x9257CC", VA = "0x9257CC")]
		[DebuggerHidden]
		public _003CGetConnections_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x925804", Offset = "0x925804", VA = "0x925804", Slot = "7")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x925808", Offset = "0x925808", VA = "0x925808", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x925990", Offset = "0x925990", VA = "0x925990", Slot = "10")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x925A30", Offset = "0x925A30", VA = "0x925A30", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<AStarSearch<AudioVolume, SearchContext>.Connection> System_002ECollections_002EGeneric_002EIEnumerable_003CTechnology_002EAStarSearch_003CAudioVolume_002CAudioVolume_002ESearchContext_003E_002EConnection_003E_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x925AD8", Offset = "0x925AD8", VA = "0x925AD8", Slot = "5")]
		[DebuggerHidden]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x40006DB")]
	[FieldOffset(Offset = "0x60")]
	[HideInInspector]
	public List<AudioVolume> ConnectedVolumes;

	[NonSerialized]
	[Token(Token = "0x40006DC")]
	[FieldOffset(Offset = "0x68")]
	public List<AISensor> SensorsInside;

	[Token(Token = "0x6000897")]
	[Address(RVA = "0xC0A2B0", Offset = "0xC0A2B0", VA = "0xC0A2B0", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000898")]
	[Address(RVA = "0xC0A380", Offset = "0xC0A380", VA = "0xC0A380", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000899")]
	[Address(RVA = "0xC0A44C", Offset = "0xC0A44C", VA = "0xC0A44C")]
	protected void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600089A")]
	[Address(RVA = "0xC0A56C", Offset = "0xC0A56C", VA = "0xC0A56C")]
	protected void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600089B")]
	[Address(RVA = "0xC0A690", Offset = "0xC0A690", VA = "0xC0A690")]
	public void OnSensorDestroyed(AISensor sensor)
	{
	}

	[Token(Token = "0x600089C")]
	[Address(RVA = "0xC0A6F4", Offset = "0xC0A6F4", VA = "0xC0A6F4")]
	public bool Contains(Vector3 position)
	{
		return default(bool);
	}

	[Token(Token = "0x600089D")]
	[Address(RVA = "0xC0A7F0", Offset = "0xC0A7F0", VA = "0xC0A7F0")]
	public static List<AudioVolume> GetVolumesAt(Vector3 position)
	{
		return null;
	}

	[Token(Token = "0x600089E")]
	[Address(RVA = "0xC0A92C", Offset = "0xC0A92C", VA = "0xC0A92C", Slot = "14")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6127D8", Offset = "0x6127D8")]
	public IEnumerable<AStarSearch<AudioVolume, SearchContext>.Connection> GetConnections(SearchContext context)
	{
		return null;
	}

	[Token(Token = "0x600089F")]
	[Address(RVA = "0xC0A998", Offset = "0xC0A998", VA = "0xC0A998", Slot = "15")]
	public float EstimateCostToDestination(AudioVolume destination, SearchContext context)
	{
		return default(float);
	}

	[Token(Token = "0x60008A0")]
	[Address(RVA = "0xC0AA28", Offset = "0xC0AA28", VA = "0xC0AA28")]
	public AudioVolume()
	{
	}
}
