using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000040")]
	public class WaypointCircuit : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000041")]
		public class WaypointList
		{
			[Token(Token = "0x400014A")]
			[FieldOffset(Offset = "0x10")]
			public WaypointCircuit circuit;

			[Token(Token = "0x400014B")]
			[FieldOffset(Offset = "0x18")]
			public Transform[] items;

			[Token(Token = "0x6000175")]
			[Address(RVA = "0x18BE6A4", Offset = "0x18BE6A4", VA = "0x18BE6A4")]
			public WaypointList()
			{
			}
		}

		[Token(Token = "0x2000042")]
		public struct RoutePoint
		{
			[Token(Token = "0x400014C")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x400014D")]
			[FieldOffset(Offset = "0xC")]
			public Vector3 direction;

			[Token(Token = "0x6000176")]
			[Address(RVA = "0x18BE290", Offset = "0x18BE290", VA = "0x18BE290")]
			public RoutePoint(Vector3 position, Vector3 direction)
			{
			}
		}

		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x18")]
		public WaypointList waypointList;

		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool smoothRoute;

		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x24")]
		private int numPoints;

		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x28")]
		private Vector3[] points;

		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x30")]
		private float[] distances;

		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x38")]
		public float editorVisualisationSubsteps;

		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9438", Offset = "0x6F9438")]
		private float _003CLength_003Ek__BackingField;

		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x40")]
		private int p0n;

		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x44")]
		private int p1n;

		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x48")]
		private int p2n;

		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x4C")]
		private int p3n;

		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x50")]
		private float i;

		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x54")]
		private Vector3 P0;

		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x60")]
		private Vector3 P1;

		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 P2;

		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x78")]
		private Vector3 P3;

		[Token(Token = "0x17000015")]
		public float Length
		{
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x18BDC44", Offset = "0x18BDC44", VA = "0x18BDC44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FA370", Offset = "0x6FA370")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x18BDC4C", Offset = "0x18BDC4C", VA = "0x18BDC4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FA380", Offset = "0x6FA380")]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public Transform[] Waypoints
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x18BDC54", Offset = "0x18BDC54", VA = "0x18BDC54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x18BDC70", Offset = "0x18BDC70", VA = "0x18BDC70")]
		private void Awake()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x18BDF78", Offset = "0x18BDF78", VA = "0x18BDF78")]
		public RoutePoint GetRoutePoint(float dist)
		{
			return default(RoutePoint);
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x18BE004", Offset = "0x18BE004", VA = "0x18BE004")]
		public Vector3 GetRoutePosition(float dist)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x18BE2A0", Offset = "0x18BE2A0", VA = "0x18BE2A0")]
		private Vector3 CatmullRom(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float i)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x18BDCCC", Offset = "0x18BDCCC", VA = "0x18BDCCC")]
		private void CachePositionsAndDistances()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x18BE3AC", Offset = "0x18BE3AC", VA = "0x18BE3AC")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x18BE62C", Offset = "0x18BE62C", VA = "0x18BE62C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x18BE3B4", Offset = "0x18BE3B4", VA = "0x18BE3B4")]
		private void DrawGizmos(bool selected)
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x18BE634", Offset = "0x18BE634", VA = "0x18BE634")]
		public WaypointCircuit()
		{
		}
	}
}
