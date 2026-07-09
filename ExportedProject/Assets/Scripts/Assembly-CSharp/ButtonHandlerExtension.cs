using System;
using Il2CppDummyDll;

[Token(Token = "0x20004FF")]
public static class ButtonHandlerExtension
{
	[Token(Token = "0x6001EC1")]
	[Address(RVA = "0xA77F14", Offset = "0xA77F14", VA = "0xA77F14")]
	public static void BindClick(this ButtonHandler btn, EventHandler<ButtonHandler.ButtonHandlerEventArgs> handler, bool forceFirst = false)
	{
	}

	[Token(Token = "0x6001EC2")]
	[Address(RVA = "0xA78468", Offset = "0xA78468", VA = "0xA78468")]
	public static void UnbindClick(this ButtonHandler btn, EventHandler<ButtonHandler.ButtonHandlerEventArgs> handler)
	{
	}

	[Token(Token = "0x6001EC3")]
	[Address(RVA = "0xA8ABA0", Offset = "0xA8ABA0", VA = "0xA8ABA0")]
	public static void BindPress(this ButtonHandler btn, EventHandler<ButtonHandler.PressButtonHandlerEventArgs> handler)
	{
	}

	[Token(Token = "0x6001EC4")]
	[Address(RVA = "0xA8AC3C", Offset = "0xA8AC3C", VA = "0xA8AC3C")]
	public static void UnbindPress(this ButtonHandler btn, EventHandler<ButtonHandler.PressButtonHandlerEventArgs> handler)
	{
	}

	[Token(Token = "0x6001EC5")]
	[Address(RVA = "0xA8ACD8", Offset = "0xA8ACD8", VA = "0xA8ACD8")]
	public static void BindLongPress(this ButtonHandler btn, EventHandler<ButtonHandler.ButtonHandlerEventArgs> handler)
	{
	}

	[Token(Token = "0x6001EC6")]
	[Address(RVA = "0xA8AD74", Offset = "0xA8AD74", VA = "0xA8AD74")]
	public static void UnbindLongPress(this ButtonHandler btn, EventHandler<ButtonHandler.ButtonHandlerEventArgs> handler)
	{
	}
}
