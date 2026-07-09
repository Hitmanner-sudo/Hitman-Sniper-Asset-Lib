using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;
using UnityEngine;

[Token(Token = "0x200084C")]
public class GenerateRandomScoresAction
{
	[Token(Token = "0x200084D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5968A0", Offset = "0x5968A0")]
	private sealed class _003CDoGenerate_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002ED8")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002ED9")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002EDA")]
		[FieldOffset(Offset = "0x20")]
		public GenerateRandomScoresAction _003C_003E4__this;

		[Token(Token = "0x4002EDB")]
		[FieldOffset(Offset = "0x28")]
		public int numToGenerate;

		[Token(Token = "0x4002EDC")]
		[FieldOffset(Offset = "0x30")]
		public MonoBehaviour coroutineObj;

		[Token(Token = "0x4002EDD")]
		[FieldOffset(Offset = "0x38")]
		public int leaderboardId;

		[Token(Token = "0x4002EDE")]
		[FieldOffset(Offset = "0x3C")]
		public int minScore;

		[Token(Token = "0x4002EDF")]
		[FieldOffset(Offset = "0x40")]
		public int maxScore;

		[Token(Token = "0x4002EE0")]
		[FieldOffset(Offset = "0x44")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x170006E7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003641")]
			[Address(RVA = "0x8738E4", Offset = "0x8738E4", VA = "0x8738E4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006E8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003643")]
			[Address(RVA = "0x87392C", Offset = "0x87392C", VA = "0x87392C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600363E")]
		[Address(RVA = "0x8737D8", Offset = "0x8737D8", VA = "0x8737D8")]
		[DebuggerHidden]
		public _003CDoGenerate_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600363F")]
		[Address(RVA = "0x873804", Offset = "0x873804", VA = "0x873804", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003640")]
		[Address(RVA = "0x873808", Offset = "0x873808", VA = "0x873808", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003642")]
		[Address(RVA = "0x8738EC", Offset = "0x8738EC", VA = "0x8738EC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200084E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5968B0", Offset = "0x5968B0")]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		[Token(Token = "0x4002EE1")]
		[FieldOffset(Offset = "0x10")]
		public bool createDone;

		[Token(Token = "0x4002EE2")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, string> profile;

		[Token(Token = "0x4002EE3")]
		[FieldOffset(Offset = "0x20")]
		public StringBuilder sb;

		[Token(Token = "0x4002EE4")]
		[FieldOffset(Offset = "0x28")]
		public int score;

		[Token(Token = "0x4002EE5")]
		[FieldOffset(Offset = "0x2C")]
		public bool setScoreDone;

		[Token(Token = "0x6003644")]
		[Address(RVA = "0x873654", Offset = "0x873654", VA = "0x873654")]
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		[Token(Token = "0x6003645")]
		[Address(RVA = "0x87365C", Offset = "0x87365C", VA = "0x87365C")]
		internal void _003CGenerateOne_003Eb__0(object result)
		{
		}

		[Token(Token = "0x6003646")]
		[Address(RVA = "0x8736F0", Offset = "0x8736F0", VA = "0x8736F0")]
		internal void _003CGenerateOne_003Eb__1(bool res)
		{
		}
	}

	[Token(Token = "0x200084F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5968C0", Offset = "0x5968C0")]
	private sealed class _003CGenerateOne_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002EE6")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002EE7")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002EE8")]
		[FieldOffset(Offset = "0x20")]
		public GenerateRandomScoresAction _003C_003E4__this;

		[Token(Token = "0x4002EE9")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass14_0 _003C_003E8__1;

		[Token(Token = "0x4002EEA")]
		[FieldOffset(Offset = "0x30")]
		public int minScore;

		[Token(Token = "0x4002EEB")]
		[FieldOffset(Offset = "0x34")]
		public int maxScore;

		[Token(Token = "0x4002EEC")]
		[FieldOffset(Offset = "0x38")]
		public int leaderboardId;

		[Token(Token = "0x170006E9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600364A")]
			[Address(RVA = "0x873CA0", Offset = "0x873CA0", VA = "0x873CA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006EA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600364C")]
			[Address(RVA = "0x873CE8", Offset = "0x873CE8", VA = "0x873CE8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003647")]
		[Address(RVA = "0x873934", Offset = "0x873934", VA = "0x873934")]
		[DebuggerHidden]
		public _003CGenerateOne_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003648")]
		[Address(RVA = "0x873960", Offset = "0x873960", VA = "0x873960", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003649")]
		[Address(RVA = "0x873964", Offset = "0x873964", VA = "0x873964", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600364B")]
		[Address(RVA = "0x873CA8", Offset = "0x873CA8", VA = "0x873CA8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000850")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5968D0", Offset = "0x5968D0")]
	private sealed class _003C_003Ec__DisplayClass17_0
	{
		[Token(Token = "0x4002EED")]
		[FieldOffset(Offset = "0x10")]
		public SvcOpSetPlayerScore op;

		[Token(Token = "0x4002EEE")]
		[FieldOffset(Offset = "0x18")]
		public int leaderboardId;

		[Token(Token = "0x4002EEF")]
		[FieldOffset(Offset = "0x20")]
		public string uid;

		[Token(Token = "0x4002EF0")]
		[FieldOffset(Offset = "0x28")]
		public int score;

		[Token(Token = "0x600364D")]
		[Address(RVA = "0x8737A0", Offset = "0x8737A0", VA = "0x8737A0")]
		public _003C_003Ec__DisplayClass17_0()
		{
		}

		[Token(Token = "0x600364E")]
		[Address(RVA = "0x8737A8", Offset = "0x8737A8", VA = "0x8737A8")]
		internal void _003CSetScore_003Eb__0()
		{
		}
	}

	[Token(Token = "0x4002ED0")]
	private const string ON_COMPLETE_KEY = "onComplete";

	[Token(Token = "0x4002ED1")]
	private const string UID_KEY = "uid";

	[Token(Token = "0x4002ED2")]
	private const string UUID_KEY = "uuid";

	[Token(Token = "0x4002ED3")]
	private const string RESPONSE_UID_KEY = "_id";

	[Token(Token = "0x4002ED4")]
	private const string RESPONSE_UUID_KEY = "s_uuid";

	[Token(Token = "0x4002ED5")]
	[FieldOffset(Offset = "0x10")]
	private Coroutine _coroutine;

	[Token(Token = "0x4002ED6")]
	[FieldOffset(Offset = "0x18")]
	private bool _finished;

	[Token(Token = "0x4002ED7")]
	[FieldOffset(Offset = "0x1C")]
	private int _remaining;

	[Token(Token = "0x170006E5")]
	public bool IsFinished
	{
		[Token(Token = "0x6003634")]
		[Address(RVA = "0xD9D720", Offset = "0xD9D720", VA = "0xD9D720")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170006E6")]
	public int Remaining
	{
		[Token(Token = "0x6003635")]
		[Address(RVA = "0xD9D740", Offset = "0xD9D740", VA = "0xD9D740")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6003636")]
	[Address(RVA = "0xD9D748", Offset = "0xD9D748", VA = "0xD9D748")]
	public void Generate(int leaderboardId, int minScore, int maxScore, int numToGenerate, MonoBehaviour coroutineObj)
	{
	}

	[Token(Token = "0x6003637")]
	[Address(RVA = "0xD9D790", Offset = "0xD9D790", VA = "0xD9D790")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x623320", Offset = "0x623320")]
	private IEnumerator DoGenerate(int leaderboardId, int minScore, int maxScore, int numToGenerate, MonoBehaviour coroutineObj)
	{
		return null;
	}

	[Token(Token = "0x6003638")]
	[Address(RVA = "0xD9D838", Offset = "0xD9D838", VA = "0xD9D838")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x623380", Offset = "0x623380")]
	private IEnumerator GenerateOne(int leaderboardId, int minScore, int maxScore)
	{
		return null;
	}

	[Token(Token = "0x6003639")]
	[Address(RVA = "0xD9D8C8", Offset = "0xD9D8C8", VA = "0xD9D8C8")]
	private void CreateProfile(Action<object> onComplete)
	{
	}

	[Token(Token = "0x600363A")]
	[Address(RVA = "0xD9DAAC", Offset = "0xD9DAAC", VA = "0xD9DAAC")]
	private void OnCreateProfileDone(IResponseContext response, IRequestContext request, OSRequestState state, Dictionary<string, object> meta)
	{
	}

	[Token(Token = "0x600363B")]
	[Address(RVA = "0xD9DFD0", Offset = "0xD9DFD0", VA = "0xD9DFD0")]
	private void SetScore(int leaderboardId, string uid, int score, Action<bool> onComplete)
	{
	}

	[Token(Token = "0x600363C")]
	[Address(RVA = "0xD9E200", Offset = "0xD9E200", VA = "0xD9E200")]
	private void OnPostScoreDone(IResponseContext response, IRequestContext request, OSRequestState state, Dictionary<string, object> meta)
	{
	}

	[Token(Token = "0x600363D")]
	[Address(RVA = "0xD9E2C4", Offset = "0xD9E2C4", VA = "0xD9E2C4")]
	public GenerateRandomScoresAction()
	{
	}
}
