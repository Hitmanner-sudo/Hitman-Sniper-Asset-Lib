using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200038D")]
public class RecoilSystem
{
	[Token(Token = "0x40013BD")]
	[FieldOffset(Offset = "0x10")]
	private List<RecoilItem> _recoils;

	[Token(Token = "0x6001595")]
	[Address(RVA = "0xB42BF8", Offset = "0xB42BF8", VA = "0xB42BF8")]
	public void AddRecoil(RecoilData[] recoils)
	{
	}

	[Token(Token = "0x6001596")]
	[Address(RVA = "0xB42E08", Offset = "0xB42E08", VA = "0xB42E08")]
	public void AddRecoildPlayerTime(RecoilData[] recoils)
	{
	}

	[Token(Token = "0x6001597")]
	[Address(RVA = "0xB42CD0", Offset = "0xB42CD0", VA = "0xB42CD0")]
	private RecoilItem AddRecoil(RecoilData recoilData)
	{
		return null;
	}

	[Token(Token = "0x6001598")]
	[Address(RVA = "0xB42F30", Offset = "0xB42F30", VA = "0xB42F30")]
	public void Execute()
	{
	}

	[Token(Token = "0x6001599")]
	[Address(RVA = "0xB43050", Offset = "0xB43050", VA = "0xB43050")]
	public void ApplyRecoil(ref Vector3 translation, ref Quaternion rotation)
	{
	}

	[Token(Token = "0x600159A")]
	[Address(RVA = "0xB43118", Offset = "0xB43118", VA = "0xB43118")]
	public RecoilSystem()
	{
	}
}
