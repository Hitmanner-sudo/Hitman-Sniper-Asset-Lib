using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using SimpleJSON;
using Technology;
using Technology.Core.ServiceOperations;

[Serializable]
[Token(Token = "0x20004C2")]
public class PlayerReferralData : ISaveable
{
	[Serializable]
	[Token(Token = "0x20004C3")]
	public class JustCauseGunReferralData : ISaveable
	{
		[Token(Token = "0x4001987")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B7264", Offset = "0x5B7264")]
		public int ReferralRequiredCount;

		[NonSerialized]
		[Token(Token = "0x4001988")]
		[FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B7274", Offset = "0x5B7274")]
		public bool ReferralTresholdObtained;

		[Token(Token = "0x4001989")]
		[FieldOffset(Offset = "0x15")]
		[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B7284", Offset = "0x5B7284")]
		public bool ReferralInfoShown;

		[Token(Token = "0x6001D2C")]
		[Address(RVA = "0x8D48F8", Offset = "0x8D48F8", VA = "0x8D48F8", Slot = "4")]
		public void OnSaveableDeserialization(JSONNode data)
		{
		}

		[Token(Token = "0x6001D2D")]
		[Address(RVA = "0x8D4980", Offset = "0x8D4980", VA = "0x8D4980", Slot = "5")]
		public JSONNode OnSaveableSerialization()
		{
			return null;
		}

		[Token(Token = "0x6001D2E")]
		[Address(RVA = "0x8D49F8", Offset = "0x8D49F8", VA = "0x8D49F8")]
		public JustCauseGunReferralData()
		{
		}
	}

	[Token(Token = "0x20004C4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594D90", Offset = "0x594D90")]
	private sealed class _003CWaitForOnlineSuite_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400198A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400198B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400198C")]
		[FieldOffset(Offset = "0x20")]
		public PlayerReferralData _003C_003E4__this;

		[Token(Token = "0x400198D")]
		[FieldOffset(Offset = "0x28")]
		private OnlineSuite _003Cos_003E5__2;

		[Token(Token = "0x17000480")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001D32")]
			[Address(RVA = "0x8D48A8", Offset = "0x8D48A8", VA = "0x8D48A8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000481")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001D34")]
			[Address(RVA = "0x8D48F0", Offset = "0x8D48F0", VA = "0x8D48F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001D2F")]
		[Address(RVA = "0x8D4654", Offset = "0x8D4654", VA = "0x8D4654")]
		[DebuggerHidden]
		public _003CWaitForOnlineSuite_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001D30")]
		[Address(RVA = "0x8D4680", Offset = "0x8D4680", VA = "0x8D4680", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001D31")]
		[Address(RVA = "0x8D4684", Offset = "0x8D4684", VA = "0x8D4684", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001D33")]
		[Address(RVA = "0x8D48B0", Offset = "0x8D48B0", VA = "0x8D48B0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[NonSerialized]
	[Token(Token = "0x4001983")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B7224", Offset = "0x5B7224")]
	public string FriendReferredBy;

	[NonSerialized]
	[Token(Token = "0x4001984")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B7234", Offset = "0x5B7234")]
	public bool FriendReferralAttributed;

	[NonSerialized]
	[Token(Token = "0x4001985")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B7244", Offset = "0x5B7244")]
	public List<string> FriendsReferred;

	[Token(Token = "0x4001986")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B7254", Offset = "0x5B7254")]
	public JustCauseGunReferralData JustCauseReferralData;

	[Token(Token = "0x6001D21")]
	[Address(RVA = "0xAAE324", Offset = "0xAAE324", VA = "0xAAE324")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6001D22")]
	[Address(RVA = "0xAB5804", Offset = "0xAB5804", VA = "0xAB5804")]
	private void OnSaveGameManagerLoadCompleted(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x6001D23")]
	[Address(RVA = "0xAB592C", Offset = "0xAB592C", VA = "0xAB592C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6186F8", Offset = "0x6186F8")]
	private IEnumerator WaitForOnlineSuite()
	{
		return null;
	}

	[Token(Token = "0x6001D24")]
	[Address(RVA = "0xAB5998", Offset = "0xAB5998", VA = "0xAB5998")]
	private void OnOnlineSuiteInitialized()
	{
	}

	[Token(Token = "0x6001D25")]
	[Address(RVA = "0xAB5AE0", Offset = "0xAB5AE0", VA = "0xAB5AE0")]
	private void OnConversionDataChanged(Dictionary<string, string> data)
	{
	}

	[Token(Token = "0x6001D26")]
	[Address(RVA = "0xAB5C90", Offset = "0xAB5C90", VA = "0xAB5C90")]
	private void AttributeFriendReferral()
	{
	}

	[Token(Token = "0x6001D27")]
	[Address(RVA = "0xAB5FAC", Offset = "0xAB5FAC", VA = "0xAB5FAC")]
	public void ProcessReferral(string referree)
	{
	}

	[Token(Token = "0x6001D28")]
	[Address(RVA = "0xAB610C", Offset = "0xAB610C", VA = "0xAB610C", Slot = "4")]
	public void OnSaveableDeserialization(JSONNode data)
	{
	}

	[Token(Token = "0x6001D29")]
	[Address(RVA = "0xAB6194", Offset = "0xAB6194", VA = "0xAB6194", Slot = "5")]
	public JSONNode OnSaveableSerialization()
	{
		return null;
	}

	[Token(Token = "0x6001D2A")]
	[Address(RVA = "0xAB43B4", Offset = "0xAB43B4", VA = "0xAB43B4")]
	public PlayerReferralData()
	{
	}

	[Token(Token = "0x6001D2B")]
	[Address(RVA = "0xAB620C", Offset = "0xAB620C", VA = "0xAB620C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618758", Offset = "0x618758")]
	private void _003CAttributeFriendReferral_003Eb__10_0(bool success, IResponseContext response)
	{
	}
}
