using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SocialPlatforms;

namespace Technology.Core.Achievement
{
	[Token(Token = "0x2000E34")]
	public abstract class AbstractAchievementDescription : IArmoryAchievementDescription, IAchievementDescription
	{
		[Token(Token = "0x4004362")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF694", Offset = "0x5BF694")]
		private string _003CId_003Ek__BackingField;

		[Token(Token = "0x4004363")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF6A4", Offset = "0x5BF6A4")]
		private string _003CTitle_003Ek__BackingField;

		[Token(Token = "0x4004364")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF6B4", Offset = "0x5BF6B4")]
		private string _003CAchievedDescription_003Ek__BackingField;

		[Token(Token = "0x4004365")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF6C4", Offset = "0x5BF6C4")]
		private Texture2D _003CAchievedImage_003Ek__BackingField;

		[Token(Token = "0x4004366")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF6D4", Offset = "0x5BF6D4")]
		private string _003CUnachievedDescription_003Ek__BackingField;

		[Token(Token = "0x4004367")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF6E4", Offset = "0x5BF6E4")]
		private Texture2D _003CUnachievedImage_003Ek__BackingField;

		[Token(Token = "0x4004368")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF6F4", Offset = "0x5BF6F4")]
		private bool _003CHidden_003Ek__BackingField;

		[Token(Token = "0x4004369")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF704", Offset = "0x5BF704")]
		private int _003CSteps_003Ek__BackingField;

		[Token(Token = "0x400436A")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF714", Offset = "0x5BF714")]
		private int _003CPoints_003Ek__BackingField;

		[Token(Token = "0x17000B96")]
		public string Id
		{
			[Token(Token = "0x6005747")]
			[Address(RVA = "0xA9E748", Offset = "0xA9E748", VA = "0xA9E748", Slot = "4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B6D0", Offset = "0x62B6D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005748")]
			[Address(RVA = "0xA9E750", Offset = "0xA9E750", VA = "0xA9E750", Slot = "5")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B6E0", Offset = "0x62B6E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000B97")]
		public string Title
		{
			[Token(Token = "0x6005749")]
			[Address(RVA = "0xA9E758", Offset = "0xA9E758", VA = "0xA9E758", Slot = "6")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B6F0", Offset = "0x62B6F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600574A")]
			[Address(RVA = "0xA9E760", Offset = "0xA9E760", VA = "0xA9E760")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B700", Offset = "0x62B700")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B98")]
		public string AchievedDescription
		{
			[Token(Token = "0x600574B")]
			[Address(RVA = "0xA9E768", Offset = "0xA9E768", VA = "0xA9E768", Slot = "7")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B710", Offset = "0x62B710")]
			get
			{
				return null;
			}
			[Token(Token = "0x600574C")]
			[Address(RVA = "0xA9E770", Offset = "0xA9E770", VA = "0xA9E770")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B720", Offset = "0x62B720")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B99")]
		public Texture2D AchievedImage
		{
			[Token(Token = "0x600574D")]
			[Address(RVA = "0xA9E778", Offset = "0xA9E778", VA = "0xA9E778", Slot = "8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B730", Offset = "0x62B730")]
			get
			{
				return null;
			}
			[Token(Token = "0x600574E")]
			[Address(RVA = "0xA9E780", Offset = "0xA9E780", VA = "0xA9E780")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B740", Offset = "0x62B740")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B9A")]
		public string UnachievedDescription
		{
			[Token(Token = "0x600574F")]
			[Address(RVA = "0xA9E788", Offset = "0xA9E788", VA = "0xA9E788", Slot = "9")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B750", Offset = "0x62B750")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005750")]
			[Address(RVA = "0xA9E790", Offset = "0xA9E790", VA = "0xA9E790")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B760", Offset = "0x62B760")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B9B")]
		public Texture2D UnachievedImage
		{
			[Token(Token = "0x6005751")]
			[Address(RVA = "0xA9E798", Offset = "0xA9E798", VA = "0xA9E798", Slot = "10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B770", Offset = "0x62B770")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005752")]
			[Address(RVA = "0xA9E7A0", Offset = "0xA9E7A0", VA = "0xA9E7A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B780", Offset = "0x62B780")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B9C")]
		public bool Hidden
		{
			[Token(Token = "0x6005753")]
			[Address(RVA = "0xA9E7A8", Offset = "0xA9E7A8", VA = "0xA9E7A8", Slot = "11")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B790", Offset = "0x62B790")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005754")]
			[Address(RVA = "0xA9E7B0", Offset = "0xA9E7B0", VA = "0xA9E7B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B7A0", Offset = "0x62B7A0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B9D")]
		public int Steps
		{
			[Token(Token = "0x6005755")]
			[Address(RVA = "0xA9E7BC", Offset = "0xA9E7BC", VA = "0xA9E7BC", Slot = "12")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B7B0", Offset = "0x62B7B0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6005756")]
			[Address(RVA = "0xA9E7C4", Offset = "0xA9E7C4", VA = "0xA9E7C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B7C0", Offset = "0x62B7C0")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000B9E")]
		public int Points
		{
			[Token(Token = "0x6005757")]
			[Address(RVA = "0xA9E7CC", Offset = "0xA9E7CC", VA = "0xA9E7CC", Slot = "13")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B7D0", Offset = "0x62B7D0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6005758")]
			[Address(RVA = "0xA9E7D4", Offset = "0xA9E7D4", VA = "0xA9E7D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B7E0", Offset = "0x62B7E0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B9F")]
		private string UnityEngine_002ESocialPlatforms_002EIAchievementDescription_002Eid
		{
			[Token(Token = "0x6005759")]
			[Address(RVA = "0xA9E7DC", Offset = "0xA9E7DC", VA = "0xA9E7DC", Slot = "15")]
			get
			{
				return null;
			}
			[Token(Token = "0x600575A")]
			[Address(RVA = "0xA9E7E4", Offset = "0xA9E7E4", VA = "0xA9E7E4", Slot = "16")]
			set
			{
			}
		}

		[Token(Token = "0x17000BA0")]
		private string UnityEngine_002ESocialPlatforms_002EIAchievementDescription_002Etitle
		{
			[Token(Token = "0x600575B")]
			[Address(RVA = "0xA9E7EC", Offset = "0xA9E7EC", VA = "0xA9E7EC", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BA1")]
		private Texture2D UnityEngine_002ESocialPlatforms_002EIAchievementDescription_002Eimage
		{
			[Token(Token = "0x600575C")]
			[Address(RVA = "0xA9E7F4", Offset = "0xA9E7F4", VA = "0xA9E7F4", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BA2")]
		private string UnityEngine_002ESocialPlatforms_002EIAchievementDescription_002EachievedDescription
		{
			[Token(Token = "0x600575D")]
			[Address(RVA = "0xA9E7FC", Offset = "0xA9E7FC", VA = "0xA9E7FC", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BA3")]
		private string UnityEngine_002ESocialPlatforms_002EIAchievementDescription_002EunachievedDescription
		{
			[Token(Token = "0x600575E")]
			[Address(RVA = "0xA9E804", Offset = "0xA9E804", VA = "0xA9E804", Slot = "20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BA4")]
		private bool UnityEngine_002ESocialPlatforms_002EIAchievementDescription_002Ehidden
		{
			[Token(Token = "0x600575F")]
			[Address(RVA = "0xA9E80C", Offset = "0xA9E80C", VA = "0xA9E80C", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000BA5")]
		private int UnityEngine_002ESocialPlatforms_002EIAchievementDescription_002Epoints
		{
			[Token(Token = "0x6005760")]
			[Address(RVA = "0xA9E814", Offset = "0xA9E814", VA = "0xA9E814", Slot = "22")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6005761")]
		[Address(RVA = "0xA9E81C", Offset = "0xA9E81C", VA = "0xA9E81C")]
		protected AbstractAchievementDescription(string id, AchievementData achievement)
		{
		}

		[Token(Token = "0x6005762")]
		[Address(RVA = "0xA9E89C", Offset = "0xA9E89C", VA = "0xA9E89C", Slot = "14")]
		public void Update(IAchievementDescription description)
		{
		}
	}
}
