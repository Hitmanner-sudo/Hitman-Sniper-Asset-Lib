using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x20008E9")]
public class TimeReferential
{
	[Token(Token = "0x4003130")]
	[FieldOffset(Offset = "0x10")]
	protected float _time;

	[Token(Token = "0x4003131")]
	[FieldOffset(Offset = "0x14")]
	protected float _timeScale;

	[Token(Token = "0x4003132")]
	[FieldOffset(Offset = "0x18")]
	protected float _deltaTime;

	[Token(Token = "0x4003133")]
	[FieldOffset(Offset = "0x20")]
	private List<object> _pausers;

	[Token(Token = "0x1700072B")]
	public float Time
	{
		[Token(Token = "0x6003920")]
		[Address(RVA = "0xACF9E8", Offset = "0xACF9E8", VA = "0xACF9E8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700072C")]
	public float TimeScale
	{
		[Token(Token = "0x6003921")]
		[Address(RVA = "0xACF9F0", Offset = "0xACF9F0", VA = "0xACF9F0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6003922")]
		[Address(RVA = "0xACFA70", Offset = "0xACFA70", VA = "0xACFA70")]
		set
		{
		}
	}

	[Token(Token = "0x1700072D")]
	public float DeltaTime
	{
		[Token(Token = "0x6003923")]
		[Address(RVA = "0xACFA78", Offset = "0xACFA78", VA = "0xACFA78")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700072E")]
	public bool Paused
	{
		[Token(Token = "0x6003924")]
		[Address(RVA = "0xACFA1C", Offset = "0xACFA1C", VA = "0xACFA1C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6003925")]
	[Address(RVA = "0xACFAA4", Offset = "0xACFAA4", VA = "0xACFAA4")]
	public TimeReferential()
	{
	}

	[Token(Token = "0x6003926")]
	[Address(RVA = "0xACFB34", Offset = "0xACFB34", VA = "0xACFB34")]
	public void Pause(object owner)
	{
	}

	[Token(Token = "0x6003927")]
	[Address(RVA = "0xACFB98", Offset = "0xACFB98", VA = "0xACFB98")]
	public bool Resume(object owner)
	{
		return default(bool);
	}

	[Token(Token = "0x6003928")]
	[Address(RVA = "0xACFC2C", Offset = "0xACFC2C", VA = "0xACFC2C")]
	public void Update(float baseDeltaTime)
	{
	}
}
