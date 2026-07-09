using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200061B")]
public class RotateOnDrag : MonoBehaviour
{
	[Token(Token = "0x200061C")]
	public class DragTimeStamp
	{
		[Token(Token = "0x40021B2")]
		[FieldOffset(Offset = "0x10")]
		public float YAngle;

		[Token(Token = "0x40021B3")]
		[FieldOffset(Offset = "0x14")]
		public float TimeStamp;

		[Token(Token = "0x6002797")]
		[Address(RVA = "0x8B5984", Offset = "0x8B5984", VA = "0x8B5984")]
		public DragTimeStamp()
		{
		}
	}

	[Token(Token = "0x400219E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool _activateAutoRotation;

	[Token(Token = "0x400219F")]
	[FieldOffset(Offset = "0x19")]
	[SerializeField]
	private bool _useGlobalTime;

	[Token(Token = "0x40021A0")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private Vector3 _defaultStartingAngle;

	[Token(Token = "0x40021A1")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _autoRotationsPerSecond;

	[Token(Token = "0x40021A2")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private Vector3 _autoRotationAxis;

	[Token(Token = "0x40021A3")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float _dragRotationsMultiplier;

	[Token(Token = "0x40021A4")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private Vector3 _dragRotationAxis;

	[Token(Token = "0x40021A5")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private int _zAngleMinValue;

	[Token(Token = "0x40021A6")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private int _zAngleMaxValue;

	[Token(Token = "0x40021A7")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private bool _resetZPositionAfterDrag;

	[Token(Token = "0x40021A8")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	private float _resetZAngleLerpTime;

	[Token(Token = "0x40021A9")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private float _dragContinuationTime;

	[Token(Token = "0x40021AA")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private float _dragContinuationLerpTime;

	[Token(Token = "0x40021AB")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private bool _keepLocalRotation;

	[Token(Token = "0x40021AC")]
	[FieldOffset(Offset = "0x61")]
	private bool _isDragging;

	[Token(Token = "0x40021AD")]
	[FieldOffset(Offset = "0x68")]
	private List<DragTimeStamp> _dragTimeStampList;

	[Token(Token = "0x40021AE")]
	[FieldOffset(Offset = "0x70")]
	private float _originalZAngle;

	[Token(Token = "0x40021AF")]
	[FieldOffset(Offset = "0x74")]
	private float _destinationZAngle;

	[Token(Token = "0x40021B0")]
	[FieldOffset(Offset = "0x78")]
	private float _dragContinuationAverage;

	[Token(Token = "0x40021B1")]
	[FieldOffset(Offset = "0x7C")]
	private float _currentTime;

	[Token(Token = "0x6002791")]
	[Address(RVA = "0xBA4ED8", Offset = "0xBA4ED8", VA = "0xBA4ED8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002792")]
	[Address(RVA = "0xBA5044", Offset = "0xBA5044", VA = "0xBA5044")]
	private void Update()
	{
	}

	[Token(Token = "0x6002793")]
	[Address(RVA = "0xBA4EDC", Offset = "0xBA4EDC", VA = "0xBA4EDC")]
	private void UpdatePosition()
	{
	}

	[Token(Token = "0x6002794")]
	[Address(RVA = "0xBA5080", Offset = "0xBA5080", VA = "0xBA5080")]
	private void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x6002795")]
	[Address(RVA = "0xBA520C", Offset = "0xBA520C", VA = "0xBA520C")]
	private void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x6002796")]
	[Address(RVA = "0xBA5410", Offset = "0xBA5410", VA = "0xBA5410")]
	public RotateOnDrag()
	{
	}
}
