using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000174")]
public static class CharacterAnimationDefines
{
	[Token(Token = "0x2000175")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x59274C", Offset = "0x59274C")]
	public class AnimationDefineAttribute : Attribute
	{
		[Token(Token = "0x40007ED")]
		[FieldOffset(Offset = "0x10")]
		public bool Validate;

		[Token(Token = "0x40007EE")]
		[FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x40007EF")]
		[FieldOffset(Offset = "0x20")]
		public Type KeyType;

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0x86192C", Offset = "0x86192C", VA = "0x86192C")]
		public AnimationDefineAttribute(string name, Type keyType, bool validate = true)
		{
		}
	}

	[Token(Token = "0x40007BB")]
	[FieldOffset(Offset = "0x0")]
	public static readonly int BASE_LAYER;

	[Token(Token = "0x40007BC")]
	[FieldOffset(Offset = "0x4")]
	public static readonly int BASE_FEMALE_LAYER;

	[Token(Token = "0x40007BD")]
	[FieldOffset(Offset = "0x8")]
	public static readonly int ARM_RIGHT_LAYER;

	[Token(Token = "0x40007BE")]
	[FieldOffset(Offset = "0xC")]
	public static readonly int REACT_LAYER;

	[Token(Token = "0x40007BF")]
	[FieldOffset(Offset = "0x10")]
	public static readonly int REACT_FEMALE_LAYER;

	[Token(Token = "0x40007C0")]
	[FieldOffset(Offset = "0x14")]
	public static readonly int ADDITIVE_LAYER;

	[Token(Token = "0x40007C1")]
	[FieldOffset(Offset = "0x18")]
	public static readonly int ADDITIVE_FEMALE_LAYER;

	[Token(Token = "0x40007C2")]
	[FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B0A84", Offset = "0x5B0A84")]
	public static int SPEED;

	[Token(Token = "0x40007C3")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B0B00", Offset = "0x5B0B00")]
	public static int DIRECTION;

	[Token(Token = "0x40007C4")]
	[FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B0B7C", Offset = "0x5B0B7C")]
	public static int TURN_ON_SPOT;

	[Token(Token = "0x40007C5")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B0BF8", Offset = "0x5B0BF8")]
	public static int STOP_SPEED;

	[Token(Token = "0x40007C6")]
	[FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B0C74", Offset = "0x5B0C74")]
	public static int MOVE_STOP;

	[Token(Token = "0x40007C7")]
	[FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B0CF0", Offset = "0x5B0CF0")]
	public static int MOVE_ANTICIPATIION;

	[Token(Token = "0x40007C8")]
	[FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B0D6C", Offset = "0x5B0D6C")]
	public static int STAIRS_INDEX;

	[Token(Token = "0x40007C9")]
	[FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B0DE8", Offset = "0x5B0DE8")]
	public static int DAMAGE_TYPE;

	[Token(Token = "0x40007CA")]
	[FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B0E64", Offset = "0x5B0E64")]
	public static int DEATH;

	[Token(Token = "0x40007CB")]
	[FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B0EE0", Offset = "0x5B0EE0")]
	public static int DEATHINDEX;

	[Token(Token = "0x40007CC")]
	[FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B0F5C", Offset = "0x5B0F5C")]
	public static int ATTITUDE_INDEX;

	[Token(Token = "0x40007CD")]
	[FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B0FD8", Offset = "0x5B0FD8")]
	public static int STATE_INDEX;

	[Token(Token = "0x40007CE")]
	[FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B1054", Offset = "0x5B1054")]
	public static int STATE_INDEX_DELAY;

	[Token(Token = "0x40007CF")]
	[FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B10D0", Offset = "0x5B10D0")]
	public static int SET_STANCE;

	[Token(Token = "0x40007D0")]
	[FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B114C", Offset = "0x5B114C")]
	public static int STANCE;

	[Token(Token = "0x40007D1")]
	[FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B11C8", Offset = "0x5B11C8")]
	public static int IDLE_TYPE;

	[Token(Token = "0x40007D2")]
	[FieldOffset(Offset = "0x5C")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B1244", Offset = "0x5B1244")]
	public static int IDLE_OUT;

	[Token(Token = "0x40007D3")]
	[FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B12C0", Offset = "0x5B12C0")]
	public static int IDLE_BREAKER_INDEX;

	[Token(Token = "0x40007D4")]
	[FieldOffset(Offset = "0x64")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B133C", Offset = "0x5B133C")]
	public static int IDLE_BREAKER;

	[Token(Token = "0x40007D5")]
	[FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B13B8", Offset = "0x5B13B8")]
	public static int IDLE_TYPE_INDEX;

	[Token(Token = "0x40007D6")]
	[FieldOffset(Offset = "0x6C")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B1434", Offset = "0x5B1434")]
	public static int ACTION_STAND_UP;

	[Token(Token = "0x40007D7")]
	[FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B14B0", Offset = "0x5B14B0")]
	public static int INTERCEPT;

	[Token(Token = "0x40007D8")]
	[FieldOffset(Offset = "0x74")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B152C", Offset = "0x5B152C")]
	public static int ARREST_INDEX;

	[Token(Token = "0x40007D9")]
	[FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B15A8", Offset = "0x5B15A8")]
	public static int ARRESTED_INDEX;

	[Token(Token = "0x40007DA")]
	[FieldOffset(Offset = "0x7C")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B1624", Offset = "0x5B1624")]
	public static int COVER_INDEX;

	[Token(Token = "0x40007DB")]
	[FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B16A0", Offset = "0x5B16A0")]
	public static int WAS_WOUNDED;

	[Token(Token = "0x40007DC")]
	[FieldOffset(Offset = "0x84")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B171C", Offset = "0x5B171C")]
	public static int HIT_DIRECTION;

	[Token(Token = "0x40007DD")]
	[FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B1798", Offset = "0x5B1798")]
	public static int BULLET_TYPE;

	[Token(Token = "0x40007DE")]
	[FieldOffset(Offset = "0x8C")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B1814", Offset = "0x5B1814")]
	public static int REACTION_TYPE;

	[Token(Token = "0x40007DF")]
	[FieldOffset(Offset = "0x90")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B1890", Offset = "0x5B1890")]
	public static int REACTION_DIRECTION;

	[Token(Token = "0x40007E0")]
	[FieldOffset(Offset = "0x94")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B190C", Offset = "0x5B190C")]
	public static int REACT_HURT_INDEX;

	[Token(Token = "0x40007E1")]
	[FieldOffset(Offset = "0x98")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B1988", Offset = "0x5B1988")]
	public static int PROP_ID_LH;

	[Token(Token = "0x40007E2")]
	[FieldOffset(Offset = "0x9C")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B1A04", Offset = "0x5B1A04")]
	public static int PROP_ID_RH;

	[Token(Token = "0x40007E3")]
	[FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B1A80", Offset = "0x5B1A80")]
	public static int DOT_TYPE;

	[Token(Token = "0x40007E4")]
	[FieldOffset(Offset = "0xA4")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B1AFC", Offset = "0x5B1AFC")]
	public static int RANDOM_ANIM_INDEX;

	[Token(Token = "0x40007E5")]
	[FieldOffset(Offset = "0xA8")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B1B78", Offset = "0x5B1B78")]
	public static int SPAWNING_DONE;

	[Token(Token = "0x40007E6")]
	[FieldOffset(Offset = "0xAC")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B1BF4", Offset = "0x5B1BF4")]
	public static int IS_SCREAMING;

	[Token(Token = "0x40007E7")]
	[FieldOffset(Offset = "0xB0")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B1C70", Offset = "0x5B1C70")]
	public static int IS_ATTACKING;

	[Token(Token = "0x40007E8")]
	[FieldOffset(Offset = "0xB4")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B1CEC", Offset = "0x5B1CEC")]
	public static int IS_ATTACKED;

	[Token(Token = "0x40007E9")]
	[FieldOffset(Offset = "0xB8")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B1D68", Offset = "0x5B1D68")]
	public static int IS_JUMP_ATTACKING;

	[Token(Token = "0x40007EA")]
	[FieldOffset(Offset = "0xBC")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B1DE4", Offset = "0x5B1DE4")]
	public static int IS_MASS_CONFUSED;

	[Token(Token = "0x40007EB")]
	[FieldOffset(Offset = "0xC0")]
	[AttributeAttribute(Name = "AnimationDefineAttribute", RVA = "0x5B1E60", Offset = "0x5B1E60")]
	public static int RANDOM_100;

	[Token(Token = "0x40007EC")]
	[FieldOffset(Offset = "0xC8")]
	private static Dictionary<int, AnimationDefineAttribute> _animDefines;

	[Token(Token = "0x60009A4")]
	[Address(RVA = "0xAFAB6C", Offset = "0xAFAB6C", VA = "0xAFAB6C")]
	public static void CopyLayers(Animator source, Animator dest)
	{
	}

	[Token(Token = "0x60009A5")]
	[Address(RVA = "0xAFAC60", Offset = "0xAFAC60", VA = "0xAFAC60")]
	public static void CopyVariables(Animator source, Animator dest)
	{
	}

	[Token(Token = "0x60009A6")]
	[Address(RVA = "0xAFB01C", Offset = "0xAFB01C", VA = "0xAFB01C")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x612CF8", Offset = "0x612CF8")]
	public static void ValidateVariables(Animator animator)
	{
	}

	[Token(Token = "0x60009A7")]
	[Address(RVA = "0xAFB330", Offset = "0xAFB330", VA = "0xAFB330")]
	static CharacterAnimationDefines()
	{
	}
}
