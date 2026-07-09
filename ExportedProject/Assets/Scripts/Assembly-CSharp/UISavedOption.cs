using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200003A")]
[Attribute(Name = "AddComponentMenu", RVA = "0x591088", Offset = "0x591088")]
public class UISavedOption : MonoBehaviour
{
	[Token(Token = "0x4000135")]
	[FieldOffset(Offset = "0x18")]
	public string keyName;

	[Token(Token = "0x4000136")]
	[FieldOffset(Offset = "0x20")]
	private UIPopupList mList;

	[Token(Token = "0x4000137")]
	[FieldOffset(Offset = "0x28")]
	private UIToggle mCheck;

	[Token(Token = "0x1700002D")]
	private string key
	{
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x142E2A8", Offset = "0x142E2A8", VA = "0x142E2A8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x142E328", Offset = "0x142E328", VA = "0x142E328")]
	private void Awake()
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x142E3A0", Offset = "0x142E3A0", VA = "0x142E3A0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x142E6E4", Offset = "0x142E6E4", VA = "0x142E6E4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x142E9BC", Offset = "0x142E9BC", VA = "0x142E9BC")]
	private void SaveSelection()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x142EA24", Offset = "0x142EA24", VA = "0x142EA24")]
	private void SaveState()
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x142EAB0", Offset = "0x142EAB0", VA = "0x142EAB0")]
	public UISavedOption()
	{
	}
}
