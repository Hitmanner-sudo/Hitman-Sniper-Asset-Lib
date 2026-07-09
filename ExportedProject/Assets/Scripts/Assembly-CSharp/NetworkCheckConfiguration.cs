using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20008D1")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x596C2C", Offset = "0x596C2C")]
public class NetworkCheckConfiguration : ScriptableObject
{
	[Token(Token = "0x20008D2")]
	public enum NetworkCheck
	{
		[Token(Token = "0x40030EB")]
		None = 0,
		[Token(Token = "0x40030EC")]
		Blocking = 1,
		[Token(Token = "0x40030ED")]
		Unblocking = 2
	}

	[Token(Token = "0x40030E3")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	internal NetworkCheck _checkOnInit;

	[Token(Token = "0x40030E4")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	internal NetworkCheck _checkOnMissionInit;

	[Token(Token = "0x40030E5")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	internal NetworkCheck _checkOnMissionCompleted;

	[Token(Token = "0x40030E6")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	internal NetworkCheck _checkOnDeathValleyInit;

	[Token(Token = "0x40030E7")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	internal NetworkCheck _checkOnDeathValleyCompleted;

	[Token(Token = "0x40030E8")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	internal NetworkCheck _checkOnInventoryModification;

	[Token(Token = "0x40030E9")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	internal NetworkCheck _checkOnLeaderboardRequest;

	[Token(Token = "0x60038D6")]
	[Address(RVA = "0xC596A0", Offset = "0xC596A0", VA = "0xC596A0")]
	public NetworkCheckConfiguration()
	{
	}
}
