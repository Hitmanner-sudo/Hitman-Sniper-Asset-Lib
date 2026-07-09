using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004F1")]
public class BezierSpline : MonoBehaviour
{
	[Token(Token = "0x4001A72")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Vector3[] _points;

	[Token(Token = "0x4001A73")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Bezier.BezierControlPointMode[] _modes;

	[Token(Token = "0x4001A74")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool _loop;

	[Token(Token = "0x170004B6")]
	public int ControlPointCount
	{
		[Token(Token = "0x6001E6F")]
		[Address(RVA = "0xC10990", Offset = "0xC10990", VA = "0xC10990")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170004B7")]
	public int CurveCount
	{
		[Token(Token = "0x6001E70")]
		[Address(RVA = "0xC109AC", Offset = "0xC109AC", VA = "0xC109AC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170004B8")]
	public bool Loop
	{
		[Token(Token = "0x6001E74")]
		[Address(RVA = "0xC10C70", Offset = "0xC10C70", VA = "0xC10C70")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001E75")]
		[Address(RVA = "0xC10C78", Offset = "0xC10C78", VA = "0xC10C78")]
		set
		{
		}
	}

	[Token(Token = "0x6001E71")]
	[Address(RVA = "0xC109E4", Offset = "0xC109E4", VA = "0xC109E4")]
	public Vector3 GetControlPoint(int index)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001E72")]
	[Address(RVA = "0xC10A2C", Offset = "0xC10A2C", VA = "0xC10A2C")]
	public Bezier.BezierControlPointMode GetControlPointMode(int index)
	{
		return default(Bezier.BezierControlPointMode);
	}

	[Token(Token = "0x6001E73")]
	[Address(RVA = "0xC10A84", Offset = "0xC10A84", VA = "0xC10A84")]
	public Vector3 GetDirection(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001E76")]
	[Address(RVA = "0xC10CEC", Offset = "0xC10CEC", VA = "0xC10CEC")]
	public void SetControlPoint(int index, Vector3 point)
	{
	}

	[Token(Token = "0x6001E77")]
	[Address(RVA = "0xC11140", Offset = "0xC11140", VA = "0xC11140")]
	public void SetControlPointMode(int index, Bezier.BezierControlPointMode mode)
	{
	}

	[Token(Token = "0x6001E78")]
	[Address(RVA = "0xC10F34", Offset = "0xC10F34", VA = "0xC10F34")]
	private void EnforceMode(int index)
	{
	}

	[Token(Token = "0x6001E79")]
	[Address(RVA = "0xC111E8", Offset = "0xC111E8", VA = "0xC111E8")]
	public Vector3 GetPoint(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001E7A")]
	[Address(RVA = "0xC10AB4", Offset = "0xC10AB4", VA = "0xC10AB4")]
	public Vector3 GetVelocity(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001E7B")]
	[Address(RVA = "0xC11360", Offset = "0xC11360", VA = "0xC11360")]
	public void AddCurve()
	{
	}

	[Token(Token = "0x6001E7C")]
	[Address(RVA = "0xC115A4", Offset = "0xC115A4", VA = "0xC115A4")]
	public void Reset()
	{
	}

	[Token(Token = "0x6001E7D")]
	[Address(RVA = "0xC11690", Offset = "0xC11690", VA = "0xC11690")]
	public BezierSpline()
	{
	}
}
