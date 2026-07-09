using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002DF")]
public class ZombieSpecialIntro : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20002E0")]
	public struct IntroInfo
	{
		[Token(Token = "0x4000FE4")]
		[FieldOffset(Offset = "0x0")]
		public float CameraFieldOfView;

		[Token(Token = "0x4000FE5")]
		[FieldOffset(Offset = "0x8")]
		public BezierSpline BezierSpline;

		[Token(Token = "0x4000FE6")]
		[FieldOffset(Offset = "0x10")]
		public float TravelDuration;

		[Token(Token = "0x4000FE7")]
		[FieldOffset(Offset = "0x14")]
		public float FadeToGrayDuration;

		[Token(Token = "0x4000FE8")]
		[FieldOffset(Offset = "0x18")]
		public float UIDisplayDuration;

		[Token(Token = "0x4000FE9")]
		[FieldOffset(Offset = "0x20")]
		public LazyGameObject UIToDisplay;
	}

	[Token(Token = "0x4000FE3")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private IntroInfo _introInfo;

	[Token(Token = "0x60011AC")]
	[Address(RVA = "0x8867C4", Offset = "0x8867C4", VA = "0x8867C4")]
	public void StartIntro()
	{
	}

	[Token(Token = "0x60011AD")]
	[Address(RVA = "0x88685C", Offset = "0x88685C", VA = "0x88685C")]
	public ZombieSpecialIntro()
	{
	}
}
