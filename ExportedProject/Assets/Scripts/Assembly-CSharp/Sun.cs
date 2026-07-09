using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000940")]
public class Sun : MonoBehaviour
{
	[Token(Token = "0x4003226")]
	[FieldOffset(Offset = "0x18")]
	public GameObject mainManager;

	[Token(Token = "0x4003227")]
	[FieldOffset(Offset = "0x20")]
	private skydomeScript2 skydomeScript;

	[Token(Token = "0x4003228")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 m_vDirection;

	[Token(Token = "0x4003229")]
	[FieldOffset(Offset = "0x34")]
	public Vector3 m_vColor;

	[Token(Token = "0x400322A")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 sunDirection;

	[Token(Token = "0x400322B")]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 sunDirection2;

	[Token(Token = "0x400322C")]
	[FieldOffset(Offset = "0x58")]
	private float SolarAzimuth;

	[Token(Token = "0x400322D")]
	[FieldOffset(Offset = "0x5C")]
	private float solarAltitude;

	[Token(Token = "0x400322E")]
	[FieldOffset(Offset = "0x60")]
	private Vector3 sunPosition;

	[Token(Token = "0x400322F")]
	[FieldOffset(Offset = "0x6C")]
	public float domeRadius;

	[Token(Token = "0x4003230")]
	[FieldOffset(Offset = "0x70")]
	public float m_fTheta;

	[Token(Token = "0x4003231")]
	[FieldOffset(Offset = "0x74")]
	public float m_fPhi;

	[Token(Token = "0x6003A95")]
	[Address(RVA = "0xD2F08C", Offset = "0xD2F08C", VA = "0xD2F08C")]
	private void Start()
	{
	}

	[Token(Token = "0x6003A96")]
	[Address(RVA = "0xD2F180", Offset = "0xD2F180", VA = "0xD2F180")]
	private void Update()
	{
	}

	[Token(Token = "0x6003A97")]
	[Address(RVA = "0xD2F3DC", Offset = "0xD2F3DC", VA = "0xD2F3DC")]
	private void SetPosition(float fTheta, float fPhi)
	{
	}

	[Token(Token = "0x6003A98")]
	[Address(RVA = "0xD2F1F8", Offset = "0xD2F1F8", VA = "0xD2F1F8")]
	private void SetPosition2(float fTime)
	{
	}

	[Token(Token = "0x6003A99")]
	[Address(RVA = "0xD2F5D8", Offset = "0xD2F5D8", VA = "0xD2F5D8")]
	private Vector3 calcDirection(float thetaSun, float phiSun)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6003A9A")]
	[Address(RVA = "0xD2F574", Offset = "0xD2F574", VA = "0xD2F574")]
	private Vector3 sphericalToCartesian(Vector3 sunDir)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6003A9B")]
	[Address(RVA = "0xD2F660", Offset = "0xD2F660", VA = "0xD2F660")]
	private void ComputeAttenuation()
	{
	}

	[Token(Token = "0x6003A9C")]
	[Address(RVA = "0xD2F940", Offset = "0xD2F940", VA = "0xD2F940")]
	public Sun()
	{
	}
}
