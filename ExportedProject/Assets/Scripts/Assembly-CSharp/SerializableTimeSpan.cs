using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x20007BB")]
public struct SerializableTimeSpan
{
	[Serializable]
	[Token(Token = "0x20007BC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x596234", Offset = "0x596234")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002B76")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x60032FF")]
		[Address(RVA = "0x8BC0E4", Offset = "0x8BC0E4", VA = "0x8BC0E4")]
		public _003C_003Ec()
		{
		}
	}

	[Token(Token = "0x4002B6C")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string DAYS_FIELD_NAME;

	[Token(Token = "0x4002B6D")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string HOURS_FIELD_NAME;

	[Token(Token = "0x4002B6E")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string MINUTES_FIELD_NAME;

	[Token(Token = "0x4002B6F")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string SECONDS_FIELD_NAME;

	[Token(Token = "0x4002B70")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string MILLISECONDS_FIELD_NAME;

	[Token(Token = "0x4002B71")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	private int _days;

	[Token(Token = "0x4002B72")]
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	private int _hours;

	[Token(Token = "0x4002B73")]
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	private int _minutes;

	[Token(Token = "0x4002B74")]
	[FieldOffset(Offset = "0xC")]
	[SerializeField]
	private int _seconds;

	[Token(Token = "0x4002B75")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private int _milliseconds;

	[Token(Token = "0x1700068B")]
	public TimeSpan Value
	{
		[Token(Token = "0x60032FB")]
		[Address(RVA = "0xB7234C", Offset = "0xB7234C", VA = "0xB7234C")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Token(Token = "0x60032FC")]
	[Address(RVA = "0xB72384", Offset = "0xB72384", VA = "0xB72384")]
	public SerializableTimeSpan(int days = 0, int hours = 0, int minutes = 0, int seconds = 0, int milliseconds = 0)
	{
	}
}
