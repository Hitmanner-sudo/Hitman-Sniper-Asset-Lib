using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007E0")]
public class ShaderManager : MonoBehaviour
{
	[Token(Token = "0x4002BED")]
	[FieldOffset(Offset = "0x0")]
	private static bool _warmedUp;

	[Token(Token = "0x4002BEE")]
	private const int TICS_PER_SECOND = 1048576;

	[Token(Token = "0x4002BEF")]
	private const int LOOP_TICS = 503316480;

	[Token(Token = "0x4002BF0")]
	private const float MAX_DELTA_TIME = 480f;

	[Token(Token = "0x4002BF1")]
	[FieldOffset(Offset = "0x18")]
	private int _timeInTics;

	[Token(Token = "0x6003397")]
	[Address(RVA = "0x83DCC4", Offset = "0x83DCC4", VA = "0x83DCC4")]
	protected void Awake()
	{
	}

	[Token(Token = "0x6003398")]
	[Address(RVA = "0x83DD34", Offset = "0x83DD34", VA = "0x83DD34")]
	protected void Update()
	{
	}

	[Token(Token = "0x6003399")]
	[Address(RVA = "0x83DE04", Offset = "0x83DE04", VA = "0x83DE04")]
	public ShaderManager()
	{
	}
}
