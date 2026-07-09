using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005BF")]
public class LoadingModel : DataModel
{
	[Token(Token = "0x4001ED6")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string CAN_ADVANCE_LOADING_BAR;

	[Token(Token = "0x4001ED7")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string DOWNLOAD_PERCENTAGE_WEIGHT;

	[Token(Token = "0x4001ED8")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string LEVEL_LOAD_PERCENTAGE_WEIGHT;

	[Token(Token = "0x4001ED9")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float _downloadPercentageWeight;

	[Token(Token = "0x4001EDA")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float _levelLoadPercentageWeight;

	[Token(Token = "0x4001EDB")]
	[FieldOffset(Offset = "0x50")]
	private bool _canStartLoadingBar;

	[Token(Token = "0x6002477")]
	[Address(RVA = "0x9D24DC", Offset = "0x9D24DC", VA = "0x9D24DC", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x6002478")]
	[Address(RVA = "0x9D26E0", Offset = "0x9D26E0", VA = "0x9D26E0")]
	public LoadingModel()
	{
	}

	[Token(Token = "0x600247A")]
	[Address(RVA = "0x9D2790", Offset = "0x9D2790", VA = "0x9D2790")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B410", Offset = "0x61B410")]
	private bool _003CBindAllVariables_003Eb__6_0()
	{
		return default(bool);
	}

	[Token(Token = "0x600247B")]
	[Address(RVA = "0x9D2798", Offset = "0x9D2798", VA = "0x9D2798")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B420", Offset = "0x61B420")]
	private void _003CBindAllVariables_003Eb__6_1(bool a)
	{
	}

	[Token(Token = "0x600247C")]
	[Address(RVA = "0x9D27A4", Offset = "0x9D27A4", VA = "0x9D27A4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B430", Offset = "0x61B430")]
	private float _003CBindAllVariables_003Eb__6_2()
	{
		return default(float);
	}

	[Token(Token = "0x600247D")]
	[Address(RVA = "0x9D27AC", Offset = "0x9D27AC", VA = "0x9D27AC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B440", Offset = "0x61B440")]
	private float _003CBindAllVariables_003Eb__6_3()
	{
		return default(float);
	}
}
