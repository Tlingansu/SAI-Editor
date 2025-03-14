﻿using System;

namespace SAI_Editor.Enumerators
{
    public enum FormState
    {
        FormStateLogin,
        FormStateExpandingOrContracting,
        FormStateMain,
    }

    public enum WowExpansion
    {
        ExpansionWotlk = 0,
        ExpansionCata,
        ExpansionMop,
        ExpansionWod,
    }

    internal enum SaiEditorSizes
    {
        LoginFormWidth = 403,
        LoginFormHeight = 236,

        MainFormWidth = 969,
        MainFormHeight = 542,

        TabControlWorkspaceWidth = 934,
        TabControlWorkspaceHeight = 466,

        ListViewHeightContract = 65,

        LoginFormHeightShowWarning = 309,

        StaticTooltipsPadding = 17,
    }

    public enum SourceTypes
    {
        SourceTypeNone               = -1,
        SourceTypeCreature           = 0,
        SourceTypeGameobject         = 1,
        SourceTypeAreaTrigger        = 2,
        SourceTypeScriptedActionlist = 9,
    }

    public enum ScriptTypeId
    {
        ScriptTypeEvent,
        ScriptTypeAction,
        ScriptTypeTarget,
    }

    public enum SmartEvent
    {
        SMART_EVENT_UPDATE_IC = 0,
        SMART_EVENT_UPDATE_OOC = 1,
        SMART_EVENT_HEALT_PCT = 2,
        SMART_EVENT_MANA_PCT = 3,
        SMART_EVENT_AGGRO = 4,
        SMART_EVENT_KILL = 5,
        SMART_EVENT_DEATH = 6,
        SMART_EVENT_EVADE = 7,
        SMART_EVENT_SPELLHIT = 8,
        SMART_EVENT_RANGE = 9,
        SMART_EVENT_OOC_LOS = 10,
        SMART_EVENT_RESPAWN = 11,
        SMART_EVENT_TARGET_HEALTH_PCT = 12,
        SMART_EVENT_VICTIM_CASTING = 13,
        SMART_EVENT_FRIENDLY_HEALTH = 14,
        SMART_EVENT_FRIENDLY_IS_CC = 15,
        SMART_EVENT_FRIENDLY_MISSING_BUFF = 16,
        SMART_EVENT_SUMMONED_UNIT = 17,
        SMART_EVENT_TARGET_MANA_PCT = 18,
        SMART_EVENT_ACCEPTED_QUEST = 19,
        SMART_EVENT_REWARD_QUEST = 20,
        SMART_EVENT_REACHED_HOME = 21,
        SMART_EVENT_RECEIVE_EMOTE = 22,
        SMART_EVENT_HAS_AURA = 23,
        SMART_EVENT_TARGET_BUFFED = 24,
        SMART_EVENT_RESET = 25,
        SMART_EVENT_IC_LOS = 26,
        SMART_EVENT_PASSENGER_BOARDED = 27,
        SMART_EVENT_PASSENGER_REMOVED = 28,
        SMART_EVENT_CHARMED = 29,
        SMART_EVENT_CHARMED_TARGET = 30,
        SMART_EVENT_SPELLHIT_TARGET = 31,
        SMART_EVENT_DAMAGED = 32,
        SMART_EVENT_DAMAGED_TARGET = 33,
        SMART_EVENT_MOVEMENTINFORM = 34,
        SMART_EVENT_SUMMON_DESPAWNED = 35,
        SMART_EVENT_CORPSE_REMOVED = 36,
        SMART_EVENT_AI_INIT = 37,
        SMART_EVENT_DATA_SET = 38,
        SMART_EVENT_WAYPOINT_START = 39,
        SMART_EVENT_WAYPOINT_REACHED = 40,
        SMART_EVENT_TRANSPORT_ADDPLAYER = 41,
        SMART_EVENT_TRANSPORT_ADDCREATURE = 42,
        SMART_EVENT_TRANSPORT_REMOVE_PLAYER = 43,
        SMART_EVENT_TRANSPORT_RELOCATE = 44,
        SMART_EVENT_INSTANCE_PLAYER_ENTER = 45,
        SMART_EVENT_AREATRIGGER_ONTRIGGER = 46,
        SMART_EVENT_QUEST_ACCEPTED = 47,
        SMART_EVENT_QUEST_OBJ_COMPLETION = 48,
        SMART_EVENT_QUEST_COMPLETION = 49,
        SMART_EVENT_QUEST_REWARDED = 50,
        SMART_EVENT_QUEST_FAIL = 51,
        SMART_EVENT_TEXT_OVER = 52,
        SMART_EVENT_RECEIVE_HEAL = 53,
        SMART_EVENT_JUST_SUMMONED = 54,
        SMART_EVENT_WAYPOINT_PAUSED = 55,
        SMART_EVENT_WAYPOINT_RESUMED = 56,
        SMART_EVENT_WAYPOINT_STOPPED = 57,
        SMART_EVENT_WAYPOINT_ENDED = 58,
        SMART_EVENT_TIMED_EVENT_TRIGGERED = 59,
        SMART_EVENT_UPDATE = 60,
        SMART_EVENT_LINK = 61,
        SMART_EVENT_GOSSIP_SELECT = 62,
        SMART_EVENT_JUST_CREATED = 63,
        SMART_EVENT_GOSSIP_HELLO = 64,
        SMART_EVENT_FOLLOW_COMPLETED = 65,
        SMART_EVENT_EVENT_PHASE_CHANGE = 66,
        SMART_EVENT_IS_BEHIND_TARGET = 67,
        SMART_EVENT_GAME_EVENT_START = 68,
        SMART_EVENT_GAME_EVENT_END = 69,
        SMART_EVENT_GO_STATE_CHANGED = 70,
        SMART_EVENT_GO_EVENT_INFORM = 71,
        SMART_EVENT_ACTION_DONE = 72,
        SMART_EVENT_ON_SPELLCLICK = 73,
        SMART_EVENT_FRIENDLY_HEALTH_PCT = 74,
        SMART_EVENT_DISTANCE_CREATURE = 75,
        SMART_EVENT_DISTANCE_GAMEOBJECT = 76,
        SMART_EVENT_COUNTER_SET = 77,
        SMART_EVENT_SCENE_START = 78,
        SMART_EVENT_SCENE_TRIGGER = 79,
        SMART_EVENT_SCENE_CANCEL = 80,
        SMART_EVENT_SCENE_COMPLETE = 81,
        SMART_EVENT_SUMMONED_UNIT_DIES = 82,
        SMART_EVENT_ON_SPELL_CAST = 83,
        SMART_EVENT_ON_SPELL_FAILED = 84,
        SMART_EVENT_ON_SPELL_START = 85,
        SMART_EVENT_ON_DESPAWN = 86,
        SMART_EVENT_MAX,
    }

    public enum SmartAction
    {
        SMART_ACTION_NONE = 0,
        SMART_ACTION_TALK = 1,
        SMART_ACTION_SET_FACTION = 2,
        SMART_ACTION_MORPH_TO_ENTRY_OR_MODEL = 3,
        SMART_ACTION_SOUND = 4,
        SMART_ACTION_EMOTE = 5,
        SMART_ACTION_FAIL_QUEST = 6,
        SMART_ACTION_OFFER_QUEST = 7,
        SMART_ACTION_SET_REACT_STATE = 8,
        SMART_ACTION_ACTIVATE_GOBJECT = 9,
        SMART_ACTION_RANDOM_EMOTE = 10,
        SMART_ACTION_CAST = 11,
        SMART_ACTION_SUMMON_CREATURE = 12,
        SMART_ACTION_THREAT_SINGLE_PCT = 13,
        SMART_ACTION_THREAT_ALL_PCT = 14,
        SMART_ACTION_CALL_AREAEXPLOREDOREVENTHAPPENS = 15,
        SMART_ACTION_UNUSED_16 = 16,
        SMART_ACTION_SET_EMOTE_STATE = 17,
        SMART_ACTION_SET_UNIT_FLAG = 18,
        SMART_ACTION_REMOVE_UNIT_FLAG = 19,
        SMART_ACTION_AUTO_ATTACK = 20,
        SMART_ACTION_COMBAT_MOVEMENT = 21,
        SMART_ACTION_SET_EVENT_PHASE = 22,
        SMART_ACTION_INC_EVENT_PHASE = 23,
        SMART_ACTION_EVADE = 24,
        SMART_ACTION_FLEE_FOR_ASSIST = 25,
        SMART_ACTION_CALL_GROUPEVENTHAPPENS = 26,
        SMART_ACTION_COMBAT_STOP = 27,
        SMART_ACTION_REMOVEAURASFROMSPELL = 28,
        SMART_ACTION_FOLLOW = 29,
        SMART_ACTION_RANDOM_PHASE = 30,
        SMART_ACTION_RANDOM_PHASE_RANGE = 31,
        SMART_ACTION_RESET_GOBJECT = 32,
        SMART_ACTION_CALL_KILLEDMONSTER = 33,
        SMART_ACTION_SET_INST_DATA = 34,
        SMART_ACTION_SET_INST_DATA64 = 35,
        SMART_ACTION_UPDATE_TEMPLATE = 36,
        SMART_ACTION_DIE = 37,
        SMART_ACTION_SET_IN_COMBAT_WITH_ZONE = 38,
        SMART_ACTION_CALL_FOR_HELP = 39,
        SMART_ACTION_SET_SHEATH = 40,
        SMART_ACTION_FORCE_DESPAWN = 41,
        SMART_ACTION_SET_INVINCIBILITY_HP_LEVEL = 42,
        SMART_ACTION_MOUNT_TO_ENTRY_OR_MODEL = 43,
        SMART_ACTION_SET_PHASE_MASK = 44,
        SMART_ACTION_SET_DATA = 45,
        SMART_ACTION_MOVE_FORWARD = 46,
        SMART_ACTION_SET_VISIBILITY = 47,
        SMART_ACTION_SET_ACTIVE = 48,
        SMART_ACTION_ATTACK_START = 49,
        SMART_ACTION_SUMMON_GO = 50,
        SMART_ACTION_KILL_UNIT = 51,
        SMART_ACTION_ACTIVATE_TAXI = 52,
        SMART_ACTION_WP_START = 53,
        SMART_ACTION_WP_PAUSE = 54,
        SMART_ACTION_WP_STOP = 55,
        SMART_ACTION_ADD_ITEM = 56,
        SMART_ACTION_REMOVE_ITEM = 57,
        SMART_ACTION_INSTALL_AI_TEMPLATE = 58,
        SMART_ACTION_SET_RUN = 59,
        SMART_ACTION_SET_DISABLE_GRAVITY = 60,
        SMART_ACTION_SET_SWIM = 61,
        SMART_ACTION_TELEPORT = 62,
        SMART_ACTION_SET_COUNTER = 63,
        SMART_ACTION_STORE_TARGET_LIST = 64,
        SMART_ACTION_WP_RESUME = 65,
        SMART_ACTION_SET_ORIENTATION = 66,
        SMART_ACTION_CREATE_TIMED_EVENT = 67,
        SMART_ACTION_PLAYMOVIE = 68,
        SMART_ACTION_MOVE_TO_POS = 69,
        SMART_ACTION_RESPAWN_TARGET = 70,
        SMART_ACTION_EQUIP = 71,
        SMART_ACTION_CLOSE_GOSSIP = 72,
        SMART_ACTION_TRIGGER_TIMED_EVENT = 73,
        SMART_ACTION_REMOVE_TIMED_EVENT = 74,
        SMART_ACTION_ADD_AURA = 75,
        SMART_ACTION_OVERRIDE_SCRIPT_BASE_OBJECT = 76,
        SMART_ACTION_RESET_SCRIPT_BASE_OBJECT = 77,
        SMART_ACTION_CALL_SCRIPT_RESET = 78,
        SMART_ACTION_SET_RANGED_MOVEMENT = 79,
        SMART_ACTION_CALL_TIMED_ACTIONLIST = 80,
        SMART_ACTION_SET_NPC_FLAG = 81,
        SMART_ACTION_ADD_NPC_FLAG = 82,
        SMART_ACTION_REMOVE_NPC_FLAG = 83,
        SMART_ACTION_SIMPLE_TALK = 84,
        SMART_ACTION_INVOKER_CAST = 85,
        SMART_ACTION_CROSS_CAST = 86,
        SMART_ACTION_CALL_RANDOM_TIMED_ACTIONLIST = 87,
        SMART_ACTION_CALL_RANDOM_RANGE_TIMED_ACTIONLIST = 88,
        SMART_ACTION_RANDOM_MOVE = 89,
        SMART_ACTION_SET_UNIT_FIELD_BYTES_1 = 90,
        SMART_ACTION_REMOVE_UNIT_FIELD_BYTES_1 = 91,
        SMART_ACTION_INTERRUPT_SPELL = 92,
        SMART_ACTION_SEND_GO_CUSTOM_ANIM = 93,
        SMART_ACTION_SET_DYNAMIC_FLAG = 94,
        SMART_ACTION_ADD_DYNAMIC_FLAG = 95,
        SMART_ACTION_REMOVE_DYNAMIC_FLAG = 96,
        SMART_ACTION_JUMP_TO_POS = 97,
        SMART_ACTION_SEND_GOSSIP_MENU = 98,
        SMART_ACTION_GO_SET_LOOT_STATE = 99,
        SMART_ACTION_SEND_TARGET_TO_TARGET = 100,
        SMART_ACTION_SET_HOME_POS = 101,
        SMART_ACTION_SET_HEALTH_REGEN = 102,
        SMART_ACTION_SET_ROOT = 103,
        SMART_ACTION_SET_GO_FLAG = 104,
        SMART_ACTION_ADD_GO_FLAG = 105,
        SMART_ACTION_REMOVE_GO_FLAG = 106,
        SMART_ACTION_SUMMON_CREATURE_GROUP = 107,
        SMART_ACTION_SET_POWER = 108,
        SMART_ACTION_ADD_POWER = 109,
        SMART_ACTION_REMOVE_POWER = 110,
        SMART_ACTION_GAME_EVENT_STOP = 111,
        SMART_ACTION_GAME_EVENT_START = 112,
        SMART_ACTION_START_CLOSEST_WAYPOINT = 113,
        SMART_ACTION_MOVE_OFFSET = 114,
        SMART_ACTION_RANDOM_SOUND = 115,
        SMART_ACTION_SET_CORPSE_DELAY = 116,
        SMART_ACTION_DISABLE_EVADE = 117,
        SMART_ACTION_GO_SET_GO_STATE = 118,
        SMART_ACTION_SET_CAN_FLY = 119,
        SMART_ACTION_REMOVE_AURAS_BY_TYPE = 120,
        SMART_ACTION_SET_SIGHT_DIST = 121,
        SMART_ACTION_FLEE = 122,
        SMART_ACTION_ADD_THREAT = 123,
        SMART_ACTION_LOAD_EQUIPMENT = 124,
        SMART_ACTION_TRIGGER_RANDOM_TIMED_EVENT = 125,
        SMART_ACTION_REMOVE_ALL_GAMEOBJECTS = 126,
        SMART_ACTION_PAUSE_MOVEMENT = 127,
        SMART_ACTION_PLAY_ANIMKIT = 128,
        SMART_ACTION_SCENE_PLAY = 129,
        SMART_ACTION_SCENE_CANCEL = 130,
        SMART_ACTION_SPAWN_SPAWNGROUP = 131,
        SMART_ACTION_DESPAWN_SPAWNGROUP = 132,
        SMART_ACTION_RESPAWN_BY_SPAWNID = 133,
        SMART_ACTION_INVOKER_CAST_ = 134,
        SMART_ACTION_PLAY_CINEMATIC = 135,
        SMART_ACTION_SET_MOVEMENT_SPEED = 136,
        SMART_ACTION_PLAY_SPELL_VISUAL_KIT = 137,
        SMART_ACTION_OVERRIDE_LIGHT = 138,
        SMART_ACTION_OVERRIDE_WEATHER = 139,
        SMART_ACTION_SET_AI_ANIM_KIT = 140,
        SMART_ACTION_SET_HOVER = 141,
        SMART_ACTION_SET_HEALTH_PCT = 142,
        SMART_ACTION_CREATE_CONVERSATION = 143,
        SMART_ACTION_SET_IMMUNE_PC = 144,
        SMART_ACTION_SET_IMMUNE_NPC = 145,
        SMART_ACTION_SET_UNINTERACTIBLE = 146,
        SMART_ACTION_ACTIVATE_GAMEOBJECT = 147,
        SMART_ACTION_ADD_TO_STORED_TARGET_LIST = 148,
        SMART_ACTION_BECOME_PERSONAL_CLONE_FOR_PLAYER = 149,
        SMART_ACTION_TRIGGER_GAME_EVENT = 150,
        SMART_ACTION_DO_ACTION = 151,
        SMART_ACTION_UNUSED_152 = 152,
        SMART_ACTION_UNUSED_153 = 153,
        SMART_ACTION_UNUSED_154 = 154,
        SMART_ACTION_UNUSED_155 = 155,
        SMART_ACTION_UNUSED_156 = 156,
        SMART_ACTION_UNUSED_157 = 157,
        SMART_ACTION_UNUSED_158 = 158,
        SMART_ACTION_UNUSED_159 = 159,
        SMART_ACTION_UNUSED_160 = 160,
        SMART_ACTION_UNUSED_161 = 161,
        SMART_ACTION_UNUSED_162 = 162,
        SMART_ACTION_UNUSED_163 = 163,
        SMART_ACTION_UNUSED_164 = 164,
        SMART_ACTION_UNUSED_165 = 165,
        SMART_ACTION_UNUSED_166 = 166,
        SMART_ACTION_UNUSED_167 = 167,
        SMART_ACTION_UNUSED_168 = 168,
        SMART_ACTION_UNUSED_169 = 169,
        SMART_ACTION_UNUSED_170 = 170,
        SMART_ACTION_UNUSED_171 = 171,
        SMART_ACTION_UNUSED_172 = 172,
        SMART_ACTION_UNUSED_173 = 173,
        SMART_ACTION_UNUSED_174 = 174,
        SMART_ACTION_UNUSED_175 = 175,
        SMART_ACTION_UNUSED_176 = 176,
        SMART_ACTION_UNUSED_177 = 177,
        SMART_ACTION_UNUSED_178 = 178,
        SMART_ACTION_UNUSED_179 = 179,
        SMART_ACTION_UNUSED_180 = 180,
        SMART_ACTION_UNUSED_181 = 181,
        SMART_ACTION_UNUSED_182 = 182,
        SMART_ACTION_UNUSED_183 = 183,
        SMART_ACTION_UNUSED_184 = 184,
        SMART_ACTION_UNUSED_185 = 185,
        SMART_ACTION_UNUSED_186 = 186,
        SMART_ACTION_UNUSED_187 = 187,
        SMART_ACTION_UNUSED_188 = 188,
        SMART_ACTION_UNUSED_189 = 189,
        SMART_ACTION_UNUSED_190 = 190,
        SMART_ACTION_UNUSED_191 = 191,
        SMART_ACTION_UNUSED_192 = 192,
        SMART_ACTION_UNUSED_193 = 193,
        SMART_ACTION_UNUSED_194 = 194,
        SMART_ACTION_UNUSED_195 = 195,
        SMART_ACTION_UNUSED_196 = 196,
        SMART_ACTION_UNUSED_197 = 197,
        SMART_ACTION_UNUSED_198 = 198,
        SMART_ACTION_UNUSED_199 = 199,
        SMART_ACTION_SET_CREATURE_RESPAWN_TIME = 200,
        SMART_ACTION_MOVE_HOME_POS = 201,
        SMART_ACTION_LOAD_GRID = 202,
        SMART_ACTION_STORE_EVENT_PHASE = 203,
        SMART_ACTION_SET_STORED_EVENT_PHASE = 204,
        SMART_ACTION_CHECK_DUPLICATE_AND_DESPAWN = 205,
        SMART_ACTION_DISMOUNT = 206,
        SMART_ACTION_CHECK_HOMEDIST_AND_EVADE = 207,
        SMART_ACTION_SET_SPEED_RATE = 208,
        SMART_ACTION_LOAD_WP_PATH = 209,
        SMART_ACTION_DELETE_THREAT_LIST = 210,
        SMART_ACTION_CAST_RANDOM_SPELL = 211,
        SMART_ACTION_COMBAT_STOP_WITH_PETS = 212,
        SMART_ACTION_PAUSE_WAYPOINT_DATA_MOVEMENT = 213,
        SMART_ACTION_MOVE_TO_POS_TARGET = 214,
        SMART_ACTION_SAVE_CHECKPOINT = 215,
        SMART_ACTION_CROSS_CAST_IN_COMBAT = 216,
        SMART_ACTION_EXIT_VEHICLE = 217,
        SMART_ACTION_SET_HEALTH = 218,
        SMART_ACTION_STOP_MOTION = 219,
        SMART_ACTION_LOAD_TEMPLATE = 220,
        SMART_ACTION_SPAWN_CREATUREGROUP = 221,
        SMART_ACTION_DESPAWN_CREATUREGROUP = 222,
        SMART_ACTION_SPAWN_GAMEOBJECTGROUP = 223,
        SMART_ACTION_DESPAWN_GAMEOBJECTGROUP = 224,
        SMART_ACTION_SET_UNIT_MOVEMENT_FLAGS = 225,
        SMART_ACTION_SET_COMBAT_DISTANCE = 226,
        SMART_ACTION_ADD_IMMUNITY = 227,
        SMART_ACTION_REMOVE_IMMUNITY = 228,
        SMART_ACTION_MOVE_FALL = 229,
        SMART_ACTION_SET_EVENT_PHASE_RESET = 230,
        SMART_ACTION_ZONE_UNDER_ATTACK = 231,
        SMART_ACTION_REMOVE_LOOT_MODE = 232,
        SMART_ACTION_SET_REPUTATION_GAIN = 233,
        SMART_ACTION_ADD_LOOT_MODE = 234,
        SMART_ACTION_SET_COUNTER_RESET_OPTION = 235,
        SMART_ACTION_GO_DELETE = 236,
        SMART_ACTION_SET_LEVEL = 237,
        SMART_ACTION_SET_CREATURE_SCALE = 238,
        SMART_ACTION_SET_FEATHER_FALL = 239,
        SMART_ACTION_SET_WATER_WALKING = 240,
        SMART_ACTION_SET_MELEE_DAMAGE_SCHOOL = 241,
        SMART_ACTION_SET_UNIT_STATE = 242,
        SMART_ACTION_RESET_LOOT_MODE = 243,
        SMART_ACTION_SET_LOOT_MODE = 244,
        SMART_ACTION_MOVE_SPAWN_POS = 245,
        SMART_ACTION_SET_FLY_MODE = 246,
        SMART_ACTION_MOVE_CIRCLE_PATH = 247,
        SMART_ACTION_SET_FLAG_EXTRA = 248,
        SMART_ACTION_REMOVE_FLAG_EXTRA = 249,
        SMART_ACTION_SET_FAR_VISIBLE = 250,
        SMART_ACTION_PAUSE_RND_MOVEMENT = 251,
        SMART_ACTION_MAX,
    }

    public enum SmartTarget
    {
        SMART_TARGET_NONE = 0,
        SMART_TARGET_SELF = 1,
        SMART_TARGET_VICTIM = 2,
        SMART_TARGET_HOSTILE_SECOND_AGGRO = 3,
        SMART_TARGET_HOSTILE_LAST_AGGRO = 4,
        SMART_TARGET_HOSTILE_RANDOM = 5,
        SMART_TARGET_HOSTILE_RANDOM_NOT_TOP = 6,
        SMART_TARGET_ACTION_INVOKER = 7,
        SMART_TARGET_POSITION = 8,
        SMART_TARGET_CREATURE_RANGE = 9,
        SMART_TARGET_CREATURE_GUID = 10,
        SMART_TARGET_CREATURE_DISTANCE = 11,
        SMART_TARGET_STORED = 12,
        SMART_TARGET_GAMEOBJECT_RANGE = 13,
        SMART_TARGET_GAMEOBJECT_GUID = 14,
        SMART_TARGET_GAMEOBJECT_DISTANCE = 15,
        SMART_TARGET_INVOKER_PARTY = 16,
        SMART_TARGET_PLAYER_RANGE = 17,
        SMART_TARGET_PLAYER_DISTANCE = 18,
        SMART_TARGET_CLOSEST_CREATURE = 19,
        SMART_TARGET_CLOSEST_GAMEOBJECT = 20,
        SMART_TARGET_CLOSEST_PLAYER = 21,
        SMART_TARGET_ACTION_INVOKER_VEHICLE = 22,
        SMART_TARGET_OWNER_OR_SUMMONER = 23,
        SMART_TARGET_THREAT_LIST = 24,
        SMART_TARGET_CLOSEST_ENEMY = 25,
        SMART_TARGET_CLOSEST_FRIENDLY = 26,
        SMART_TARGET_LOOT_RECIPIENTS = 27,
        SMART_TARGET_FARTHEST = 28,
        SMART_TARGET_VEHICLE_PASSENGER = 29,
        SMART_TARGET_CLOSEST_UNSPAWNED_GAMEOBJECT = 30,
        SMART_TARGET_UNUSED_1 = 31,
        SMART_TARGET_UNUSED_2 = 32,
        SMART_TARGET_UNUSED_3 = 33,
        SMART_TARGET_UNUSED_4 = 34,
        SMART_TARGET_UNUSED_5 = 35,
        SMART_TARGET_UNUSED_6 = 36,
        SMART_TARGET_UNUSED_7 = 37,
        SMART_TARGET_UNUSED_8 = 38,
        SMART_TARGET_UNUSED_9 = 39,
        SMART_TARGET_SUMMON = 40,
        SMART_TARGET_MAX,
    }

    public enum SmartReactState
    {
        REACT_PASSIVE    = 0,
        REACT_DEFENSIVE  = 1,
        REACT_AGGRESSIVE = 2
    }

    public enum SmartSourceType
    {
        SMART_SCRIPT_TYPE_CREATURE                      = 0,
        SMART_SCRIPT_TYPE_GAMEOBJECT                    = 1,
        SMART_SCRIPT_TYPE_AREATRIGGER                   = 2,
        SMART_SCRIPT_TYPE_EVENT_NYI                     = 3,
        SMART_SCRIPT_TYPE_GOSSIP_NYI                    = 4,
        SMART_SCRIPT_TYPE_QUEST_NYI                     = 5,
        SMART_SCRIPT_TYPE_SPELL_NYI                     = 6,
        SMART_SCRIPT_TYPE_TRANSPORT_NYI                 = 7,
        SMART_SCRIPT_TYPE_INSTANCE_NYI                  = 8,
        SMART_SCRIPT_TYPE_TIMED_ACTIONLIST              = 9,
        SMART_SCRIPT_TYPE_SCENE                         = 10, // RESERVED
        SMART_SCRIPT_TYPE_AREATRIGGER_ENTITY            = 11, // RESERVED
        SMART_SCRIPT_TYPE_AREATRIGGER_ENTITY_SERVERSIDE = 12 // RESERVED
    }

    public enum SmartSummonType
    {
        TEMPSUMMON_TIMED_OR_DEAD_DESPAWN                = 1,
        TEMPSUMMON_TIMED_OR_CORPSE_DESPAWN              = 2,
        TEMPSUMMON_TIMED_DESPAWN                        = 3,
        TEMPSUMMON_TIMED_DESPAWN_OUT_OF_COMBAT          = 4,
        TEMPSUMMON_CORPSE_DESPAWN                       = 5,
        TEMPSUMMON_CORPSE_TIMED_DESPAWN                 = 6,
        TEMPSUMMON_DEAD_DESPAWN                         = 7,
        TEMPSUMMON_MANUAL_DESPAWN                       = 8
    }

    [Flags]
    public enum SmartCastFlags
    {
        SMARTCAST_NONE                                  = 0x00,
        SMARTCAST_INTERRUPT_PREVIOUS                    = 0x01,
        SMARTCAST_TRIGGERED                             = 0x02,
        //SMARTCAST_FORCE_CAST                          = 0x04,                     //Forces cast even if creature is out of mana or out of range
        //SMARTCAST_NO_MELEE_IF_OOM                     = 0x08,                     //Prevents creature from entering melee if out of mana or out of range
        //SMARTCAST_FORCE_TARGET_SELF                   = 0x10,                     //Forces the target to cast this spell on itself
        SMARTCAST_AURA_NOT_PRESENT                      = 0x20,
        SMARTCAST_COMBAT_MOVE                           = 0x40,
    }

    [Flags]
    public enum SmartSpawnFlags
    {
        SMARTAI_SPAWN_FLAG_NONE                         = 0x00,
        SMARTAI_SPAWN_FLAG_IGNORE_RESPAWN               = 0x01,
        SMARTAI_SPAWN_FLAG_FORCE_SPAWN                  = 0x02,
        SMARTAI_SPAWN_FLAG_NOSAVE_RESPAWN               = 0x04,
    }

    public enum ReactState
    {
        REACT_PASSIVE                                   = 0,
        REACT_DEFENSIVE                                 = 1,
        REACT_AGGRESSIVE                                = 2,
    }

    public enum SmartRespawnCondition
    {
        RESPAWN_CONDITION_NONE                          = 0,
        RESPAWN_CONDITION_MAP                           = 1,
        RESPAWN_CONDITION_AREA                          = 2,
    }

    public enum GoLootState
    {
        GAMEOBJECT_NOT_READY                            = 0,
        GAMEOBJECT_READY                                = 1,
        GAMEOBJECT_ACTIVATED                            = 2,
        GAMEOBJECT_JUST_DEACTIVATED                     = 3,
    }

    public enum SmartAiTemplates
    {
        SMARTAI_TEMPLATE_BASIC                          = 0,
        SMARTAI_TEMPLATE_CASTER                         = 1,
        SMARTAI_TEMPLATE_TURRET                         = 2,
        SMARTAI_TEMPLATE_PASSIVE                        = 3,
        SMARTAI_TEMPLATE_CAGED_GO_PART                  = 4,
        SMARTAI_TEMPLATE_CAGED_NPC_PART                 = 5,
    }

    [Flags]
    public enum GoFlags
    {
        GO_FLAG_IN_USE                          = 0x00000001,                   // disables interaction while animated
        GO_FLAG_LOCKED                          = 0x00000002,                   // require key, spell, event, etc to be opened. Makes "Locked" appear in tooltip
        GO_FLAG_INTERACT_COND                   = 0x00000004,                   // cannot interact (condition to interact - requires GO_DYNFLAG_LO_ACTIVATE to enable interaction clientside)
        GO_FLAG_TRANSPORT                       = 0x00000008,                   // any kind of transport? Object can transport (elevator, boat, car)
        GO_FLAG_NOT_SELECTABLE                  = 0x00000010,                   // not selectable even in GM mode
        GO_FLAG_NODESPAWN                       = 0x00000020,                   // never despawn, typically for doors, they just change state
        GO_FLAG_AI_OBSTACLE                     = 0x00000040,                   // makes the client register the object in something called AIObstacleMgr, unknown what it does
        GO_FLAG_FREEZE_ANIMATION                = 0x00000080,
        GO_FLAG_DAMAGED                         = 0x00000200,
        GO_FLAG_DESTROYED                       = 0x00000400,
        GO_FLAG_TRANSPORT_PHASING               = 0x00000800,                   // Enable Phasing even if the GO is a transpor
        GO_FLAG_HUGE_SIZE                       = 0x00001000,                   // Increased Interaction Distance
    }

    [Flags]
    public enum DynamicFlags
    {
        UNIT_DYNFLAG_NONE                       = 0x0000,
        UNIT_DYNFLAG_LOOTABLE                   = 0x0001,
        UNIT_DYNFLAG_TRACK_UNIT                 = 0x0002,
        UNIT_DYNFLAG_TAPPED                     = 0x0004,       // Lua_UnitIsTapped
        UNIT_DYNFLAG_TAPPED_BY_PLAYER           = 0x0008,       // Lua_UnitIsTappedByPlayer
        UNIT_DYNFLAG_SPECIALINFO                = 0x0010,
        UNIT_DYNFLAG_DEAD                       = 0x0020,
        UNIT_DYNFLAG_REFER_A_FRIEND             = 0x0040,
        UNIT_DYNFLAG_TAPPED_BY_ALL_THREAT_LIST  = 0x0080        // Lua_UnitIsTappedByAllThreatList
    }

    public enum UnitStandStateType
    {
        UNIT_STAND_STATE_STAND                  = 0,
        UNIT_STAND_STATE_SIT                    = 1,
        UNIT_STAND_STATE_SIT_CHAIR              = 2,
        UNIT_STAND_STATE_SLEEP                  = 3,
        UNIT_STAND_STATE_SIT_LOW_CHAIR          = 4,
        UNIT_STAND_STATE_SIT_MEDIUM_CHAIR       = 5,
        UNIT_STAND_STATE_SIT_HIGH_CHAIR         = 6,
        UNIT_STAND_STATE_DEAD                   = 7,
        UNIT_STAND_STATE_KNEEL                  = 8,
        UNIT_STAND_STATE_SUBMERGED              = 9
    }

    [Flags]
    public enum UnitStandFlags
    {
        UNIT_STAND_FLAGS_NONE                   = 0x00,
        UNIT_STAND_FLAGS_UNK1                   = 0x01,
        UNIT_STAND_FLAGS_CREEP                  = 0x02,
        UNIT_STAND_FLAGS_UNTRACKABLE            = 0x04,
        UNIT_STAND_FLAGS_UNK4                   = 0x08,
        UNIT_STAND_FLAGS_UNK5                   = 0x10,
        UNIT_STAND_FLAGS_ALL                    = 0xFF
    }

    [Flags]
    public enum UnitBytes1_Flags
    {
        UNIT_BYTE1_FLAG_ALWAYS_STAND            = 0x01,
        UNIT_BYTE1_FLAG_HOVER                   = 0x02,
        UNIT_BYTE1_FLAG_UNK_3                   = 0x04,
        UNIT_BYTE1_FLAG_ALL                     = 0xFF
    }

    [Flags]
    public enum SmartEventFlags
    {
        EVENT_FLAG_NONE                         = 0x00,
        EVENT_FLAG_NOT_REPEATABLE               = 0x01,
        EVENT_FLAG_NORMAL_DUNGEON               = 0x02,
        EVENT_FLAG_HEROIC_DUNGEON               = 0x04,
        EVENT_FLAG_NORMAL_RAID                  = 0x08,
        EVENT_FLAG_HEROIC_RAID                  = 0x10,
        EVENT_FLAG_DEBUG_ONLY                   = 0x80,
        EVENT_FLAG_DONT_RESET                   = 0x100,
        EVENT_FLAG_WHILE_CHARMED                = 0x200,
        SMART_EVENT_FLAGS_MYTHIC_1              = 0x400,                     //Event only occurs in Mythic 1 or greater
        SMART_EVENT_FLAGS_MYTHIC_5              = 0x800,                     //Event only occurs in Mythic 5 or greater
        SMART_EVENT_FLAGS_MYTHIC_10             = 0x1000,                    //Event only occurs in Mythic 10 or greater
        SMART_EVENT_FLAGS_MYTHIC_15             = 0x2000,                    //Event only occurs in Mythic 15 or greater
        SMART_EVENT_FLAGS_MYTHIC_20             = 0x4000,                    //Event only occurs in Mythic 20 or greater
        SMART_EVENT_FLAGS_MYTHIC_25             = 0x8000,                    //Event only occurs in Mythic 25 or greater
        SMART_EVENT_FLAGS_MYTHIC_30             = 0x10000,                   //Event only occurs in Mythic 30 or greater
        SMART_EVENT_FLAGS_MYTHIC_35             = 0x20000,                   //Event only occurs in Mythic 35 or greater
        SMART_EVENT_FLAGS_MYTHIC_40             = 0x40000,                   //Event only occurs in Mythic 40 or greater
    }

    [Flags]
    public enum UnitFlags
    {
        UNIT_FLAG_NONE                          = 0x00000000,
        UNIT_FLAG_SERVER_CONTROLLED             = 0x00000001,           // set only when unit movement is controlled by server - by SPLINE/MONSTER_MOVE packets, together with UNIT_FLAG_STUNNED; only set to units controlled by client; client function CGUnit_C::IsClientControlled returns false when set for owner
        UNIT_FLAG_NON_ATTACKABLE                = 0x00000002,           // not attackable
        UNIT_FLAG_REMOVE_CLIENT_CONTROL         = 0x00000004,           // This is a legacy flag used to disable movement player's movement while controlling other units, SMSG_CLIENT_CONTROL replaces this functionality clientside now. CONFUSED and FLEEING flags have the same effect on client movement asDISABLE_MOVE_CONTROL in addition to preventing spell casts/autoattack (they all allow climbing steeper hills and emotes while moving)
        UNIT_FLAG_PLAYER_CONTROLLED             = 0x00000008,           // controlled by player, use _IMMUNE_TO_PC instead of _IMMUNE_TO_NPC
        UNIT_FLAG_RENAME                        = 0x00000010,
        UNIT_FLAG_PREPARATION                   = 0x00000020,           // don't take reagents for spells with SPELL_ATTR5_NO_REAGENT_WHILE_PREP
        UNIT_FLAG_UNK_6                         = 0x00000040,
        UNIT_FLAG_NOT_ATTACKABLE_1              = 0x00000080,           // ?? (UNIT_FLAG_PVP_ATTACKABLE | UNIT_FLAG_NOT_ATTACKABLE_1) is NON_PVP_ATTACKABLE
        UNIT_FLAG_IMMUNE_TO_PC                  = 0x00000100,           // disables combat/assistance with PlayerCharacters (PC) - see Unit::_IsValidAttackTarget, Unit::_IsValidAssistTarget
        UNIT_FLAG_IMMUNE_TO_NPC                 = 0x00000200,           // disables combat/assistance with NonPlayerCharacters (NPC) - see Unit::_IsValidAttackTarget, Unit::_IsValidAssistTarget
        UNIT_FLAG_LOOTING                       = 0x00000400,           // loot animation
        UNIT_FLAG_PET_IN_COMBAT                 = 0x00000800,           // in combat?, 2.0.8
        UNIT_FLAG_PVP                           = 0x00001000,           // changed in 3.0.3
        UNIT_FLAG_SILENCED                      = 0x00002000,           // silenced, 2.1.1
        UNIT_FLAG_CANNOT_SWIM                   = 0x00004000,           // 2.0.8
        UNIT_FLAG_SWIMMING                      = 0x00008000,           // shows swim animation in water
        UNIT_FLAG_NON_ATTACKABLE_2              = 0x00010000,           // removes attackable icon, if on yourself, cannot assist self but can cast TARGET_SELF spells - added by SPELL_AURA_MOD_UNATTACKABLE
        UNIT_FLAG_PACIFIED                      = 0x00020000,           // 3.0.3 ok
        UNIT_FLAG_STUNNED                       = 0x00040000,           // 3.0.3 ok
        UNIT_FLAG_IN_COMBAT                     = 0x00080000,
        UNIT_FLAG_TAXI_FLIGHT                   = 0x00100000,           // disable casting at client side spell not allowed by taxi flight (mounted?), probably used with 0x4 flag
        UNIT_FLAG_DISARMED                      = 0x00200000,           // 3.0.3, disable melee spells casting..., "Required melee weapon" added to melee spells tooltip.
        UNIT_FLAG_CONFUSED                      = 0x00400000,
        UNIT_FLAG_FLEEING                       = 0x00800000,
        UNIT_FLAG_POSSESSED                     = 0x01000000,           // under direct client control by a player (possess or vehicle)
        UNIT_FLAG_NOT_SELECTABLE                = 0x02000000,
        UNIT_FLAG_SKINNABLE                     = 0x04000000,
        UNIT_FLAG_MOUNT                         = 0x08000000,
        UNIT_FLAG_UNK_28                        = 0x10000000,
        UNIT_FLAG_PREVENT_EMOTES_FROM_CHAT_TEXT = 0x20000000,           // Prevent automatically playing emotes from parsing chat text, for example "lol" in /say, ending message with ? or !, or using /yell
        UNIT_FLAG_SHEATHE                       = 0x40000000,
    }

    [Flags]
    public enum CreatureFlagsExtra
    {
        CREATURE_FLAG_EXTRA_INSTANCE_BIND                         = 0x00000001,       // creature kill bind instance with killer and killer's group
        CREATURE_FLAG_EXTRA_CIVILIAN                              = 0x00000002,       // not aggro (ignore faction/reputation hostility)
        CREATURE_FLAG_EXTRA_NO_PARRY                              = 0x00000004,       // creature can't parry
        CREATURE_FLAG_EXTRA_NO_PARRY_HASTEN                       = 0x00000008,       // creature can't counter-attack at parry
        CREATURE_FLAG_EXTRA_NO_BLOCK                              = 0x00000010,       // creature can't block
        CREATURE_FLAG_EXTRA_NO_CRUSHING_BLOWS                     = 0x00000020,       // creature can't do crush attacks
        CREATURE_FLAG_EXTRA_NO_XP                                 = 0x00000040,       // creature kill not provide XP
        CREATURE_FLAG_EXTRA_TRIGGER                               = 0x00000080,       // trigger creature
        CREATURE_FLAG_EXTRA_NO_TAUNT                              = 0x00000100,       // creature is immune to taunt auras and effect attack me
        CREATURE_FLAG_EXTRA_NO_MOVE_FLAGS_UPDATE                  = 0x00000200,       // creature won't update movement flags
        CREATURE_FLAG_EXTRA_GHOST_VISIBILITY                      = 0x00000400,       // creature will be only visible for dead players
        CREATURE_FLAG_EXTRA_USE_OFFHAND_ATTACK                    = 0x00000800,       // creature will use offhand attacks
        CREATURE_FLAG_EXTRA_NO_SELL_VENDOR                        = 0x00001000,       // players can't sell items to this vendor
        CREATURE_FLAG_EXTRA_CANNOT_ENTER_COMBAT                   = 0x00002000,       // creature is not allowed to enter combat
        CREATURE_FLAG_EXTRA_WORLDEVENT                            = 0x00004000,       // custom flag for world event creatures (left room for merging)
        CREATURE_FLAG_EXTRA_GUARD                                 = 0x00008000,       // Creature is guard
        CREATURE_FLAG_EXTRA_IGNORE_FEIGN_DEATH                    = 0x00010000,       // creature ignores feign death
        CREATURE_FLAG_EXTRA_NO_CRIT                               = 0x00020000,       // creature can't do critical strikes
        CREATURE_FLAG_EXTRA_NO_SKILLGAIN                          = 0x00040000,       // creature won't increase weapon skills
        CREATURE_FLAG_EXTRA_OBEYS_TAUNT_DIMINISHING_RETURNS       = 0x00080000,       // Taunt is a subject to diminishing returns on this creautre
        CREATURE_FLAG_EXTRA_ALL_DIMINISH                          = 0x00100000,       // creature is subject to all diminishing returns as player are
        CREATURE_FLAG_EXTRA_NO_PLAYER_DAMAGE_REQ                  = 0x00200000,       // creature does not need to take player damage for kill credit
        CREATURE_FLAG_EXTRA_IGNORE_INVISIBILITY                   = 0x00400000,       // creature can detect invisible units
        CREATURE_FLAG_EXTRA_IGNORE_SPELL_FACING_REQ               = 0x00800000,       // players can attack this creature from all angles
        CREATURE_FLAG_EXTRA_UNUSED_24                             = 0x01000000,
        CREATURE_FLAG_EXTRA_UNUSED_25                             = 0x02000000,
        CREATURE_FLAG_EXTRA_UNUSED_26                             = 0x04000000,
        CREATURE_FLAG_EXTRA_UNUSED_27                             = 0x08000000,
        CREATURE_FLAG_EXTRA_DUNGEON_BOSS                          = 0x10000000,       // creature is a dungeon boss (SET DYNAMICALLY, DO NOT ADD IN DB)
        CREATURE_FLAG_EXTRA_IGNORE_PATHFINDING                    = 0x20000000,       // creature ignore pathfinding
        CREATURE_FLAG_EXTRA_IMMUNITY_KNOCKBACK                    = 0x40000000        // creature is immune to knockback effects
    }

    [Flags]
    public enum CreatureFlagsExtra2
    {
        CREATURE_FLAG_EXTRA_NO_CREATURE_DAMAGE_TAKEN              = 0x00000001,       // creature is immune to damage from creatures with this flag
        CREATURE_FLAG_EXTRA_ACTIVE                                = 0x00000002,       // creature is set to active on create
        CREATURE_FLAG_EXTRA_NO_DAZE                               = 0x00000004,       // creature can't daze
        CREATURE_FLAG_EXTRA_GAME_MODE_DISABLE_REP_GAIN            = 0x00000008,       // creature rep gain is diabled in specific game mode
        CREATURE_FLAG_EXTRA_DISABLE_PVE_MODE                      = 0x00000010,       // creature removes PvE Mode from victim once damage is taken
        CREATURE_FLAG_EXTRA_USE_FANNING                           = 0x00000020,       // creature will spread around target if other creatures are nearby
        CREATURE_FLAG_EXTRA_DUNGEON_BOSS_FINAL                    = 0x00000040,       // creature is a final dungeon boss (SET DYNAMICALLY, DO NOT ADD IN DB)
        CREATURE_FLAG_EXTRA_NEVER_EVADE                           = 0x00000080,       // creature will not have Evade behaviors
        CREATURE_FLAG_EXTRA_NEVER_MELEE_REPOSITION                = 0x00000100,       // creature will never melee reposition
        CREATURE_FLAG_EXTRA_CALL_FOR_HELP_40                      = 0x00000200,       // creature will execute a 40 yard call for help on pull
        CREATURE_FLAG_EXTRA_IGNORE_CANNOT_REACH_TARGET            = 0x00000400,       // creature will ignore cannot reach target evade call
        CREATURE_FLAG_EXTRA_NO_FIERCE_BLOW                        = 0x00000800,       // creature will never fierce blow
        CREATURE_FLAG_EXTRA_SCALE_AFFECTS_PET_SIZE                = 0x00001000,       // creature template will scale pet size
        CREATURE_FLAG_EXTRA_NO_CREATURE_DAMAGE_DONE               = 0x00002000,       // creature will do 0 damage to creatures
        CREATURE_FLAG_EXTRA_LOAD_SPAWN_ENTRY                      = 0x00004000,       // creature has id 0 and will load different ids from creature_spawn_entry
        CREATURE_FLAG_EXTRA_MYTHIC_PROGRESS_OVERRIDE              = 0x00008000,       // creature will override the mythic progress check for whether or not the creature can give experience
        CREATURE_FLAG_EXTRA_IS_RANDOM_VENDOR                      = 0x00010000,       // creature is a random vendor
        CREATURE_FLAG_EXTRA_IS_PERSONALIZED_VENDOR                = 0x00020000,       // creature is a personalized vendor
        CREATURE_FLAG_EXTRA_IS_ACCOUNT_PERSONALIZED_VENDOR        = 0x00040000,       // creature is an account personalized vendor
        CREATURE_FLAG_EXTRA_FIXED_UPDATE_DIFF                     = 0x00080000        // creature will use fixed update diff, it will not update at a different rate out of combat
    }

    [Flags]
    public enum UnitFlags2
    {
        UNIT_FLAG2_FEIGN_DEATH                  = 0x00000001,
        UNIT_FLAG2_HIDE_BODY                    = 0x00000002, // Hide unit model (show only player equip)
        UNIT_FLAG2_IGNORE_REPUTATION            = 0x00000004,
        UNIT_FLAG2_COMPREHEND_LANG              = 0x00000008,
        UNIT_FLAG2_MIRROR_IMAGE                 = 0x00000010,
        UNIT_FLAG2_DO_NOT_FADE_IN               = 0x00000020,   // Unit model instantly appears when summoned (does not fade in)
        UNIT_FLAG2_FORCE_MOVEMENT               = 0x00000040,
        UNIT_FLAG2_DISARM_OFFHAND               = 0x00000080,
        UNIT_FLAG2_DISABLE_PRED_STATS           = 0x00000100,   // Player has disabled predicted stats (Used by raid frames)
        UNIT_FLAG2_DISARM_RANGED                = 0x00000400,   // this does not disable ranged weapon display (maybe additional flag needed?)
        UNIT_FLAG2_REGENERATE_POWER             = 0x00000800,
        UNIT_FLAG2_RESTRICT_PARTY_INTERACTION   = 0x00001000,   // Restrict interaction to party or raid
        UNIT_FLAG2_PREVENT_SPELL_CLICK          = 0x00002000,   // Prevent spellclick
        UNIT_FLAG2_ALLOW_ENEMY_INTERACT         = 0x00004000,
        UNIT_FLAG2_CANNOT_TURN                  = 0x00008000,
        UNIT_FLAG2_UNK2                         = 0x00010000,
        UNIT_FLAG2_PLAY_DEATH_ANIM              = 0x00020000,   // Plays special death animation upon death
        UNIT_FLAG2_ALLOW_CHEAT_SPELLS           = 0x00040000    // Allows casting spells with AttributesEx7 & SPELL_ATTR7_IS_CHEAT_SPELL
    }

    public enum AuraTypes
    {
        SPELL_AURA_NONE = 0,
        SPELL_AURA_BIND_SIGHT = 1,
        SPELL_AURA_MOD_POSSESS = 2,
        SPELL_AURA_PERIODIC_DAMAGE = 3,
        SPELL_AURA_DUMMY = 4,
        SPELL_AURA_MOD_CONFUSE = 5,
        SPELL_AURA_MOD_CHARM = 6,
        SPELL_AURA_MOD_FEAR = 7,
        SPELL_AURA_PERIODIC_HEAL = 8,
        SPELL_AURA_MOD_ATTACKSPEED = 9,
        SPELL_AURA_MOD_THREAT = 10,
        SPELL_AURA_MOD_TAUNT = 11,
        SPELL_AURA_MOD_STUN = 12,
        SPELL_AURA_MOD_DAMAGE_DONE = 13,
        SPELL_AURA_MOD_DAMAGE_TAKEN = 14,
        SPELL_AURA_DAMAGE_SHIELD = 15,
        SPELL_AURA_MOD_STEALTH = 16,
        SPELL_AURA_MOD_STEALTH_DETECT = 17,
        SPELL_AURA_MOD_INVISIBILITY = 18,
        SPELL_AURA_MOD_INVISIBILITY_DETECT = 19,
        SPELL_AURA_OBS_MOD_HEALTH = 20,   // 20, 21 unofficial
        SPELL_AURA_OBS_MOD_POWER = 21,
        SPELL_AURA_MOD_RESISTANCE = 22,
        SPELL_AURA_PERIODIC_TRIGGER_SPELL = 23,
        SPELL_AURA_PERIODIC_ENERGIZE = 24,
        SPELL_AURA_MOD_PACIFY = 25,
        SPELL_AURA_MOD_ROOT = 26,
        SPELL_AURA_MOD_SILENCE = 27,
        SPELL_AURA_REFLECT_SPELLS = 28,
        SPELL_AURA_MOD_STAT = 29,
        SPELL_AURA_MOD_SKILL = 30,
        SPELL_AURA_MOD_INCREASE_SPEED = 31,
        SPELL_AURA_MOD_INCREASE_MOUNTED_SPEED = 32,
        SPELL_AURA_MOD_DECREASE_SPEED = 33,
        SPELL_AURA_MOD_INCREASE_HEALTH = 34,
        SPELL_AURA_MOD_INCREASE_ENERGY = 35,
        SPELL_AURA_MOD_SHAPESHIFT = 36,
        SPELL_AURA_EFFECT_IMMUNITY = 37,
        SPELL_AURA_STATE_IMMUNITY = 38,
        SPELL_AURA_SCHOOL_IMMUNITY = 39,
        SPELL_AURA_DAMAGE_IMMUNITY = 40,
        SPELL_AURA_DISPEL_IMMUNITY = 41,
        SPELL_AURA_PROC_TRIGGER_SPELL = 42,
        SPELL_AURA_PROC_TRIGGER_DAMAGE = 43,
        SPELL_AURA_TRACK_CREATURES = 44,
        SPELL_AURA_TRACK_RESOURCES = 45,
        SPELL_AURA_46 = 46,   // Ignore all Gear test spells
        SPELL_AURA_MOD_PARRY_PERCENT = 47,
        SPELL_AURA_48 = 48,   // One periodic spell
        SPELL_AURA_MOD_DODGE_PERCENT = 49,
        SPELL_AURA_MOD_CRITICAL_HEALING_AMOUNT = 50,
        SPELL_AURA_MOD_BLOCK_PERCENT = 51,
        SPELL_AURA_MOD_WEAPON_CRIT_PERCENT = 52,
        SPELL_AURA_PERIODIC_LEECH = 53,
        SPELL_AURA_MOD_HIT_CHANCE = 54,
        SPELL_AURA_MOD_SPELL_HIT_CHANCE = 55,
        SPELL_AURA_TRANSFORM = 56,
        SPELL_AURA_MOD_SPELL_CRIT_CHANCE = 57,
        SPELL_AURA_MOD_INCREASE_SWIM_SPEED = 58,
        SPELL_AURA_MOD_DAMAGE_DONE_CREATURE = 59,
        SPELL_AURA_MOD_PACIFY_SILENCE = 60,
        SPELL_AURA_MOD_SCALE = 61,
        SPELL_AURA_PERIODIC_HEALTH_FUNNEL = 62,
        SPELL_AURA_63 = 63,   // old SPELL_AURA_PERIODIC_MANA_FUNNEL
        SPELL_AURA_PERIODIC_MANA_LEECH = 64,
        SPELL_AURA_MOD_CASTING_SPEED_NOT_STACK = 65,
        SPELL_AURA_FEIGN_DEATH = 66,
        SPELL_AURA_MOD_DISARM = 67,
        SPELL_AURA_MOD_STALKED = 68,
        SPELL_AURA_SCHOOL_ABSORB = 69,
        SPELL_AURA_EXTRA_ATTACKS = 70,
        SPELL_AURA_MOD_SPELL_CRIT_CHANCE_SCHOOL = 71,
        SPELL_AURA_MOD_POWER_COST_SCHOOL_PCT = 72,
        SPELL_AURA_MOD_POWER_COST_SCHOOL = 73,
        SPELL_AURA_REFLECT_SPELLS_SCHOOL = 74,
        SPELL_AURA_MOD_LANGUAGE = 75,
        SPELL_AURA_FAR_SIGHT = 76,
        SPELL_AURA_MECHANIC_IMMUNITY = 77,
        SPELL_AURA_MOUNTED = 78,
        SPELL_AURA_MOD_DAMAGE_PERCENT_DONE = 79,
        SPELL_AURA_MOD_PERCENT_STAT = 80,
        SPELL_AURA_SPLIT_DAMAGE_PCT = 81,
        SPELL_AURA_WATER_BREATHING = 82,
        SPELL_AURA_MOD_BASE_RESISTANCE = 83,
        SPELL_AURA_MOD_REGEN = 84,
        SPELL_AURA_MOD_POWER_REGEN = 85,
        SPELL_AURA_CHANNEL_DEATH_ITEM = 86,
        SPELL_AURA_MOD_DAMAGE_PERCENT_TAKEN = 87,
        SPELL_AURA_MOD_HEALTH_REGEN_PERCENT = 88,
        SPELL_AURA_PERIODIC_DAMAGE_PERCENT = 89,
        SPELL_AURA_90 = 90,   // old SPELL_AURA_MOD_RESIST_CHANCE
        SPELL_AURA_MOD_DETECT_RANGE = 91,
        SPELL_AURA_PREVENTS_FLEEING = 92,
        SPELL_AURA_MOD_UNATTACKABLE = 93,
        SPELL_AURA_INTERRUPT_REGEN = 94,
        SPELL_AURA_GHOST = 95,
        SPELL_AURA_SPELL_MAGNET = 96,
        SPELL_AURA_MANA_SHIELD = 97,
        SPELL_AURA_MOD_SKILL_TALENT = 98,
        SPELL_AURA_MOD_ATTACK_POWER = 99,
        SPELL_AURA_AURAS_VISIBLE = 100,
        SPELL_AURA_MOD_RESISTANCE_PCT = 101,
        SPELL_AURA_MOD_MELEE_ATTACK_POWER_VERSUS = 102,
        SPELL_AURA_MOD_TOTAL_THREAT = 103,
        SPELL_AURA_WATER_WALK = 104,
        SPELL_AURA_FEATHER_FALL = 105,
        SPELL_AURA_HOVER = 106,
        SPELL_AURA_ADD_FLAT_MODIFIER = 107,
        SPELL_AURA_ADD_PCT_MODIFIER = 108,
        SPELL_AURA_ADD_TARGET_TRIGGER = 109,
        SPELL_AURA_MOD_POWER_REGEN_PERCENT = 110,
        SPELL_AURA_ADD_CASTER_HIT_TRIGGER = 111,
        SPELL_AURA_OVERRIDE_CLASS_SCRIPTS = 112,
        SPELL_AURA_MOD_RANGED_DAMAGE_TAKEN = 113,
        SPELL_AURA_MOD_RANGED_DAMAGE_TAKEN_PCT = 114,
        SPELL_AURA_MOD_HEALING = 115,
        SPELL_AURA_MOD_REGEN_DURING_COMBAT = 116,
        SPELL_AURA_MOD_MECHANIC_RESISTANCE = 117,
        SPELL_AURA_MOD_HEALING_PCT = 118,
        SPELL_AURA_119 = 119,  // old SPELL_AURA_SHARE_PET_TRACKING
        SPELL_AURA_UNTRACKABLE = 120,
        SPELL_AURA_EMPATHY = 121,
        SPELL_AURA_MOD_OFFHAND_DAMAGE_PCT = 122,
        SPELL_AURA_MOD_TARGET_RESISTANCE = 123,
        SPELL_AURA_MOD_RANGED_ATTACK_POWER = 124,
        SPELL_AURA_MOD_MELEE_DAMAGE_TAKEN = 125,
        SPELL_AURA_MOD_MELEE_DAMAGE_TAKEN_PCT = 126,
        SPELL_AURA_RANGED_ATTACK_POWER_ATTACKER_BONUS = 127,
        SPELL_AURA_MOD_POSSESS_PET = 128,
        SPELL_AURA_MOD_SPEED_ALWAYS = 129,
        SPELL_AURA_MOD_MOUNTED_SPEED_ALWAYS = 130,
        SPELL_AURA_MOD_RANGED_ATTACK_POWER_VERSUS = 131,
        SPELL_AURA_MOD_INCREASE_ENERGY_PERCENT = 132,
        SPELL_AURA_MOD_INCREASE_HEALTH_PERCENT = 133,
        SPELL_AURA_MOD_MANA_REGEN_INTERRUPT = 134,
        SPELL_AURA_MOD_HEALING_DONE = 135,
        SPELL_AURA_MOD_HEALING_DONE_PERCENT = 136,
        SPELL_AURA_MOD_TOTAL_STAT_PERCENTAGE = 137,
        SPELL_AURA_MOD_MELEE_HASTE = 138,
        SPELL_AURA_FORCE_REACTION = 139,
        SPELL_AURA_MOD_RANGED_HASTE = 140,
        SPELL_AURA_MOD_RANGED_AMMO_HASTE = 141,
        SPELL_AURA_MOD_BASE_RESISTANCE_PCT = 142,
        SPELL_AURA_MOD_RESISTANCE_EXCLUSIVE = 143,
        SPELL_AURA_SAFE_FALL = 144,
        SPELL_AURA_MOD_PET_TALENT_POINTS = 145,
        SPELL_AURA_ALLOW_TAME_PET_TYPE = 146,
        SPELL_AURA_MECHANIC_IMMUNITY_MASK = 147,
        SPELL_AURA_RETAIN_COMBO_POINTS = 148,
        SPELL_AURA_REDUCE_PUSHBACK = 149,  //    Reduce Pushback
        SPELL_AURA_MOD_SHIELD_BLOCKVALUE_PCT = 150,
        SPELL_AURA_TRACK_STEALTHED = 151,  //    Track Stealthed
        SPELL_AURA_MOD_DETECTED_RANGE = 152,  //    Mod Detected Range
        SPELL_AURA_SPLIT_DAMAGE_FLAT = 153,  //    Split Damage Flat
        SPELL_AURA_MOD_STEALTH_LEVEL = 154,  //    Stealth Level Modifier
        SPELL_AURA_MOD_WATER_BREATHING = 155,  //    Mod Water Breathing
        SPELL_AURA_MOD_REPUTATION_GAIN = 156,  //    Mod Reputation Gain
        SPELL_AURA_PET_DAMAGE_MULTI = 157,  //    Mod Pet Damage
        SPELL_AURA_MOD_SHIELD_BLOCKVALUE = 158,
        SPELL_AURA_NO_PVP_CREDIT = 159,
        SPELL_AURA_MOD_AOE_AVOIDANCE = 160,
        SPELL_AURA_MOD_HEALTH_REGEN_IN_COMBAT = 161,
        SPELL_AURA_POWER_BURN = 162,
        SPELL_AURA_MOD_CRIT_DAMAGE_BONUS = 163,
        SPELL_AURA_164 = 164,
        SPELL_AURA_MELEE_ATTACK_POWER_ATTACKER_BONUS = 165,
        SPELL_AURA_MOD_ATTACK_POWER_PCT = 166,
        SPELL_AURA_MOD_RANGED_ATTACK_POWER_PCT = 167,
        SPELL_AURA_MOD_DAMAGE_DONE_VERSUS = 168,
        SPELL_AURA_MOD_CRIT_PERCENT_VERSUS = 169,
        SPELL_AURA_DETECT_AMORE = 170,
        SPELL_AURA_MOD_SPEED_NOT_STACK = 171,
        SPELL_AURA_MOD_MOUNTED_SPEED_NOT_STACK = 172,
        SPELL_AURA_173 = 173,  // old SPELL_AURA_ALLOW_CHAMPION_SPELLS
        SPELL_AURA_MOD_SPELL_DAMAGE_OF_STAT_PERCENT = 174,  // by defeult intelect, dependent from SPELL_AURA_MOD_SPELL_HEALING_OF_STAT_PERCENT
        SPELL_AURA_MOD_SPELL_HEALING_OF_STAT_PERCENT = 175,
        SPELL_AURA_SPIRIT_OF_REDEMPTION = 176,
        SPELL_AURA_AOE_CHARM = 177,
        SPELL_AURA_MOD_DEBUFF_RESISTANCE = 178,
        SPELL_AURA_MOD_ATTACKER_SPELL_CRIT_CHANCE = 179,
        SPELL_AURA_MOD_FLAT_SPELL_DAMAGE_VERSUS = 180,
        SPELL_AURA_181 = 181,  // old SPELL_AURA_MOD_FLAT_SPELL_CRIT_DAMAGE_VERSUS - possible flat spell crit damage versus
        SPELL_AURA_MOD_RESISTANCE_OF_STAT_PERCENT = 182,
        SPELL_AURA_MOD_CRITICAL_THREAT = 183,
        SPELL_AURA_MOD_ATTACKER_MELEE_HIT_CHANCE = 184,
        SPELL_AURA_MOD_ATTACKER_RANGED_HIT_CHANCE = 185,
        SPELL_AURA_MOD_ATTACKER_SPELL_HIT_CHANCE = 186,
        SPELL_AURA_MOD_ATTACKER_MELEE_CRIT_CHANCE = 187,
        SPELL_AURA_MOD_ATTACKER_RANGED_CRIT_CHANCE = 188,
        SPELL_AURA_MOD_RATING = 189,
        SPELL_AURA_MOD_FACTION_REPUTATION_GAIN = 190,
        SPELL_AURA_USE_NORMAL_MOVEMENT_SPEED = 191,
        SPELL_AURA_MOD_MELEE_RANGED_HASTE = 192,
        SPELL_AURA_MELEE_SLOW = 193,
        SPELL_AURA_MOD_TARGET_ABSORB_SCHOOL = 194,
        SPELL_AURA_MOD_TARGET_ABILITY_ABSORB_SCHOOL = 195,
        SPELL_AURA_MOD_COOLDOWN = 196,  // only 24818 Noxious Breath
        SPELL_AURA_MOD_ATTACKER_SPELL_AND_WEAPON_CRIT_CHANCE = 197,
        SPELL_AURA_198 = 198,  // old SPELL_AURA_MOD_ALL_WEAPON_SKILLS
        SPELL_AURA_MOD_INCREASES_SPELL_PCT_TO_HIT = 199,
        SPELL_AURA_MOD_XP_PCT = 200,
        SPELL_AURA_FLY = 201,
        SPELL_AURA_IGNORE_COMBAT_RESULT = 202,
        SPELL_AURA_MOD_ATTACKER_MELEE_CRIT_DAMAGE = 203,
        SPELL_AURA_MOD_ATTACKER_RANGED_CRIT_DAMAGE = 204,
        SPELL_AURA_MOD_SCHOOL_CRIT_DMG_TAKEN = 205,
        SPELL_AURA_MOD_INCREASE_VEHICLE_FLIGHT_SPEED = 206,
        SPELL_AURA_MOD_INCREASE_MOUNTED_FLIGHT_SPEED = 207,
        SPELL_AURA_MOD_INCREASE_FLIGHT_SPEED = 208,
        SPELL_AURA_MOD_MOUNTED_FLIGHT_SPEED_ALWAYS = 209,
        SPELL_AURA_MOD_VEHICLE_SPEED_ALWAYS = 210,
        SPELL_AURA_MOD_FLIGHT_SPEED_NOT_STACK = 211,
        SPELL_AURA_MOD_RANGED_ATTACK_POWER_OF_STAT_PERCENT = 212,
        SPELL_AURA_MOD_RAGE_FROM_DAMAGE_DEALT = 213,
        SPELL_AURA_214 = 214,
        SPELL_AURA_ARENA_PREPARATION = 215,
        SPELL_AURA_HASTE_SPELLS = 216,
        SPELL_AURA_MOD_MELEE_HASTE_2 = 217, // NYI
        SPELL_AURA_HASTE_RANGED = 218,
        SPELL_AURA_MOD_MANA_REGEN_FROM_STAT = 219,
        SPELL_AURA_MOD_RATING_FROM_STAT = 220,
        SPELL_AURA_MOD_DETAUNT = 221,
        SPELL_AURA_222 = 222,
        SPELL_AURA_RAID_PROC_FROM_CHARGE = 223,
        SPELL_AURA_224 = 224,
        SPELL_AURA_RAID_PROC_FROM_CHARGE_WITH_VALUE = 225,
        SPELL_AURA_PERIODIC_DUMMY = 226,
        SPELL_AURA_PERIODIC_TRIGGER_SPELL_WITH_VALUE = 227,
        SPELL_AURA_DETECT_STEALTH = 228,
        SPELL_AURA_MOD_AOE_DAMAGE_AVOIDANCE = 229,
        SPELL_AURA_230 = 230,
        SPELL_AURA_PROC_TRIGGER_SPELL_WITH_VALUE = 231,
        SPELL_AURA_MECHANIC_DURATION_MOD = 232,
        SPELL_AURA_CHANGE_MODEL_FOR_ALL_HUMANOIDS = 233,  // client-side only
        SPELL_AURA_MECHANIC_DURATION_MOD_NOT_STACK = 234,
        SPELL_AURA_MOD_DISPEL_RESIST = 235,
        SPELL_AURA_CONTROL_VEHICLE = 236,
        SPELL_AURA_MOD_SPELL_DAMAGE_OF_ATTACK_POWER = 237,
        SPELL_AURA_MOD_SPELL_HEALING_OF_ATTACK_POWER = 238,
        SPELL_AURA_MOD_SCALE_2 = 239,
        SPELL_AURA_MOD_EXPERTISE = 240,
        SPELL_AURA_FORCE_MOVE_FORWARD = 241,
        SPELL_AURA_MOD_SPELL_DAMAGE_FROM_HEALING = 242,
        SPELL_AURA_MOD_FACTION = 243,
        SPELL_AURA_COMPREHEND_LANGUAGE = 244,
        SPELL_AURA_MOD_AURA_DURATION_BY_DISPEL = 245,
        SPELL_AURA_MOD_AURA_DURATION_BY_DISPEL_NOT_STACK = 246,
        SPELL_AURA_CLONE_CASTER = 247,
        SPELL_AURA_MOD_COMBAT_RESULT_CHANCE = 248,
        SPELL_AURA_CONVERT_RUNE = 249,
        SPELL_AURA_MOD_INCREASE_HEALTH_2 = 250,
        SPELL_AURA_MOD_ENEMY_DODGE = 251,
        SPELL_AURA_MOD_SPEED_SLOW_ALL = 252,
        SPELL_AURA_MOD_BLOCK_CRIT_CHANCE = 253,
        SPELL_AURA_MOD_DISARM_OFFHAND = 254,
        SPELL_AURA_MOD_MECHANIC_DAMAGE_TAKEN_PERCENT = 255,
        SPELL_AURA_NO_REAGENT_USE = 256,
        SPELL_AURA_MOD_TARGET_RESIST_BY_SPELL_CLASS = 257,
        SPELL_AURA_258 = 258,
        SPELL_AURA_MOD_HOT_PCT = 259,
        SPELL_AURA_SCREEN_EFFECT = 260,
        SPELL_AURA_PHASE = 261,
        SPELL_AURA_ABILITY_IGNORE_AURASTATE = 262,
        SPELL_AURA_ALLOW_ONLY_ABILITY = 263,
        SPELL_AURA_264 = 264,
        SPELL_AURA_265 = 265,
        SPELL_AURA_266 = 266,
        SPELL_AURA_MOD_IMMUNE_AURA_APPLY_SCHOOL = 267,
        SPELL_AURA_MOD_ATTACK_POWER_OF_STAT_PERCENT = 268,
        SPELL_AURA_MOD_IGNORE_TARGET_RESIST = 269,
        SPELL_AURA_MOD_ABILITY_IGNORE_TARGET_RESIST = 270,  // Possibly need swap vs 195 aura used only in 1 spell Chaos Bolt Passive
        SPELL_AURA_MOD_DAMAGE_FROM_CASTER = 271,
        SPELL_AURA_IGNORE_MELEE_RESET = 272,
        SPELL_AURA_X_RAY = 273,
        SPELL_AURA_ABILITY_CONSUME_NO_AMMO = 274,
        SPELL_AURA_MOD_IGNORE_SHAPESHIFT = 275,
        SPELL_AURA_MOD_DAMAGE_DONE_FOR_MECHANIC = 276,  // NYI
        SPELL_AURA_MOD_MAX_AFFECTED_TARGETS = 277,
        SPELL_AURA_MOD_DISARM_RANGED = 278,
        SPELL_AURA_INITIALIZE_IMAGES = 279,
        SPELL_AURA_MOD_ARMOR_PENETRATION_PCT = 280,
        SPELL_AURA_MOD_HONOR_GAIN_PCT = 281,
        SPELL_AURA_MOD_BASE_HEALTH_PCT = 282,
        SPELL_AURA_MOD_HEALING_RECEIVED = 283,  // Possibly only for some spell family class spells
        SPELL_AURA_LINKED = 284,
        SPELL_AURA_MOD_ATTACK_POWER_OF_ARMOR = 285,
        SPELL_AURA_ABILITY_PERIODIC_CRIT = 286,
        SPELL_AURA_DEFLECT_SPELLS = 287,
        SPELL_AURA_IGNORE_HIT_DIRECTION = 288,
        SPELL_AURA_PREVENT_DURABILITY_LOSS = 289,
        SPELL_AURA_MOD_CRIT_PCT = 290,
        SPELL_AURA_MOD_XP_QUEST_PCT = 291,
        SPELL_AURA_OPEN_STABLE = 292,
        SPELL_AURA_OVERRIDE_SPELLS = 293,
        SPELL_AURA_PREVENT_REGENERATE_POWER = 294,
        SPELL_AURA_295 = 295,
        SPELL_AURA_SET_VEHICLE_ID = 296,
        SPELL_AURA_BLOCK_SPELL_FAMILY = 297,
        SPELL_AURA_STRANGULATE = 298,
        SPELL_AURA_299 = 299,
        SPELL_AURA_SHARE_DAMAGE_PCT = 300,
        SPELL_AURA_SCHOOL_HEAL_ABSORB = 301,
        SPELL_AURA_302 = 302,
        SPELL_AURA_MOD_DAMAGE_DONE_VERSUS_AURASTATE = 303,
        SPELL_AURA_MOD_FAKE_INEBRIATE = 304,
        SPELL_AURA_MOD_MINIMUM_SPEED = 305,
        SPELL_AURA_306 = 306,
        SPELL_AURA_HEAL_ABSORB_TEST = 307,
        SPELL_AURA_MOD_CRIT_CHANCE_FOR_CASTER = 308,
        SPELL_AURA_309 = 309,
        SPELL_AURA_MOD_CREATURE_AOE_DAMAGE_AVOIDANCE = 310,
        SPELL_AURA_311 = 311,
        SPELL_AURA_312 = 312,
        SPELL_AURA_313 = 313,
        SPELL_AURA_PREVENT_RESURRECTION = 314,
        SPELL_AURA_UNDERWATER_WALKING = 315,
        SPELL_AURA_PERIODIC_HASTE = 316,
        TOTAL_AURAS = 317
    };

    enum UnitState
    {
        UNIT_STATE_DIED                  = 0x00000001,                     // player has fake death aura
        UNIT_STATE_MELEE_ATTACKING       = 0x00000002,                     // player is melee attacking someone
        UNIT_STATE_CHARMED               = 0x00000004,                     // having any kind of charm aura on self
        UNIT_STATE_STUNNED               = 0x00000008,
        UNIT_STATE_ROAMING               = 0x00000010,
        UNIT_STATE_CHASE                 = 0x00000020,
        UNIT_STATE_FOCUSING              = 0x00000040,
        UNIT_STATE_FLEEING               = 0x00000080,
        UNIT_STATE_IN_FLIGHT             = 0x00000100,                     // player is in flight mode
        UNIT_STATE_FOLLOW                = 0x00000200,
        UNIT_STATE_ROOT                  = 0x00000400,
        UNIT_STATE_CONFUSED              = 0x00000800,
        UNIT_STATE_DISTRACTED            = 0x00001000,
        UNIT_STATE_ISOLATED              = 0x00002000,                     // area auras do not affect other players
        UNIT_STATE_ATTACK_PLAYER         = 0x00004000,
        UNIT_STATE_CASTING               = 0x00008000,
        UNIT_STATE_POSSESSED             = 0x00010000,
        UNIT_STATE_CHARGING              = 0x00020000,
        UNIT_STATE_JUMPING               = 0x00040000,
        UNIT_STATE_MOVE                  = 0x00100000,
        UNIT_STATE_ROTATING              = 0x00200000,
        UNIT_STATE_EVADE                 = 0x00400000,
        UNIT_STATE_ROAMING_MOVE          = 0x00800000,
        UNIT_STATE_CONFUSED_MOVE         = 0x01000000,
        UNIT_STATE_FLEEING_MOVE          = 0x02000000,
        UNIT_STATE_CHASE_MOVE            = 0x04000000,
        UNIT_STATE_FOLLOW_MOVE           = 0x08000000,
        UNIT_STATE_IGNORE_PATHFINDING    = 0x10000000,                 // do not use pathfinding in any MovementGenerator
        
        // Custom
        UNIT_STATE_WAYPOINT_PAUSED       = 0x40000000,                 // Pause waypoint_data movement
        UNIT_STATE_ALL_STATE_SUPPORTED = UNIT_STATE_DIED | UNIT_STATE_MELEE_ATTACKING | UNIT_STATE_STUNNED | UNIT_STATE_ROAMING | UNIT_STATE_CHASE
                                       | UNIT_STATE_FLEEING | UNIT_STATE_IN_FLIGHT | UNIT_STATE_FOLLOW | UNIT_STATE_ROOT | UNIT_STATE_CONFUSED
                                       | UNIT_STATE_DISTRACTED | UNIT_STATE_ISOLATED | UNIT_STATE_ATTACK_PLAYER | UNIT_STATE_CASTING
                                       | UNIT_STATE_POSSESSED | UNIT_STATE_CHARGING | UNIT_STATE_JUMPING | UNIT_STATE_MOVE | UNIT_STATE_ROTATING
                                       | UNIT_STATE_EVADE | UNIT_STATE_ROAMING_MOVE | UNIT_STATE_CONFUSED_MOVE | UNIT_STATE_FLEEING_MOVE
                                       | UNIT_STATE_CHASE_MOVE | UNIT_STATE_FOLLOW_MOVE | UNIT_STATE_IGNORE_PATHFINDING | UNIT_STATE_WAYPOINT_PAUSED,

        UNIT_STATE_UNATTACKABLE    = UNIT_STATE_IN_FLIGHT,
        // for real move using movegen check and stop (except unstoppable flight)
        UNIT_STATE_MOVING          = UNIT_STATE_ROAMING_MOVE | UNIT_STATE_CONFUSED_MOVE | UNIT_STATE_FLEEING_MOVE | UNIT_STATE_CHASE_MOVE | UNIT_STATE_FOLLOW_MOVE,
        UNIT_STATE_CONTROLLED      = (UNIT_STATE_CONFUSED | UNIT_STATE_STUNNED | UNIT_STATE_FLEEING),
        UNIT_STATE_LOST_CONTROL    = (UNIT_STATE_CONTROLLED | UNIT_STATE_JUMPING | UNIT_STATE_CHARGING),
        UNIT_STATE_SIGHTLESS       = (UNIT_STATE_LOST_CONTROL | UNIT_STATE_EVADE),
        UNIT_STATE_CANNOT_AUTOATTACK     = (UNIT_STATE_LOST_CONTROL | UNIT_STATE_CASTING),
        UNIT_STATE_CANNOT_TURN     = (UNIT_STATE_LOST_CONTROL | UNIT_STATE_ROTATING),
        // stay by different reasons
        UNIT_STATE_NOT_MOVE        = UNIT_STATE_ROOT | UNIT_STATE_STUNNED | UNIT_STATE_DIED | UNIT_STATE_DISTRACTED,
    }

    [Flags]
    public enum NpcFlags
    {
        UNIT_NPC_FLAG_NONE                  = 0x00000000,
        UNIT_NPC_FLAG_GOSSIP                = 0x00000001,       // 100%
        UNIT_NPC_FLAG_QUESTGIVER            = 0x00000002,       // guessed, probably ok
        UNIT_NPC_FLAG_UNK1                  = 0x00000004,
        UNIT_NPC_FLAG_UNK2                  = 0x00000008,
        UNIT_NPC_FLAG_TRAINER               = 0x00000010,       // 100%
        UNIT_NPC_FLAG_TRAINER_CLASS         = 0x00000020,       // 100%
        UNIT_NPC_FLAG_TRAINER_PROFESSION    = 0x00000040,       // 100%
        UNIT_NPC_FLAG_VENDOR                = 0x00000080,       // 100%
        UNIT_NPC_FLAG_VENDOR_AMMO           = 0x00000100,       // 100%, general goods vendor
        UNIT_NPC_FLAG_VENDOR_FOOD           = 0x00000200,       // 100%
        UNIT_NPC_FLAG_VENDOR_POISON         = 0x00000400,       // guessed
        UNIT_NPC_FLAG_VENDOR_REAGENT        = 0x00000800,       // 100%
        UNIT_NPC_FLAG_REPAIR                = 0x00001000,       // 100%
        UNIT_NPC_FLAG_FLIGHTMASTER          = 0x00002000,       // 100%
        UNIT_NPC_FLAG_SPIRITHEALER          = 0x00004000,       // guessed
        UNIT_NPC_FLAG_SPIRITGUIDE           = 0x00008000,       // guessed
        UNIT_NPC_FLAG_INNKEEPER             = 0x00010000,       // 100%
        UNIT_NPC_FLAG_BANKER                = 0x00020000,       // 100%
        UNIT_NPC_FLAG_PETITIONER            = 0x00040000,       // 100% 0xC0000 = guild petitions, 0x40000 = arena team petitions
        UNIT_NPC_FLAG_TABARDDESIGNER        = 0x00080000,       // 100%
        UNIT_NPC_FLAG_BATTLEMASTER          = 0x00100000,       // 100%
        UNIT_NPC_FLAG_AUCTIONEER            = 0x00200000,       // 100%
        UNIT_NPC_FLAG_STABLEMASTER          = 0x00400000,       // 100%
        UNIT_NPC_FLAG_GUILD_BANKER          = 0x00800000,       // cause client to send 997 opcode
        UNIT_NPC_FLAG_SPELLCLICK            = 0x01000000,       // cause client to send 1015 opcode (spell click)
        UNIT_NPC_FLAG_PLAYER_VEHICLE        = 0x02000000,       // players with mounts that have vehicle data should have it set
        UNIT_NPC_FLAG_MAILBOX               = 0x04000000        //
    }

    [Flags]
    public enum SmartPhaseMasks
    {
        SMART_EVENT_PHASE_ALWAYS            = 0x000,
        SMART_EVENT_PHASE_1                 = 0x001,
        SMART_EVENT_PHASE_2                 = 0x002,
        SMART_EVENT_PHASE_3                 = 0x004,
        SMART_EVENT_PHASE_4                 = 0x008,
        SMART_EVENT_PHASE_5                 = 0x010,
        SMART_EVENT_PHASE_6                 = 0x020,
        SMART_EVENT_PHASE_7                 = 0x040,
        SMART_EVENT_PHASE_8                 = 0x080,
        SMART_EVENT_PHASE_9                 = 0x100,
    }

    [Flags]
    public enum PhaseMasks
    {
        PHASEMASK_NEVER                     = 0x00,
        PHASEMASK_2                         = 0x02,
        PHASEMASK_3                         = 0x04,
        PHASEMASK_4                         = 0x08,
        PHASEMASK_5                         = 0x10,
        PHASEMASK_6                         = 0x20,
        PHASEMASK_7                         = 0x40,
        PHASEMASK_8                         = 0x80,
        PHASEMASK_9                         = 0x100,
        PHASEMASK_10                        = 0x200,
        PHASEMASK_11                        = 0x400,
        PHASEMASK_12                        = 0x800,
        PHASEMASK_13                        = 0x1000,
        PHASEMASK_14                        = 0x2000,
        PHASEMASK_15                        = 0x4000,
        // etc....                          
        PHASEMASK_ANYWHERE                  = ~0,   //! -1, 0xFFFFFFFF, etc.
    }

    enum SMART_EVENT_PHASE_BITS
    {
        SMART_EVENT_PHASE_ALWAYS_BIT        = 0,
        SMART_EVENT_PHASE_1_BIT             = 1,
        SMART_EVENT_PHASE_2_BIT             = 2,
        SMART_EVENT_PHASE_3_BIT             = 4,
        SMART_EVENT_PHASE_4_BIT             = 8,
        SMART_EVENT_PHASE_5_BIT             = 16,
        SMART_EVENT_PHASE_6_BIT             = 32,
        SMART_EVENT_PHASE_7_BIT             = 64,
        SMART_EVENT_PHASE_8_BIT             = 128,
        SMART_EVENT_PHASE_9_BIT             = 256,
        SMART_EVENT_PHASE_ALL               = SMART_EVENT_PHASE_1_BIT + SMART_EVENT_PHASE_2_BIT + SMART_EVENT_PHASE_3_BIT + SMART_EVENT_PHASE_4_BIT + SMART_EVENT_PHASE_5_BIT + SMART_EVENT_PHASE_6_BIT
    }

    public enum PowerTypes : int
    {
        POWER_MANA                          = 0,
        POWER_RAGE                          = 1,
        POWER_FOCUS                         = 2,
        POWER_ENERGY                        = 3,
        POWER_HAPPINESS                     = 4,
        POWER_RUNE                          = 5,
        POWER_RUNIC_POWER                   = 6,
        //MAX_POWERS                        = 7,
        //POWER_ALL                         = 127,    // default for class?
        //POWER_HEALTH                      = 0xFFFFFFFE    // (-2 as signed value)
        POWER_HEALTH                        = -2,
    }

    public enum GoStates
    {
        GO_STATE_NOT_READY                  = 0,
        GO_STATE_READY                      = 1,
        GO_STATE_ACTIVATED                  = 2,
        GO_STATE_DEACTIVATED                = 3,
    }

    public enum SetGoStates
    {
        GO_STATE_ACTIVE                     = 0,                        // show in world as used and not reset (closed door open)
        GO_STATE_READY                      = 1,                        // show in world as ready (closed door close)
        GO_STATE_DESTROYED                  = 2                         // show the object in-game as already used and not yet reset (e.g. door opened by a cannon blast)
    }

    public enum HostilityModes
    {
        HOSTILE_MODE_HOSTILE                = 0,                  // Enable Event if creature reacts to other creature: Hostile       
        HOSTILE_MODE_NOT_HOSTILE            = 1,                  // Enable Event if creature reacts to other creature: Not hostile (not that Friendly and Not hostile have different meanings)
        HOSTILE_MODE_ANY                    = 2                   // Enable Event if creature reacts to other creature: Any, as in both Hostile and Not hostile
    }

    public enum TeamIDs
    {
        HORDE                               = 67,
        ALLIANCE                            = 469,
        //TEAM_STEAMWHEEDLE_CARTEL          = 169,                       // not used in code
        //TEAM_ALLIANCE_FORCES              = 891,
        //TEAM_HORDE_FORCES                 = 892,
        //TEAM_SANCTUARY                    = 936,
        //TEAM_OUTLAND                      = 980,
        TEAM_ANY                            = 0                            // if ReputationListId > 0 && Flags != FACTION_FLAG_TEAM_HEADER
    }

    public enum MovementGeneratorType
    {
        IDLE_MOTION_TYPE                    = 0,                  // IdleMovementGenerator.h
        RANDOM_MOTION_TYPE                  = 1,                  // RandomMovementGenerator.h
        WAYPOINT_MOTION_TYPE                = 2,                  // WaypointMovementGenerator.h
        MAX_DB_MOTION_TYPE                  = 3,                  // Below motion types can't be set in DB.
        CONFUSED_MOTION_TYPE                = 4,                  // ConfusedMovementGenerator.h
        CHASE_MOTION_TYPE                   = 5,                  // TargetedMovementGenerator.h
        HOME_MOTION_TYPE                    = 6,                  // HomeMovementGenerator.h
        FLIGHT_MOTION_TYPE                  = 7,                  // WaypointMovementGenerator.h
        POINT_MOTION_TYPE                   = 8,                  // PointMovementGenerator.h
        FLEEING_MOTION_TYPE                 = 9,                  // FleeingMovementGenerator.h
        DISTRACT_MOTION_TYPE                = 10,                 // IdleMovementGenerator.h
        ASSISTANCE_MOTION_TYPE              = 11,                 // PointMovementGenerator.h
        ASSISTANCE_DISTRACT_MOTION_TYPE     = 12,                 // IdleMovementGenerator.h
        TIMED_FLEEING_MOTION_TYPE           = 13,                 // FleeingMovementGenerator.h
        FOLLOW_MOTION_TYPE                  = 14,
        ROTATE_MOTION_TYPE                  = 15,
        EFFECT_MOTION_TYPE                  = 16,
        SPLINE_CHAIN_MOTION_TYPE            = 17,                 // SplineChainMovementGenerator.h
    }

    public enum SpellSchools
    {
        SPELL_SCHOOL_NORMAL                 = 0,
        SPELL_SCHOOL_HOLY                   = 1,
        SPELL_SCHOOL_FIRE                   = 2,
        SPELL_SCHOOL_NATURE                 = 3,
        SPELL_SCHOOL_FROST                  = 4,
        SPELL_SCHOOL_SHADOW                 = 5,
        SPELL_SCHOOL_ARCANE                 = 6
    }

    public enum UnitStates
    {
        UNIT_STATE_DIED                     = 1,                     // player has fake death aura
        UNIT_STATE_MELEE_ATTACKING          = 2,                     // player is melee attacking someone
        UNIT_STATE_CHARMED                  = 4,                     // having any kind of charm aura on self
        UNIT_STATE_STUNNED                  = 8,
        UNIT_STATE_ROAMING                  = 16,
        UNIT_STATE_CHASE                    = 32,
        UNIT_STATE_FOCUSING                 = 64,
        UNIT_STATE_FLEEING                  = 128,
        UNIT_STATE_IN_FLIGHT                = 256,                     // player is in flight mode
        UNIT_STATE_FOLLOW                   = 512,
        UNIT_STATE_ROOT                     = 1024,
        UNIT_STATE_CONFUSED                 = 2048,
        UNIT_STATE_DISTRACTED               = 4096,
        UNIT_STATE_ISOLATED                 = 8192,                     // area auras do not affect other players
        UNIT_STATE_ATTACK_PLAYER            = 16384,
        UNIT_STATE_CASTING                  = 32768,
        UNIT_STATE_POSSESSED                = 65536,
        UNIT_STATE_CHARGING                 = 131072,
        UNIT_STATE_JUMPING                  = 262144,
        UNIT_STATE_MOVE                     = 1048576,
        UNIT_STATE_ROTATING                 = 2097152,
        UNIT_STATE_EVADE                    = 4194304,
        UNIT_STATE_ROAMING_MOVE             = 8388608,
        UNIT_STATE_CONFUSED_MOVE            = 16777216,
        UNIT_STATE_FLEEING_MOVE             = 33554432,
        UNIT_STATE_CHASE_MOVE               = 67108864,
        UNIT_STATE_FOLLOW_MOVE              = 134217728,
        UNIT_STATE_IGNORE_PATHFINDING       = 268435456,                 // do not use pathfinding in any MovementGenerator
        UNIT_STATE_DIFFERENT_PATHFINDING    = 536870912,                 // do not call NormalizePath, do not add CollisioHeight
        UNIT_STATE_WAYPOINT_PAUSED          = 1073741824,
    }

    [Flags]
    public enum GameObjectActions
    {
        // Name from client executable      // Comments
         None                          = 0,   // -NONE-
         AnimateCustom0                = 1,   // Animate Custom0
         AnimateCustom1                = 2,   // Animate Custom1
         AnimateCustom2                = 3,   // Animate Custom2
         AnimateCustom3                = 4,   // Animate Custom3
         Disturb                       = 5,   // Disturb                          // Triggers trap
         Unlock                        = 6,   // Unlock                           // Resets GO_FLAG_LOCKED
         Lock                          = 7,   // Lock                             // Sets GO_FLAG_LOCKED
         Open                          = 8,   // Open                             // Sets GO_STATE_ACTIVE
         OpenAndUnlock                 = 9,   // Open + Unlock                    // Sets GO_STATE_ACTIVE and resets GO_FLAG_LOCKED
         Close                         = 10,  // Close                            // Sets GO_STATE_READY
         ToggleOpen                    = 11,  // Toggle Open
         Destroy                       = 12,  // Destroy                          // Sets GO_STATE_DESTROYED
         Rebuild                       = 13,  // Rebuild                          // Resets from GO_STATE_DESTROYED
         Creation                      = 14,  // Creation
         Despawn                       = 15,  // Despawn
         MakeInert                     = 16,  // Make Inert                       // Disables interactions
         MakeActive                    = 17,  // Make Active                      // Enables interactions
         CloseAndLock                  = 18,  // Close + Lock                     // Sets GO_STATE_READY and sets GO_FLAG_LOCKED
         UseArtKit0                    = 19,  // Use ArtKit0                      // 46904: 121
         UseArtKit1                    = 20,  // Use ArtKit1                      // 36639: 81, 46903: 122
         UseArtKit2                    = 21,  // Use ArtKit2
         UseArtKit3                    = 22,  // Use ArtKit3
         SetTapList                    = 23  // Set Tap List
    };

    [Flags]
    public enum TriggerCastFlags
    {
        TRIGGERED_NONE                                = 0,   //! Not triggered
        TRIGGERED_IGNORE_GCD                          = 1,   //! Will ignore GCD
        TRIGGERED_IGNORE_SPELL_AND_CATEGORY_CD        = 2,   //! Will ignore Spell and Category cooldowns
        TRIGGERED_IGNORE_POWER_AND_REAGENT_COST       = 4,   //! Will ignore power and reagent cost
        TRIGGERED_IGNORE_CAST_ITEM                    = 8,   //! Will not take away cast item or update related achievement criteria
        TRIGGERED_IGNORE_AURA_SCALING                 = 16,   //! Will ignore aura scaling
        TRIGGERED_IGNORE_CAST_IN_PROGRESS             = 32,   //! Will not check if a current cast is in progress
        TRIGGERED_IGNORE_COMBO_POINTS                 = 64,   //! Will ignore combo point requirement
        TRIGGERED_CAST_DIRECTLY                       = 128,   //! In Spell::prepare, will be cast directly without setting containers for executed spell
        TRIGGERED_IGNORE_AURA_INTERRUPT_FLAGS         = 256,   //! Will ignore interruptible aura's at cast
        TRIGGERED_IGNORE_SET_FACING                   = 512,   //! Will not adjust facing to target (if any)
        TRIGGERED_IGNORE_SHAPESHIFT                   = 1024,   //! Will ignore shapeshift checks
        TRIGGERED_IGNORE_CASTER_AURASTATE             = 2048,   //! Will ignore caster aura states including combat requirements and death state
        TRIGGERED_DISALLOW_PROC_EVENTS                = 4096,   //! Disallows proc events from triggered spell (default)
        TRIGGERED_IGNORE_CASTER_MOUNTED_OR_ON_VEHICLE = 8192,   //! Will ignore mounted/on vehicle restrictions
                                                                      // reuse                                        = 0x00004000,
                                                                      // reuse                                        = 0x00008000,
        TRIGGERED_IGNORE_CASTER_AURAS                 = 65536,   //! Will ignore caster aura restrictions or requirements
        TRIGGERED_DONT_RESET_PERIODIC_TIMER           = 131072,   //! Will allow periodic aura timers to keep ticking (instead of resetting)
        TRIGGERED_DONT_REPORT_CAST_ERROR              = 262144,   //! Will return SPELL_FAILED_DONT_REPORT in CheckCast functions

        // debug flags (used with .cast triggered commands)
        TRIGGERED_IGNORE_EQUIPPED_ITEM_REQUIREMENT    = 524288,   //! Will ignore equipped item requirements
    };
    
    public enum SheathState
    {
        SHEATH_STATE_UNARMED                   = 0,                              // non prepared weapon
        SHEATH_STATE_MELEE                     = 1,                              // prepared melee weapon
        SHEATH_STATE_RANGED                    = 2                               // prepared ranged weapon
    }

    public enum TempSummonType
    {
        TEMPSUMMON_TIMED_OR_DEAD_DESPAWN       = 1,             // despawns after a specified time OR when the creature disappears
        TEMPSUMMON_TIMED_OR_CORPSE_DESPAWN     = 2,             // despawns after a specified time OR when the creature dies
        TEMPSUMMON_TIMED_DESPAWN               = 3,             // despawns after a specified time
        TEMPSUMMON_TIMED_DESPAWN_OUT_OF_COMBAT = 4,             // despawns after a specified time after the creature is out of combat
        TEMPSUMMON_CORPSE_DESPAWN              = 5,             // despawns instantly after death
        TEMPSUMMON_CORPSE_TIMED_DESPAWN        = 6,             // despawns after a specified time after death
        TEMPSUMMON_DEAD_DESPAWN                = 7,             // despawns when the creature disappears
        TEMPSUMMON_MANUAL_DESPAWN              = 8              // despawns when UnSummon() is called
    }

    public enum UnitFieldBytes1Types
    {
        UNIT_STAND_STAND_STATE_TYPE            = 0,
        UNIT_PET_TALENTS_TYPE                  = 1,
        UNIT_STAND_FLAGS_TYPE                  = 2,
        UNIT_BYTES1_FLAGS_TYPE                 = 3,
    }

    public enum SmartActionlistTimerUpdateType
    {
        ACTIONLIST_UPDATE_OUT_OF_COMBAT        = 0,
        ACTIONLIST_UPDATE_IN_COMBAT            = 1,
        ACTIONLIST_UPDATE_ALWAYS               = 2,
    }

    public enum ConditionSourceTypes
    {
        CONDITION_SOURCE_TYPE_NONE                           = 0,
        CONDITION_SOURCE_TYPE_CREATURE_LOOT_TEMPLATE         = 1,
        CONDITION_SOURCE_TYPE_DISENCHANT_LOOT_TEMPLATE       = 2,
        CONDITION_SOURCE_TYPE_FISHING_LOOT_TEMPLATE          = 3,
        CONDITION_SOURCE_TYPE_GAMEOBJECT_LOOT_TEMPLATE       = 4,
        CONDITION_SOURCE_TYPE_ITEM_LOOT_TEMPLATE             = 5,
        CONDITION_SOURCE_TYPE_MAIL_LOOT_TEMPLATE             = 6,
        CONDITION_SOURCE_TYPE_MILLING_LOOT_TEMPLATE          = 7,
        CONDITION_SOURCE_TYPE_PICKPOCKETING_LOOT_TEMPLATE    = 8,
        CONDITION_SOURCE_TYPE_PROSPECTING_LOOT_TEMPLATE      = 9,
        CONDITION_SOURCE_TYPE_REFERENCE_LOOT_TEMPLATE        = 10,
        CONDITION_SOURCE_TYPE_SKINNING_LOOT_TEMPLATE         = 11,
        CONDITION_SOURCE_TYPE_SPELL_LOOT_TEMPLATE            = 12,
        CONDITION_SOURCE_TYPE_SPELL_IMPLICIT_TARGET          = 13,
        CONDITION_SOURCE_TYPE_GOSSIP_MENU                    = 14,
        CONDITION_SOURCE_TYPE_GOSSIP_MENU_OPTION             = 15,
        CONDITION_SOURCE_TYPE_CREATURE_TEMPLATE_VEHICLE      = 16,
        CONDITION_SOURCE_TYPE_SPELL                          = 17,
        CONDITION_SOURCE_TYPE_SPELL_CLICK_EVENT              = 18,
        CONDITION_SOURCE_TYPE_QUEST_ACCEPT                   = 19,
        CONDITION_SOURCE_TYPE_QUEST_SHOW_MARK                = 20,
        CONDITION_SOURCE_TYPE_VEHICLE_SPELL                  = 21,
        CONDITION_SOURCE_TYPE_SMART_EVENT                    = 22,
        CONDITION_SOURCE_TYPE_NPC_VENDOR                     = 23,
        CONDITION_SOURCE_TYPE_SPELL_PROC                     = 24,
        CONDITION_SOURCE_TYPE_MAX,
    }

    public enum ConditionTypes
    {                                                           // value1           value2         value3
        CONDITION_NONE                  = 0,                    // 0                0              0                  always true
        CONDITION_AURA                  = 1,                    // spell_id         effindex       use target?        true if player (or target, if value3) has aura of spell_id with effect effindex
        CONDITION_ITEM                  = 2,                    // item_id          count          bank               true if has #count of item_ids (if 'bank' is set it searches in bank slots too)
        CONDITION_ITEM_EQUIPPED         = 3,                    // item_id          0              0                  true if has item_id equipped
        CONDITION_ZONEID                = 4,                    // zone_id          0              0                  true if in zone_id
        CONDITION_REPUTATION_RANK       = 5,                    // faction_id       rankMask       0                  true if has min_rank for faction_id
        CONDITION_TEAM                  = 6,                    // player_team      0,             0                  469 - Alliance, 67 - Horde)
        CONDITION_SKILL                 = 7,                    // skill_id         skill_value    0                  true if has skill_value for skill_id
        CONDITION_QUESTREWARDED         = 8,                    // quest_id         0              0                  true if quest_id was rewarded before
        CONDITION_QUESTTAKEN            = 9,                    // quest_id         0,             0                  true while quest active
        CONDITION_DRUNKENSTATE          = 10,                   // DrunkenState     0,             0                  true if player is drunk enough
        CONDITION_WORLD_STATE           = 11,                   // index            value          0                  true if world has the value for the index
        CONDITION_ACTIVE_EVENT          = 12,                   // event_id         0              0                  true if event is active
        CONDITION_INSTANCE_INFO         = 13,                   // entry            data           type               true if the instance info defined by type (enum InstanceInfo) equals data.
        CONDITION_QUEST_NONE            = 14,                   // quest_id         0              0                  true if doesn't have quest saved
        CONDITION_CLASS                 = 15,                   // class            0              0                  true if player's class is equal to class
        CONDITION_RACE                  = 16,                   // race             0              0                  true if player's race is equal to race
        CONDITION_ACHIEVEMENT           = 17,                   // achievement_id   0              0                  true if achievement is complete
        CONDITION_TITLE                 = 18,                   // title id         0              0                  true if player has title
        CONDITION_SPAWNMASK             = 19,                   // spawnMask        0              0                  true if in spawnMask
        CONDITION_GENDER                = 20,                   // gender           0              0                  true if player's gender is equal to gender
        CONDITION_UNIT_STATE            = 21,                   // unitState        0              0                  true if unit has unitState
        CONDITION_MAPID                 = 22,                   // map_id           0              0                  true if in map_id
        CONDITION_AREAID                = 23,                   // area_id          0              0                  true if in area_id
        CONDITION_CREATURE_TYPE         = 24,                   // cinfo.type       0              0                  true if creature_template.type = value1
        CONDITION_SPELL                 = 25,                   // spell_id         0              0                  true if player has learned spell
        CONDITION_PHASEMASK             = 26,                   // phasemask        0              0                  true if object is in phasemask
        CONDITION_LEVEL                 = 27,                   // level            ComparisonType 0                  true if unit's level is equal to param1 (param2 can modify the statement)
        CONDITION_QUEST_COMPLETE        = 28,                   // quest_id         0              0                  true if player has quest_id with all objectives complete, but not yet rewarded
        CONDITION_NEAR_CREATURE         = 29,                   // creature entry   distance       0                  true if there is a creature of entry in range
        CONDITION_NEAR_GAMEOBJECT       = 30,                   // gameobject entry distance       0                  true if there is a gameobject of entry in range
        CONDITION_OBJECT_ENTRY          = 31,                   // TypeID           entry          0                  true if object is type TypeID and the entry is 0 or matches entry of the object
        CONDITION_TYPE_MASK             = 32,                   // TypeMask         0              0                  true if object is type object's TypeMask matches provided TypeMask
        CONDITION_RELATION_TO           = 33,                   // ConditionTarget  RelationType   0                  true if object is in given relation with object specified by ConditionTarget
        CONDITION_REACTION_TO           = 34,                   // ConditionTarget  rankMask       0                  true if object's reaction matches rankMask object specified by ConditionTarget
        CONDITION_DISTANCE_TO           = 35,                   // ConditionTarget  distance       ComparisonType     true if object and ConditionTarget are within distance given by parameters
        CONDITION_ALIVE                 = 36,                   // 0                0              0                  true if unit is alive
        CONDITION_HP_VAL                = 37,                   // hpVal            ComparisonType 0                  true if unit's hp matches given value
        CONDITION_HP_PCT                = 38,                   // hpPct            ComparisonType 0                  true if unit's hp matches given pct
        CONDITION_MAX                   = 39                    // MAX
    }

    public enum SpellEffIndex
    {
        EFFECT_0 = 0,
        EFFECT_1 = 1,
        EFFECT_2 = 2
    }

    //! ErrorType in Conditions
    public enum SpellCastResult
    {
        NONE = 0,
        AFFECTING_COMBAT = 1,
        ALREADY_AT_FULL_HEALTH = 2,
        ALREADY_AT_FULL_MANA = 3,
        ALREADY_AT_FULL_POWER = 4,
        ALREADY_BEING_TAMED = 5,
        ALREADY_HAVE_CHARM = 6,
        ALREADY_HAVE_SUMMON = 7,
        ALREADY_OPEN = 8,
        AURA_BOUNCED = 9,
        AUTOTRACK_INTERRUPTED = 10,
        BAD_IMPLICIT_TARGETS = 11,
        BAD_TARGETS = 12,
        CANT_BE_CHARMED = 13,
        CANT_BE_DISENCHANTED = 14,
        CANT_BE_DISENCHANTED_SKILL = 15,
        CANT_BE_MILLED = 16,
        CANT_BE_PROSPECTED = 17,
        CANT_CAST_ON_TAPPED = 18,
        CANT_DUEL_WHILE_INVISIBLE = 19,
        CANT_DUEL_WHILE_STEALTHED = 20,
        CANT_STEALTH = 21,
        CASTER_AURASTATE = 22,
        CASTER_DEAD = 23,
        CHARMED = 24,
        CHEST_IN_USE = 25,
        CONFUSED = 26,
        DONT_REPORT = 27,
        EQUIPPED_ITEM = 28,
        EQUIPPED_ITEM_CLASS = 29,
        EQUIPPED_ITEM_CLASS_MAINHAND = 30,
        EQUIPPED_ITEM_CLASS_OFFHAND = 31,
        ERROR = 32,
        FIZZLE = 33,
        FLEEING = 34,
        FOOD_LOWLEVEL = 35,
        HIGHLEVEL = 36,
        HUNGER_SATIATED = 37,
        IMMUNE = 38,
        INCORRECT_AREA = 39,
        INTERRUPTED = 40,
        INTERRUPTED_COMBAT = 41,
        ITEM_ALREADY_ENCHANTED = 42,
        ITEM_GONE = 43,
        ITEM_NOT_FOUND = 44,
        ITEM_NOT_READY = 45,
        LEVEL_REQUIREMENT = 46,
        LINE_OF_SIGHT = 47,
        LOWLEVEL = 48,
        LOW_CASTLEVEL = 49,
        MAINHAND_EMPTY = 50,
        MOVING = 51,
        NEED_AMMO = 52,
        NEED_AMMO_POUCH = 53,
        NEED_EXOTIC_AMMO = 54,
        NEED_MORE_ITEMS = 55,
        NOPATH = 56,
        NOT_BEHIND = 57,
        NOT_FISHABLE = 58,
        NOT_FLYING = 59,
        NOT_HERE = 60,
        NOT_INFRONT = 61,
        NOT_IN_CONTROL = 62,
        NOT_KNOWN = 63,
        NOT_MOUNTED = 64,
        NOT_ON_TAXI = 65,
        NOT_ON_TRANSPORT = 66,
        NOT_READY = 67,
        NOT_SHAPESHIFT = 68,
        NOT_STANDING = 69,
        NOT_TRADEABLE = 70,
        NOT_TRADING = 71,
        NOT_UNSHEATHED = 72,
        NOT_WHILE_GHOST = 73,
        NOT_WHILE_LOOTING = 74,
        NO_AMMO = 75,
        NO_CHARGES_REMAIN = 76,
        NO_CHAMPION = 77,
        NO_COMBO_POINTS = 78,
        NO_DUELING = 79,
        NO_ENDURANCE = 80,
        NO_FISH = 81,
        NO_ITEMS_WHILE_SHAPESHIFTED = 82,
        NO_MOUNTS_ALLOWED = 83,
        NO_PET = 84,
        NO_POWER = 85,
        NOTHING_TO_DISPEL = 86,
        NOTHING_TO_STEAL = 87,
        ONLY_ABOVEWATER = 88,
        ONLY_DAYTIME = 89,
        ONLY_INDOORS = 90,
        ONLY_MOUNTED = 91,
        ONLY_NIGHTTIME = 92,
        ONLY_OUTDOORS = 93,
        ONLY_SHAPESHIFT = 94,
        ONLY_STEALTHED = 95,
        ONLY_UNDERWATER = 96,
        OUT_OF_RANGE = 97,
        PACIFIED = 98,
        POSSESSED = 99,
        REAGENTS = 100,
        REQUIRES_AREA = 101,
        REQUIRES_SPELL_FOCUS = 102,
        ROOTED = 103,
        SILENCED = 104,
        SPELL_IN_PROGRESS = 105,
        SPELL_LEARNED = 106,
        SPELL_UNAVAILABLE = 107,
        STUNNED = 108,
        TARGETS_DEAD = 109,
        TARGET_AFFECTING_COMBAT = 110,
        TARGET_AURASTATE = 111,
        TARGET_DUELING = 112,
        TARGET_ENEMY = 113,
        TARGET_ENRAGED = 114,
        TARGET_FRIENDLY = 115,
        TARGET_IN_COMBAT = 116,
        TARGET_IS_PLAYER = 117,
        TARGET_IS_PLAYER_CONTROLLED = 118,
        TARGET_NOT_DEAD = 119,
        TARGET_NOT_IN_PARTY = 120,
        TARGET_NOT_LOOTED = 121,
        TARGET_NOT_PLAYER = 122,
        TARGET_NO_POCKETS = 123,
        TARGET_NO_WEAPONS = 124,
        TARGET_NO_RANGED_WEAPONS = 125,
        TARGET_UNSKINNABLE = 126,
        THIRST_SATIATED = 127,
        TOO_CLOSE = 128,
        TOO_MANY_OF_ITEM = 129,
        TOTEM_CATEGORY = 130,
        TOTEMS = 131,
        TRY_AGAIN = 132,
        UNIT_NOT_BEHIND = 133,
        UNIT_NOT_INFRONT = 134,
        WRONG_PET_FOOD = 135,
        NOT_WHILE_FATIGUED = 136,
        TARGET_NOT_IN_INSTANCE = 137,
        NOT_WHILE_TRADING = 138,
        TARGET_NOT_IN_RAID = 139,
        TARGET_FREEFORALL = 140,
        NO_EDIBLE_CORPSES = 141,
        ONLY_BATTLEGROUNDS = 142,
        TARGET_NOT_GHOST = 143,
        TRANSFORM_UNUSABLE = 144,
        WRONG_WEATHER = 145,
        DAMAGE_IMMUNE = 146,
        PREVENTED_BY_MECHANIC = 147,
        PLAY_TIME = 148,
        REPUTATION = 149,
        MIN_SKILL = 150,
        NOT_IN_ARENA = 151,
        NOT_ON_SHAPESHIFT = 152,
        NOT_ON_STEALTHED = 153,
        NOT_ON_DAMAGE_IMMUNE = 154,
        NOT_ON_MOUNTED = 155,
        TOO_SHALLOW = 156,
        TARGET_NOT_IN_SANCTUARY = 157,
        TARGET_IS_TRIVIAL = 158,
        BM_OR_INVISGOD = 159,
        EXPERT_RIDING_REQUIREMENT = 160,
        ARTISAN_RIDING_REQUIREMENT = 161,
        NOT_IDLE = 162,
        NOT_INACTIVE = 163,
        PARTIAL_PLAYTIME = 164,
        NO_PLAYTIME = 165,
        NOT_IN_BATTLEGROUND = 166,
        NOT_IN_RAID_INSTANCE = 167,
        ONLY_IN_ARENA = 168,
        TARGET_LOCKED_TO_RAID_INSTANCE = 169,
        ON_USE_ENCHANT = 170,
        NOT_ON_GROUND = 171,
        CUSTOM_ERROR = 172,
        CANT_DO_THAT_RIGHT_NOW = 173,
        TOO_MANY_SOCKETS = 174,
        INVALID_GLYPH = 175,
        UNIQUE_GLYPH = 176,
        GLYPH_SOCKET_LOCKED = 177,
        NO_VALID_TARGETS = 178,
        ITEM_AT_MAX_CHARGES = 179,
        NOT_IN_BARBERSHOP = 180,
        FISHING_TOO_LOW = 181,
        ITEM_ENCHANT_TRADE_WINDOW = 182,
        SUMMON_PENDING = 183,
        MAX_SOCKETS = 184,
        PET_CAN_RENAME = 185,
        TARGET_CANNOT_BE_RESURRECTED = 186,
    }

    //! ErrorTextId
    public enum SpellCustomErrors
    {
        ERROR_NONE                             =  0,
        ERROR_CUSTOM_MSG                       =  1, // Something bad happened, and we want to display a custom message!
        ERROR_ALEX_BROKE_QUEST                 =  2, // Alex broke your quest! Thank him later!
        ERROR_NEED_HELPLESS_VILLAGER           =  3, // This spell may only be used on Helpless Wintergarde Villagers that have not been rescued.
        ERROR_NEED_WARSONG_DISGUISE            =  4, // Requires that you be wearing the Warsong Orc Disguise.
        ERROR_REQUIRES_PLAGUE_WAGON            =  5, // You must be closer to a plague wagon in order to drop off your 7th Legion Siege Engineer.
        ERROR_CANT_TARGET_FRIENDLY_NONPARTY    =  6, // You cannot target friendly units outside your party.
        ERROR_NEED_CHILL_NYMPH                 =  7, // You must target a weakened chill nymph.
        ERROR_MUST_BE_IN_ENKILAH               =  8, // The Imbued Scourge Shroud will only work when equipped in the Temple City of En'kilah.
        ERROR_REQUIRES_CORPSE_DUST             =  9, // Requires Corpse Dust
        ERROR_CANT_SUMMON_GARGOYLE             = 10, // You cannot summon another gargoyle yet.
        ERROR_NEED_CORPSE_DUST_IF_NO_TARGET    = 11, // Requires Corpse Dust if the target is not dead and humanoid.
        ERROR_MUST_BE_AT_SHATTERHORN           = 12, // Can only be placed near Shatterhorn
        ERROR_MUST_TARGET_PROTO_DRAKE_EGG      = 13, // You must first select a Proto-Drake Egg.
        ERROR_MUST_BE_CLOSE_TO_TREE            = 14, // You must be close to a marked tree.
        ERROR_MUST_TARGET_TURKEY               = 15, // You must target a Fjord Turkey.
        ERROR_MUST_TARGET_HAWK                 = 16, // You must target a Fjord Hawk.
        ERROR_TOO_FAR_FROM_BOUY                = 17, // You are too far from the bouy.
        ERROR_MUST_BE_CLOSE_TO_OIL_SLICK       = 18, // Must be used near an oil slick.
        ERROR_MUST_BE_CLOSE_TO_BOUY            = 19, // You must be closer to the buoy!
        ERROR_WYRMREST_VANQUISHER              = 20, // You may only call for the aid of a Wyrmrest Vanquisher in Wyrmrest Temple, The Dragon Wastes, Galakrond's Rest or The Wicked Coil.
        ERROR_MUST_TARGET_ICE_HEART_JORMUNGAR  = 21, // That can only be used on a Ice Heart Jormungar Spawn.
        ERROR_MUST_BE_CLOSE_TO_SINKHOLE        = 22, // You must be closer to a sinkhole to use your map.
        ERROR_REQUIRES_HAROLD_LANE             = 23, // You may only call down a stampede on Harold Lane.
        ERROR_REQUIRES_GAMMOTH_MAGNATAUR = 24, // You may only use the Pouch of Crushed Bloodspore on Gammothra or other magnataur in the Bloodspore Plains and Gammoth.
        ERROR_MUST_BE_IN_RESURRECTION_CHAMBER  = 25, // Requires the magmawyrm resurrection chamber in the back of the Maw of Neltharion.
        ERROR_CANT_CALL_WINTERGARDE_HERE       = 26, // You may only call down a Wintergarde Gryphon in Wintergarde Keep or the Carrion Fields.
        ERROR_MUST_TARGET_WILHELM              = 27, // What are you doing? Only aim that thing at Wilhelm!
        ERROR_NOT_ENOUGH_HEALTH                = 28, // Not enough health!
        ERROR_NO_NEARBY_CORPSES                = 29, // There are no nearby corpses to use
        ERROR_TOO_MANY_GHOULS                  = 30, // You've created enough ghouls. Return to Gothik the Harvester at Death's Breach.
        ERROR_GO_FURTHER_FROM_SUNDERED_SHARD   = 31, // Your companion does not want to come here.  Go further from the Sundered Shard.
        ERROR_MUST_BE_IN_CAT_FORM              = 32, // Must be in Cat Form
        ERROR_MUST_BE_DEATH_KNIGHT             = 33, // Only Death Knights may enter Ebon Hold.
        ERROR_MUST_BE_IN_FERAL_FORM            = 34, // Must be in Cat Form, Bear Form, or Dire Bear Form
        ERROR_MUST_BE_NEAR_HELPLESS_VILLAGER   = 35, // You must be within range of a Helpless Wintergarde Villager.
        ERROR_CANT_TARGET_ELEMENTAL_MECHANICAL = 36, // You cannot target an elemental or mechanical corpse.
        ERROR_MUST_HAVE_USED_DALARAN_CRYSTAL   = 37, // This teleport crystal cannot be used until the teleport crystal in Dalaran has been used at least once.
        ERROR_YOU_ALREADY_HOLD_SOMETHING       = 38, // You are already holding something in your hand. You must throw the creature in your hand before picking up another.
        ERROR_YOU_DONT_HOLD_ANYTHING           = 39, // You don't have anything to throw! Find a Vargul and use Gymer Grab to pick one up!
        ERROR_MUST_BE_CLOSE_TO_VALDURAN        = 40, // Bouldercrag's War Horn can only be used within 10 yards of Valduran the Stormborn.
        ERROR_NO_PASSENGER                     = 41, // You are not carrying a passenger. There is nobody to drop off.
        ERROR_CANT_BUILD_MORE_VEHICLES         = 42, // You cannot build any more siege vehicles.
        ERROR_ALREADY_CARRYING_CRUSADER        = 43, // You are already carrying a captured Argent Crusader. You must return to the Argent Vanguard infirmary and drop off your passenger before you may pick up another.
        ERROR_CANT_DO_WHILE_ROOTED             = 44, // You can't do that while rooted.
        ERROR_REQUIRES_NEARBY_TARGET           = 45, // Requires a nearby target.
        ERROR_NOTHING_TO_DISCOVER              = 46, // Nothing left to discover.
        ERROR_NOT_ENOUGH_TARGETS               = 47, // No targets close enough to bluff.
        ERROR_CONSTRUCT_TOO_FAR                = 48, // Your Iron Rune Construct is out of range.
        ERROR_REQUIRES_GRAND_MASTER_ENGINEER   = 49, // Requires Grand Master Engineer
        ERROR_CANT_USE_THAT_MOUNT              = 50, // You can't use that mount.
        ERROR_NOONE_TO_EJECT                   = 51, // There is nobody to eject!
        ERROR_TARGET_MUST_BE_BOUND             = 52, // The target must be bound to you.
        ERROR_TARGET_MUST_BE_UNDEAD            = 53, // Target must be undead.
        ERROR_TARGET_TOO_FAR                   = 54, // You have no target or your target is too far away.
        ERROR_MISSING_DARK_MATTER              = 55, // Missing Reagents: Dark Matter
        ERROR_CANT_USE_THAT_ITEM               = 56, // You can't use that item
        ERROR_CANT_DO_WHILE_CYCYLONED          = 57, // You can't do that while Cycloned
        ERROR_TARGET_HAS_SCROLL                = 58, // Target is already affected by a scroll
        ERROR_POISON_TOO_STRONG                = 59, // That anti-venom is not strong enough to dispel that poison
        ERROR_MUST_HAVE_LANCE_EQUIPPED         = 60, // You must have a lance equipped.
        ERROR_MUST_BE_CLOSE_TO_MAIDEN          = 61, // You must be near the Maiden of Winter's Breath Lake.
        ERROR_LEARNED_EVERYTHING               = 62, // You have learned everything from that book
        ERROR_PET_IS_DEAD                      = 63, // Your pet is dead
        ERROR_NO_VALID_TARGETS                 = 64, // There are no valid targets within range.
        ERROR_GM_ONLY                          = 65, // Only GMs may use that. Your account has been reported for investigation.
        ERROR_REQUIRES_LEVEL_58                = 66, // You must reach level 58 to use this portal.
        ERROR_AT_HONOR_CAP                     = 67, // You already have the maximum amount of honor.
        ERROR_68                               = 68, // ""
        ERROR_69                               = 69, // ""
        ERROR_70                               = 70, // ""
        ERROR_71                               = 71, // ""
        ERROR_72                               = 72, // ""
        ERROR_73                               = 73, // ""
        ERROR_74                               = 74, // ""
        ERROR_MUST_HAVE_DEMONIC_CIRCLE         = 75, // You must have a demonic circle active.
        ERROR_AT_MAX_RAGE                      = 76, // You already have maximum rage
        ERROR_REQUIRES_350_ENGINEERING         = 77, // Requires Engineering (350)
        ERROR_SOUL_BELONGS_TO_LICH_KING        = 78, // Your soul belongs to the Lich King
        ERROR_ATTENDANT_HAS_PONY               = 79, // Your attendant already has an Argent Pony
        ERROR_80                               = 80, // ""
        ERROR_81                               = 81, // ""
        ERROR_82                               = 82, // ""
        ERROR_MUST_HAVE_FIRE_TOTEM             = 83, // You must have a Fire Totem active.
        ERROR_CANT_TARGET_VAMPIRES             = 84, // You may not bite other vampires.
        ERROR_PET_ALREADY_AT_YOUR_LEVEL        = 85, // Your pet is already at your level.
        ERROR_MISSING_ITEM_REQUIREMENS         = 86, // You do not meet the level requirements for this item.
        ERROR_TOO_MANY_ABOMINATIONS            = 87, // There are too many Mutated Abominations.
        ERROR_ALL_POTIONS_USED                 = 88, // The potions have all been depleted by Professor Putricide.
        ERROR_89                               = 89, // ""
        ERROR_REQUIRES_LEVEL_65                = 90, // Requires level 65
        ERROR_91                               = 91, // ""
        ERROR_92                               = 92, // ""
        ERROR_93                               = 93, // ""
        ERROR_94                               = 94, // ""
        ERROR_95                               = 95, // ""
        ERROR_MAX_NUMBER_OF_RECRUITS           = 96, // You already have the max number of recruits.
        ERROR_MAX_NUMBER_OF_VOLUNTEERS         = 97, // You already have the max number of volunteers.
        ERROR_FROSTMOURNE_RENDERED_RESSURECT   = 98, // Frostmourne has rendered you unable to ressurect.
        ERROR_CANT_MOUNT_WITH_SHAPESHIFT       = 99  // You can't mount while affected by that shapeshift.
    }

    enum ReputationRank
    {
        REP_HATED       = 0,
        REP_HOSTILE     = 1,
        REP_UNFRIENDLY  = 2,
        REP_NEUTRAL     = 3,
        REP_FRIENDLY    = 4,
        REP_HONORED     = 5,
        REP_REVERED     = 6,
        REP_EXALTED     = 7
    }

    enum ReputationRankMask
    {
        REP_NONE        = 0,
        REP_HATED       = 1,
        REP_HOSTILE     = 2,
        REP_UNFRIENDLY  = 4,
        REP_NEUTRAL     = 8,
        REP_FRIENDLY    = 16,
        REP_HONORED     = 32,
        REP_REVERED     = 64,
        REP_EXALTED     = 128
    }

    enum DrunkenState
    {
        DRUNKEN_STATE_SOBER,
        DRUNKEN_STATE_TIPSY,
        DRUNKEN_STATE_DRUNK,
        DRUNKEN_STATE_SMASHED,
    }

    enum InstanceInfo
    {
        INSTANCE_INFO_DATA,
        INSTANCE_INFO_DATA64,
        INSTANCE_INFO_BOSS_STATE
    }

    enum PlayerClasses
    {
        CLASS_NONE                = 0,
        CLASS_WARRIOR             = 1,
        CLASS_PALADIN             = 2,
        CLASS_HUNTER              = 3,
        CLASS_ROGUE               = 4,
        CLASS_PRIEST              = 5,
        CLASS_DEATH_KNIGHT        = 6,
        CLASS_SHAMAN              = 7,
        CLASS_MAGE                = 8,
        CLASS_WARLOCK             = 9,
        //CLASS_UNK               = 10,
        CLASS_DRUID               = 11
    }

    enum Races
    {
        RACE_NONE                 = 0,
        RACE_HUMAN                = 1,
        RACE_ORC                  = 2,
        RACE_DWARF                = 3,
        RACE_NIGHTELF             = 4,
        RACE_UNDEAD_PLAYER        = 5,
        RACE_TAUREN               = 6,
        RACE_GNOME                = 7,
        RACE_TROLL                = 8,
        //RACE_GOBLIN             = 9,
        RACE_BLOODELF             = 10,
        RACE_DRAENEI              = 11
        //RACE_FEL_ORC            = 12,
        //RACE_NAGA               = 13,
        //RACE_BROKEN             = 14,
        //RACE_SKELETON           = 15,
        //RACE_VRYKUL             = 16,
        //RACE_TUSKARR            = 17,
        //RACE_FOREST_TROLL       = 18,
        //RACE_TAUNKA             = 19,
        //RACE_NORTHREND_SKELETON = 20,
        //RACE_ICE_TROLL          = 21
    }

    enum Difficulty
    {
        REGULAR_DIFFICULTY           = 0,
                                     
        DUNGEON_DIFFICULTY_NORMAL    = 0,
        DUNGEON_DIFFICULTY_HEROIC    = 1,
        DUNGEON_DIFFICULTY_EPIC      = 2,

        RAID_DIFFICULTY_10MAN_NORMAL = 0,
        RAID_DIFFICULTY_25MAN_NORMAL = 1,
        RAID_DIFFICULTY_10MAN_HEROIC = 2,
        RAID_DIFFICULTY_25MAN_HEROIC = 3
    }

    [Flags]
    enum SpawnMask
    {
        SPAWNMASK_NONE = 0,
        SPAWNMASK_CONTINENT = (1 << Difficulty.REGULAR_DIFFICULTY), // any maps without spawn modes

        SPAWNMASK_DUNGEON_NORMAL = (1 << Difficulty.DUNGEON_DIFFICULTY_NORMAL),
        SPAWNMASK_DUNGEON_HEROIC = (1 << Difficulty.DUNGEON_DIFFICULTY_HEROIC),
        SPAWNMASK_DUNGEON_ALL = (SPAWNMASK_DUNGEON_NORMAL | SPAWNMASK_DUNGEON_HEROIC),

        SPAWNMASK_RAID_10MAN_NORMAL = (1 << Difficulty.RAID_DIFFICULTY_10MAN_NORMAL),
        SPAWNMASK_RAID_25MAN_NORMAL = (1 << Difficulty.RAID_DIFFICULTY_25MAN_NORMAL),
        SPAWNMASK_RAID_NORMAL_ALL = (SPAWNMASK_RAID_10MAN_NORMAL | SPAWNMASK_RAID_25MAN_NORMAL),

        SPAWNMASK_RAID_10MAN_HEROIC = (1 << Difficulty.RAID_DIFFICULTY_10MAN_HEROIC),
        SPAWNMASK_RAID_25MAN_HEROIC = (1 << Difficulty.RAID_DIFFICULTY_25MAN_HEROIC),
        SPAWNMASK_RAID_HEROIC_ALL = (SPAWNMASK_RAID_10MAN_HEROIC | SPAWNMASK_RAID_25MAN_HEROIC),

        SPAWNMASK_RAID_ALL = (SPAWNMASK_RAID_NORMAL_ALL | SPAWNMASK_RAID_HEROIC_ALL)
    }

    enum Gender
    {
        GENDER_MALE                    = 0,
        GENDER_FEMALE                  = 1,
        GENDER_NONE                    = 2
    }

    enum CreatureType
    {
        CREATURE_TYPE_BEAST            = 1,
        CREATURE_TYPE_DRAGONKIN        = 2,
        CREATURE_TYPE_DEMON            = 3,
        CREATURE_TYPE_ELEMENTAL        = 4,
        CREATURE_TYPE_GIANT            = 5,
        CREATURE_TYPE_UNDEAD           = 6,
        CREATURE_TYPE_HUMANOID         = 7,
        CREATURE_TYPE_CRITTER          = 8,
        CREATURE_TYPE_MECHANICAL       = 9,
        CREATURE_TYPE_NOT_SPECIFIED    = 10,
        CREATURE_TYPE_TOTEM            = 11,
        CREATURE_TYPE_NON_COMBAT_PET   = 12,
        CREATURE_TYPE_GAS_CLOUD        = 13,
        CREATURE_TYPE_BUG              = 14,
        CREATURE_TYPE_MYSTIC_RIFT      = 15
    }

    enum TypeID
    {
        TYPEID_OBJECT                  = 0,
        TYPEID_ITEM                    = 1,
        TYPEID_CONTAINER               = 2,
        TYPEID_UNIT                    = 3,
        TYPEID_PLAYER                  = 4,
        TYPEID_GAMEOBJECT              = 5,
        TYPEID_DYNAMICOBJECT           = 6,
        TYPEID_CORPSE                  = 7,
    }

    [Flags]
    enum TypeMask
    {
        TYPEMASK_NONE                  = 0x0000,
        TYPEMASK_OBJECT                = 0x0001,
        TYPEMASK_ITEM                  = 0x0002,
        TYPEMASK_CONTAINER             = 0x0006,                       // TYPEMASK_ITEM | 0x0004
        TYPEMASK_UNIT                  = 0x0008,                       // creature
        TYPEMASK_PLAYER                = 0x0010,
        TYPEMASK_GAMEOBJECT            = 0x0020,
        TYPEMASK_DYNAMICOBJECT         = 0x0040,
        TYPEMASK_CORPSE                = 0x0080,
        TYPEMASK_SEER                  = TYPEMASK_PLAYER | TYPEMASK_UNIT | TYPEMASK_DYNAMICOBJECT
    }

    enum CondRelationType
    {
        RELATION_SELF,
        RELATION_IN_PARTY,
        RELATION_IN_RAID_OR_PARTY,
        RELATION_OWNED_BY,
        RELATION_PASSENGER_OF,
        RELATION_CREATED_BY,
    }

    enum ComparisionType
    {
        COMP_TYPE_EQ,
        COMP_TYPE_HIGH,
        COMP_TYPE_LOW,
        COMP_TYPE_HIGH_EQ,
        COMP_TYPE_LOW_EQ,
    }

    enum MiscEnumerators : int
    {
        MaxWorkSpaceCount = 10,
    }
}
