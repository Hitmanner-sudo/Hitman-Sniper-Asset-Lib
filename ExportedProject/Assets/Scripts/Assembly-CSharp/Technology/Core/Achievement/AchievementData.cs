using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Core.Achievement
{
	[Serializable]
	[Token(Token = "0x2000E37")]
	public class AchievementData
	{
		[Token(Token = "0x400436C")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5BF734", Offset = "0x5BF734")]
		[SerializeField]
		private string _id;

		[Token(Token = "0x400436D")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5BF780", Offset = "0x5BF780")]
		[SerializeField]
		private string _googlePlayGamesId;

		[Token(Token = "0x400436E")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5BF7CC", Offset = "0x5BF7CC")]
		[SerializeField]
		private string _amazonId;

		[Token(Token = "0x400436F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5BF818", Offset = "0x5BF818")]
		private string _gameCenterId;

		[Token(Token = "0x4004370")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5BF864", Offset = "0x5BF864")]
		[SerializeField]
		private string _steamId;

		[Token(Token = "0x4004371")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5BF8B0", Offset = "0x5BF8B0")]
		[SerializeField]
		private string _oculusId;

		[Token(Token = "0x4004372")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5BF8FC", Offset = "0x5BF8FC")]
		private string _sonyId;

		[Token(Token = "0x4004373")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5BF948", Offset = "0x5BF948")]
		private string _steamStatId;

		[Token(Token = "0x4004374")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5BF994", Offset = "0x5BF994")]
		[SerializeField]
		private string _title;

		[Token(Token = "0x4004375")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5BF9E0", Offset = "0x5BF9E0")]
		[SerializeField]
		private string _achievedDescription;

		[Token(Token = "0x4004376")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5BFA2C", Offset = "0x5BFA2C")]
		[SerializeField]
		private string _unachievedDescription;

		[Token(Token = "0x4004377")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5BFA78", Offset = "0x5BFA78")]
		[SerializeField]
		private Texture2D _achievedImage;

		[Token(Token = "0x4004378")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5BFAC4", Offset = "0x5BFAC4")]
		[SerializeField]
		private Texture2D _unachievedImage;

		[Token(Token = "0x4004379")]
		[FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5BFB10", Offset = "0x5BFB10")]
		[SerializeField]
		private bool _hidden;

		[Token(Token = "0x400437A")]
		[FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5BFB5C", Offset = "0x5BFB5C")]
		[SerializeField]
		private int _steps;

		[Token(Token = "0x400437B")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5BFBA8", Offset = "0x5BFBA8")]
		private int _points;

		[Token(Token = "0x17000BA6")]
		public string Id
		{
			[Token(Token = "0x6005765")]
			[Address(RVA = "0xAA8284", Offset = "0xAA8284", VA = "0xAA8284")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BA7")]
		public string GooglePlayGamesId
		{
			[Token(Token = "0x6005766")]
			[Address(RVA = "0xAA828C", Offset = "0xAA828C", VA = "0xAA828C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BA8")]
		public string AmazonId
		{
			[Token(Token = "0x6005767")]
			[Address(RVA = "0xAA8294", Offset = "0xAA8294", VA = "0xAA8294")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BA9")]
		public string GameCenterId
		{
			[Token(Token = "0x6005768")]
			[Address(RVA = "0xAA829C", Offset = "0xAA829C", VA = "0xAA829C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BAA")]
		public string SteamId
		{
			[Token(Token = "0x6005769")]
			[Address(RVA = "0xAA82A4", Offset = "0xAA82A4", VA = "0xAA82A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BAB")]
		public string OculusID
		{
			[Token(Token = "0x600576A")]
			[Address(RVA = "0xAA82AC", Offset = "0xAA82AC", VA = "0xAA82AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BAC")]
		public string SonyID
		{
			[Token(Token = "0x600576B")]
			[Address(RVA = "0xAA82B4", Offset = "0xAA82B4", VA = "0xAA82B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BAD")]
		public string SteamStatId
		{
			[Token(Token = "0x600576C")]
			[Address(RVA = "0xAA82BC", Offset = "0xAA82BC", VA = "0xAA82BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BAE")]
		public string Title
		{
			[Token(Token = "0x600576D")]
			[Address(RVA = "0xAA82C4", Offset = "0xAA82C4", VA = "0xAA82C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BAF")]
		public string AchievedDescription
		{
			[Token(Token = "0x600576E")]
			[Address(RVA = "0xAA82CC", Offset = "0xAA82CC", VA = "0xAA82CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BB0")]
		public string UnachievedDescription
		{
			[Token(Token = "0x600576F")]
			[Address(RVA = "0xAA82D4", Offset = "0xAA82D4", VA = "0xAA82D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BB1")]
		public Texture2D AchievedImage
		{
			[Token(Token = "0x6005770")]
			[Address(RVA = "0xAA82DC", Offset = "0xAA82DC", VA = "0xAA82DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BB2")]
		public Texture2D UnachievedImage
		{
			[Token(Token = "0x6005771")]
			[Address(RVA = "0xAA82E4", Offset = "0xAA82E4", VA = "0xAA82E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BB3")]
		public bool Hidden
		{
			[Token(Token = "0x6005772")]
			[Address(RVA = "0xAA82EC", Offset = "0xAA82EC", VA = "0xAA82EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000BB4")]
		public int Steps
		{
			[Token(Token = "0x6005773")]
			[Address(RVA = "0xAA82F4", Offset = "0xAA82F4", VA = "0xAA82F4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000BB5")]
		public int Points
		{
			[Token(Token = "0x6005774")]
			[Address(RVA = "0xAA82FC", Offset = "0xAA82FC", VA = "0xAA82FC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6005775")]
		[Address(RVA = "0xAA8304", Offset = "0xAA8304", VA = "0xAA8304")]
		public AchievementData()
		{
		}
	}
}
