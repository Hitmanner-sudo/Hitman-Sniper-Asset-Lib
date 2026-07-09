using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x20008EF")]
public class Timer
{
	[Token(Token = "0x400313D")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BB8EC", Offset = "0x5BB8EC")]
	private float _003CDuration_003Ek__BackingField;

	[Token(Token = "0x400313E")]
	[FieldOffset(Offset = "0x14")]
	private float m_StartTime;

	[Token(Token = "0x400313F")]
	[FieldOffset(Offset = "0x18")]
	private float m_PauseTime;

	[Token(Token = "0x4003140")]
	[FieldOffset(Offset = "0x1C")]
	private bool Running;

	[Token(Token = "0x4003141")]
	[FieldOffset(Offset = "0x20")]
	private TimeReferential _referential;

	[Token(Token = "0x17000734")]
	public float Duration
	{
		[Token(Token = "0x600393E")]
		[Address(RVA = "0xACFC74", Offset = "0xACFC74", VA = "0xACFC74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x624550", Offset = "0x624550")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600393F")]
		[Address(RVA = "0xACFC7C", Offset = "0xACFC7C", VA = "0xACFC7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x624560", Offset = "0x624560")]
		set
		{
		}
	}

	[Token(Token = "0x17000735")]
	public bool IsRunning
	{
		[Token(Token = "0x6003940")]
		[Address(RVA = "0xACFC84", Offset = "0xACFC84", VA = "0xACFC84")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000736")]
	public bool IsElapsed
	{
		[Token(Token = "0x6003941")]
		[Address(RVA = "0xAC6448", Offset = "0xAC6448", VA = "0xAC6448")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000737")]
	protected float CurrentTime
	{
		[Token(Token = "0x6003942")]
		[Address(RVA = "0xACFCC8", Offset = "0xACFCC8", VA = "0xACFCC8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000738")]
	public float RemainingTime
	{
		[Token(Token = "0x600394C")]
		[Address(RVA = "0xACFEF0", Offset = "0xACFEF0", VA = "0xACFEF0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000739")]
	public float ElapsedTime
	{
		[Token(Token = "0x600394D")]
		[Address(RVA = "0xACFF14", Offset = "0xACFF14", VA = "0xACFF14")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700073A")]
	public float Ratio
	{
		[Token(Token = "0x600394E")]
		[Address(RVA = "0xACFE2C", Offset = "0xACFE2C", VA = "0xACFE2C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600394F")]
		[Address(RVA = "0xACFE70", Offset = "0xACFE70", VA = "0xACFE70")]
		set
		{
		}
	}

	[Token(Token = "0x1700073B")]
	public bool Expired
	{
		[Token(Token = "0x6003950")]
		[Address(RVA = "0xACFC8C", Offset = "0xACFC8C", VA = "0xACFC8C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6003943")]
	[Address(RVA = "0xACFCE4", Offset = "0xACFCE4", VA = "0xACFCE4")]
	public Timer(TimeReferential referential)
	{
	}

	[Token(Token = "0x6003944")]
	[Address(RVA = "0xACFD10", Offset = "0xACFD10", VA = "0xACFD10")]
	public void Start()
	{
	}

	[Token(Token = "0x6003945")]
	[Address(RVA = "0xAC64DC", Offset = "0xAC64DC", VA = "0xAC64DC")]
	public void Start(float duration)
	{
	}

	[Token(Token = "0x6003946")]
	[Address(RVA = "0xACFD3C", Offset = "0xACFD3C", VA = "0xACFD3C")]
	public void Restart()
	{
	}

	[Token(Token = "0x6003947")]
	[Address(RVA = "0xACFD64", Offset = "0xACFD64", VA = "0xACFD64")]
	public void Pause()
	{
	}

	[Token(Token = "0x6003948")]
	[Address(RVA = "0xACFD90", Offset = "0xACFD90", VA = "0xACFD90")]
	public void Resume()
	{
	}

	[Token(Token = "0x6003949")]
	[Address(RVA = "0xACFDD8", Offset = "0xACFDD8", VA = "0xACFDD8")]
	public void Stop()
	{
	}

	[Token(Token = "0x600394A")]
	[Address(RVA = "0xACFDE4", Offset = "0xACFDE4", VA = "0xACFDE4")]
	public void Reverse()
	{
	}

	[Token(Token = "0x600394B")]
	[Address(RVA = "0xACFE9C", Offset = "0xACFE9C", VA = "0xACFE9C")]
	public void Reverse(float newDuration)
	{
	}
}
