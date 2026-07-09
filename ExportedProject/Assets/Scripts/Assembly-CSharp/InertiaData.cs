using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000381")]
public class InertiaData : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000382")]
	public class InertiaSetting
	{
		[Token(Token = "0x400138B")]
		[FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x400138C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		internal Vector2 _minMovement;

		[Token(Token = "0x400138D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		internal Vector2 _maxMovement;

		[Token(Token = "0x400138E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		internal Vector3 _minPosition;

		[Token(Token = "0x400138F")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		internal Vector3 _maxPosition;

		[Token(Token = "0x4001390")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		internal Vector3 _pivot;

		[Token(Token = "0x4001391")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		internal Vector3 _minAngle;

		[Token(Token = "0x4001392")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		internal Vector3 _maxAngle;

		[NonSerialized]
		[Token(Token = "0x4001393")]
		[FieldOffset(Offset = "0x64")]
		internal Vector2 _minMovementModifier;

		[NonSerialized]
		[Token(Token = "0x4001394")]
		[FieldOffset(Offset = "0x6C")]
		internal Vector2 _maxMovementModifier;

		[NonSerialized]
		[Token(Token = "0x4001395")]
		[FieldOffset(Offset = "0x74")]
		internal Vector3 _minPositionModifier;

		[NonSerialized]
		[Token(Token = "0x4001396")]
		[FieldOffset(Offset = "0x80")]
		internal Vector3 _maxPositionModifier;

		[NonSerialized]
		[Token(Token = "0x4001397")]
		[FieldOffset(Offset = "0x8C")]
		internal Vector3 _pivotModifier;

		[NonSerialized]
		[Token(Token = "0x4001398")]
		[FieldOffset(Offset = "0x98")]
		internal Vector3 _minAngleModifier;

		[NonSerialized]
		[Token(Token = "0x4001399")]
		[FieldOffset(Offset = "0xA4")]
		internal Vector3 _maxAngleModifier;

		[Token(Token = "0x17000337")]
		public Vector2 MinMovement
		{
			[Token(Token = "0x6001566")]
			[Address(RVA = "0xB25948", Offset = "0xB25948", VA = "0xB25948")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x17000338")]
		public Vector2 MaxMovement
		{
			[Token(Token = "0x6001567")]
			[Address(RVA = "0xB2595C", Offset = "0xB2595C", VA = "0xB2595C")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x17000339")]
		public Vector3 MinPosition
		{
			[Token(Token = "0x6001568")]
			[Address(RVA = "0xB25970", Offset = "0xB25970", VA = "0xB25970")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700033A")]
		public Vector3 MaxPosition
		{
			[Token(Token = "0x6001569")]
			[Address(RVA = "0xB25990", Offset = "0xB25990", VA = "0xB25990")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700033B")]
		public Vector3 Pivot
		{
			[Token(Token = "0x600156A")]
			[Address(RVA = "0xB259B0", Offset = "0xB259B0", VA = "0xB259B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700033C")]
		public Vector3 MinAngle
		{
			[Token(Token = "0x600156B")]
			[Address(RVA = "0xB259D0", Offset = "0xB259D0", VA = "0xB259D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700033D")]
		public Vector3 MaxAngle
		{
			[Token(Token = "0x600156C")]
			[Address(RVA = "0xB259F0", Offset = "0xB259F0", VA = "0xB259F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700033E")]
		public Quaternion MinRotation
		{
			[Token(Token = "0x600156D")]
			[Address(RVA = "0xB25A10", Offset = "0xB25A10", VA = "0xB25A10")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x1700033F")]
		public Quaternion MaxRotation
		{
			[Token(Token = "0x600156E")]
			[Address(RVA = "0xB25A34", Offset = "0xB25A34", VA = "0xB25A34")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x600156F")]
		[Address(RVA = "0xB25A58", Offset = "0xB25A58", VA = "0xB25A58")]
		public void ResetModifiers()
		{
		}

		[Token(Token = "0x6001570")]
		[Address(RVA = "0xB25ADC", Offset = "0xB25ADC", VA = "0xB25ADC")]
		public InertiaSetting()
		{
		}
	}

	[Token(Token = "0x2000383")]
	public enum InertiaSettingEnum
	{
		[Token(Token = "0x400139B")]
		OutHorizontal = 0,
		[Token(Token = "0x400139C")]
		OutVertical = 1,
		[Token(Token = "0x400139D")]
		InHorizontal = 2,
		[Token(Token = "0x400139E")]
		InVertical = 3,
		[Token(Token = "0x400139F")]
		Count = 4
	}

	[Token(Token = "0x4001383")]
	[FieldOffset(Offset = "0x18")]
	public InertiaSetting[] Inertia;

	[Token(Token = "0x4001384")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _outOfScopeAccelDampSpeed;

	[Token(Token = "0x4001385")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _outOfScopeDecelDampSpeed;

	[NonSerialized]
	[Token(Token = "0x4001386")]
	[FieldOffset(Offset = "0x28")]
	public float OutOfScopeDampSpeedModifier;

	[Token(Token = "0x4001387")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float _inScopeAccelDampSpeed;

	[Token(Token = "0x4001388")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float _inScopeDecelDampSpeed;

	[NonSerialized]
	[Token(Token = "0x4001389")]
	[FieldOffset(Offset = "0x34")]
	public float InScopeDampSpeedModifier;

	[Token(Token = "0x400138A")]
	[FieldOffset(Offset = "0x38")]
	public float InScopeMovementThreshold;

	[Token(Token = "0x17000333")]
	public float OutOfScopeAccelDampSpeed
	{
		[Token(Token = "0x6001560")]
		[Address(RVA = "0xB0DAEC", Offset = "0xB0DAEC", VA = "0xB0DAEC")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000334")]
	public float OutOfScopeDecelDampSpeed
	{
		[Token(Token = "0x6001561")]
		[Address(RVA = "0xB0DAFC", Offset = "0xB0DAFC", VA = "0xB0DAFC")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000335")]
	public float InScopeAccelDampSpeed
	{
		[Token(Token = "0x6001562")]
		[Address(RVA = "0xB0DB08", Offset = "0xB0DB08", VA = "0xB0DB08")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000336")]
	public float InScopeDecelDampSpeed
	{
		[Token(Token = "0x6001563")]
		[Address(RVA = "0xB0DB18", Offset = "0xB0DB18", VA = "0xB0DB18")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6001564")]
	[Address(RVA = "0xB0DB24", Offset = "0xB0DB24", VA = "0xB0DB24")]
	public void ResetModifiers()
	{
	}

	[Token(Token = "0x6001565")]
	[Address(RVA = "0xB0DB98", Offset = "0xB0DB98", VA = "0xB0DB98")]
	public InertiaData()
	{
	}
}
