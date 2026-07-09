using System.Collections.Generic;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x2000129")]
[AutoInstantiate]
[Scope]
public class AIAudioSetup : GameSingleton<AIAudioSetup>
{
	[Token(Token = "0x4000672")]
	[FieldOffset(Offset = "0x48")]
	[HideInInspector]
	public List<AudioVolume> AudioVolumes;

	[Token(Token = "0x600080E")]
	[Address(RVA = "0xA91B08", Offset = "0xA91B08", VA = "0xA91B08")]
	public AIAudioSetup()
	{
	}
}
