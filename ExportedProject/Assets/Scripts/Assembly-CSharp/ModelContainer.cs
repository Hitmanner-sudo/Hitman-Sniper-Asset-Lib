using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology.Distribution;
using UnityEngine;

[Serializable]
[Token(Token = "0x20005C5")]
public class ModelContainer
{
	[Serializable]
	[Token(Token = "0x20005C6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59544C", Offset = "0x59544C")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001F08")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001F09")]
		[FieldOffset(Offset = "0x8")]
		public static Converter<string, DataModel> _003C_003E9__3_0;

		[Token(Token = "0x60024BE")]
		[Address(RVA = "0x8C8C44", Offset = "0x8C8C44", VA = "0x8C8C44")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60024BF")]
		[Address(RVA = "0x8C8C4C", Offset = "0x8C8C4C", VA = "0x8C8C4C")]
		internal DataModel _003Cget_ModelsList_003Eb__3_0(string s)
		{
			return null;
		}
	}

	[Token(Token = "0x20005C7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59545C", Offset = "0x59545C")]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		[Token(Token = "0x4001F0A")]
		[FieldOffset(Offset = "0x10")]
		public Bundle b;

		[Token(Token = "0x60024C0")]
		[Address(RVA = "0x8C8CC8", Offset = "0x8C8CC8", VA = "0x8C8CC8")]
		public _003C_003Ec__DisplayClass4_0()
		{
		}

		[Token(Token = "0x60024C1")]
		[Address(RVA = "0x8C8CD0", Offset = "0x8C8CD0", VA = "0x8C8CD0")]
		internal bool _003COnBundleLoaded_003Eb__0(DataModel m)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4001F06")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private string[] ModelsPaths;

	[NonSerialized]
	[Token(Token = "0x4001F07")]
	[FieldOffset(Offset = "0x18")]
	private List<DataModel> _models;

	[Token(Token = "0x17000522")]
	public List<DataModel> ModelsList
	{
		[Token(Token = "0x60024A9")]
		[Address(RVA = "0xA2A370", Offset = "0xA2A370", VA = "0xA2A370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60024AA")]
	[Address(RVA = "0xA2A560", Offset = "0xA2A560", VA = "0xA2A560")]
	private void OnBundleLoaded(Bundle b)
	{
	}

	[Token(Token = "0x60024AB")]
	public T GetVariable<T>(string name)
	{
		return (T)null;
	}

	[Token(Token = "0x60024AC")]
	[Address(RVA = "0xA2A7EC", Offset = "0xA2A7EC", VA = "0xA2A7EC")]
	public int GetIntVariable(string name)
	{
		return default(int);
	}

	[Token(Token = "0x60024AD")]
	[Address(RVA = "0xA2A8CC", Offset = "0xA2A8CC", VA = "0xA2A8CC")]
	public bool GetBoolVariable(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x60024AE")]
	[Address(RVA = "0xA2A9B4", Offset = "0xA2A9B4", VA = "0xA2A9B4")]
	public float GetFloatVariable(string name)
	{
		return default(float);
	}

	[Token(Token = "0x60024AF")]
	[Address(RVA = "0xA1B9E0", Offset = "0xA1B9E0", VA = "0xA1B9E0")]
	public void SetVariable(string name, object value)
	{
	}

	[Token(Token = "0x60024B0")]
	[Address(RVA = "0xA2AA94", Offset = "0xA2AA94", VA = "0xA2AA94")]
	public void SetVariable(string name, object value, bool forceChangedEvent)
	{
	}

	[Token(Token = "0x60024B1")]
	[Address(RVA = "0xA2AB9C", Offset = "0xA2AB9C", VA = "0xA2AB9C")]
	public void SetVariable(string name, int value)
	{
	}

	[Token(Token = "0x60024B2")]
	[Address(RVA = "0xA2ABA4", Offset = "0xA2ABA4", VA = "0xA2ABA4")]
	public void SetVariable(string name, int value, bool forceChangedEvent)
	{
	}

	[Token(Token = "0x60024B3")]
	[Address(RVA = "0xA2ACAC", Offset = "0xA2ACAC", VA = "0xA2ACAC")]
	public void SetVariable(string name, bool value)
	{
	}

	[Token(Token = "0x60024B4")]
	[Address(RVA = "0xA2ACB8", Offset = "0xA2ACB8", VA = "0xA2ACB8")]
	public void SetVariable(string name, bool value, bool forceChangedEvent)
	{
	}

	[Token(Token = "0x60024B5")]
	[Address(RVA = "0xA2ADC0", Offset = "0xA2ADC0", VA = "0xA2ADC0")]
	public void SetVariable(string name, float value)
	{
	}

	[Token(Token = "0x60024B6")]
	[Address(RVA = "0xA2ADC8", Offset = "0xA2ADC8", VA = "0xA2ADC8")]
	public void SetVariable(string name, float value, bool forceChangedEvent)
	{
	}

	[Token(Token = "0x60024B7")]
	[Address(RVA = "0xA2AED0", Offset = "0xA2AED0", VA = "0xA2AED0")]
	public void FireVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x60024B8")]
	[Address(RVA = "0xA2AFC8", Offset = "0xA2AFC8", VA = "0xA2AFC8")]
	public void IncrementVariable(string name, int step)
	{
	}

	[Token(Token = "0x60024B9")]
	[Address(RVA = "0xA1F6D4", Offset = "0xA1F6D4", VA = "0xA1F6D4")]
	public void BindVariableChangedEvent(EventHandler<DataModel.VariableChangedEventArgs> handler)
	{
	}

	[Token(Token = "0x60024BA")]
	[Address(RVA = "0xA202EC", Offset = "0xA202EC", VA = "0xA202EC")]
	public void UnbindVariableChangedEvent(EventHandler<DataModel.VariableChangedEventArgs> handler)
	{
	}

	[Token(Token = "0x60024BB")]
	[Address(RVA = "0xA2B0BC", Offset = "0xA2B0BC", VA = "0xA2B0BC")]
	public void ClearNonAssetModels()
	{
	}

	[Token(Token = "0x60024BC")]
	[Address(RVA = "0xA2B228", Offset = "0xA2B228", VA = "0xA2B228")]
	public ModelContainer()
	{
	}
}
