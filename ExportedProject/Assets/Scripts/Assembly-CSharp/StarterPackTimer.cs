using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200074A")]
public class StarterPackTimer : MonoBehaviour
{
	[Token(Token = "0x4002947")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Label;

	[Token(Token = "0x4002948")]
	[FieldOffset(Offset = "0x20")]
	private StarterPackInfo _starterPackInfo;

	[Token(Token = "0x4002949")]
	[FieldOffset(Offset = "0x28")]
	private TimeSpan _lastValue;

	[Token(Token = "0x60030B3")]
	[Address(RVA = "0xD2967C", Offset = "0xD2967C", VA = "0xD2967C")]
	protected void OnEnable()
	{
	}

	[Token(Token = "0x60030B4")]
	[Address(RVA = "0xD297F0", Offset = "0xD297F0", VA = "0xD297F0")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x60030B5")]
	[Address(RVA = "0xD29918", Offset = "0xD29918", VA = "0xD29918")]
	private string FormatRemainingTime(TimeSpan timeRemaining)
	{
		return null;
	}

	[Token(Token = "0x60030B6")]
	[Address(RVA = "0xD29A98", Offset = "0xD29A98", VA = "0xD29A98")]
	protected void Update()
	{
	}

	[Token(Token = "0x60030B7")]
	[Address(RVA = "0xD29764", Offset = "0xD29764", VA = "0xD29764")]
	private void RefreshStarterPackInfo()
	{
	}

	[Token(Token = "0x60030B8")]
	[Address(RVA = "0xD29BF8", Offset = "0xD29BF8", VA = "0xD29BF8")]
	public StarterPackTimer()
	{
	}
}
