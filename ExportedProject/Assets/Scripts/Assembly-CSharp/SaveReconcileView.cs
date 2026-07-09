using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006C5")]
public class SaveReconcileView : View
{
	[Token(Token = "0x4002608")]
	[FieldOffset(Offset = "0x60")]
	public UILabel LocalDate;

	[Token(Token = "0x4002609")]
	[FieldOffset(Offset = "0x68")]
	public UILabel LocalMissionCount;

	[Token(Token = "0x400260A")]
	[FieldOffset(Offset = "0x70")]
	public UILabel LocalSoftCurrency;

	[Token(Token = "0x400260B")]
	[FieldOffset(Offset = "0x78")]
	public UILabel LocalChallengeToken;

	[Token(Token = "0x400260C")]
	[FieldOffset(Offset = "0x80")]
	public UILabel LocalTime;

	[Token(Token = "0x400260D")]
	[FieldOffset(Offset = "0x88")]
	public UILabel RemoteDate;

	[Token(Token = "0x400260E")]
	[FieldOffset(Offset = "0x90")]
	public UILabel RemoteMissionCount;

	[Token(Token = "0x400260F")]
	[FieldOffset(Offset = "0x98")]
	public UILabel RemoteSoftCurrency;

	[Token(Token = "0x4002610")]
	[FieldOffset(Offset = "0xA0")]
	public UILabel RemoteChallengeToken;

	[Token(Token = "0x4002611")]
	[FieldOffset(Offset = "0xA8")]
	public UILabel RemoteTime;

	[Token(Token = "0x4002612")]
	[FieldOffset(Offset = "0xB0")]
	public UILabel MainDescription;

	[Token(Token = "0x4002613")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject CancelButton;

	[Token(Token = "0x6002C91")]
	[Address(RVA = "0xBAFA44", Offset = "0xBAFA44", VA = "0xBAFA44", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002C92")]
	[Address(RVA = "0xBAFA6C", Offset = "0xBAFA6C", VA = "0xBAFA6C")]
	private void Setup()
	{
	}

	[Token(Token = "0x6002C93")]
	[Address(RVA = "0xBAFDFC", Offset = "0xBAFDFC", VA = "0xBAFDFC")]
	private static string FormatDate(DateTime datetime)
	{
		return null;
	}

	[Token(Token = "0x6002C94")]
	[Address(RVA = "0xBAFE68", Offset = "0xBAFE68", VA = "0xBAFE68")]
	private static string FormatTime(DateTime datetime)
	{
		return null;
	}

	[Token(Token = "0x6002C95")]
	[Address(RVA = "0xBAFEA0", Offset = "0xBAFEA0", VA = "0xBAFEA0")]
	public SaveReconcileView()
	{
	}
}
