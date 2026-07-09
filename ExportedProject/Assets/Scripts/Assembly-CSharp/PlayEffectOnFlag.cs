using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200089C")]
public class PlayEffectOnFlag : MonoBehaviour
{
	[Token(Token = "0x400301C")]
	[FieldOffset(Offset = "0x18")]
	public string ClassName;

	[Token(Token = "0x400301D")]
	[FieldOffset(Offset = "0x20")]
	public string StaticVariableName;

	[Token(Token = "0x400301E")]
	[FieldOffset(Offset = "0x28")]
	public ParticleSystem ParticleSystemObject;

	[Token(Token = "0x400301F")]
	[FieldOffset(Offset = "0x30")]
	private FieldInfo _info;

	[Token(Token = "0x6003801")]
	[Address(RVA = "0xB74EC8", Offset = "0xB74EC8", VA = "0xB74EC8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003802")]
	[Address(RVA = "0xB74F78", Offset = "0xB74F78", VA = "0xB74F78")]
	private void Update()
	{
	}

	[Token(Token = "0x6003803")]
	[Address(RVA = "0xB7505C", Offset = "0xB7505C", VA = "0xB7505C")]
	public PlayEffectOnFlag()
	{
	}
}
