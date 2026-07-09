using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002B7")]
public class TutorialEntryPoint : ScriptableObject
{
	[Token(Token = "0x4000F52")]
	[FieldOffset(Offset = "0x18")]
	public TutorialEntryPointConditions conditions;

	[Token(Token = "0x4000F53")]
	[FieldOffset(Offset = "0x20")]
	public string TutorialStartFunctionName;

	[Token(Token = "0x6001093")]
	[Address(RVA = "0xCA0F54", Offset = "0xCA0F54", VA = "0xCA0F54", Slot = "4")]
	public virtual bool TutorialShouldHappen()
	{
		return default(bool);
	}

	[Token(Token = "0x6001094")]
	[Address(RVA = "0xCA0F8C", Offset = "0xCA0F8C", VA = "0xCA0F8C")]
	private bool TutorialIsCompleted()
	{
		return default(bool);
	}

	[Token(Token = "0x6001095")]
	[Address(RVA = "0xCA1140", Offset = "0xCA1140", VA = "0xCA1140")]
	private bool IsMissionValid()
	{
		return default(bool);
	}

	[Token(Token = "0x6001096")]
	[Address(RVA = "0xCA12B4", Offset = "0xCA12B4", VA = "0xCA12B4")]
	public TutorialEntryPoint()
	{
	}
}
