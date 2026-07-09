using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000055")]
[Attribute(Name = "AddComponentMenu", RVA = "0x591478", Offset = "0x591478")]
public class NGUIDebug : MonoBehaviour
{
	[Token(Token = "0x40001CA")]
	[FieldOffset(Offset = "0x0")]
	private static List<string> mLines;

	[Token(Token = "0x40001CB")]
	[FieldOffset(Offset = "0x8")]
	private static NGUIDebug mInstance;

	[Token(Token = "0x6000240")]
	[Address(RVA = "0xA31EC0", Offset = "0xA31EC0", VA = "0xA31EC0")]
	public static void Log(string text)
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0xA3213C", Offset = "0xA3213C", VA = "0xA3213C")]
	public static void DrawBounds(Bounds b)
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0xA322F8", Offset = "0xA322F8", VA = "0xA322F8")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0xA324A0", Offset = "0xA324A0", VA = "0xA324A0")]
	public NGUIDebug()
	{
	}
}
