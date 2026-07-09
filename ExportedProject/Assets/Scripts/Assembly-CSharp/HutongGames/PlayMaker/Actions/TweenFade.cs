using System;
using HutongGames.PlayMaker.TweenEnums;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011D0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5A9B24", Offset = "0x5A9B24")]
	[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x5A9B24", Offset = "0x5A9B24")]
	public class TweenFade : TweenActionBase
	{
		[Token(Token = "0x20011D1")]
		public enum TargetType
		{
			[Token(Token = "0x4005535")]
			None = 0,
			[Token(Token = "0x4005536")]
			Material = 1,
			[Token(Token = "0x4005537")]
			Sprite = 2,
			[Token(Token = "0x4005538")]
			Image = 3,
			[Token(Token = "0x4005539")]
			Text = 4,
			[Token(Token = "0x400553A")]
			Light = 5,
			[Token(Token = "0x400553B")]
			AudioSource = 6,
			[Token(Token = "0x400553C")]
			CanvasGroup = 7
		}

		[Token(Token = "0x4005524")]
		private const string SupportedComponents = "MeshRenderer, Sprite, Image, Text, Light, AudioSource, or CanvasGroup component.";

		[Token(Token = "0x4005525")]
		[FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5FF6C4", Offset = "0x5FF6C4")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005526")]
		[FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5FF6FC", Offset = "0x5FF6FC")]
		public TweenDirection tweenDirection;

		[Token(Token = "0x4005527")]
		[FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5FF734", Offset = "0x5FF734")]
		public FsmFloat value;

		[Token(Token = "0x4005528")]
		[FieldOffset(Offset = "0xC8")]
		private GameObject cachedGameObject;

		[Token(Token = "0x4005529")]
		[FieldOffset(Offset = "0xD0")]
		private Component cachedComponent;

		[Token(Token = "0x400552A")]
		[FieldOffset(Offset = "0xD8")]
		private TargetType targetType;

		[Token(Token = "0x400552B")]
		[FieldOffset(Offset = "0xE0")]
		private Renderer renderer;

		[Token(Token = "0x400552C")]
		[FieldOffset(Offset = "0xE8")]
		private SpriteRenderer spriteRenderer;

		[Token(Token = "0x400552D")]
		[FieldOffset(Offset = "0xF0")]
		private Text text;

		[Token(Token = "0x400552E")]
		[FieldOffset(Offset = "0xF8")]
		private Image image;

		[Token(Token = "0x400552F")]
		[FieldOffset(Offset = "0x100")]
		private Light light;

		[Token(Token = "0x4005530")]
		[FieldOffset(Offset = "0x108")]
		private CanvasGroup canvasGroup;

		[Token(Token = "0x4005531")]
		[FieldOffset(Offset = "0x110")]
		private AudioSource audioSource;

		[Token(Token = "0x4005532")]
		[FieldOffset(Offset = "0x118")]
		private float startValue;

		[Token(Token = "0x4005533")]
		[FieldOffset(Offset = "0x11C")]
		private float endValue;

		[Token(Token = "0x17000C48")]
		public TargetType type
		{
			[Token(Token = "0x60068CA")]
			[Address(RVA = "0xCADDF8", Offset = "0xCADDF8", VA = "0xCADDF8")]
			get
			{
				return default(TargetType);
			}
		}

		[Token(Token = "0x60068CB")]
		[Address(RVA = "0xCADE00", Offset = "0xCADE00", VA = "0xCADE00", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60068CC")]
		[Address(RVA = "0xCADE30", Offset = "0xCADE30", VA = "0xCADE30")]
		private void UpdateCache(GameObject go)
		{
		}

		[Token(Token = "0x60068CD")]
		[Address(RVA = "0xCAE154", Offset = "0xCAE154", VA = "0xCAE154")]
		private void FindComponent(params Type[] components)
		{
		}

		[Token(Token = "0x60068CE")]
		[Address(RVA = "0xCAE238", Offset = "0xCAE238", VA = "0xCAE238")]
		private void CheckCache()
		{
		}

		[Token(Token = "0x60068CF")]
		[Address(RVA = "0xCAE2E4", Offset = "0xCAE2E4", VA = "0xCAE2E4")]
		private void InitTarget()
		{
		}

		[Token(Token = "0x60068D0")]
		[Address(RVA = "0xCAE67C", Offset = "0xCAE67C", VA = "0xCAE67C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60068D1")]
		[Address(RVA = "0xCAE768", Offset = "0xCAE768", VA = "0xCAE768")]
		private float GetTargetFade()
		{
			return default(float);
		}

		[Token(Token = "0x60068D2")]
		[Address(RVA = "0xCAE880", Offset = "0xCAE880", VA = "0xCAE880")]
		private void SetTargetFade(float fade)
		{
		}

		[Token(Token = "0x60068D3")]
		[Address(RVA = "0xCAEA74", Offset = "0xCAEA74", VA = "0xCAEA74", Slot = "63")]
		protected override void DoTween()
		{
		}

		[Token(Token = "0x60068D4")]
		[Address(RVA = "0xCAEAD0", Offset = "0xCAEAD0", VA = "0xCAEAD0")]
		public TweenFade()
		{
		}
	}
}
