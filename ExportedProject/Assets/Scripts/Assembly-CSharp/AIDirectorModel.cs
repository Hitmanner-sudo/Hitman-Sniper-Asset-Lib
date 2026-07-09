using System;
using Il2CppDummyDll;

[Token(Token = "0x200057A")]
public class AIDirectorModel : DataModel
{
	[Token(Token = "0x4001CDD")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string AI_DIRECTOR_WAVENUMBER;

	[Token(Token = "0x4001CDE")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string AI_DIRECTOR_STRESS;

	[Token(Token = "0x4001CDF")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string AI_DIRECTOR_WAVE_SIZE;

	[Token(Token = "0x4001CE0")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string AI_DIRECTOR_ZOMBIE_ALIVE;

	[NonSerialized]
	[Token(Token = "0x4001CE1")]
	[FieldOffset(Offset = "0x48")]
	public int WaveNumber;

	[NonSerialized]
	[Token(Token = "0x4001CE2")]
	[FieldOffset(Offset = "0x4C")]
	public float Stress;

	[NonSerialized]
	[Token(Token = "0x4001CE3")]
	[FieldOffset(Offset = "0x50")]
	public float WaveSize;

	[NonSerialized]
	[Token(Token = "0x4001CE4")]
	[FieldOffset(Offset = "0x54")]
	public float ZombieAlive;

	[Token(Token = "0x600226D")]
	[Address(RVA = "0xA95350", Offset = "0xA95350", VA = "0xA95350", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x600226E")]
	[Address(RVA = "0xA95678", Offset = "0xA95678", VA = "0xA95678")]
	public AIDirectorModel()
	{
	}

	[Token(Token = "0x6002270")]
	[Address(RVA = "0xA95748", Offset = "0xA95748", VA = "0xA95748")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619DC0", Offset = "0x619DC0")]
	private int _003CBindAllVariables_003Eb__8_0()
	{
		return default(int);
	}

	[Token(Token = "0x6002271")]
	[Address(RVA = "0xA95750", Offset = "0xA95750", VA = "0xA95750")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619DD0", Offset = "0x619DD0")]
	private void _003CBindAllVariables_003Eb__8_1(int s)
	{
	}

	[Token(Token = "0x6002272")]
	[Address(RVA = "0xA95758", Offset = "0xA95758", VA = "0xA95758")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619DE0", Offset = "0x619DE0")]
	private float _003CBindAllVariables_003Eb__8_2()
	{
		return default(float);
	}

	[Token(Token = "0x6002273")]
	[Address(RVA = "0xA95760", Offset = "0xA95760", VA = "0xA95760")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619DF0", Offset = "0x619DF0")]
	private void _003CBindAllVariables_003Eb__8_3(float s)
	{
	}

	[Token(Token = "0x6002274")]
	[Address(RVA = "0xA95768", Offset = "0xA95768", VA = "0xA95768")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619E00", Offset = "0x619E00")]
	private float _003CBindAllVariables_003Eb__8_4()
	{
		return default(float);
	}

	[Token(Token = "0x6002275")]
	[Address(RVA = "0xA95770", Offset = "0xA95770", VA = "0xA95770")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619E10", Offset = "0x619E10")]
	private void _003CBindAllVariables_003Eb__8_5(float s)
	{
	}

	[Token(Token = "0x6002276")]
	[Address(RVA = "0xA95778", Offset = "0xA95778", VA = "0xA95778")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619E20", Offset = "0x619E20")]
	private float _003CBindAllVariables_003Eb__8_6()
	{
		return default(float);
	}

	[Token(Token = "0x6002277")]
	[Address(RVA = "0xA95780", Offset = "0xA95780", VA = "0xA95780")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619E30", Offset = "0x619E30")]
	private void _003CBindAllVariables_003Eb__8_7(float s)
	{
	}
}
