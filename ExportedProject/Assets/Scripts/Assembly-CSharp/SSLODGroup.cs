using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200091E")]
public class SSLODGroup : MonoBehaviour
{
	[Token(Token = "0x40031D5")]
	[FieldOffset(Offset = "0x18")]
	public Camera PlayerCamera;

	[Token(Token = "0x40031D6")]
	[FieldOffset(Offset = "0x20")]
	public GameObject LOD0;

	[Token(Token = "0x40031D7")]
	[FieldOffset(Offset = "0x28")]
	public GameObject LOD1;

	[Token(Token = "0x40031D8")]
	[FieldOffset(Offset = "0x30")]
	public GameObject LOD2;

	[Token(Token = "0x40031D9")]
	[FieldOffset(Offset = "0x38")]
	public float Clip_LOD1;

	[Token(Token = "0x40031DA")]
	[FieldOffset(Offset = "0x3C")]
	public float Clip_LOD2;

	[Token(Token = "0x40031DB")]
	[FieldOffset(Offset = "0x40")]
	public Vector3 boundMin;

	[Token(Token = "0x40031DC")]
	[FieldOffset(Offset = "0x4C")]
	public Vector3 boundMax;

	[Token(Token = "0x40031DD")]
	[FieldOffset(Offset = "0x58")]
	public GameObject ACTIVELOD;

	[Token(Token = "0x40031DE")]
	[FieldOffset(Offset = "0x60")]
	public bool LODEnabled;

	[Token(Token = "0x40031DF")]
	[FieldOffset(Offset = "0x64")]
	public float LODSize;

	[Token(Token = "0x40031E0")]
	private const string LOD1TAG = "[LOD1]";

	[Token(Token = "0x40031E1")]
	private const string LOD2TAG = "[LOD2]";

	[Token(Token = "0x6003A24")]
	[Address(RVA = "0xBA8004", Offset = "0xBA8004", VA = "0xBA8004")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003A25")]
	[Address(RVA = "0xBA8664", Offset = "0xBA8664", VA = "0xBA8664")]
	private void Update()
	{
	}

	[Token(Token = "0x6003A26")]
	[Address(RVA = "0xBA86E4", Offset = "0xBA86E4", VA = "0xBA86E4")]
	public void UpdateLOD()
	{
	}

	[Token(Token = "0x6003A27")]
	[Address(RVA = "0xBA8404", Offset = "0xBA8404", VA = "0xBA8404")]
	public void SetLODSize(GameObject LOD)
	{
	}

	[Token(Token = "0x6003A28")]
	[Address(RVA = "0xBA8190", Offset = "0xBA8190", VA = "0xBA8190")]
	public GameObject LoadLOD(int lodRes)
	{
		return null;
	}

	[Token(Token = "0x6003A29")]
	[Address(RVA = "0xBA8940", Offset = "0xBA8940", VA = "0xBA8940")]
	public SSLODGroup()
	{
	}
}
