using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005A8")]
public class GDPRModel : DataModel
{
	[Token(Token = "0x4001DBD")]
	private const string PREFIX = "GDPRModel.";

	[Token(Token = "0x4001DBE")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string POPUP_PREFAB;

	[Token(Token = "0x4001DBF")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string PRIVACY_POLICY_VERSION;

	[Token(Token = "0x4001DC0")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string TERMS_VERSION;

	[Token(Token = "0x4001DC1")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private LazyPopupGDPR _lazyPopupPrefab;

	[Token(Token = "0x4001DC2")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GlobalConfig.DocumentVersion _privacyPolicyVersion;

	[Token(Token = "0x4001DC3")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GlobalConfig.DocumentVersion _termsVersion;

	[Token(Token = "0x6002373")]
	[Address(RVA = "0x95E98C", Offset = "0x95E98C", VA = "0x95E98C", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x6002374")]
	[Address(RVA = "0x95EBAC", Offset = "0x95EBAC", VA = "0x95EBAC")]
	private PopupGDPR GetPopupPrefab()
	{
		return null;
	}

	[Token(Token = "0x6002375")]
	[Address(RVA = "0x95ED10", Offset = "0x95ED10", VA = "0x95ED10")]
	public GDPRModel()
	{
	}

	[Token(Token = "0x6002377")]
	[Address(RVA = "0x95EDC0", Offset = "0x95EDC0", VA = "0x95EDC0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A510", Offset = "0x61A510")]
	private object _003CBindAllVariables_003Eb__7_0()
	{
		return null;
	}

	[Token(Token = "0x6002378")]
	[Address(RVA = "0x95EE20", Offset = "0x95EE20", VA = "0x95EE20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A520", Offset = "0x61A520")]
	private void _003CBindAllVariables_003Eb__7_1(object s)
	{
	}

	[Token(Token = "0x6002379")]
	[Address(RVA = "0x95EEA4", Offset = "0x95EEA4", VA = "0x95EEA4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A530", Offset = "0x61A530")]
	private object _003CBindAllVariables_003Eb__7_2()
	{
		return null;
	}

	[Token(Token = "0x600237A")]
	[Address(RVA = "0x95EF04", Offset = "0x95EF04", VA = "0x95EF04")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A540", Offset = "0x61A540")]
	private void _003CBindAllVariables_003Eb__7_3(object s)
	{
	}
}
