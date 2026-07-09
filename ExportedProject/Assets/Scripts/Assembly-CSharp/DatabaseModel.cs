using System.Collections.Generic;
using Il2CppDummyDll;
using SimpleJSON;
using Technology;
using Technology.Core.ServiceOperations;
using UnityEngine;

[Token(Token = "0x20001E4")]
public abstract class DatabaseModel : ScriptableObject, ISaveable
{
	[Token(Token = "0x20001E5")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5929B4", Offset = "0x5929B4")]
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		[Token(Token = "0x4000AF0")]
		[FieldOffset(Offset = "0x10")]
		public SvcOpGetDatabase svcOp;

		[Token(Token = "0x4000AF1")]
		[FieldOffset(Offset = "0x18")]
		public DatabaseModel _003C_003E4__this;

		[Token(Token = "0x6000BFD")]
		[Address(RVA = "0x86AD5C", Offset = "0x86AD5C", VA = "0x86AD5C")]
		public _003C_003Ec__DisplayClass6_0()
		{
		}

		[Token(Token = "0x6000BFE")]
		[Address(RVA = "0x86AD64", Offset = "0x86AD64", VA = "0x86AD64")]
		internal void _003CGetDatabase_003Eb__0()
		{
		}
	}

	[Token(Token = "0x4000AED")]
	private const string DATABASE_CACHE_KEY = "DATABASE_CACHE";

	[Token(Token = "0x4000AEE")]
	[FieldOffset(Offset = "0x18")]
	public string Id;

	[Token(Token = "0x4000AEF")]
	[FieldOffset(Offset = "0x20")]
	public bool LocalDataEditorOnly;

	[Token(Token = "0x170001EA")]
	public string DatabaseKey
	{
		[Token(Token = "0x6000BEF")]
		[Address(RVA = "0xAE427C", Offset = "0xAE427C", VA = "0xAE427C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000BF0")]
	[Address(RVA = "0xAE42CC", Offset = "0xAE42CC", VA = "0xAE42CC")]
	public void Load()
	{
	}

	[Token(Token = "0x6000BF1")]
	[Address(RVA = "0xAE4350", Offset = "0xAE4350", VA = "0xAE4350")]
	private void GetDatabase()
	{
	}

	[Token(Token = "0x6000BF2")]
	[Address(RVA = "0xAE44E8", Offset = "0xAE44E8", VA = "0xAE44E8")]
	private void SubscriberAction(IResponseContext responseContext, IRequestContext requestContext, OSRequestState state, Dictionary<string, object> meta)
	{
	}

	[Token(Token = "0x6000BF3")]
	[Address(RVA = "0xAE42F0", Offset = "0xAE42F0", VA = "0xAE42F0")]
	private void LoadFromCacheValue()
	{
	}

	[Token(Token = "0x6000BF4")]
	[Address(RVA = "0xAE4904", Offset = "0xAE4904", VA = "0xAE4904")]
	private void SetCacheValue(string value)
	{
	}

	[Token(Token = "0x6000BF5")]
	[Address(RVA = "0xAE48CC", Offset = "0xAE48CC", VA = "0xAE48CC")]
	private void LoadFromValue(string value)
	{
	}

	[Token(Token = "0x6000BF6")]
	[Address(RVA = "0xAE4934", Offset = "0xAE4934", VA = "0xAE4934", Slot = "6")]
	protected virtual void OnLoadSuccessed(string value)
	{
	}

	[Token(Token = "0x6000BF7")]
	[Address(RVA = "0xAE497C", Offset = "0xAE497C", VA = "0xAE497C", Slot = "7")]
	protected virtual void OnLoadFailed(string value)
	{
	}

	[Token(Token = "0x6000BF8")]
	[Address(RVA = "0xAE4620", Offset = "0xAE4620", VA = "0xAE4620")]
	private void Parse(JSONNode json)
	{
	}

	[Token(Token = "0x6000BF9")]
	[Address(RVA = "0xAE4980", Offset = "0xAE4980", VA = "0xAE4980", Slot = "8")]
	public virtual void OnSaveableDeserialization(JSONNode data)
	{
	}

	[Token(Token = "0x6000BFA")]
	[Address(RVA = "0xAE4A08", Offset = "0xAE4A08", VA = "0xAE4A08", Slot = "5")]
	public JSONNode OnSaveableSerialization()
	{
		return null;
	}

	[Token(Token = "0x6000BFB")]
	[Address(RVA = "0xAE4A80", Offset = "0xAE4A80", VA = "0xAE4A80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000BFC")]
	[Address(RVA = "0xAE4AA4", Offset = "0xAE4AA4", VA = "0xAE4AA4")]
	protected DatabaseModel()
	{
	}
}
