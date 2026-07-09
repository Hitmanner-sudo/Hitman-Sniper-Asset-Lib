using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200086C")]
public class OneFingerGesture : FingerGesture
{
	[Token(Token = "0x4002F3D")]
	[FieldOffset(Offset = "0x30")]
	public bool CreatedFromBrokenMoreFingerGesture;

	[Token(Token = "0x4002F3E")]
	[FieldOffset(Offset = "0x34")]
	private float _startTapTime;

	[Token(Token = "0x4002F3F")]
	[FieldOffset(Offset = "0x38")]
	private Vector2 _startTapPos;

	[Token(Token = "0x4002F40")]
	[FieldOffset(Offset = "0x40")]
	private bool _hasTouch;

	[Token(Token = "0x4002F41")]
	[FieldOffset(Offset = "0x44")]
	private Vector2 _lastTouchPos;

	[Token(Token = "0x4002F42")]
	[FieldOffset(Offset = "0x4C")]
	private Vector2 _lastDragPos;

	[Token(Token = "0x4002F43")]
	[FieldOffset(Offset = "0x54")]
	private Vector2 _dragDirRaw;

	[Token(Token = "0x4002F44")]
	[FieldOffset(Offset = "0x5C")]
	private Vector2 _dragDir;

	[Token(Token = "0x4002F45")]
	[FieldOffset(Offset = "0x64")]
	private Vector3 _smoothAccelVelocity;

	[Token(Token = "0x4002F46")]
	[FieldOffset(Offset = "0x70")]
	private Vector3 _smoothDecelVelocity;

	[Token(Token = "0x4002F47")]
	[FieldOffset(Offset = "0x7C")]
	private float _dragSpeedMultiplier;

	[Token(Token = "0x4002F48")]
	[FieldOffset(Offset = "0x80")]
	private float _dragSpeedMultiplierVelocity;

	[Token(Token = "0x17000700")]
	public float SetStartTapTime
	{
		[Token(Token = "0x6003706")]
		[Address(RVA = "0x9F6F2C", Offset = "0x9F6F2C", VA = "0x9F6F2C")]
		set
		{
		}
	}

	[Token(Token = "0x17000701")]
	public override bool HasTouch
	{
		[Token(Token = "0x6003707")]
		[Address(RVA = "0x9F6F34", Offset = "0x9F6F34", VA = "0x9F6F34", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000702")]
	protected float PinchTimeWindow
	{
		[Token(Token = "0x6003708")]
		[Address(RVA = "0x9F6F3C", Offset = "0x9F6F3C", VA = "0x9F6F3C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000703")]
	protected float TapTime
	{
		[Token(Token = "0x6003709")]
		[Address(RVA = "0x9F6F60", Offset = "0x9F6F60", VA = "0x9F6F60")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000704")]
	protected float MaxTapDistance
	{
		[Token(Token = "0x600370A")]
		[Address(RVA = "0x9F6F84", Offset = "0x9F6F84", VA = "0x9F6F84")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000705")]
	private float HorizontalSpeed
	{
		[Token(Token = "0x600370B")]
		[Address(RVA = "0x9F6FA8", Offset = "0x9F6FA8", VA = "0x9F6FA8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000706")]
	private float VerticalSpeed
	{
		[Token(Token = "0x600370C")]
		[Address(RVA = "0x9F6FCC", Offset = "0x9F6FCC", VA = "0x9F6FCC")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000707")]
	private float MovementDamping
	{
		[Token(Token = "0x600370D")]
		[Address(RVA = "0x9F6FF0", Offset = "0x9F6FF0", VA = "0x9F6FF0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000708")]
	private float StationnaryDamping
	{
		[Token(Token = "0x600370E")]
		[Address(RVA = "0x9F7014", Offset = "0x9F7014", VA = "0x9F7014")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000709")]
	private float StopDamping
	{
		[Token(Token = "0x600370F")]
		[Address(RVA = "0x9F7038", Offset = "0x9F7038", VA = "0x9F7038")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6003710")]
	[Address(RVA = "0x9F705C", Offset = "0x9F705C", VA = "0x9F705C")]
	public OneFingerGesture(GestureSystem owner)
	{
	}

	[Token(Token = "0x6003711")]
	[Address(RVA = "0x9F70BC", Offset = "0x9F70BC", VA = "0x9F70BC", Slot = "8")]
	public override void Start()
	{
	}

	[Token(Token = "0x6003712")]
	[Address(RVA = "0x9F70EC", Offset = "0x9F70EC", VA = "0x9F70EC", Slot = "9")]
	public override void Execute(List<Touch> touches)
	{
	}

	[Token(Token = "0x6003713")]
	[Address(RVA = "0x9F7788", Offset = "0x9F7788", VA = "0x9F7788")]
	public bool CanBeCombined(OneFingerGesture other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003714")]
	[Address(RVA = "0x9F77F4", Offset = "0x9F77F4", VA = "0x9F77F4", Slot = "5")]
	public override void AddFingers(FingerInput.FingerID fingers)
	{
	}

	[Token(Token = "0x6003715")]
	[Address(RVA = "0x9F77FC", Offset = "0x9F77FC", VA = "0x9F77FC", Slot = "10")]
	public override void Stop()
	{
	}

	[Token(Token = "0x6003716")]
	[Address(RVA = "0x9F7110", Offset = "0x9F7110", VA = "0x9F7110")]
	private void UpdateTouchControl(List<Touch> touches)
	{
	}

	[Token(Token = "0x6003717")]
	[Address(RVA = "0x9F782C", Offset = "0x9F782C", VA = "0x9F782C")]
	private void UpdateInput(Vector2 inputPosition, bool isValidInput)
	{
	}

	[Token(Token = "0x6003718")]
	[Address(RVA = "0x9F7910", Offset = "0x9F7910", VA = "0x9F7910", Slot = "14")]
	protected virtual void StartTouch(Vector2 touch, Vector2 deltaTouch)
	{
	}

	[Token(Token = "0x6003719")]
	[Address(RVA = "0x9F7AB8", Offset = "0x9F7AB8", VA = "0x9F7AB8", Slot = "15")]
	protected virtual void UpdateTouch(Vector2 touch, Vector2 deltaTouch)
	{
	}

	[Token(Token = "0x600371A")]
	[Address(RVA = "0x9F7B44", Offset = "0x9F7B44", VA = "0x9F7B44", Slot = "16")]
	protected virtual void EndTouch(Vector2 touch, Vector2 deltaTouch)
	{
	}

	[Token(Token = "0x600371B")]
	[Address(RVA = "0x9F794C", Offset = "0x9F794C", VA = "0x9F794C")]
	private void StartTap(Vector2 touch)
	{
	}

	[Token(Token = "0x600371C")]
	[Address(RVA = "0x9F7B68", Offset = "0x9F7B68", VA = "0x9F7B68")]
	private void EndTap(Vector2 touch)
	{
	}

	[Token(Token = "0x600371D")]
	[Address(RVA = "0x9F7A24", Offset = "0x9F7A24", VA = "0x9F7A24")]
	private void StartDrag(Vector2 touch, Vector2 deltaTouch)
	{
	}

	[Token(Token = "0x600371E")]
	[Address(RVA = "0x9F7ABC", Offset = "0x9F7ABC", VA = "0x9F7ABC")]
	private void UpdateDrag(Vector2 touch, Vector2 deltaTouch)
	{
	}

	[Token(Token = "0x600371F")]
	[Address(RVA = "0x9F7D64", Offset = "0x9F7D64", VA = "0x9F7D64")]
	private void EndDrag(Vector2 touch, Vector2 deltaTouch)
	{
	}

	[Token(Token = "0x6003720")]
	[Address(RVA = "0x9F72AC", Offset = "0x9F72AC", VA = "0x9F72AC")]
	private void PostProcessDrag()
	{
	}
}
