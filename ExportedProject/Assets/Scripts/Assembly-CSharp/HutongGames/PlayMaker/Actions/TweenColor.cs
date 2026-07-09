using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011CD")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A9AD4", Offset = "0x5A9AD4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A9AD4", Offset = "0x5A9AD4")]
	public class TweenColor : TweenPropertyBase<FsmColor>
	{
		[Token(Token = "0x20011CE")]
		public enum Target
		{
			[Token(Token = "0x400551B")]
			GameObject = 0,
			[Token(Token = "0x400551C")]
			Variable = 1
		}

		[Token(Token = "0x20011CF")]
		public enum TargetType
		{
			[Token(Token = "0x400551E")]
			None = 0,
			[Token(Token = "0x400551F")]
			Material = 1,
			[Token(Token = "0x4005520")]
			Sprite = 2,
			[Token(Token = "0x4005521")]
			Image = 3,
			[Token(Token = "0x4005522")]
			Text = 4,
			[Token(Token = "0x4005523")]
			Light = 5
		}

		[Token(Token = "0x400550B")]
		private const string SupportedComponents = "MeshRenderer, Sprite, Image, Text, Light.";

		[Token(Token = "0x400550C")]
		private const string OffsetTooltip = "How to apply the Offset Color. Similar to Photoshop Blend modes. \nNote: use the color alpha to fade the blend.";

		[Token(Token = "0x400550D")]
		[FieldOffset(Offset = "0xD8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FF594", Offset = "0x5FF594")]
		public Target target;

		[Token(Token = "0x400550E")]
		[FieldOffset(Offset = "0xE0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FF5CC", Offset = "0x5FF5CC")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400550F")]
		[FieldOffset(Offset = "0xE8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FF604", Offset = "0x5FF604")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FF604", Offset = "0x5FF604")]
		public FsmColor variable;

		[Token(Token = "0x4005510")]
		[FieldOffset(Offset = "0xF0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FF654", Offset = "0x5FF654")]
		public ColorBlendMode fromOffsetBlendMode;

		[Token(Token = "0x4005511")]
		[FieldOffset(Offset = "0xF4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FF68C", Offset = "0x5FF68C")]
		public ColorBlendMode toOffsetBlendMode;

		[Token(Token = "0x4005512")]
		[FieldOffset(Offset = "0xF8")]
		private GameObject cachedGameObject;

		[Token(Token = "0x4005513")]
		[FieldOffset(Offset = "0x100")]
		private Component cachedComponent;

		[Token(Token = "0x4005514")]
		[FieldOffset(Offset = "0x108")]
		private TargetType targetType;

		[Token(Token = "0x4005515")]
		[FieldOffset(Offset = "0x110")]
		private Material material;

		[Token(Token = "0x4005516")]
		[FieldOffset(Offset = "0x118")]
		private SpriteRenderer spriteRenderer;

		[Token(Token = "0x4005517")]
		[FieldOffset(Offset = "0x120")]
		private Text text;

		[Token(Token = "0x4005518")]
		[FieldOffset(Offset = "0x128")]
		private Image image;

		[Token(Token = "0x4005519")]
		[FieldOffset(Offset = "0x130")]
		private Light light;

		[Token(Token = "0x17000C47")]
		public TargetType type
		{
			[Token(Token = "0x60068BD")]
			[Address(RVA = "0xCACEF8", Offset = "0xCACEF8", VA = "0xCACEF8")]
			get
			{
				return default(TargetType);
			}
		}

		[Token(Token = "0x60068BE")]
		[Address(RVA = "0xCACF00", Offset = "0xCACF00", VA = "0xCACF00", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60068BF")]
		[Address(RVA = "0xCACF5C", Offset = "0xCACF5C", VA = "0xCACF5C")]
		private void UpdateCache(GameObject go)
		{
		}

		[Token(Token = "0x60068C0")]
		[Address(RVA = "0xCAD160", Offset = "0xCAD160", VA = "0xCAD160")]
		private void CheckCache()
		{
		}

		[Token(Token = "0x60068C1")]
		[Address(RVA = "0xCAD20C", Offset = "0xCAD20C", VA = "0xCAD20C")]
		private void Init()
		{
		}

		[Token(Token = "0x60068C2")]
		[Address(RVA = "0xCAD4E4", Offset = "0xCAD4E4", VA = "0xCAD4E4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60068C3")]
		[Address(RVA = "0xCAD66C", Offset = "0xCAD66C", VA = "0xCAD66C", Slot = "64")]
		protected override void InitTargets()
		{
		}

		[Token(Token = "0x60068C4")]
		[Address(RVA = "0xCAD870", Offset = "0xCAD870", VA = "0xCAD870")]
		private Color GetTargetColor()
		{
			return default(Color);
		}

		[Token(Token = "0x60068C5")]
		[Address(RVA = "0xCAD96C", Offset = "0xCAD96C", VA = "0xCAD96C")]
		private void SetTargetColor(Color color)
		{
		}

		[Token(Token = "0x60068C6")]
		[Address(RVA = "0xCAD55C", Offset = "0xCAD55C", VA = "0xCAD55C")]
		private void InitOffsets()
		{
		}

		[Token(Token = "0x60068C7")]
		[Address(RVA = "0xCADA6C", Offset = "0xCADA6C", VA = "0xCADA6C", Slot = "65")]
		protected override object GetOffsetValue(object value, object offset)
		{
			return null;
		}

		[Token(Token = "0x60068C8")]
		[Address(RVA = "0xCADA74", Offset = "0xCADA74", VA = "0xCADA74", Slot = "63")]
		protected override void DoTween()
		{
		}

		[Token(Token = "0x60068C9")]
		[Address(RVA = "0xCADBA8", Offset = "0xCADBA8", VA = "0xCADBA8")]
		public TweenColor()
		{
		}
	}
}
