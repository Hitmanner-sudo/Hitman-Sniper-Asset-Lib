using HutongGames.PlayMaker;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007B4")]
public static class FsmUtils
{
	[Token(Token = "0x60032C7")]
	[Address(RVA = "0x95D944", Offset = "0x95D944", VA = "0x95D944")]
	public static void SendFsmEvent(this Fsm fsm, string eventstr)
	{
	}

	[Token(Token = "0x60032C8")]
	[Address(RVA = "0x95D954", Offset = "0x95D954", VA = "0x95D954")]
	public static void SendFsmEvent(this PlayMakerFSM fsm, string eventstr)
	{
	}

	[Token(Token = "0x60032C9")]
	[Address(RVA = "0x95DA10", Offset = "0x95DA10", VA = "0x95DA10")]
	public static void SetFloatVariable(this Fsm fsm, string varName, float varValue)
	{
	}

	[Token(Token = "0x60032CA")]
	[Address(RVA = "0x95DA4C", Offset = "0x95DA4C", VA = "0x95DA4C")]
	public static void SetFloatVariable(this PlayMakerFSM fsm, string varName, float varValue)
	{
	}

	[Token(Token = "0x60032CB")]
	[Address(RVA = "0x95DB14", Offset = "0x95DB14", VA = "0x95DB14")]
	public static void SetGameObjectVariable(this Fsm fsm, string varName, GameObject varValue)
	{
	}

	[Token(Token = "0x60032CC")]
	[Address(RVA = "0x95DB60", Offset = "0x95DB60", VA = "0x95DB60")]
	public static void SetGameObjectVariable(this PlayMakerFSM fsm, string varName, GameObject varValue)
	{
	}

	[Token(Token = "0x60032CD")]
	[Address(RVA = "0x95DC1C", Offset = "0x95DC1C", VA = "0x95DC1C")]
	public static void SetVector2Variable(this Fsm fsm, string varName, Vector2 varValue)
	{
	}

	[Token(Token = "0x60032CE")]
	[Address(RVA = "0x95DC5C", Offset = "0x95DC5C", VA = "0x95DC5C")]
	public static void SetVector2Variable(this PlayMakerFSM fsm, string varName, Vector2 varValue)
	{
	}

	[Token(Token = "0x60032CF")]
	[Address(RVA = "0x95DD2C", Offset = "0x95DD2C", VA = "0x95DD2C")]
	public static void SetVector3Variable(this Fsm fsm, string varName, Vector3 varValue)
	{
	}

	[Token(Token = "0x60032D0")]
	[Address(RVA = "0x95DD7C", Offset = "0x95DD7C", VA = "0x95DD7C")]
	public static void SetVector3Variable(this PlayMakerFSM fsm, string varName, Vector3 varValue)
	{
	}

	[Token(Token = "0x60032D1")]
	public static T GetComponent<T>(this Fsm fsm, string componentName) where T : Component
	{
		return null;
	}

	[Token(Token = "0x60032D2")]
	[Address(RVA = "0x95DE60", Offset = "0x95DE60", VA = "0x95DE60")]
	public static Faction GetInstigatorFactionFromFSM(this GameObject go)
	{
		return null;
	}

	[Token(Token = "0x60032D3")]
	[Address(RVA = "0x95DFD0", Offset = "0x95DFD0", VA = "0x95DFD0")]
	public static PlayMakerFSM GetFsmfromName(this GameObject go, string fsmName)
	{
		return null;
	}
}
