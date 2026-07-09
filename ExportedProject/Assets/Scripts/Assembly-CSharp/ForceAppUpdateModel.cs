using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005A7")]
public class ForceAppUpdateModel : DataModel
{
	[Token(Token = "0x4001DB9")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string FORCE_APP_UPDATE;

	[Token(Token = "0x4001DBA")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string DEFAULT_LINK;

	[Token(Token = "0x4001DBB")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private bool _forceAppUpdate;

	[Token(Token = "0x4001DBC")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private string _defaultLink;

	[Token(Token = "0x600236D")]
	[Address(RVA = "0x959C40", Offset = "0x959C40", VA = "0x959C40", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x600236E")]
	[Address(RVA = "0x959DF4", Offset = "0x959DF4", VA = "0x959DF4")]
	public ForceAppUpdateModel()
	{
	}

	[Token(Token = "0x6002370")]
	[Address(RVA = "0x959E84", Offset = "0x959E84", VA = "0x959E84")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A4E0", Offset = "0x61A4E0")]
	private bool _003CBindAllVariables_003Eb__4_0()
	{
		return default(bool);
	}

	[Token(Token = "0x6002371")]
	[Address(RVA = "0x959E8C", Offset = "0x959E8C", VA = "0x959E8C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A4F0", Offset = "0x61A4F0")]
	private void _003CBindAllVariables_003Eb__4_1(bool b)
	{
	}

	[Token(Token = "0x6002372")]
	[Address(RVA = "0x959E98", Offset = "0x959E98", VA = "0x959E98")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A500", Offset = "0x61A500")]
	private object _003CBindAllVariables_003Eb__4_2()
	{
		return null;
	}
}
