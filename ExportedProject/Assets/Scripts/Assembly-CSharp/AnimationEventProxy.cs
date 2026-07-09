using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200016D")]
public class AnimationEventProxy : MonoBehaviour
{
	[Token(Token = "0x200016E")]
	public delegate void AnimEventDelegate(GameObject sender, AnimationEvent ev);

	[Token(Token = "0x14000019")]
	public event AnimEventDelegate OnAnimEvent
	{
		[Token(Token = "0x600097F")]
		[Address(RVA = "0xD458E0", Offset = "0xD458E0", VA = "0xD458E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x612C38", Offset = "0x612C38")]
		add
		{
		}
		[Token(Token = "0x6000980")]
		[Address(RVA = "0xD45980", Offset = "0xD45980", VA = "0xD45980")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x612C48", Offset = "0x612C48")]
		remove
		{
		}
	}

	[Token(Token = "0x1400001A")]
	public event AnimEventDelegate OnSoundEvent
	{
		[Token(Token = "0x6000981")]
		[Address(RVA = "0xD45A20", Offset = "0xD45A20", VA = "0xD45A20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x612C58", Offset = "0x612C58")]
		add
		{
		}
		[Token(Token = "0x6000982")]
		[Address(RVA = "0xD45AC0", Offset = "0xD45AC0", VA = "0xD45AC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x612C68", Offset = "0x612C68")]
		remove
		{
		}
	}

	[Token(Token = "0x6000983")]
	[Address(RVA = "0xD45B60", Offset = "0xD45B60", VA = "0xD45B60")]
	protected void AnimEvent(AnimationEvent ev)
	{
	}

	[Token(Token = "0x6000984")]
	[Address(RVA = "0xD45C30", Offset = "0xD45C30", VA = "0xD45C30")]
	public AnimationEventProxy()
	{
	}
}
