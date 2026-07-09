using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000043")]
	public class WaypointProgressTracker : MonoBehaviour
	{
		[Token(Token = "0x2000044")]
		public enum ProgressStyle
		{
			[Token(Token = "0x400015E")]
			SmoothAlongRoute = 0,
			[Token(Token = "0x400015F")]
			PointToPoint = 1
		}

		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private WaypointCircuit circuit;

		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float lookAheadForTargetOffset;

		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float lookAheadForTargetFactor;

		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float lookAheadForSpeedOffset;

		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float lookAheadForSpeedFactor;

		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ProgressStyle progressStyle;

		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float pointToPointThreshold;

		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F94B8", Offset = "0x6F94B8")]
		private WaypointCircuit.RoutePoint _003CtargetPoint_003Ek__BackingField;

		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F94C8", Offset = "0x6F94C8")]
		private WaypointCircuit.RoutePoint _003CspeedPoint_003Ek__BackingField;

		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F94D8", Offset = "0x6F94D8")]
		private WaypointCircuit.RoutePoint _003CprogressPoint_003Ek__BackingField;

		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x80")]
		public Transform target;

		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x88")]
		private float progressDistance;

		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x8C")]
		private int progressNum;

		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x90")]
		private Vector3 lastPosition;

		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x9C")]
		private float speed;

		[Token(Token = "0x17000017")]
		public WaypointCircuit.RoutePoint targetPoint
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x18BE700", Offset = "0x18BE700", VA = "0x18BE700")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FA390", Offset = "0x6FA390")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x18BE714", Offset = "0x18BE714", VA = "0x18BE714")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FA3A0", Offset = "0x6FA3A0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public WaypointCircuit.RoutePoint speedPoint
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x18BE728", Offset = "0x18BE728", VA = "0x18BE728")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FA3B0", Offset = "0x6FA3B0")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x18BE73C", Offset = "0x18BE73C", VA = "0x18BE73C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FA3C0", Offset = "0x6FA3C0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public WaypointCircuit.RoutePoint progressPoint
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x18BE750", Offset = "0x18BE750", VA = "0x18BE750")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FA3D0", Offset = "0x6FA3D0")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x18BE764", Offset = "0x18BE764", VA = "0x18BE764")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FA3E0", Offset = "0x6FA3E0")]
			private set
			{
			}
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x18BE778", Offset = "0x18BE778", VA = "0x18BE778")]
		private void Start()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x18BE870", Offset = "0x18BE870", VA = "0x18BE870")]
		public void Reset()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x18BE948", Offset = "0x18BE948", VA = "0x18BE948")]
		private void Update()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x18BED44", Offset = "0x18BED44", VA = "0x18BED44")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x18BEE94", Offset = "0x18BEE94", VA = "0x18BEE94")]
		public WaypointProgressTracker()
		{
		}
	}
}
