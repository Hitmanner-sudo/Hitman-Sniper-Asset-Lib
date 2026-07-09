using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000077")]
[Attribute(Name = "AddComponentMenu", RVA = "0x591988", Offset = "0x591988")]
public class TweenVolume : UITweener
{
	[Token(Token = "0x4000263")]
	[FieldOffset(Offset = "0x8C")]
	[Attribute(Name = "RangeAttribute", RVA = "0x5AF3F4", Offset = "0x5AF3F4")]
	public float from;

	[Token(Token = "0x4000264")]
	[FieldOffset(Offset = "0x90")]
	[Attribute(Name = "RangeAttribute", RVA = "0x5AF40C", Offset = "0x5AF40C")]
	public float to;

	[Token(Token = "0x4000265")]
	[FieldOffset(Offset = "0x98")]
	private AudioSource mSource;

	[Token(Token = "0x17000098")]
	public AudioSource audioSource
	{
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x1574BA0", Offset = "0x1574BA0", VA = "0x1574BA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000099")]
	public float volume
	{
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x1574CD8", Offset = "0x1574CD8", VA = "0x1574CD8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x1574D78", Offset = "0x1574D78", VA = "0x1574D78")]
		set
		{
		}
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x1574E28", Offset = "0x1574E28", VA = "0x1574E28", Slot = "4")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x1574E90", Offset = "0x1574E90", VA = "0x1574E90")]
	public static TweenVolume Begin(GameObject go, float duration, float targetVolume)
	{
		return null;
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x1574F38", Offset = "0x1574F38", VA = "0x1574F38")]
	public TweenVolume()
	{
	}
}
