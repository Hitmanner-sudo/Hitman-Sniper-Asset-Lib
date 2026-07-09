using System;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x2000506")]
public class CheckmarkWidget : GameMonoBehaviour
{
	[Token(Token = "0x4001AB0")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject _checkmark;

	[Token(Token = "0x4001AB1")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private ButtonHandler _button;

	[Token(Token = "0x170004C3")]
	public bool IsChecked
	{
		[Token(Token = "0x6001EE7")]
		[Address(RVA = "0xB00338", Offset = "0xB00338", VA = "0xB00338")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x14000080")]
	public event Action<bool> StateChanged
	{
		[Token(Token = "0x6001EE5")]
		[Address(RVA = "0xB001F8", Offset = "0xB001F8", VA = "0xB001F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618EB8", Offset = "0x618EB8")]
		add
		{
		}
		[Token(Token = "0x6001EE6")]
		[Address(RVA = "0xB00298", Offset = "0xB00298", VA = "0xB00298")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618EC8", Offset = "0x618EC8")]
		remove
		{
		}
	}

	[Token(Token = "0x6001EE8")]
	[Address(RVA = "0xB00354", Offset = "0xB00354", VA = "0xB00354", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6001EE9")]
	[Address(RVA = "0xB00404", Offset = "0xB00404", VA = "0xB00404", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6001EEA")]
	[Address(RVA = "0xB004B0", Offset = "0xB004B0", VA = "0xB004B0")]
	private void OnButtonClicked(object sender, ButtonHandler.ButtonHandlerEventArgs e)
	{
	}

	[Token(Token = "0x6001EEB")]
	[Address(RVA = "0xB00540", Offset = "0xB00540", VA = "0xB00540")]
	public CheckmarkWidget()
	{
	}
}
