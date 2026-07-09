using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20008D3")]
public class DebugConsole : MonoBehaviour
{
	[Token(Token = "0x40030EE")]
	[FieldOffset(Offset = "0x18")]
	private ArrayList messages;

	[Token(Token = "0x40030EF")]
	[FieldOffset(Offset = "0x20")]
	private Vector2 _scrollPosition;

	[Token(Token = "0x40030F0")]
	[FieldOffset(Offset = "0x28")]
	private Vector2 _scrollPositionDetail;

	[Token(Token = "0x40030F1")]
	[FieldOffset(Offset = "0x30")]
	private bool _detail;

	[Token(Token = "0x40030F2")]
	[FieldOffset(Offset = "0x31")]
	private bool _showConsole;

	[Token(Token = "0x40030F3")]
	[FieldOffset(Offset = "0x34")]
	private float _lineHeight;

	[Token(Token = "0x60038D7")]
	[Address(RVA = "0xAE7D84", Offset = "0xAE7D84", VA = "0xAE7D84")]
	protected void Awake()
	{
	}

	[Token(Token = "0x60038D8")]
	[Address(RVA = "0xAE7E30", Offset = "0xAE7E30", VA = "0xAE7E30")]
	protected void OnDestroy()
	{
	}

	[Token(Token = "0x60038D9")]
	[Address(RVA = "0xAE7E54", Offset = "0xAE7E54", VA = "0xAE7E54")]
	private void HandleUnityExceptions(string message, string stackTrace, LogType type)
	{
	}

	[Token(Token = "0x60038DA")]
	[Address(RVA = "0xAE7E78", Offset = "0xAE7E78", VA = "0xAE7E78")]
	protected void OnGUI()
	{
	}

	[Token(Token = "0x60038DB")]
	[Address(RVA = "0xAE8634", Offset = "0xAE8634", VA = "0xAE8634")]
	public DebugConsole()
	{
	}
}
