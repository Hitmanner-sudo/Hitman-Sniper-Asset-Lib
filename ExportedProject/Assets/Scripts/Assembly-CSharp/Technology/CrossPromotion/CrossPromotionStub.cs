using Il2CppDummyDll;
using UnityEngine;

namespace Technology.CrossPromotion
{
	[Token(Token = "0x2000C06")]
	public class CrossPromotionStub
	{
		[Token(Token = "0x4003C00")]
		[FieldOffset(Offset = "0x10")]
		private ICrossPromotionStrategy _strategy;

		[Token(Token = "0x4003C01")]
		[FieldOffset(Offset = "0x18")]
		private ICrossPromotionConfig _config;

		[Token(Token = "0x4003C02")]
		[FieldOffset(Offset = "0x20")]
		private CrossPromotionRecord _record;

		[Token(Token = "0x4003C03")]
		[FieldOffset(Offset = "0x28")]
		private Texture2D _texture;

		[Token(Token = "0x4003C04")]
		[FieldOffset(Offset = "0x30")]
		private Rect _rect;

		[Token(Token = "0x6004BFE")]
		[Address(RVA = "0xD87C24", Offset = "0xD87C24", VA = "0xD87C24")]
		public void SetStrategy(ICrossPromotionStrategy strategy)
		{
		}

		[Token(Token = "0x6004BFF")]
		[Address(RVA = "0xD87C2C", Offset = "0xD87C2C", VA = "0xD87C2C")]
		public void SetConfig(ICrossPromotionConfig config)
		{
		}

		[Token(Token = "0x6004C00")]
		[Address(RVA = "0xD87C34", Offset = "0xD87C34", VA = "0xD87C34")]
		public void LoadNewPromotion()
		{
		}

		[Token(Token = "0x6004C01")]
		[Address(RVA = "0xD87E54", Offset = "0xD87E54", VA = "0xD87E54")]
		public void Draw()
		{
		}

		[Token(Token = "0x6004C02")]
		[Address(RVA = "0xD87F40", Offset = "0xD87F40", VA = "0xD87F40")]
		public void HandleEvents()
		{
		}

		[Token(Token = "0x6004C03")]
		[Address(RVA = "0xD88074", Offset = "0xD88074", VA = "0xD88074")]
		public void SetRect(Rect rect)
		{
		}

		[Token(Token = "0x6004C04")]
		[Address(RVA = "0xD87FB8", Offset = "0xD87FB8", VA = "0xD87FB8")]
		private static bool IsSingleClick(Event ev)
		{
			return default(bool);
		}

		[Token(Token = "0x6004C05")]
		[Address(RVA = "0xD87FE0", Offset = "0xD87FE0", VA = "0xD87FE0")]
		private static bool IsLeftMouseButton(Event ev)
		{
			return default(bool);
		}

		[Token(Token = "0x6004C06")]
		[Address(RVA = "0xD8802C", Offset = "0xD8802C", VA = "0xD8802C")]
		private void HandleLeftMouseButtonDown(Vector2 mousePos)
		{
		}

		[Token(Token = "0x6004C07")]
		[Address(RVA = "0xD88080", Offset = "0xD88080", VA = "0xD88080")]
		public CrossPromotionStub()
		{
		}
	}
}
