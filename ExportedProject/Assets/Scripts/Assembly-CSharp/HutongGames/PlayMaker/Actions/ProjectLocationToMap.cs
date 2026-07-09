using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F81")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59D588", Offset = "0x59D588")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59D588", Offset = "0x59D588")]
	public class ProjectLocationToMap : FsmStateAction
	{
		[Token(Token = "0x2000F82")]
		public enum MapProjection
		{
			[Token(Token = "0x400492F")]
			EquidistantCylindrical = 0,
			[Token(Token = "0x4004930")]
			Mercator = 1
		}

		[Token(Token = "0x400491E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D1844", Offset = "0x5D1844")]
		public FsmVector3 GPSLocation;

		[Token(Token = "0x400491F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D187C", Offset = "0x5D187C")]
		public MapProjection mapProjection;

		[Token(Token = "0x4004920")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D18B4", Offset = "0x5D18B4")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5D18B4", Offset = "0x5D18B4")]
		[Attribute(Name = "ActionSection", RVA = "0x5D18B4", Offset = "0x5D18B4")]
		public FsmFloat minLongitude;

		[Token(Token = "0x4004921")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5D1934", Offset = "0x5D1934")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D1934", Offset = "0x5D1934")]
		public FsmFloat maxLongitude;

		[Token(Token = "0x4004922")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5D1990", Offset = "0x5D1990")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D1990", Offset = "0x5D1990")]
		public FsmFloat minLatitude;

		[Token(Token = "0x4004923")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5D19EC", Offset = "0x5D19EC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D19EC", Offset = "0x5D19EC")]
		public FsmFloat maxLatitude;

		[Token(Token = "0x4004924")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D1A48", Offset = "0x5D1A48")]
		[Attribute(Name = "ActionSection", RVA = "0x5D1A48", Offset = "0x5D1A48")]
		public FsmFloat minX;

		[Token(Token = "0x4004925")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D1AA8", Offset = "0x5D1AA8")]
		public FsmFloat minY;

		[Token(Token = "0x4004926")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D1AE0", Offset = "0x5D1AE0")]
		public FsmFloat width;

		[Token(Token = "0x4004927")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D1B18", Offset = "0x5D1B18")]
		public FsmFloat height;

		[Token(Token = "0x4004928")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D1B50", Offset = "0x5D1B50")]
		[Attribute(Name = "ActionSection", RVA = "0x5D1B50", Offset = "0x5D1B50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D1B50", Offset = "0x5D1B50")]
		public FsmFloat projectedX;

		[Token(Token = "0x4004929")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D1BC4", Offset = "0x5D1BC4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D1BC4", Offset = "0x5D1BC4")]
		public FsmFloat projectedY;

		[Token(Token = "0x400492A")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D1C14", Offset = "0x5D1C14")]
		public FsmBool normalized;

		[Token(Token = "0x400492B")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D1C4C", Offset = "0x5D1C4C")]
		public bool everyFrame;

		[Token(Token = "0x400492C")]
		[FieldOffset(Offset = "0xBC")]
		private float x;

		[Token(Token = "0x400492D")]
		[FieldOffset(Offset = "0xC0")]
		private float y;

		[Token(Token = "0x6005E6E")]
		[Address(RVA = "0xB39920", Offset = "0xB39920", VA = "0xB39920", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005E6F")]
		[Address(RVA = "0xB39A44", Offset = "0xB39A44", VA = "0xB39A44", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005E70")]
		[Address(RVA = "0xB39C70", Offset = "0xB39C70", VA = "0xB39C70", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005E71")]
		[Address(RVA = "0xB39A9C", Offset = "0xB39A9C", VA = "0xB39A9C")]
		private void DoProjectGPSLocation()
		{
		}

		[Token(Token = "0x6005E72")]
		[Address(RVA = "0xB39C74", Offset = "0xB39C74", VA = "0xB39C74")]
		private void DoEquidistantCylindrical()
		{
		}

		[Token(Token = "0x6005E73")]
		[Address(RVA = "0xB39D3C", Offset = "0xB39D3C", VA = "0xB39D3C")]
		private void DoMercatorProjection()
		{
		}

		[Token(Token = "0x6005E74")]
		[Address(RVA = "0xB39E10", Offset = "0xB39E10", VA = "0xB39E10")]
		private static float LatitudeToMercator(float latitudeInDegrees)
		{
			return default(float);
		}

		[Token(Token = "0x6005E75")]
		[Address(RVA = "0xB39E5C", Offset = "0xB39E5C", VA = "0xB39E5C")]
		public ProjectLocationToMap()
		{
		}
	}
}
