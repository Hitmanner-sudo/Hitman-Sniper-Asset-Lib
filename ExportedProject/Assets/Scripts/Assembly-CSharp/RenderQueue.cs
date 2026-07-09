using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007D7")]
[ExecuteInEditMode]
public class RenderQueue : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20007D8")]
	public enum QueueType
	{
		[Token(Token = "0x4002BD0")]
		None = 0,
		[Token(Token = "0x4002BD1")]
		Background = 1000,
		[Token(Token = "0x4002BD2")]
		Geometry = 2000,
		[Token(Token = "0x4002BD3")]
		AlphaTest = 2450,
		[Token(Token = "0x4002BD4")]
		Transparent = 3000,
		[Token(Token = "0x4002BD5")]
		Overlay = 4000
	}

	[Token(Token = "0x4002BCD")]
	[FieldOffset(Offset = "0x18")]
	public QueueType Queue;

	[Token(Token = "0x4002BCE")]
	[FieldOffset(Offset = "0x1C")]
	public int QueueOffset;

	[Token(Token = "0x170006A2")]
	private int renderQueue
	{
		[Token(Token = "0x6003373")]
		[Address(RVA = "0x965E28", Offset = "0x965E28", VA = "0x965E28")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6003374")]
	[Address(RVA = "0x965E34", Offset = "0x965E34", VA = "0x965E34")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6003375")]
	[Address(RVA = "0x965F48", Offset = "0x965F48", VA = "0x965F48")]
	public RenderQueue()
	{
	}
}
