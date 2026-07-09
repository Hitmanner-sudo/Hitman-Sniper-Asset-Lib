using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using SimpleJSON;
using Technology.Core.ServiceOperations;

[Token(Token = "0x2000917")]
public class OnlineSuiteDatabase
{
	[Token(Token = "0x2000918")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x596F2C", Offset = "0x596F2C")]
	private sealed class _003CWaitForOnlineSuiteInitialized_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40031CA")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40031CB")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40031CC")]
		[FieldOffset(Offset = "0x20")]
		public OnlineSuiteDatabase _003C_003E4__this;

		[Token(Token = "0x40031CD")]
		[FieldOffset(Offset = "0x28")]
		private OnlineSuite _003Cos_003E5__2;

		[Token(Token = "0x1700074E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003A07")]
			[Address(RVA = "0x8CE89C", Offset = "0x8CE89C", VA = "0x8CE89C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700074F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003A09")]
			[Address(RVA = "0x8CE8E4", Offset = "0x8CE8E4", VA = "0x8CE8E4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003A04")]
		[Address(RVA = "0x8CE6A8", Offset = "0x8CE6A8", VA = "0x8CE6A8")]
		[DebuggerHidden]
		public _003CWaitForOnlineSuiteInitialized_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003A05")]
		[Address(RVA = "0x8CE6D4", Offset = "0x8CE6D4", VA = "0x8CE6D4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003A06")]
		[Address(RVA = "0x8CE6D8", Offset = "0x8CE6D8", VA = "0x8CE6D8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003A08")]
		[Address(RVA = "0x8CE8A4", Offset = "0x8CE8A4", VA = "0x8CE8A4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000919")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x596F3C", Offset = "0x596F3C")]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		[Token(Token = "0x40031CE")]
		[FieldOffset(Offset = "0x10")]
		public SvcOpGetDatabase svcOp;

		[Token(Token = "0x40031CF")]
		[FieldOffset(Offset = "0x18")]
		public OnlineSuiteDatabase _003C_003E4__this;

		[Token(Token = "0x6003A0A")]
		[Address(RVA = "0x8CE674", Offset = "0x8CE674", VA = "0x8CE674")]
		public _003C_003Ec__DisplayClass5_0()
		{
		}

		[Token(Token = "0x6003A0B")]
		[Address(RVA = "0x8CE67C", Offset = "0x8CE67C", VA = "0x8CE67C")]
		internal void _003CFetchDatabase_003Eb__0()
		{
		}
	}

	[Token(Token = "0x40031C8")]
	[FieldOffset(Offset = "0x10")]
	private readonly string _databaseId;

	[Token(Token = "0x40031C9")]
	[FieldOffset(Offset = "0x18")]
	private Action<JSONNode> _onComplete;

	[Token(Token = "0x60039FE")]
	[Address(RVA = "0x9FA4B0", Offset = "0x9FA4B0", VA = "0x9FA4B0")]
	public OnlineSuiteDatabase(string databaseId)
	{
	}

	[Token(Token = "0x60039FF")]
	[Address(RVA = "0x9FA4DC", Offset = "0x9FA4DC", VA = "0x9FA4DC")]
	public void Get(Action<JSONNode> onComplete)
	{
	}

	[Token(Token = "0x6003A00")]
	[Address(RVA = "0x9FA590", Offset = "0x9FA590", VA = "0x9FA590")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x624800", Offset = "0x624800")]
	private IEnumerator WaitForOnlineSuiteInitialized()
	{
		return null;
	}

	[Token(Token = "0x6003A01")]
	[Address(RVA = "0x9FA5FC", Offset = "0x9FA5FC", VA = "0x9FA5FC")]
	private void FetchDatabase()
	{
	}

	[Token(Token = "0x6003A02")]
	[Address(RVA = "0x9FA790", Offset = "0x9FA790", VA = "0x9FA790")]
	private void OnGetDatabaseComplete(IResponseContext response, IRequestContext request, OSRequestState state, Dictionary<string, object> meta)
	{
	}

	[Token(Token = "0x6003A03")]
	[Address(RVA = "0x9FA804", Offset = "0x9FA804", VA = "0x9FA804")]
	private JSONNode GetValueNode(IResponseContext response)
	{
		return null;
	}
}
