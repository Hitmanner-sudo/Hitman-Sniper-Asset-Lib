using System;
using Il2CppDummyDll;

[Token(Token = "0x2000547")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x595134", Offset = "0x595134")]
public class SaveReconcileController : UIController
{
	[Token(Token = "0x2000548")]
	public enum UserChoice
	{
		[Token(Token = "0x4001C0A")]
		Cancel = 0,
		[Token(Token = "0x4001C0B")]
		Local = 1,
		[Token(Token = "0x4001C0C")]
		Remote = 2,
		[Token(Token = "0x4001C0D")]
		ExternalDestruction = 3
	}

	[Token(Token = "0x4001C04")]
	[FieldOffset(Offset = "0x50")]
	public BlinkButtonHandler SelectLocalButton;

	[Token(Token = "0x4001C05")]
	[FieldOffset(Offset = "0x58")]
	public BlinkButtonHandler SelectRemoteButton;

	[Token(Token = "0x4001C06")]
	[FieldOffset(Offset = "0x60")]
	public BlinkButtonHandler CancelButton;

	[Token(Token = "0x4001C08")]
	[FieldOffset(Offset = "0x70")]
	private bool _destroyedByUserAction;

	[Token(Token = "0x1400008A")]
	public event Action<UserChoice> OnChosen
	{
		[Token(Token = "0x6002120")]
		[Address(RVA = "0xBAE4B4", Offset = "0xBAE4B4", VA = "0xBAE4B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619858", Offset = "0x619858")]
		add
		{
		}
		[Token(Token = "0x6002121")]
		[Address(RVA = "0xBAE554", Offset = "0xBAE554", VA = "0xBAE554")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619868", Offset = "0x619868")]
		remove
		{
		}
	}

	[Token(Token = "0x6002122")]
	[Address(RVA = "0xBAE5F4", Offset = "0xBAE5F4", VA = "0xBAE5F4", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002123")]
	[Address(RVA = "0xBAE734", Offset = "0xBAE734", VA = "0xBAE734", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002124")]
	[Address(RVA = "0xBAE8F0", Offset = "0xBAE8F0", VA = "0xBAE8F0")]
	private void OnApplicationPause(bool paused)
	{
	}

	[Token(Token = "0x6002125")]
	[Address(RVA = "0xBAEA4C", Offset = "0xBAEA4C", VA = "0xBAEA4C")]
	private void OnSelectLocalClicked(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6002126")]
	[Address(RVA = "0xBAEB20", Offset = "0xBAEB20", VA = "0xBAEB20")]
	private void OnSelectRemoteClicked(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6002127")]
	[Address(RVA = "0xBAE978", Offset = "0xBAE978", VA = "0xBAE978")]
	private void OnCancelClicked(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6002128")]
	[Address(RVA = "0xBAEBF4", Offset = "0xBAEBF4", VA = "0xBAEBF4")]
	public SaveReconcileController()
	{
	}
}
