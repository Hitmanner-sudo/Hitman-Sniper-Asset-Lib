using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000941")]
public class skydomeScript2 : MonoBehaviour
{
	[Token(Token = "0x4003232")]
	[FieldOffset(Offset = "0x18")]
	public Light sunLight;

	[Token(Token = "0x4003233")]
	[FieldOffset(Offset = "0x20")]
	public GameObject SkyDome;

	[Token(Token = "0x4003234")]
	[FieldOffset(Offset = "0x28")]
	public Camera cam;

	[Token(Token = "0x4003235")]
	[FieldOffset(Offset = "0x30")]
	private Sun sunlightScript;

	[Token(Token = "0x4003236")]
	[FieldOffset(Offset = "0x38")]
	public bool debug;

	[Token(Token = "0x4003237")]
	[FieldOffset(Offset = "0x3C")]
	public float JULIANDATE;

	[Token(Token = "0x4003238")]
	[FieldOffset(Offset = "0x40")]
	public float LONGITUDE;

	[Token(Token = "0x4003239")]
	[FieldOffset(Offset = "0x44")]
	public float LATITUDE;

	[Token(Token = "0x400323A")]
	[FieldOffset(Offset = "0x48")]
	public float MERIDIAN;

	[Token(Token = "0x400323B")]
	[FieldOffset(Offset = "0x4C")]
	public float TIME;

	[Token(Token = "0x400323C")]
	[FieldOffset(Offset = "0x50")]
	public float m_fTurbidity;

	[Token(Token = "0x400323D")]
	[FieldOffset(Offset = "0x54")]
	public float cloudSpeed1;

	[Token(Token = "0x400323E")]
	[FieldOffset(Offset = "0x58")]
	public float cloudSpeed2;

	[Token(Token = "0x400323F")]
	[FieldOffset(Offset = "0x5C")]
	public float cloudHeight1;

	[Token(Token = "0x4003240")]
	[FieldOffset(Offset = "0x60")]
	public float cloudHeight2;

	[Token(Token = "0x4003241")]
	[FieldOffset(Offset = "0x64")]
	public float cloudTint;

	[Token(Token = "0x4003242")]
	[FieldOffset(Offset = "0x68")]
	private Vector4 vBetaRayleigh;

	[Token(Token = "0x4003243")]
	[FieldOffset(Offset = "0x78")]
	private Vector4 vBetaMie;

	[Token(Token = "0x4003244")]
	[FieldOffset(Offset = "0x88")]
	private Vector3 m_vBetaRayTheta;

	[Token(Token = "0x4003245")]
	[FieldOffset(Offset = "0x94")]
	private Vector3 m_vBetaMieTheta;

	[Token(Token = "0x4003246")]
	[FieldOffset(Offset = "0xA0")]
	public float m_fRayFactor;

	[Token(Token = "0x4003247")]
	[FieldOffset(Offset = "0xA4")]
	public float m_fMieFactor;

	[Token(Token = "0x4003248")]
	[FieldOffset(Offset = "0xA8")]
	public float m_fDirectionalityFactor;

	[Token(Token = "0x4003249")]
	[FieldOffset(Offset = "0xAC")]
	public float m_fSunColorIntensity;

	[Token(Token = "0x6003A9D")]
	[Address(RVA = "0x90E700", Offset = "0x90E700", VA = "0x90E700")]
	private void Start()
	{
	}

	[Token(Token = "0x6003A9E")]
	[Address(RVA = "0x90E7F4", Offset = "0x90E7F4", VA = "0x90E7F4")]
	private void Update()
	{
	}

	[Token(Token = "0x6003A9F")]
	[Address(RVA = "0x90EB98", Offset = "0x90EB98", VA = "0x90EB98")]
	private void calcAtmosphere()
	{
	}

	[Token(Token = "0x6003AA0")]
	[Address(RVA = "0x90EC08", Offset = "0x90EC08", VA = "0x90EC08")]
	private void calcRay()
	{
	}

	[Token(Token = "0x6003AA1")]
	[Address(RVA = "0x90EC78", Offset = "0x90EC78", VA = "0x90EC78")]
	private void CalculateMieCoeff()
	{
	}

	[Token(Token = "0x6003AA2")]
	[Address(RVA = "0x90EE44", Offset = "0x90EE44", VA = "0x90EE44")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6003AA3")]
	[Address(RVA = "0x91012C", Offset = "0x91012C", VA = "0x91012C")]
	public skydomeScript2()
	{
	}
}
