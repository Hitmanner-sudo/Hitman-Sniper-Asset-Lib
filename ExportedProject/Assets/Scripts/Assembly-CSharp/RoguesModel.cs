using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005D1")]
public class RoguesModel : DataModel
{
	[Token(Token = "0x4001F5D")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string ROGUES_DATA;

	[Token(Token = "0x4001F5E")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private LazyRogueData[] _rogueDatas;

	[Token(Token = "0x600253B")]
	[Address(RVA = "0x973AF4", Offset = "0x973AF4", VA = "0x973AF4", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x600253C")]
	[Address(RVA = "0x973BCC", Offset = "0x973BCC", VA = "0x973BCC")]
	public RoguesModel()
	{
	}

	[Token(Token = "0x600253E")]
	[Address(RVA = "0x973C38", Offset = "0x973C38", VA = "0x973C38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BAA0", Offset = "0x61BAA0")]
	private object _003CBindAllVariables_003Eb__2_0()
	{
		return null;
	}
}
