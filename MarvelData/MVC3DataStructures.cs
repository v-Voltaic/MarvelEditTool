using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Xml.Linq;
using System.Windows.Media.TextFormatting;
using System.Resources;

namespace MarvelData {


  /*  
    [StructLayout(LayoutKind.Explicit)]
        public struct ShotChunk
        {
            [FieldOffset(0)] public int unk64;
            [FieldOffset(4)] public int unk68;
            [FieldOffset(8)] public int unk6C;
            [FieldOffset(12)] public int projectileSpawn;
            [FieldOffset(16)] public ShtFlagsA ShtFlagsA;
            [FieldOffset(20)] public ShtFlagsB ShtFlagsB;
            [FieldOffset(24)] public ShtFlagsC ShtFlagsC;
            [FieldOffset(28)] public int unk80;
            [FieldOffset(32)] public float projectileDuration;
            [FieldOffset(36)] public float unk88;
            [FieldOffset(40)] public int unk8c;
            [FieldOffset(44)] public float projectileSpeed;
            [FieldOffset(48)] public float projectileAccel;
            [FieldOffset(52)] public float unk98;
            [FieldOffset(56)] public float beamDuration;
            [FieldOffset(60)] public float projectileYSpeed;
            [FieldOffset(64)] public float projectileYAccel;
            [FieldOffset(68)] public float unkA8;
            [FieldOffset(72)] public float unkAC;
            [FieldOffset(76)] public float trackingStrength;
            [FieldOffset(80)] public float trackingUnk;
            [FieldOffset(84)] public float trackingRotation;
            [FieldOffset(88)] public float trackingStartFrame;
            [FieldOffset(92)] public int unkC0;
            [FieldOffset(96)] public int unkC4;
            [FieldOffset(100)] public float trackingEndFrame;
            [FieldOffset(104)] public int unkCC;
            [FieldOffset(108)] public float despawnProjectileFrame;
            [FieldOffset(112)] public int returnBone;
            [FieldOffset(116)] public int unkD8;
            [FieldOffset(120)] public int unkDC;
            [FieldOffset(124)] public int unkE0;
            [FieldOffset(128)] public int unkE4;
            [FieldOffset(132)] public float unkE8;
            [FieldOffset(136)] public float SpawnVerticalPosition;
            [FieldOffset(140)] public float SpawnHorizontalPosition;
            [FieldOffset(144)] public int unkF4;
            [FieldOffset(148)] public float unkF8;
            [FieldOffset(152)] public int unkFC;
            [FieldOffset(156)] public float unk100;
            [FieldOffset(160)] public float SpawnPositionAngle;
            [FieldOffset(164)] public float ProjectileAngle;
            [FieldOffset(168)] public float unk10C;
            [FieldOffset(172)] public float unk110;
            [FieldOffset(176)] public float RandomSpawnAngle;
            [FieldOffset(180)] public float RandomSpawnAngle2;
            [FieldOffset(184)] public int unk11C;
            [FieldOffset(188)] public int unk120;
            [FieldOffset(192)] public int unk124;
            [FieldOffset(196)] public float unk128;
            [FieldOffset(200)] public float unk12C;
            [FieldOffset(204)] public TrapTransition trapTransition; //bitwise flags
            [FieldOffset(208)] public TrapTransition trapTransition2;
            [FieldOffset(212)] public TrapTransition trapTransition3;
            [FieldOffset(216)] public long projectile2Reference;
            [FieldOffset(280)] public long projectile3Reference;
            [FieldOffset(344)] public long projectile4Reference;
            public int projectile2Reference1;
            public int projectile2Reference2;
            public int projectile2Reference3;
            public int projectile2Reference4;
            public int projectile2Reference5;
            public int projectile2Reference6;
            public int projectile2Reference7;
            public int projectile2Reference8;
            public int projectile2Reference9;
            public int projectile2Reference10;
            public int projectile2Reference11;
            public int projectile2Reference12;
            public int projectile2Reference13;
            public int projectile2Reference14;
            public int projectile2Reference15;
            public int projectile2Reference16;
            public int projectile3Reference1;
                public int projectile3Reference2;
                public int projectile3Reference3;
                public int projectile3Reference4;
                public int projectile3Reference5;
                public int projectile3Reference6;
                public int projectile3Reference7;
                public int projectile3Reference8;
                public int projectile3Reference9;
                public int projectile3Reference10;
                public int projectile3Reference11;
                public int projectile3Reference12;
                public int projectile3Reference13;
                public int projectile3Reference14;
                public int projectile3Reference15;
                public int projectile3Reference16;
                public int projectile4Reference1;
                public int projectile4Reference2;
                public int projectile4Reference3;
                public int projectile4Reference4;
                public int projectile4Reference5;
                public int projectile4Reference6;
                public int projectile4Reference7;
                public int projectile4Reference8;
                public int projectile4Reference9;
                public int projectile4Reference10;
                public int projectile4Reference11;
                public int projectile4Reference12;
                public int projectile4Reference13;
                public int projectile4Reference14;
                public int projectile4Reference15;
                public int projectile4Reference16;
            [FieldOffset(408)] public int unk1FC;
            [FieldOffset(412)] public int unk200;
            [FieldOffset(416)] public int unk204;
            [FieldOffset(420)] public int unk208;
            [FieldOffset(424)] public int unk20C;
            [FieldOffset(428)] public int unk210;
            [FieldOffset(432)] public long projectileAnmString;
            [FieldOffset(496)] public int unk254;
            [FieldOffset(500)] public int unk258;
            [FieldOffset(504)] public int unk25C;
            [FieldOffset(508)] public int unk260;
            [FieldOffset(512)] public int unk264;
            [FieldOffset(516)] public int unk268;
            [FieldOffset(520)] public int unk26C;
            [FieldOffset(524)] public int unk270;
            [FieldOffset(528)] public int soundIDType;
            [FieldOffset(532)] public int unk278;
            [FieldOffset(536)] public int soundID;
            [FieldOffset(540)] public int soundBankIndexUnk;
            [FieldOffset(544)] public int unk284;
            [FieldOffset(548)] public int unk288;
            [FieldOffset(552)] public int soundPlay;
            [FieldOffset(556)] public int unk290;
            [FieldOffset(560)] public int unk294;
            [FieldOffset(564)] public float unk298;
            [FieldOffset(568)] public float unk29C;
            [FieldOffset(572)] public float unk2A0;
            [FieldOffset(576)] public int unk2A4;
            [FieldOffset(580)] public float unk2A8;
            [FieldOffset(584)] public float unk2AC;
            [FieldOffset(588)] public float unk2B0;
            [FieldOffset(592)] public int unk2B4;
            [FieldOffset(596)] public int effectPlayed;
            [FieldOffset(600)] public int unk2BC;
            [FieldOffset(604)] public int unk2C0;
            [FieldOffset(608)] public int unk2C4;
            [FieldOffset(612)] public float RotationXSpeed;
            [FieldOffset(616)] public float unk2CC;
            [FieldOffset(620)] public float unk2D0;
            [FieldOffset(624)] public float unk2D4;
            [FieldOffset(628)] public int unk2D8;
            [FieldOffset(632)] public int unk2DC;
            [FieldOffset(636)] public int friendlyFire;
            [FieldOffset(640)] public int unk2E4;
            [FieldOffset(644)] public int unk2E8;
            [FieldOffset(648)] public int unk2EC;
            [FieldOffset(652)] public ShotFlagsD InteractionRules;
            [FieldOffset(656)] public int unk2F4;
            [FieldOffset(660)] public int unk2F8;
            [FieldOffset(664)] public int unk2FC;
            }
    */
    [StructLayout(LayoutKind.Sequential)]
    public struct ShotChunk
    {
     public int unk64;
     public int unk68;
     public int unk6C;
     public ProjectileID projectileID;
     public ShtFlagsA ShtFlagsA;
     public ShtFlagsB ShtFlagsB;
     public ShtFlagsC ShtFlagsC;
     public int unk80;
     public float projectileDuration;
     public float unk88;
     public int SpawnDelay;
     public float XSpeed;
     public float XAccel;
     public float XMaxSpeedAccelUnk;
    public float beamDuration;
     public float YSpeed;
     public float YAccel;
     public float YMaxSpeedAccelUnk;
     public float beamMaxLength;
     public float trackingStrength;
     public float trackingUnk;
     public float trackingRotation;
     public float trackingStartFrame;
     public int unkC0;
     public int unkC4;
     public float trackingEndFrame;
     public int unkCC;
     public float despawnProjectileFrame;
     public int returnBone;
     public int unkD8;
     public int SpawnOnBone;
     public int AttachToBone;
     public int unkE4;
     public float ZSpawnPosition;
     public float YSpawnPosition;
     public float XSpawnPosition;
     public int unkF4;
     public float ZSpawnRandomDisplacement;
     public float YSpawnRandomDisplacement;
     public float XSpawnRandomDisplacement;
     public float SpawnPositionAngle;
     public float ZRotation;
     public float YRotation;
     public float XRotation;
     public float MaximumRotationUnk;
     public float ZRotationRandomDisplacement;
     public float YRotationRandomDisplacement;
     public float XRotationRandomDisplacement;
     public int unk124;
     public float unk128;
     public float unk12C;
     public TrapTransition trapTransition; //bitwise flags
     public TrapTransition trapTransition2;
     public TrapTransition trapTransition3;
     //public long projectile2Reference;
     //public long projectile3Reference;
     //public long projectile4Reference;
       public int projectile2Reference1;
        public int projectile2Reference2;
        public int projectile2Reference3;
        public int projectile2Reference4;
        public int projectile2Reference5;
        public int projectile2Reference6;
        public int projectile2Reference7;
        public int projectile2Reference8;
        public int projectile2Reference9;
        public int projectile2Reference10;
        public int projectile2Reference11;
        public int projectile2Reference12;
        public int projectile2Reference13;
        public int projectile2Reference14;
        public int projectile2Reference15;
        public int projectile2Reference16;
        public int projectile3Reference1;
            public int projectile3Reference2;
            public int projectile3Reference3;
            public int projectile3Reference4;
            public int projectile3Reference5;
            public int projectile3Reference6;
            public int projectile3Reference7;
            public int projectile3Reference8;
            public int projectile3Reference9;
            public int projectile3Reference10;
            public int projectile3Reference11;
            public int projectile3Reference12;
            public int projectile3Reference13;
            public int projectile3Reference14;
            public int projectile3Reference15;
            public int projectile3Reference16;
            public int projectile4Reference1;
            public int projectile4Reference2;
            public int projectile4Reference3;
            public int projectile4Reference4;
            public int projectile4Reference5;
            public int projectile4Reference6;
            public int projectile4Reference7;
            public int projectile4Reference8;
            public int projectile4Reference9;
            public int projectile4Reference10;
            public int projectile4Reference11;
            public int projectile4Reference12;
            public int projectile4Reference13;
            public int projectile4Reference14;
            public int projectile4Reference15;
            public int projectile4Reference16;
         public int unk1FC;
         public int unk200;
         public int unk204;
         public int unk208;
         public int unk20C;
         public int unk210;
        public int projectileAnmString1;
            public int projectileAnmString2;
            public int projectileAnmString3;
            public int projectileAnmString4;
            public int projectileAnmString5;
            public int projectileAnmString6;
            public int projectileAnmString7;
            public int projectileAnmString8;
            public int projectileAnmString9;
            public int projectileAnmString10;
            public int projectileAnmString11;
            public int projectileAnmString12;
            public int projectileAnmString13;
            public int projectileAnmString14;
            public int projectileAnmString15;
            public int projectileAnmString16;
         public int SoundType1;
         public int SoundID1A;
         public int SoundID1B;
         public int unk260;
         public int SoundType2;
         public int SoundID2A;
         public int SoundID2B;
         public int unk270;
         public int SoundType3;
         public int SoundID3A;
         public int SoundID3B;
         public int soundBankIndexUnk;
         public int SoundType4;
         public int SoundID4A;
         public int SoundID4;
         public int unk290;
         public int unk294;
         public float unk298;
         public float unk29C;
         public float unk2A0;
         public int unk2A4;
         public float unk2A8;
         public float unk2AC;
         public float unk2B0;
         public int unk2B4;
         public int EffectSubEntryA;
         public int EffectSubEntryB;
         public int unk2C0;
         public int unk2C4;
         public float HardCodedProperties1;
         public float HardCodedProperties2;
         public float HardCodedProperties3;
         public float unk2D4;
         public int unk2D8;
         public int unk2DC;
         public int friendlyFire;
         public int unk2E4;
         public int unk2E8;
         public int unk2EC;
         public ShotFlagsD InteractionRules;
         public int unk2F4;
         public int unk2F8;
         public int unk2FC;
        }
    [StructLayout(LayoutKind.Sequential)]
    public struct ShotChunkM
    {
        public int unk64;
        public int unk68;
        public int unk6C;
        public int projectileSpawn;
        public ShtFlagsA ShtFlagsA;
        public ShtFlagsB ShtFlagsB;
        public ShtFlagsC ShtFlagsC;
        public int unk80;
        public float projectileDuration;
        public float unk88;
        public int SpawnDelay;
        public float XSpeed;
        public float XAccel;
        public float XMaxSpeedAccelUnk;
        public float BeamDistance;
        public float YSpeed;
        public float YAccel;
        public float YMaxSpeedAccelUnk;
        public float beamMaxLength;
        public float trackingStrength;
        public float trackingUnk;
        public float trackingRotation;
        public float trackingStartFrame;
        public int unkC0;
        public int unkC4;
        public float trackingEndFrame;
        public int unkCC;
        public float despawnProjectileFrame;
        public int returnBone;
        public int unkD8;
        public int SpawnOnBone;
        public int AttachToBone;
        public int unkE4;
        public float ZSpawnPosition;
        public float YSpawnPosition;
        public float XSpawnPosition;
        public int unkF4;
        public float ZSpawnRandomDisplacement;
        public float YSpawnRandomDisplacement;
        public float XSpawnRandomDisplacement;
        public float SpawnPositionAngle;
        public float ZRotation;
        public float YRotation;
        public float XRotation;
        public float MaximumRotationUnk;
        public float ZRotationRandomDisplacement;
        public float YRotationRandomDisplacement;
        public float XRotationRandomDisplacement;
        public int unk124;
        public float unk128;
        public float unk12C;
        public TrapTransition trapTransition; //bitwise flags
        public TrapTransition trapTransition2;
        public TrapTransition trapTransition3;
        //public long projectile2Reference;
        //public long projectile3Reference;
        //public long projectile4Reference;
        public int projectile2Reference1;
        public int projectile2Reference2;
        public int projectile2Reference3;
        public int projectile2Reference4;
        public int projectile2Reference5;
        public int projectile2Reference6;
        public int projectile2Reference7;
        public int projectile2Reference8;
        public int projectile2Reference9;
        public int projectile2Reference10;
        public int projectile2Reference11;
        public int projectile2Reference12;
        public int projectile2Reference13;
        public int projectile2Reference14;
        public int projectile2Reference15;
        public int projectile2Reference16;
        public int projectile3Reference1;
        public int projectile3Reference2;
        public int projectile3Reference3;
        public int projectile3Reference4;
        public int projectile3Reference5;
        public int projectile3Reference6;
        public int projectile3Reference7;
        public int projectile3Reference8;
        public int projectile3Reference9;
        public int projectile3Reference10;
        public int projectile3Reference11;
        public int projectile3Reference12;
        public int projectile3Reference13;
        public int projectile3Reference14;
        public int projectile3Reference15;
        public int projectile3Reference16;
        public int projectile4Reference1;
        public int projectile4Reference2;
        public int projectile4Reference3;
        public int projectile4Reference4;
        public int projectile4Reference5;
        public int projectile4Reference6;
        public int projectile4Reference7;
        public int projectile4Reference8;
        public int projectile4Reference9;
        public int projectile4Reference10;
        public int projectile4Reference11;
        public int projectile4Reference12;
        public int projectile4Reference13;
        public int projectile4Reference14;
        public int projectile4Reference15;
        public int projectile4Reference16;
        public int unk1FC;
        public int unk200;
        public int unk204;
        public int unk208;
        public int unk20C;
        public int unk210;
        public int projectileAnmString1;
        public int projectileAnmString2;
        public int projectileAnmString3;
        public int projectileAnmString4;
        public int projectileAnmString5;
        public int projectileAnmString6;
        public int projectileAnmString7;
        public int projectileAnmString8;
        public int projectileAnmString9;
        public int projectileAnmString10;
        public int projectileAnmString11;
        public int projectileAnmString12;
        public int projectileAnmString13;
        public int projectileAnmString14;
        public int projectileAnmString15;
        public int projectileAnmString16;
        public int SoundType1;
        public int SoundID1A;
        public int SoundID1B;
        public int unk260;
        public int SoundType2;
        public int SoundID2A;
        public int SoundID2B;
        public int unk270;
        public int SoundType3;
        public int SoundID3A;
        public int SoundID3B;
        public int soundBankIndexUnk;
        public int SoundType4;
        public int SoundID4A;
        public int SoundID4;
        public int unk290;
        public int unk294;
        public float unk298;
        public float unk29C;
        public float unk2A0;
        public int unk2A4;
        public float unk2A8;
        public float unk2AC;
        public float unk2B0;
        public int unk2B4;
        public int EffectSubEntryA;
        public int EffectSubEntryB;
        public int HardCodedProperties3;
        public int HardCodedProperties4;
        public float HardCodedProperties5;
        public float HardCodedProperties6;
        public float HardCodedProperties7;
        public float HardCodedProperties8;
        public int unk2D8;
        public int unk2DC;
        public int friendlyFire;
        public int unk2E4;
        public int unk2E8;
        public int unk2EC;
        public ShotFlagsD InteractionRules;
        public int unk2F4;
        public int unk2F8;
        public int unk2FC;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct ShotHeaderChunk
    {
        public float numberOfHitsToDestroy;
        public float numberOfHitsDurability;
        public float durability;
        public float durabilityUnk;
        public Durability durabilityType;
        public int unk354;
        public int unk358;
        public int unk35C;
        public int unk360;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct ShotCLI
    {
        public int unk364;
        public int unk368;
        public int unk36C;
        public int unk370;
        public float unk374;
        public float unk378;
        public int unk37C;
        public int unk380;
        public int unk384;
        public int unk388;
        public float hitboxY;
        public float hitboxX;
        public float unk394;
        public int unk398;
        public float unk39C;
        public float unk3A0;
        public float unk3A4;
        public int unk3A8;
        public float BeamLengthLimitUnk;
        public float unk3B0;
        public float unk3B4;
        public float hitboxSize;
        public int unk3BC;
        public int unk3C0;
        public int unk3C4;
    }

    [Flags]
        public enum ShtFlagsA : uint
        {
            None = 0,
            Unk0x01 = 0x00000001,
            Unk0x02 = 0x00000002,
            Unk0x04 = 0x00000004,
            EffectPersistOnContact = 0x00000008,
            Unk0x10 = 0x00000010,
            Unk0x20 = 0x00000020,
            SpawnOnGround = 0x00000040,
            PersistEffect = 0x00000080,
            DisableATI = 0x00000100,
            persistAfterContact = 0x00000200,
            EndlessDuration = 0x00000400,
            noMovement = 0x00000800,
            canBeReflected = 0x00001000,
            rotateBackwards = 0x00002000,
            despawnInstantUnk = 0x00004000,
            Unk0x8000 = 0x00008000,
            Unk0x10000 = 0x00010000,
            SpawnOnOpponent = 0x00020000,
            AimAtOpponent = 0x00040000,
            Unk0x80000 = 0x00080000,
            Unk0x100000 = 0x00100000,
            NoGroundCollision = 0x00200000,
            Unk0x400000 = 0x00400000,
            Unk0x800000 = 0x00800000,
            projectileUnk = 0x01000000,
            Unk0x02000000 = 0x02000000,
            Unk0x04000000 = 0x04000000,
            CollisionRelated = 0x08000000,
            DisableProjectileAttach = 0x10000000,
            Unk0x20000000 = 0x20000000,
            Unk0x40000000 = 0x40000000,
            Unk0x80000000 = 0x80000000,
    }


        [Flags]
        public enum ShtFlagsB : uint
        {
            None = 0,
            despawnOnOwnerCancelUnk = 0x00000001,
            despawnOnOwnerCancel = 0x00000002,
            Unk0x04 = 0x00000004,
            despawnWhenOwnerHit = 0x00000008,
            despawnOwnerHitOrBlock = 0x00000010,
            NoGroundCollision = 0x00000020,
            Unk0x40 = 0x00000040,
            IgnoreFreezeFrames = 0x00000080,
            DisableATI = 0x00000100,
            DespawnOnOwnerTagOut = 0x00000200,
            Unk0x0400 = 0x00000400,
            Unk0x0800 = 0x00000800,
            Unk0x1000 = 0x00001000,
            EffectFadeOnDespawn = 0x00002000,
            Unk0x4000 = 0x00004000,
            DespawnOnOwnerSuper = 0x00008000,
            Unk0x10000 = 0x00010000,
            Unk0x20000 = 0x00020000,
            GroundImpactRemoveHitbox = 0x00040000,
            DespawnOnOwnerDeath = 0x00080000,
            DisableAttachToCharacter = 0x00100000,
            Unk0x200000 = 0x00200000,
            Unk0x400000 = 0x00400000,
            Unk0x800000 = 0x00800000,
            Unkx01000000 = 0x01000000,
            Unk0x02000000 = 0x02000000,
            Unk0x04000000 = 0x04000000,
            Unk0x08000000 = 0x08000000,
            Unk0x10000000 = 0x10000000,
            Unk0x20000000 = 0x20000000,
            Unk0x40000000 = 0x40000000,
            Unk0x80000000 = 0x80000000,
    }


        [Flags]
        public enum ShtFlagsC : uint
        {
            None = 0,
            Unk0x01 = 0x00000001,
            Unk0x02 = 0x00000002,
            Unk0x04 = 0x00000004,
            Unk0x08 = 0x00000008,
            Unk0x10 = 0x00000010,
            Unk0x20 = 0x00000020,
            DontDespawnOffscreen = 0x00000040,
            Unk0x80 = 0x00000080,
            Unk0x0100 = 0x00000100,
            Unk0x0200 = 0x00000200,
            NoHitBeforeTransition = 0x00000400,
            clearEffectOnTransition = 0x00000800,
            Unk0x1000 = 0x00001000,
            Unk0x2000 = 0x00002000,
            Unk0x4000 = 0x00004000,
            Unk0x8000 = 0x00008000,
            Unk0x10000 = 0x00010000,
            Unk0x20000 = 0x00020000,
            Unk0x40000 = 0x00040000,
            Unk0x80000 = 0x00080000,
            Unk0x100000 = 0x00100000,
            Unk0x200000 = 0x00200000,
            Unk0x400000 = 0x00400000,
            Unk0x800000 = 0x00800000,
            Unkx01000000 = 0x01000000,
            Unk0x02000000 = 0x02000000,
            Unk0x04000000 = 0x04000000,
            Unk0x08000000 = 0x08000000,
            Unk0x10000000 = 0x10000000,
            Unk0x20000000 = 0x20000000,
            Unk0x40000000 = 0x40000000,
            Unk0x80000000 = 0x80000000
        }
    [Flags]
    public enum ShotFlagsD : uint
    {
        None = 0,
        CanBlockOpponent = 0x00000001,
        CanHitOpponent = 0x00000002,
        Unk0x04 = 0x00000004,
        CanHitProjectiles = 0x00000008,
        Unk0x10 = 0x00000010,
        Unk0x20 = 0x00000020,
        Unk0x40 = 0x00000040,
        Unk0x80 = 0x00000080,
        Unk0x0100 = 0x00000100,
        Unk0x0200 = 0x00000200,
        Unk0x0400 = 0x00000400,
        CantHitOwner = 0x00000800,
        OwnerCanHitUnk1 = 0x00001000,
        Unk0x2000 = 0x00002000,
        Unk0x4000 = 0x00004000,
        Unk0x8000 = 0x00008000,
        Unk0x010000 = 0x00010000,
        Unk0x020000 = 0x00020000,
        Unk0x040000 = 0x00040000,
        OwnerCanHitUnk2 = 0x00080000,
        Unk0x100000 = 0x00100000,
        Unk0x200000 = 0x00200000,
        Unk0x400000 = 0x00400000,
        Unk0x800000 = 0x00800000,
        Unkx01000000 = 0x01000000,
        Unk0x02000000 = 0x02000000,
        Unk0x04000000 = 0x04000000,
        Unk0x08000000 = 0x08000000,
        Unk0x10000000 = 0x10000000,
        Unk0x20000000 = 0x20000000,
        Unk0x40000000 = 0x40000000,
        Unk0x80000000 = 0x80000000
    }
    public enum ProjectileID : uint
    {
        //Amaterasu
        Bakuen = 0x35B9C743, 
        ExtentThunder = 0x679005D9,
        Hyoran = 0x2AF37CB0,
        Magatama = 0x6CC92E1A,
        OneSpark = 0x6C6063B4,
        OneSparkZan = 0x76F2B243,
        Raikou = 0x7A54A24F,
        RaikouSub = 0x14FF9C2F,
        Tekadama = 0x5CA9B7ED,
        TekadamaExplode = 0x1FF66388,
        Tsutamaki = 0x456483BF,
        //Arthur
        Arrow = 0x3F721E65,
        SickleBoomerang = 0x48B7E249,
        ShieldKnightShield = 0x3DC1E142,
        Axe = 0x155BFE3B,
        BraceletOfGoddess = 0x1FC7E4A7,
        CrossSword = 0x60D33C12,
        GreatSorcery = 0x610EFF3B,
        Javelin = 0x7E7C0231,
        Knife = 0x5E109508,
        Torch = 0x17A93657,
        TorchFirePillar = 0x2F7BE2FB,
        //Cap
        ShieldSlash = 0x7D7EFE20,
        //Chris
        SatelliteLaser = 0x554DA965,
        GrenadeLauncher = 0x7CCACBDD,
        FlameGun = 0x6252C644,
        FireGrenadeBomb = 0x30C119C5,
        FireGrenadeExplode = 0x3C1E9061,
        FireGrenadeGroundFlame = 0x2F1CD297,
        GrenadeLauncherExplode = 0x08E7DD3A,
        HandGrenadeBomb = 0x5BF34CC8,
        HandGrenadeExplode = 0x3BDDFBC8,
        HandGun = 0x53A05C62,
        LandMine = 0x60FC8175,
        LandMineExplode = 0x5BFCB8C1,
        MachineGun = 0x41070531,
        MagnumGun = 0x4A104CB5,
        RocketLauncher = 0x73B448F8,
        SatelliteLaserLock = 0x7450FBFD,
        ShotGun = 0x7C0FBBB1,
        //Chun-Li
        Kikousyou = 0x0E0375DB,
        Kikouken = 0x3CF662CA,
        //C.Viper
        OpticBlast = 0x466316A4,
        BurningKick = 0x5B12FD8F,
        SeismoHammer = 0x3C9434E6,
        //Dante
        Crystal = 0x7EBFD26D,
        MillionCarat = 0x65A1FFC3,
        ThunderBolt = 0x07FBCE75,
        Twister = 0x72888E7B,
        Hysteric = 0x2893DFFA,
        Grapple = 0x30933DD5,
        JamSession = 0x1E782F67,
        Tempest = 0x733BE63F,
        AcidRain = 0x2F99EC0B,
        AirPlay = 0x6957753A,
        BulletDanceFinish = 0x759CAB03,
        Drive = 0x0C4DF8AF,
        EbonyAndIvory = 0x65AD68F2,
        FireWorks = 0x406E4AE5,
        MultiLock = 0x7599E2BB,
        //DeadPool
        DualShot = 0x23018021,
        SomersaultGrenade = 0x2BA02B05,
        SomersaultGrenadeExplode = 0x3EE5A794,
        SomersaultLasso = 0x45C8C7C1,
        SomersaultShuriken = 0x093AF360,
        //Dormammu
        DarkDimension = 0x7FC20C5B,
        FloatBomb = 0x46A51E49,
        BlackHole = 0x2352A176,
        ChaosticFlame = 0x7C5B9936,
        FireCarpet = 0x2CD4CA32,
        Inferno = 0x70DC15D0,
        MagicCreate = 0x11BA578C,
        MagicDestroy = 0x6037E1DE,
        MagicMagma = 0x614B22B2,
        MagicMagmaSpread = 0x42EDAF5C,
        MagicMeteor = 0x3C39AB15,
        SpiralArrow = 0x42800839, //6H
        //DrDoom
        DrDoomJS = 0x1B726F4E,
        PlasmaBeam = 0x4AD71D0D,
        DoomsMissile = 0x306C179C,
        MissileEmplacement = 0x4F5283B4,
        MolecularShield = 0x44095156,
        MolecularShieldPre = 0x7E202664,
        PhotonShot = 0x35621CDB,
        SphereFlame = 0x0FB5018C,
        //DrStrange
        BoltsOfBalthakk = 0x6D5B50D5,
        FlamesOfFaltine = 0x423E3B46,
        StrangeReflector = 0x19A80043,
        OpticalMagicSpreadM = 0x50C0F59B, //Missile
        AstralProjection = 0x6D1F4A79,
        ElementalSummon = 0x33835CBB,
        ElementalSummonExplode = 0x4B4484B4,
        ElementalSummonShot = 0x2ADA4C48,
        MagicSword = 0x78CAA8BB,
        OpticalMagic = 0x5D64877F,
        OpticalMagicS = 0x32850864,
        OpticalMagicSpreadV = 0x63490ACC, //Vulcan
        SpellOfVishanti = 0x6633B6AA,
        ThrowRose = 0x0ED811B9,
        //Felicia
        PleaseHelpMe = 0x6240F456,
        SandSplash = 0x2005B18C,
        //Frank
        LikeAMegaman = 0x76542BE8, // Unused, Franks mega buster
        WeaponCartSpreadS = 0x7C839716, //Shield
        WildPitchHit = 0x17FD4493,
        ThrowWeapon = 0x6D587771,
        ThrowWeaponB = 0x3F3D3961,
        WeaponCart = 0x6790D6D8,
        WeaponCartSpreadV = 0x23EE37D7, //Vulcan
        WildPitch = 0x5612947B,
        //Galactus?
        CosmicBeam = 0x57EDDB90, 
        //GhostRider
        HellFire = 0x3B798FBE,
        BigFirePillar = 0x3F75D1D7,
        BreakFireChain = 0x48F23B31,
        FireWall = 0x71FA04EF,
        //Gouki / Akuma
        MessatsuGouHadou = 0x79683B0E,
        GouHadouken = 0x56F568C1,
        TenmaGouZanku = 0x146DA4F5,
        //Haggar
        BodyPressFinish = 0x1AD465F6,
        IronPipeRolling = 0x4DBF21C2,
        //Hawkeye
        AntmanArrow = 0x38A1E3C2,
        BombArrow = 0x79AC228C,
        BombArrowExplode = 0x20907355,
        HyperAimArrow = 0x4920D6B1,
        IceArrow = 0x0EFC2AE0,
        NetArrow = 0x2F63C7FD,
        NormalArrow = 0x7A49A4BB,
        PierceArrow = 0x567D77EF,
        PoisonArrow = 0x5C9A6E95,
        RangingBladeArrow = 0x2B0AE474,
        SpreadArrow = 0x76386ECA,
        ThunderCartridge = 0x6858C0F8,
        ThunderCartridgeExplode = 0x5B734DB8,
        //Hiryu
        FormationD = 0x4179442B,
        Ouroboros = 0x278430CF,
        OuroborosExit = 0x086784E8,
        FormationATiger = 0x16807465,
        FormationBHawk = 0x12BDDCB4,
        FormationCBom = 0x5CFFD275,
        FormationCExplode = 0x039B7231,
        FormationCSpread = 0x165382BF,
        FormationDSpread = 0x53F4BC31,
        LegionHawk = 0x2B8902EC,
        LegionTiger = 0x759DEBD3,
        OuroborosShot = 0x5DEDBBEB,
        //Hulk
        GammaQuake = 0x71FF8ECD,
        GammaSlam = 0x7BF17AF5,
        //IronFist
        DragonAura = 0x3A532A5C,
        //IronMan
        ProtonCannon = 0x487BFD3D,
        UniBeam = 0x4C3148EE,
        RepulsarBlastSP = 0x3FD6A01E,
        DownCMissile = 0x2916BD86, // I cant start it with 2 cause VS freaks out, fuck you C#
        RepulsarBlastSPExpload = 0x048123A0,
        SmartBomb = 0x16BB6231,
        //Jill
        JillMachineGun = 0x6EAB9C41,
        //Leilei / Hsien-ko
        AnkihouBomb = 0x7EC9A643,
        AnkihouBombExplode = 0x53E10A7D,
        AnkihouKobun = 0x466E3409,
        AnkihouRolling = 0x3DF6D2AC,
        HenkyouKi = 0x562F49CA,
        Tenraiha = 0x6F9E9EC3,
        Zireitou = 0x1FB13581,
        //Magneto
        EMDisruptor = 0x74ED065C,
        MagneticShockWave = 0x6B9F3037,
        GravitySqueeze = 0x494BFCE5,
        HyperGravitation = 0x673B3E2D,
        MagneticBlast = 0x08C88C7C,
        MagneticTempst = 0x511D546F,
        MagnetoAtkSitM = 0x648BC7A8,
        //MODOK
        PsionicBlaster = 0x787F0187,
        JammingBomb = 0x18786113, //Missile, Balloon Bomb + Jamming Bomb?
        PsionicCubeDamage = 0x14865C0F,
        JammingBombV = 0x2CB81109, //Unused? Vulcan
        JammingBombExplode = 0x11E30DD1,
        LightWall = 0x33EF634D,
        ModokSitM = 0x63A51A17,
        ModokStandM = 0x34A181E0,
        PsionicCube = 0x41A0EABB,
        //Morrigan
        SoulFistAbsorb = 0x2E9E7683,
        FinishingShower = 0x42414817,
        ShilhouetteBlade = 0x6930D705,
        SoulFist = 0x0EE4ABD9,
        //Naruhodo / Phoenix Wright
        EvidencePhoto = 0x2ACD7CCC,
        BreakClock = 0x258B3F68,
        BreakVase = 0x04E6044F,
        BrownEnvelope = 0x502AE095,
        BrownEnvelopeExplode = 0x0033064A,
        DogMissile = 0x3F1CADA2,
        FileStorm = 0x70E67F70,
        HammerImpact = 0x533E9B85, // Judge
        ItemThrow = 0x0F35C297,
        MobilePhone = 0x1181C7DA,
        NaruhodoKnife = 0x0769A411,
        //Nemesis
        ExatkRocketLauncher = 0x7C1BF533,
        NemesisRocketLauncher = 0x1EF8E2A1,
        RocketLauncherExplode = 0x43AC214D,
        //Nova
        GMBeam = 0x52AB7CE8,
        GMPulseL = 0x057B6B10, //Laser
        BodyBeam = 0x23D6F134,
        EnergySpear = 0x2CF28271,
        EnergySpearSpread = 0x3D8E4353,
        GMPulse = 0x56A208D4, // Vulcan, the shield?
        //Phoenix
        TKShot = 0x0A7F5DB4,
        HealingFieldGathering = 0x52FF40C4,
        HealingField = 0x16E27D1F,
        DarkPhoenixFire = 0x375D7301,
        KaiserPhoenix = 0x4FC63EC8,
        TKBind = 0x20609B15,
        TKBindSpread = 0x3C7D3027,
        TKShotExplode = 0x169F12A8,
        //RedAremer
        DarkFire = 0x68F1CA67,
        Fire = 0x09765265,
        FirePillar = 0x3113EB4F,
        //RRaccoon
        RRaccoonPistol = 0x61915E00,
        HomingEnergyGun = 0x20D0583A,
        ClaymoreMine = 0x5A45F410,
        ClaymoreSpread = 0x08C8FF89,
        DigHole = 0x252BA144,
        EnergyGun = 0x0E382BE2,
        FallRock = 0x52651F46,
        GatlingGun = 0x7E1D4152,
        HomingEnergyGunExplode = 0x7E991E77,
        HomingEnergyGunGroundExplode = 0x73598585,
        HyperTrap = 0x2E65D791,
        HyperTrapSpread = 0x191F0E99,
        JDBomb = 0x5D2FE56B,
        JDBombExplode = 0x336C37EB,
        OilBalloon = 0x212F706E,
        OilBalloonExplode = 0x0D168098,
        OilBalloonGroundFire = 0x645DC99F,
        OilBalloonGroundOil = 0x26D89205,
        PendulumLog = 0x3858485D,
        PrickleBoard = 0x78972521,
        TrapLandMine = 0x5E715B30,
        //Ryu
        ReflectSinkuHadouken = 0x3E29340C,
        SinkuHadouken = 0x755CC92B,
        Hadouken = 0x70C0999B,
        //Sentinel
        AttackS = 0x68190BBE,
        DirectAttackBomb = 0x69579272,
        DirectAttackBombExplode = 0x0CBFA14C,
        MiniSentinel = 0x327CBFE0,
        PlasmaStorm = 0x4307EA09,
        //SheHulk
        Car = 0x0E0C068A,
        //ShumaGorath
        HyperMysticBlast = 0x34C0C0C7,
        MysticBlast = 0x15CB4B46,
        HyperMysticSmash = 0x544398D4,
        MysticStare = 0x52D36AA7,
        MysticStareBomb = 0x3BF5C07B,
        MysticStareExplode = 0x0290C913,
        //Spencer
        AttackWire = 0x09CD3E50,
        SwingWire = 0x4BF93EB8, //Option
        FurisosoguShi = 0x5EEAAD0D,
        SwingWire2 = 0x2B0F6E25,//Vulcan
        //SpiderMan
        WebBall = 0x50C01DD6,
        WebMove = 0x4BCC62F5,
        WebThrow = 0x0EBCA372,
        //Storm
        DoubleTyphoon = 0x38F17356,
        WildStorm = 0x7B2C0B96,
        IceStorm = 0x2747149B,
        LightningSphere = 0x49EE84F7,
        LightningSphereBurst = 0x6035DC6E,
        LightningStorm = 0x0565B232,
        WhirlWind = 0x41CC8294,
        //SuperSkrull
        SuperBurningSkrull = 0x184470A4,
        DivePunch = 0x40D3346B,
        //TaskMaster
        ArrowRain = 0x2895353D,
        ArrowShot = 0x34C0372B,
        Bullet = 0x539BAF3D,
        //Thor
        BigThunder = 0x288115B3,
        MujoThunder = 0x470E38DA,
        BigTornado = 0x5C0B0A33,
        MujoSyoryuThunder = 0x30671052,
        MujoThunderCharge = 0x220D5C0C,
        //Trish
        TrishBullet = 0x2E239536,
        SpadaBoomerang = 0x0DAD20CD,
        Barrier = 0x4BA25418,   //Peekaboo + Hopscotch?
        BarrierSpread = 0x73605EBF, //Peekaboo Spread?
        EnergyBolt = 0x0DBBBA4C,//Hopscotch Spread?
        //Tron
        ChushokuRash = 0x5A9AE0FB,
        KingKobun = 0x52E670F6,
        KobunLauncher = 0x7B60D628,
        RockThrow = 0x35F8E561,
        ShikiDan = 0x402568D5,
        ShikiDanKobun = 0x358C2C2F,
        //Vergil
        RoundTrip = 0x522F4001,
        RaidSword = 0x6C49A571,
        SpiralSword = 0x7DCFCC61,
        StormSword = 0x31BF74A0,
        JigenZan = 0x0BF320B3,
        RapidSlash = 0x583FFAAA,
        StormSwordSpread = 0x604022A6,
        //VJoe
        Boomerang = 0x31E834B8,
        ShockingPinkBomb= 0x00E7F455,
        ShockingPinkExplode = 0x78D0207D,
        SixCannon = 0x57372D34,
        //Wesker
        WeskerHandGun = 0x49801F12,
        //Zero
        Raikousen = 0x14EB75C4,
        Rekkouha = 0x7DF501E9,
        GenmuZero = 0x260B0B6B,
        Hadangeki = 0x4958DFB7,
        ZeroBuster = 0x5BE88F65

    }
    public enum ShotCliType : int
    { 
        Attack = 0,
        Unk01 = 1,
        Player = 2,
        Stage = 3,
        Unk04 = 4,
        SecondaryATI = 5
    }
    public enum Durability : int
    {
        Lowest = 1,
        Low = 2,
        Medium = 3,
        LowHyper = 40001,
        Hyper = 40002,
        UltraHyper = 40003
    }

    [StructLayout(LayoutKind.Sequential)]
        public struct ShotXSChunk
        {
        public float numberOfHitsToDestroy;
        public float NumberOfHitsDurability;
        public float durability;
        public float durabilityUnk;
        public Durability durabilityType;
        public int unk354;
        public int unk358;
        public int unk35C;
        public int unk360;
        }

    [StructLayout(LayoutKind.Sequential)]
        public struct ShotSChunk
        {
        public float numberOfHitsToDestroy;
        public float NumberOfHitsDurability;
        public float durability;
        public float durabilityUnk;
        public Durability durabilityType;
        public int unk354;
        public float unk358;
        public int unk35C;
        public int unk360; //Start of Entry 1
        public int unk364;
        public int unk368;
        public int unk36C;
        public ShotCliType CollisionType;   //370
        public int CollisionRules;          //374
        public EnumUnk CLIFlagA;
        public EnumUnk CLIFlagB;
        public int unk380;
        public int unk384;
        public float HitboxZ;
        public float HitboxY;
        public float HitboxX;
        public float unk394;
        public BoneReferenceId BoneID;
        public float unk39C;
        public float unk3A0;
        public float unk3A4;
        public float UnkZHitboxStretch;
        public float UnkYHitboxStretch;
        public float UnkXHitboxStretch;
        public float unk3B4;
        public float HitboxSize;
        public int unk3BC;
        public int unk3C0;
        public int unk3C4;
    }

        [StructLayout(LayoutKind.Sequential)]
        public struct ShotLChunk
        {
        public float numberOfHitsToDestroy;
        public float NumberOfHitsDurability;
        public float durability;
        public float durabilityUnk;
        public Durability durabilityType;
        public int unk354;
        public float unk358;
        public int unk35C;
        public int unk360; //Start of Entry 1
        public int unk364;
        public int unk368;
        public int unk36C;
        public ShotCliType CollisionType;   //370
        public int CollisionRules;          //374
        public EnumUnk CLIFlagA1;
        public EnumUnk CLIFlagB1;
        public int unk380;
        public int unk384;
        public float HitboxZ;
        public float HitboxY;
        public float HitboxX;
        public float unk394;
        public BoneReferenceId BoneID1;
        public float unk39C;
        public float unk3A0;
        public float unk3A4;
        public float UnkZHitboxStretch;
        public float UnkYHitboxStretch;
        public float UnkXHitboxStretch;
        public float unk3B4;
        public float HitboxSize;
        public int unk3BC;
        public int unk3C0; //Start of Entry 2
        public int unk3C4;
        public int unk3C8;
        public int unk3CC;
        public ShotCliType CollisionType2;   
        public int CollisionRules2;
        public EnumUnk CLIFlagA2;
        public EnumUnk CLIFlagB2;
        public int unk3E0;
        public int unk3E4;
        public float Hitbox2Z;
        public float Hitbox2Y;
        public float Hitbox2X;
        public float unk3F4;
        public BoneReferenceId BoneID2;
        public float unk3FC;
        public float unk400;
        public float unk404;
        public float UnkZ2HitboxStretch;
        public float UnkY2HitboxStretch;
        public float UnkX2HitboxStretch;
        public float unk414;
        public float Hitbox2Size;
        public int unk41C;
        public int unk420;
        public int unk424;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ShotXLChunk // Supports up to 3 entries
    {
        public float numberOfHitsToDestroy;
        public float NumberOfHitsDurability;
        public float durability;
        public float durabilityUnk;
        public Durability durabilityType;
        public int unk354;
        public float unk358;
        public int unk35C;
        public int unk360; //Start of Entry 1
        public int unk364;
        public int unk368;
        public int unk36C;
        public ShotCliType CollisionType;   //370
        public int CollisionRules;          //374
        public EnumUnk CLIFlagA1;
        public EnumUnk CLIFlagB1;
        public int unk380;
        public int unk384;
        public float HitboxZ;
        public float HitboxY;
        public float HitboxX;
        public float unk394;
        public BoneReferenceId BoneID1;
        public float unk39C;
        public float unk3A0;
        public float unk3A4;
        public float UnkZHitboxStretch;
        public float UnkYHitboxStretch;
        public float UnkXHitboxStretch;
        public float unk3B4;
        public float HitboxSize;
        public int unk3BC;
        public int unk3C0; //Start of Entry 2
        public int unk3C4;
        public int unk3C8;
        public int unk3CC;
        public ShotCliType CollisionType2;
        public int CollisionRules2;
        public EnumUnk CLIFlagA2;
        public EnumUnk CLIFlagB2;
        public int unk3E0;
        public int unk3E4;
        public float Hitbox2Z;
        public float Hitbox2Y;
        public float Hitbox2X;
        public float unk3F4;
        public BoneReferenceId BoneID2;
        public float unk3FC;
        public float unk400;
        public float unk404;
        public float UnkZ2HitboxStretch;
        public float UnkY2HitboxStretch;
        public float UnkX2HitboxStretch;
        public float unk414;
        public float Hitbox2Size;
        public int unk41C;
        public int unk420; // Start of Entry 3
        public int unk424;
        public int unk428;
        public int unk42C;
        public ShotCliType CollisionType3;
        public int CollisionRules3;
        public EnumUnk CLIFlagA3;
        public EnumUnk CLIFlagB3;
        public int unk4E0;
        public int unk4E4;
        public float Hitbox3Z;
        public float Hitbox3Y;
        public float Hitbox3X;
        public float unk4F4;
        public BoneReferenceId BoneID3;
        public float unk4FC;
        public float unk500;
        public float unk504;
        public float UnkZ3HitboxStretch;
        public float UnkY3HitboxStretch;
        public float UnkX3HitboxStretch;
        public float unk514;
        public float Hitbox3Size;
        public int unk51C;
        public int unk520;
        public int unk524;
    }



    [StructLayout(LayoutKind.Sequential)]
    public struct ShotX4Chunk
    {
        public float numberOfHitsToDestroy;
        public float numberOfHitsDurability;
        public float durability;
        public float durabilityUnk;
        public Durability durabilityType;
        public int unk354;
        public float unk358;
        public int unk35C;

        public int unk360; //Start of Entry 1
        public int unk364;
        public int unk368;
        public int unk36C;
        public ShotCliType CollisionType;   //370
        public int CollisionRules;          //374
        public EnumUnk CLIFlagA1;
        public EnumUnk CLIFlagB1;
        public int unk380;
        public int unk384;
        public float HitboxZ;
        public float HitboxY;
        public float HitboxX;
        public float unk394;
        public BoneReferenceId BoneID1;
        public float unk39C;
        public float unk3A0;
        public float unk3A4;
        public float UnkZHitboxStretch;
        public float UnkYHitboxStretch;
        public float UnkXHitboxStretch;
        public float unk3B4;
        public float HitboxSize;
        public int unk3BC;

        public int unk3C0; //Start of Entry 2
        public int unk3C4;
        public int unk3C8;
        public int unk3CC;
        public ShotCliType CollisionType2;
        public int CollisionRules2;
        public EnumUnk CLIFlagA2;
        public EnumUnk CLIFlagB2;
        public int unk3E0;
        public int unk3E4;
        public float Hitbox2Z;
        public float Hitbox2Y;
        public float Hitbox2X;
        public float unk3F4;
        public BoneReferenceId BoneID2;
        public float unk3FC;
        public float unk400;
        public float unk404;
        public float UnkZ2HitboxStretch;
        public float UnkY2HitboxStretch;
        public float UnkX2HitboxStretch;
        public float unk414;
        public float Hitbox2Size;
        public int unk41C;

        public int unk420; // Start of Entry 3
        public int unk424;
        public int unk428;
        public int unk42C;
        public ShotCliType CollisionType3;
        public int CollisionRules3;
        public EnumUnk CLIFlagA3;
        public EnumUnk CLIFlagB3;
        public int unk4E0;
        public int unk4E4;
        public float Hitbox3Z;
        public float Hitbox3Y;
        public float Hitbox3X;
        public float unk4F4;
        public BoneReferenceId BoneID3;
        public float unk4FC;
        public float unk500;
        public float unk504;
        public float UnkZ3HitboxStretch;
        public float UnkY3HitboxStretch;
        public float UnkX3HitboxStretch;
        public float unk514;
        public float Hitbox3Size;
        public int unk51C;

        public int unk520; // Start of Entry 4
        public int unk524;
        public int unk528;
        public int unk52C;
        public ShotCliType CollisionType4;
        public int CollisionRules4;
        public EnumUnk CLIFlagA4;
        public EnumUnk CLIFlagB4;
        public int unk5E0;
        public int unk5E4;
        public float Hitbox4Z;
        public float Hitbox4Y;
        public float Hitbox4X;
        public float unk5F4;
        public BoneReferenceId BoneID4;
        public float unk5FC;
        public float unk600;
        public float unk604;
        public float UnkZ4HitboxStretch;
        public float UnkY4HitboxStretch;
        public float UnkX4HitboxStretch;
        public float unk614;
        public float Hitbox4Size;
        public int unk61C;


        //end padding
        public int unk620;
        public int unk624;
    }



    [StructLayout(LayoutKind.Sequential)]
    public struct ShotX5Chunk
    {
        public float numberOfHitsToDestroy;
        public float numberOfHitsDurability;
        public float durability;
        public float durabilityUnk;
        public Durability durabilityType;
        public int unk354;
        public float unk358;
        public int unk35C;

        public int unk360; //Start of Entry 1
        public int unk364;
        public int unk368;
        public int unk36C;
        public ShotCliType CollisionType;   //370
        public int CollisionRules;          //374
        public EnumUnk CLIFlagA1;
        public EnumUnk CLIFlagB1;
        public int unk380;
        public int unk384;
        public float HitboxZ;
        public float HitboxY;
        public float HitboxX;
        public float unk394;
        public BoneReferenceId BoneID1;
        public float unk39C;
        public float unk3A0;
        public float unk3A4;
        public float UnkZHitboxStretch;
        public float UnkYHitboxStretch;
        public float UnkXHitboxStretch;
        public float unk3B4;
        public float HitboxSize;
        public int unk3BC;

        public int unk3C0; //Start of Entry 2
        public int unk3C4;
        public int unk3C8;
        public int unk3CC;
        public ShotCliType CollisionType2;
        public int CollisionRules2;
        public EnumUnk CLIFlagA2;
        public EnumUnk CLIFlagB2;
        public int unk3E0;
        public int unk3E4;
        public float Hitbox2Z;
        public float Hitbox2Y;
        public float Hitbox2X;
        public float unk3F4;
        public BoneReferenceId BoneID2;
        public float unk3FC;
        public float unk400;
        public float unk404;
        public float UnkZ2HitboxStretch;
        public float UnkY2HitboxStretch;
        public float UnkX2HitboxStretch;
        public float unk414;
        public float Hitbox2Size;
        public int unk41C;

        public int unk420; // Start of Entry 3
        public int unk424;
        public int unk428;
        public int unk42C;
        public ShotCliType CollisionType3;
        public int CollisionRules3;
        public EnumUnk CLIFlagA3;
        public EnumUnk CLIFlagB3;
        public int unk4E0;
        public int unk4E4;
        public float Hitbox3Z;
        public float Hitbox3Y;
        public float Hitbox3X;
        public float unk4F4;
        public BoneReferenceId BoneID3;
        public float unk4FC;
        public float unk500;
        public float unk504;
        public float UnkZ3HitboxStretch;
        public float UnkY3HitboxStretch;
        public float UnkX3HitboxStretch;
        public float unk514;
        public float Hitbox3Size;
        public int unk51C;

        public int unk520; // Start of Entry 4
        public int unk524;
        public int unk528;
        public int unk52C;
        public ShotCliType CollisionType4;
        public int CollisionRules4;
        public EnumUnk CLIFlagA4;
        public EnumUnk CLIFlagB4;
        public int unk5E0;
        public int unk5E4;
        public float Hitbox4Z;
        public float Hitbox4Y;
        public float Hitbox4X;
        public float unk5F4;
        public BoneReferenceId BoneID4;
        public float unk5FC;
        public float unk600;
        public float unk604;
        public float UnkZ4HitboxStretch;
        public float UnkY4HitboxStretch;
        public float UnkX4HitboxStretch;
        public float unk614;
        public float Hitbox4Size;
        public int unk61C;

        public int unk720; // Start of Entry 5
        public int unk724;
        public int unk728;
        public int unk72C;
        public ShotCliType CollisionType5;
        public int CollisionRules5;
        public EnumUnk CLIFlagA5;
        public EnumUnk CLIFlagB5;
        public int unk7E0;
        public int unk7E4;
        public float Hitbox5Z;
        public float Hitbox5Y;
        public float Hitbox5X;
        public float unk7F4;
        public BoneReferenceId BoneID5;
        public float unk7FC;
        public float unk800;
        public float unk804;
        public float UnkZ5HitboxStretch;
        public float UnkY5HitboxStretch;
        public float UnkX5HitboxStretch;
        public float unk814;
        public float Hitbox5Size;
        public int unk81C;

        //end padding
        public int unk820;
        public int unk824;
    }




    [StructLayout(LayoutKind.Sequential)]
    public struct ShotX6Chunk
    {
        public float numberOfHitsToDestroy;
        public float numberOfHitsDurability;
        public float durability;
        public float durabilityUnk;
        public Durability durabilityType;
        public int unk354;
        public float unk358;
        public int unk35C;

        public int unk360; //Start of Entry 1
        public int unk364;
        public int unk368;
        public int unk36C;
        public ShotCliType CollisionType;   //370
        public int CollisionRules;          //374
        public EnumUnk CLIFlagA1;
        public EnumUnk CLIFlagB1;
        public int unk380;
        public int unk384;
        public float HitboxZ;
        public float HitboxY;
        public float HitboxX;
        public float unk394;
        public BoneReferenceId BoneID1;
        public float unk39C;
        public float unk3A0;
        public float unk3A4;
        public float UnkZHitboxStretch;
        public float UnkYHitboxStretch;
        public float UnkXHitboxStretch;
        public float unk3B4;
        public float HitboxSize;
        public int unk3BC;

        public int unk3C0; //Start of Entry 2
        public int unk3C4;
        public int unk3C8;
        public int unk3CC;
        public ShotCliType CollisionType2;
        public int CollisionRules2;
        public EnumUnk CLIFlagA2;
        public EnumUnk CLIFlagB2;
        public int unk3E0;
        public int unk3E4;
        public float Hitbox2Z;
        public float Hitbox2Y;
        public float Hitbox2X;
        public float unk3F4;
        public BoneReferenceId BoneID2;
        public float unk3FC;
        public float unk400;
        public float unk404;
        public float UnkZ2HitboxStretch;
        public float UnkY2HitboxStretch;
        public float UnkX2HitboxStretch;
        public float unk414;
        public float Hitbox2Size;
        public int unk41C;

        public int unk420; // Start of Entry 3
        public int unk424;
        public int unk428;
        public int unk42C;
        public ShotCliType CollisionType3;
        public int CollisionRules3;
        public EnumUnk CLIFlagA3;
        public EnumUnk CLIFlagB3;
        public int unk4E0;
        public int unk4E4;
        public float Hitbox3Z;
        public float Hitbox3Y;
        public float Hitbox3X;
        public float unk4F4;
        public BoneReferenceId BoneID3;
        public float unk4FC;
        public float unk500;
        public float unk504;
        public float UnkZ3HitboxStretch;
        public float UnkY3HitboxStretch;
        public float UnkX3HitboxStretch;
        public float unk514;
        public float Hitbox3Size;
        public int unk51C;

        public int unk520; // Start of Entry 4
        public int unk524;
        public int unk528;
        public int unk52C;
        public ShotCliType CollisionType4;
        public int CollisionRules4;
        public EnumUnk CLIFlagA4;
        public EnumUnk CLIFlagB4;
        public int unk5E0;
        public int unk5E4;
        public float Hitbox4Z;
        public float Hitbox4Y;
        public float Hitbox4X;
        public float unk5F4;
        public BoneReferenceId BoneID4;
        public float unk5FC;
        public float unk600;
        public float unk604;
        public float UnkZ4HitboxStretch;
        public float UnkY4HitboxStretch;
        public float UnkX4HitboxStretch;
        public float unk614;
        public float Hitbox4Size;
        public int unk61C;

        public int unk720; // Start of Entry 5
        public int unk724;
        public int unk728;
        public int unk72C;
        public ShotCliType CollisionType5;
        public int CollisionRules5;
        public EnumUnk CLIFlagA5;
        public EnumUnk CLIFlagB5;
        public int unk7E0;
        public int unk7E4;
        public float Hitbox5Z;
        public float Hitbox5Y;
        public float Hitbox5X;
        public float unk7F4;
        public BoneReferenceId BoneID5;
        public float unk7FC;
        public float unk800;
        public float unk804;
        public float UnkZ5HitboxStretch;
        public float UnkY5HitboxStretch;
        public float UnkX5HitboxStretch;
        public float unk814;
        public float Hitbox5Size;
        public int unk81C;

        public int unk820; // Start of Entry 6
        public int unk824;
        public int unk828;
        public int unk82C;
        public ShotCliType CollisionType6;
        public int CollisionRules6;
        public EnumUnk CLIFlagA6;
        public EnumUnk CLIFlagB6;
        public int unk8E0;
        public int unk8E4;
        public float Hitbox6Z;
        public float Hitbox6Y;
        public float Hitbox6X;
        public float unk8F4;
        public BoneReferenceId BoneID6;
        public float unk8FC;
        public float unk900;
        public float unk904;
        public float UnkZ6HitboxStretch;
        public float UnkY6HitboxStretch;
        public float UnkX6HitboxStretch;
        public float unk914;
        public float Hitbox6Size;
        public int unk91C;

        //end padding
        public int unk920;
        public int unk924;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ShotX7Chunk
    {
        public float numberOfHitsToDestroy;
        public float numberOfHitsDurability;
        public float durability;
        public float durabilityUnk;
        public Durability durabilityType;
        public int unk354;
        public float unk358;
        public int unk35C;

        public int unk360; //Start of Entry 1
        public int unk364;
        public int unk368;
        public int unk36C;
        public ShotCliType CollisionType;   //370
        public int CollisionRules;          //374
        public EnumUnk CLIFlagA1;
        public EnumUnk CLIFlagB1;
        public int unk380;
        public int unk384;
        public float HitboxZ;
        public float HitboxY;
        public float HitboxX;
        public float unk394;
        public BoneReferenceId BoneID1;
        public float unk39C;
        public float unk3A0;
        public float unk3A4;
        public float UnkZHitboxStretch;
        public float UnkYHitboxStretch;
        public float UnkXHitboxStretch;
        public float unk3B4;
        public float HitboxSize;
        public int unk3BC;

        public int unk3C0; //Start of Entry 2
        public int unk3C4;
        public int unk3C8;
        public int unk3CC;
        public ShotCliType CollisionType2;
        public int CollisionRules2;
        public EnumUnk CLIFlagA2;
        public EnumUnk CLIFlagB2;
        public int unk3E0;
        public int unk3E4;
        public float Hitbox2Z;
        public float Hitbox2Y;
        public float Hitbox2X;
        public float unk3F4;
        public BoneReferenceId BoneID2;
        public float unk3FC;
        public float unk400;
        public float unk404;
        public float UnkZ2HitboxStretch;
        public float UnkY2HitboxStretch;
        public float UnkX2HitboxStretch;
        public float unk414;
        public float Hitbox2Size;
        public int unk41C;

        public int unk420; // Start of Entry 3
        public int unk424;
        public int unk428;
        public int unk42C;
        public ShotCliType CollisionType3;
        public int CollisionRules3;
        public EnumUnk CLIFlagA3;
        public EnumUnk CLIFlagB3;
        public int unk4E0;
        public int unk4E4;
        public float Hitbox3Z;
        public float Hitbox3Y;
        public float Hitbox3X;
        public float unk4F4;
        public BoneReferenceId BoneID3;
        public float unk4FC;
        public float unk500;
        public float unk504;
        public float UnkZ3HitboxStretch;
        public float UnkY3HitboxStretch;
        public float UnkX3HitboxStretch;
        public float unk514;
        public float Hitbox3Size;
        public int unk51C;

        public int unk520; // Start of Entry 4
        public int unk524;
        public int unk528;
        public int unk52C;
        public ShotCliType CollisionType4;
        public int CollisionRules4;
        public EnumUnk CLIFlagA4;
        public EnumUnk CLIFlagB4;
        public int unk5E0;
        public int unk5E4;
        public float Hitbox4Z;
        public float Hitbox4Y;
        public float Hitbox4X;
        public float unk5F4;
        public BoneReferenceId BoneID4;
        public float unk5FC;
        public float unk600;
        public float unk604;
        public float UnkZ4HitboxStretch;
        public float UnkY4HitboxStretch;
        public float UnkX4HitboxStretch;
        public float unk614;
        public float Hitbox4Size;
        public int unk61C;

        public int unk720; // Start of Entry 5
        public int unk724;
        public int unk728;
        public int unk72C;
        public ShotCliType CollisionType5;
        public int CollisionRules5;
        public EnumUnk CLIFlagA5;
        public EnumUnk CLIFlagB5;
        public int unk7E0;
        public int unk7E4;
        public float Hitbox5Z;
        public float Hitbox5Y;
        public float Hitbox5X;
        public float unk7F4;
        public BoneReferenceId BoneID5;
        public float unk7FC;
        public float unk800;
        public float unk804;
        public float UnkZ5HitboxStretch;
        public float UnkY5HitboxStretch;
        public float UnkX5HitboxStretch;
        public float unk814;
        public float Hitbox5Size;
        public int unk81C;

        public int unk820; // Start of Entry 6
        public int unk824;
        public int unk828;
        public int unk82C;
        public ShotCliType CollisionType6;
        public int CollisionRules6;
        public EnumUnk CLIFlagA6;
        public EnumUnk CLIFlagB6;
        public int unk8E0;
        public int unk8E4;
        public float Hitbox6Z;
        public float Hitbox6Y;
        public float Hitbox6X;
        public float unk8F4;
        public BoneReferenceId BoneID6;
        public float unk8FC;
        public float unk900;
        public float unk904;
        public float UnkZ6HitboxStretch;
        public float UnkY6HitboxStretch;
        public float UnkX6HitboxStretch;
        public float unk914;
        public float Hitbox6Size;
        public int unk91C;

        public int unk920; // Start of Entry 7
        public int unk924;
        public int unk928;
        public int unk92C;
        public ShotCliType CollisionType7;
        public int CollisionRules7;
        public EnumUnk CLIFlagA7;
        public EnumUnk CLIFlagB7;
        public int unk9E0;
        public int unk9E4;
        public float Hitbox7Z;
        public float Hitbox7Y;
        public float Hitbox7X;
        public float unk9F4;
        public BoneReferenceId BoneID7;
        public float unk9FC;
        public float unkA00;
        public float unkA04;
        public float UnkZ7HitboxStretch;
        public float UnkY7HitboxStretch;
        public float UnkX7HitboxStretch;
        public float unkA14;
        public float Hitbox7Size;
        public int unkA1C;

        //end padding
        public int unkA20;
        public int unkA24;
    }



    [StructLayout(LayoutKind.Sequential)]
    public struct ShotX8Chunk
    {
        public float numberOfHitsToDestroy;
        public float numberOfHitsDurability;
        public float durability;
        public float durabilityUnk;
        public Durability durabilityType;
        public int unk354;
        public float unk358;
        public int unk35C;

        public int unk360; //Start of Entry 1
        public int unk364;
        public int unk368;
        public int unk36C;
        public ShotCliType CollisionType;   //370
        public int CollisionRules;          //374
        public EnumUnk CLIFlagA1;
        public EnumUnk CLIFlagB1;
        public int unk380;
        public int unk384;
        public float HitboxZ;
        public float HitboxY;
        public float HitboxX;
        public float unk394;
        public BoneReferenceId BoneID1;
        public float unk39C;
        public float unk3A0;
        public float unk3A4;
        public float UnkZHitboxStretch;
        public float UnkYHitboxStretch;
        public float UnkXHitboxStretch;
        public float unk3B4;
        public float HitboxSize;
        public int unk3BC;

        public int unk3C0; //Start of Entry 2
        public int unk3C4;
        public int unk3C8;
        public int unk3CC;
        public ShotCliType CollisionType2;
        public int CollisionRules2;
        public EnumUnk CLIFlagA2;
        public EnumUnk CLIFlagB2;
        public int unk3E0;
        public int unk3E4;
        public float Hitbox2Z;
        public float Hitbox2Y;
        public float Hitbox2X;
        public float unk3F4;
        public BoneReferenceId BoneID2;
        public float unk3FC;
        public float unk400;
        public float unk404;
        public float UnkZ2HitboxStretch;
        public float UnkY2HitboxStretch;
        public float UnkX2HitboxStretch;
        public float unk414;
        public float Hitbox2Size;
        public int unk41C;

        public int unk420; // Start of Entry 3
        public int unk424;
        public int unk428;
        public int unk42C;
        public ShotCliType CollisionType3;
        public int CollisionRules3;
        public EnumUnk CLIFlagA3;
        public EnumUnk CLIFlagB3;
        public int unk4E0;
        public int unk4E4;
        public float Hitbox3Z;
        public float Hitbox3Y;
        public float Hitbox3X;
        public float unk4F4;
        public BoneReferenceId BoneID3;
        public float unk4FC;
        public float unk500;
        public float unk504;
        public float UnkZ3HitboxStretch;
        public float UnkY3HitboxStretch;
        public float UnkX3HitboxStretch;
        public float unk514;
        public float Hitbox3Size;
        public int unk51C;

        public int unk520; // Start of Entry 4
        public int unk524;
        public int unk528;
        public int unk52C;
        public ShotCliType CollisionType4;
        public int CollisionRules4;
        public EnumUnk CLIFlagA4;
        public EnumUnk CLIFlagB4;
        public int unk5E0;
        public int unk5E4;
        public float Hitbox4Z;
        public float Hitbox4Y;
        public float Hitbox4X;
        public float unk5F4;
        public BoneReferenceId BoneID4;
        public float unk5FC;
        public float unk600;
        public float unk604;
        public float UnkZ4HitboxStretch;
        public float UnkY4HitboxStretch;
        public float UnkX4HitboxStretch;
        public float unk614;
        public float Hitbox4Size;
        public int unk61C;

        public int unk720; // Start of Entry 5
        public int unk724;
        public int unk728;
        public int unk72C;
        public ShotCliType CollisionType5;
        public int CollisionRules5;
        public EnumUnk CLIFlagA5;
        public EnumUnk CLIFlagB5;
        public int unk7E0;
        public int unk7E4;
        public float Hitbox5Z;
        public float Hitbox5Y;
        public float Hitbox5X;
        public float unk7F4;
        public BoneReferenceId BoneID5;
        public float unk7FC;
        public float unk800;
        public float unk804;
        public float UnkZ5HitboxStretch;
        public float UnkY5HitboxStretch;
        public float UnkX5HitboxStretch;
        public float unk814;
        public float Hitbox5Size;
        public int unk81C;

        public int unk820; // Start of Entry 6
        public int unk824;
        public int unk828;
        public int unk82C;
        public ShotCliType CollisionType6;
        public int CollisionRules6;
        public EnumUnk CLIFlagA6;
        public EnumUnk CLIFlagB6;
        public int unk8E0;
        public int unk8E4;
        public float Hitbox6Z;
        public float Hitbox6Y;
        public float Hitbox6X;
        public float unk8F4;
        public BoneReferenceId BoneID6;
        public float unk8FC;
        public float unk900;
        public float unk904;
        public float UnkZ6HitboxStretch;
        public float UnkY6HitboxStretch;
        public float UnkX6HitboxStretch;
        public float unk914;
        public float Hitbox6Size;
        public int unk91C;

        public int unk920; // Start of Entry 7
        public int unk924;
        public int unk928;
        public int unk92C;
        public ShotCliType CollisionType7;
        public int CollisionRules7;
        public EnumUnk CLIFlagA7;
        public EnumUnk CLIFlagB7;
        public int unk9E0;
        public int unk9E4;
        public float Hitbox7Z;
        public float Hitbox7Y;
        public float Hitbox7X;
        public float unk9F4;
        public BoneReferenceId BoneID7;
        public float unk9FC;
        public float unkA00;
        public float unkA04;
        public float UnkZ7HitboxStretch;
        public float UnkY7HitboxStretch;
        public float UnkX7HitboxStretch;
        public float unkA14;
        public float Hitbox7Size;
        public int unkA1C;

        public int unkA20; // Start of Entry 8
        public int unkA24;
        public int unkA28;
        public int unkA2C;
        public ShotCliType CollisionType8;
        public int CollisionRules8;
        public EnumUnk CLIFlagA8;
        public EnumUnk CLIFlagB8;
        public int unkAE0;
        public int unkAE4;
        public float Hitbox8Z;
        public float Hitbox8Y;
        public float Hitbox8X;
        public float unkAF4;
        public BoneReferenceId BoneID8;
        public float unkAFC;
        public float unkB00;
        public float unkB04;
        public float UnkZ8HitboxStretch;
        public float UnkY8HitboxStretch;
        public float UnkX8HitboxStretch;
        public float unkB14;
        public float Hitbox8Size;
        public int unkB1C;
        //end padding
        public int unkB20;
        public int unkB24;
    }







    [StructLayout(LayoutKind.Sequential)]
        public struct StatusChunk
        {
            public int index;
            public StatusFlags statusFlags;
            public int totalHealth;
            public float meterGain;
            public float damageGiven;
            public float damageTaken;
            public float speedSelf;
            public float speedReceived;
            public float minLaunchHeight;
            public float comboWeight;
            public int unk28;
            public float unk2C;
            public float CameraSizeX;
            public float IntroPartner2Offset;
            public float IntroPartner1Offset;
            public float IntroCameraOffset;
            public float unk40;
            public int airActions;
            public float XForceAfterDash;
            public float AirXForceAfterDash;
            public float XDecelAfterDash;
            public float AirXDecelAfterDash;
            public int unk58;
            public float flightAccel;
            public float flightMaxSpeed;
            public float flightClearance;
            public float flightMaxHeight;
            public int GroundOppLightHitStun; // 0x6c
            public int GroundOppMediumHitStun;
            public int GroundOppHeavyHitStun;
            public int LightBlockStun;
            public int MediumBlockStun;
            public int HeavylockStun;
            public int AirOppLightHitStun;
            public int AirOppMediumHitStun;
            public int AirOppHeavyHitStun;
            public int GroundChainLimit;
            public int AirChainLimit;
            public float minDmgScalingNormals;
            public float minDmgScalingSpecials;
            public float minDmgScalingHypers;
            public int alphaAssistTHC;
            public int bettaAssistTHC;
            public int gammaAssistTHC;
            public int slot0DHC;
            public int slot1DHC;
            public int slot2DHC;
            public int slot3DHC;
            public int slot4DHC;
            public int slot5DHC;
            public int slot6DHC;
            public int Slot7DHC;
            public int XF1YellowHealthRegen;
            public int XF1ChipDamageOn;
            public float XF1Damage;
            public float XF1Speed;
            public float XF1Duration;
            public int unkE4;
            public int unkE8;
            public float XF1MeterSpendOnActivation;
            public float XF1PassiveMeterGain;
            public float XF1MeterGain;
            public float XF1DmgTaken;
            public float XF1DurationAdjustmentWhenHit;
            public int XF2YellowHealthRegen;
            public int XF2ChipDamageOn;
            public float XF2Damage;
            public float XF2Speed;
            public float XF2Duration;
            public int unk114;
            public int unk118;
            public float XF2MeterSpendOnActivation;
            public float XF2PassiveMeterGain;
            public float XF2MeterGain;
            public float XF2DmgTaken;
            public float XF2DurationAdjustmentWhenHit;
            public int XF3YellowHealthRegen;
            public int XF3ChipDamageOn;
            public float XF3Damage;
            public float XF3Speed;
            public float XF3Duration;
            public int unk144;
            public int unk148;
            public float XF3MeterSpendOnActivation;
            public float XF3PassiveMeterGain;
            public float XF3MeterGain;
            public float XF3DmgTaken;
            public float XF3DurationAdjustmentWhenHit;
            public int frankLevel2XP;
            public int frankLevel3XP;
            public int frankLevel4XP;
            public int frankLevel5XP;
            public float unk174;
            public float unk178;
            public float unk17C;
            public float unk180;
            public int unk184;
            public int unk188;
            public float LandingDustCloudZScaling;
            public float LandingDustCloudYScaling;
            public float LandingDustCloudXScaling;
            public float JumpAndKnockdownEffectScaling;
            public int unk19C;
            public float unk1A0;
            public int unk1A4;
            public int unk1A8;
            public int unk1AC;
            public DamageFlags damageSFXOnHit;
            public DamageFlags blockSFXOnHit;
            public DamageFlags jumpLandSFX;
            public float unk1BC;
            public float unk1C0;
            public float unk1C4;
            public float unk1C8;
            public int unk1CC;
            public float unk1D0;
            public float unk1D4;
            public float unk1D8;
            public float unk1DC;
            public float unk1E0;
            public float unk1E4;
            public float unk1E8;
            public float unk1EC;
            public int unk1F0;
            public float unk1F4;
            public float unk1F8;
            public float unk1FC;
            public float unk200;
            public float unk204;
            public float unk208;
            public int HeadTrackBone1;
            public int HeadTrackBone2;
            public float HeadTrackingUnk1;
            public float HeadTrackingUnk2;
            public float HeadTrackingUnk3;
            public float HeadTrackingUnk4;
            public float HeadTrackingUnk5;
            public float HeadTrackingUnk6;
            public float HeadTrackingRange;
            public float CrouchHeadTrackingUnk1;
            public float CrouchHeadTrackingUnk2;
            public float CrouchHeadTrackingUnk3;
            public float CrouchHeadTrackingUnk4;
            public float CrouchHeadTrackingUnk5;
            public float CrouchHeadTrackingUnk6;
            public float CrouchHeadTrackingRange;
            public float unk24C;
            public int FaceGroup1;
            public int FaceGroup2;
            public int FaceGroup3;
            public int FaceGroup4;
            public int FaceGroup5;
            public int FaceGroup6;
            public int FaceGroup7;
            public int FaceGroup8;
            public int FaceGroup9;
            public float unk274;
            public float unk278;
            public float unk27C;
            public float unk280;
            public float unk284;
            public float unk288;
            public float unk28C;
            public float unk290;
            public float unk294;
            public float unk298;
            public float unk29C;
            public float unk2A0;
            public float unk2A4;
            public float unk2A8;
            public float unk2AC;
            public float unk2B0;
            public float unk2B4;
            public int WinQuoteVsCharacterID1;
            public int WinQuoteVsCharacterID2;
            public int WinQuoteVsCharacterID3;
            public int WinQuoteVsCharacterID4;
            public int WinQuoteVsCharacterID5;
            public int WinQuoteVsCharacterID6;
            public int WinQuoteVsCharacterID7;
            public int unk2D4;
            public int unk2D8;
            public int unk2DC;
            public int unk2E0;
            public int unk2E4;
            public int unk2E8;
            public int unk2EC;
            public int unk2F0;
            public int unk2F4;
            public int unk2F8;
            public int unk2FC;
            public int unk300;
            public int unk304;
            public int unk308;
            public int unk30C;
            public int unk310;
            public float unk314;
            public int unk318;
            public int unk31C;
            public int unk320;
            public float unk324;
            public float unk328;
            public float unk32C;
            public float unk330;
            public float unk334;
            public float unk338;
            public float unk33C;
            public float unk340;
            public float unk344;
            public int unk348;
            public int unk34C;
            public int unk350;
        }

    public enum DamageFlags : int
    {
        Default = 0,
        Metal = 1,
        Heavy = 2


    }
    [Flags]
        public enum TrapTransition : uint
        {
            None = 0,
            Unk0x01 = 0x00000001,
            TimeUp = 0x00000002,
            WhenDestroyed = 0x00000004,
            Unk0x08 = 0x00000008,
            HitBlockorDestroyed = 0x00000010,
            GroundImpact = 0x00000020,
            DontTransition = 0x00000040,
            SpawnAtSelf = 0x00000080,
            Unk0x0100 = 0x00000100,
            WhenOwnerHit = 0x00000200,
            Unk0x0400 = 0x00000400,
            Unk0x0800 = 0x00000800,
            Unk0x1000 = 0x00001000,
            Unk0x2000 = 0x00002000,
            Unk0x4000 = 0x00004000,
            Unk0x8000 = 0x00008000,
            Unk0x10000 = 0x00010000,
            Unk0x20000 = 0x00020000,
            Unk0x40000 = 0x00040000,
            Unk0x80000 = 0x00080000,
            Unk0x100000 = 0x00100000,
            Unk0x200000 = 0x00200000,
            Unk0x400000 = 0x00400000,
            Unk0x800000 = 0x00800000,
            Unkx01000000 = 0x01000000,
            Unk0x02000000 = 0x02000000,
            Unk0x04000000 = 0x04000000,
            Unk0x08000000 = 0x08000000,
            Unk0x10000000 = 0x10000000,
            Unk0x20000000 = 0x20000000,
            Unk0x40000000 = 0x40000000,
            Unk0x80000000 = 0x80000000
        }

        [Flags]
        public enum StatusFlags : uint
        {
            Male = 0x00000001,
            Female = 0x00000002,
            AmmyUnk = 0x00000004,
            NoLandJumpEffects = 0x00000008,
            NoHurtbox = 0x00000010,
            AirBlockBounce = 0x00000020,
            NoHyperDrainGain = 0x00000040,
            NoHitstop = 0x00000080,
            BonneBreathingOff = 0x00000100,
            AirUnk = 0x00000200,
            ShumaUnk = 0x00000400,
            AmmyShumaUnk = 0x00000800,
            LockCharacter = 0x00001000,
            NoSnapBackNoTAC = 0x00002000,
            Unk0x4000 = 0x00004000,
            Unk0x8000 = 0x00008000,
            FriendlyFire = 0x00010000,
            NoJump = 0x00020000,
            NoDoubleJump = 0x00040000,
            NoMinLaunchHeight = 0x00080000,
            Unk0x100000 = 0x00100000,
            NoTagIn = 0x00200000,
            Unk0x400000 = 0x00400000,
            FrankUnk = 0x00800000,
            Unkx01000000 = 0x01000000,
            Unk0x02000000 = 0x02000000,
            Unk0x04000000 = 0x04000000,
            Unk0x08000000 = 0x08000000,
            Unk0x10000000 = 0x10000000,
            Unk0x20000000 = 0x20000000,
            Unk0x40000000 = 0x40000000,
            Unk0x80000000 = 0x80000000
    }
    public enum ScreenShake : uint 
    { 
        None = 4294967295,
        Strength0 = 0,
        Strength1 = 1,
        Strength2 = 2,
        Strength3 = 3,
        Strength4 = 4,
        Strength5 = 5,
        Strength6 = 6,
        Strength7 = 7,
        Strength8 = 8,
        Strength9 = 9,
        Strength10 = 10,
        Strength11 = 11,
        Strength12 = 12
    }
    public enum EffectDirection : uint
    {
        Any = 0,
        Camera = 1,
        Downward = 2,
        Forward = 3,
        ForwardRandom = 4

    }

    [StructLayout(LayoutKind.Sequential)]
        public struct ATKInfoChunk
        {
            public int index;
            public int startup;
            public int activeframes;
            public int unk00C;
            public int unk010;
            public int multiHit;
            public int HitsUntilCancel;
            public int multiHitFrequency;
            public int unk020;
            public int HitsparkFrequency;
            public int unk028;
            public int kdBounceSize;
            public float unk030;
            public float unk034;
            public float unk038;
            public AtkFlagsA atkflags;
            public AtkFlagsB atkflags2;
            public AtkFlagsC atkflags3;
            public AttackLevel AttackLevel;
            public GuardType GuardType;
            public int unk050;
            public OppHitAnim OppHitAnim;
            public OppHitAnim OppHitAnimCounter;
            public OppHitAnim OppHitAnimAir;
            public int damage;
            public float damageScaling;
            public float damageMult;
            public float ChipDamage;
            public int unk070;
            public float MeterGain;
            public float MeterGainOnHit;
            public int OppMeterGainOnHit;
            public int meterSteal; //0x80
            public Durability projectileDestruction;
            public float StunDamage;
            public int AddedGroundHitstun;
            public int AddedCounterhitStun; //0x90
            public int AddedBlockstun;
            public int AddedHardKDTime;
            public float GroundHitPushbackWallBounceXSpeed;
            public float GroundHitPushbackWallBounceXAccel; //0xA0
            public float BlockPushbackXSpeed;
            public float BlockPushbackXAccel;
            public float SelfYForceAgainstAirOpp;
            public float SelfYDecelAgainstAirOpp; //0xB0
            public float SJSelfYForceAgainstAirOpp;
            public float SJSelfYDecelAgainstAirOpp;
            public float GroundWallBounceYSpeed;
            public float GroundWallBounceYAccel; //0xC0
            public int hitstop;
            public int HitStopDelay;
            public float RemoveAllHealthAndMeterTest;
            public int sjCancelDelay;
            public int juggleHeight;
            public int JuggleGravityDelay;
            public float juggleCarry;
            public float juggleSpeed;
            public int AddedAirHitstun;
            public int SJJuggleHeight;
            public int SJJuggleGravityDelay;
            public float SJJuggleCarry;
            public float SJJuggleSpeed;
            public int AddedSJAirHitstun;
            public int PlayerCmdSPAtkClassOnHit;
            public int PlayerCmdSPAtkIndexOnHit;
            public int EnemyCmdSPAtkClassOnHit;
            public int EnemyCmdSPAtkIndexOnHit;
            public float AmmyUnk;
            public int AmmyAnmchrEntryOnHit;
            public int AmmyAnmtdownEntryOnHit;
            public HitEffect HitEffect;
            public int unk11C;
            public HitEffect SecondaryHitEffect;
            public HitEffect NegatedChipDamageEffect;
            public HitEffect BlockEffect;
            public HitEffect SecondaryBlockEffect;
            public int unk130;
            public HitEffect GroundImpactEffect;
            public int unk138;
            public HitEffect OwnerAttackNullifiedEffect;
            public int unk140;
            public int unk144;
            public int unk148;
            public ScreenShake ScreenShakeOnHit;
            public HitSFXGroup hitSFXGroup;
            public HitSFXSubGroup hitSFXSubGroup;
            public HitSFXEntry hitSFXEntry;
            public PlayWhiffSFXOnNormals playWhiffSFXOnNormals;
            public EffectDirection effectType;
            public float EffectRotation1;
            public float EffectRotation2;
            public float EffectRotation3;
            public float EffectRandomRotationDisplacement;
            public int unk174;
            public int IDReference2;
            public int FramesToIDReference2;
            public int HitsToIDReference2;
            public int SingleCharHitsToIDReference2;
            public int unk188;
        }

        [Flags]
        public enum AtkFlagsA : uint
        {
            None = 0,
            Unk0x01 = 0x00000001,
            LauncherSpecialHyperCancel = 0x00000002,
            JumpCancel = 0x00000004,
            CantHitGround = 0x00000008,
            CantHitCrouch = 0x00000010,
            Unk0x20 = 0x00000020,
            CantHitAir = 0x00000040,
            NoPushback = 0x00000080,
            AutoCorrectJuggleUnk1 = 0x00000100,
            AlwaysApplySelfYPhysics = 0x00000200,
            KeepMomentumY = 0x00000400,
            FixedHitstunDuration = 0x00000800,
            NoGroundBounceLimit = 0x00001000,
            JuggledInvinc = 0x00002000,
            Unk0x4000 = 0x00004000,
            Unk0x8000 = 0x00008000,
            Unk0x10000 = 0x00010000,
            DisablePushblock = 0x00020000,
            Unk0x40000 = 0x00040000,
            FlyingScreen = 0x00080000,
            CanWallBounce = 0x00100000,
            OTG = 0x00200000,
            ForceAirReset = 0x00400000,
            SoftKD = 0x00800000,
            HardKD = 0x01000000,
            Unk0x02000000 = 0x02000000,
            ForceWallBounce = 0x04000000,
            Unk0x8000000 = 0x08000000,
            OTGOnly = 0x10000000,
            NegatePushBlock = 0x20000000,
            JuggleInvul = 0x40000000,
            AutoCorrectJuggleUnk2 = 0x80000000
        }

        [Flags]
        public enum AtkFlagsB : uint
        {
            None = 0,
            SpecialScaling = 0x00000001,
            HyperScaling = 0x00000002,
            ProjectileHitboxJuggleAway = 0x00000004,
            NeverCounterhit = 0x00000008,
            EnableTransition = 0x00000010,
            Counter = 0x00000020,
            ChipDamage = 0x00000040,
            Unblockable = 0x00000080,
            ForceStandingState = 0x00000100,
            ProjectileInteractOnly = 0x00000200,
            NoHyperMeterBuild = 0x00000400,
            NoComboCounter = 0x00000800,
            UnscaledDamage = 0x00001000,
            ProjectileReflection = 0x00002000,
            NoPushbackAttacker = 0x00004000,
            PartnerTargeting = 0x00008000,
            Unk0x10000 = 0x00010000,
            Unk0x20000 = 0x00020000,
            NoPushBackAttackerAirOnly = 0x00040000,
            TACGlow = 0x00080000,
            Mashable = 0x00100000,
            Unk0x200000 = 0x00200000,
            Unk0x400000 = 0x00400000,
            Unk0x800000 = 0x00800000,
            Unk0x1000000 = 0x01000000,
            Unk0x2000000 = 0x02000000,
            Unk0x4000000 = 0x04000000,
            Unk0x8000000 = 0x08000000,
            Unk0x10000000 = 0x10000000,
            Unk0x20000000 = 0x20000000,
            Unk0x40000000 = 0x20000000,
            Unk0x80000000 = 0x80000000
    }
        [Flags]
        public enum AtkFlagsC : uint
        {
            None = 0,
            Unk0x01 = 0x00000001,
            TechGrabs = 0x00000002,
            HitsAssist = 0x00000004,
            Unk0x08 = 0x00000008,
            Unk0x10 = 0x00000010,
            ThrowGroundedOpp = 0x00000020,
            ThrowAirborneOpp = 0x00000040,
            DisableRecapture = 0x00000080,
            Unk0x100 = 0x00000100,
            Unk0x200 = 0x00000200,
            Unk0x400 = 0x00000400,
            CounterProjectile = 0x00000800,
            CounterSupers = 0x00001000,
            CounterLowOnly = 0x00002000,
            CounterHighMidOnly = 0x00004000,
            CounterHighMidLowOnly = 0x00008000,
            Unk0x10000 = 0x00010000,
            Unk0x20000 = 0x00020000,
            Unk0x40000 = 0x00040000,
            PlayerCmdSPAtkXOnHitOn = 0x00080000,
            Unk0x100000 = 0x00100000,
            Unk0x200000 = 0x00200000,
            Unk0x400000 = 0x00400000,
            FirstHitDmgs = 0x00800000,
            NoSnapOnLastCharacter = 0x01000000,
            TechTAC1 = 0x02000000,
            HitComboGrab = 0x04000000,
            Unk0x8000000 = 0x08000000,
            TechTAC2 = 0x10000000,
            Unk0x20000000 = 0x20000000,
            Unk0x40000000 = 0x20000000,
            NoHitboxUnk = 0x80000000
    }

        public enum HitEffect : int
        {
            YellowLSparks = 0,
            YellowMSparks = 1,
            YellowHSparks = 2,
            BladeSlash01 = 3,
            BladeSlash02 = 4,
            GuardBlue01 = 5,
            GuardRed01 = 6,
            PurpleRings = 7,
            RedImpactSpreadingSpark = 9,
            RisingGroundSpark = 10,
            YellowFire = 11,
            YellowElectricity = 12,
            IceAndScreenShake = 13,
            HiddenMissileExplosion = 14,
            GroundImpactFlyingShards = 15,
            GuardBlue02 = 17,
            GuardRed03 = 18,
            TripleSlash01 = 19,
            DoubleSlash01 = 20,
            RisingYellowCircle = 21,
            ScreenShake00 = 22,
            ScreenShake01 = 23,
            ScreenShake02 = 24,
            ScreenShake03 = 25,
            ScreenShake04 = 26,
            BlueFire = 27,
            PurpleFire = 28,
            BlueElectricity = 30,
            PurpleElectricity = 31,
            ElectricSound = 32,
            IceSound = 33,
            IceSoundCrunch = 34,
            Magnetic = 35,
            //Don't use - Game Crashes = 37     ,
            FullScreenFlair01 = 38,
            FullScreenFlair02 = 39,
            FallingBlueLightBeams = 40,
            AlphaCounter01 = 41,
            ComicBookScreenTear = 43,
            YellowJaggedOverlay = 44,
            GunShotTask = 45,
            GunShot = 46,
            ComicBookScreenRedBurn = 47,
            ComicBookScreenBlueBurn = 48,
            ComicBookScreenPurpleBurn = 49,
            GreyScreenShake01 = 50,
            GreyScreenShake02 = 51,
            GreyScreenShake03 = 52,
            GroundImpactSplash = 54,
            TripleSlash02 = 55,
            DoubleSlash03 = 56,
            AlphaCounter02 = 57,
            TACUp = 59,
            TACHorizontal = 60,
            TACDown = 61,
            AlphaCounter03 = 64,
            CharClass1 = 1000,
            CharClass2 = 1001,
            CharClass3 = 1002,
            CharClass4 = 1003,
            CharClass5 = 1004,
            FilmStrip = 1005,
            Unique = 1006
        }

        public enum GuardType : int
        {
            mid = 0,
            high = 1,
            low = 2
        }

        public enum AttackLevel : int
        {
            light = 0,
            medium = 1,
            heavy = 2,
            noPushBlock = 3
        }

        [Flags]
        public enum InputCode : uint
        {
            None = 0,
            Forward = 0x00000001,
            Back = 0x00000002,
            Up = 0x00000004,
            Down = 0x00000008,
            L = 0x00000010,
            M = 0x00000020,
            H = 0x00000040,
            S = 0x00000080,
            A1 = 0x00000100,
            A2 = 0x00000200,
            Unk0x400 = 0x00000400,
            Unk0x800 = 0x00000800,
            Unk0x1000 = 0x00001000,
            Unk0x2000 = 0x00002000,
            Unk0x4000 = 0x00004000,
            Unk0x8000 = 0x00008000,
            Unk0x10000 = 0x00010000,
            Unk0x20000 = 0x00020000,
            Unk0x40000 = 0x00040000,
            Unk0x80000 = 0x00080000,
            Taunt = 0x00100000,
            Unk0x200000 = 0x00200000,
            Unk0x400000 = 0x00400000,
            Unk0x800000 = 0x00800000,
            Unk0x1000000 = 0x01000000,
            Unk0x2000000 = 0x000200000,
            Unk0x4000000 = 0x000400000,
            Unk0x8000000 = 0x000800000
        }

        [Flags]
        public enum OppHitAnim : int
        {
            normal1 = 0,
            normal2 = 1,
            noHitstunUnk = 02,
            stagger = 3,
            fallBack1 = 4,
            crumple = 5,
            wallBounce = 6,
            fallFaceFirst = 7,
            groundBounce = 8,
            airJuggle = 9,
            spinningJuggle = 10,
            launch = 11,
            FlyingScreenHK1 = 12,
            Stun = 13,
            forceGuard = 14,
            fallBack3 = 15
        }

        [Flags]
        public enum HitSFXGroup : int 
        {
                
        }

        [Flags]
        public enum HitSFXSubGroup : int 
        { 
            generic = 0,
            handSwing = 1,
            footSwing = 2,
            swordSwing = 3,
            gunShotUnk = 15
        }

        [Flags]
        public enum HitSFXEntry : int 
        {
            l = 0,
            m = 1,
            h = 2,
            s = 3,
        }

        [Flags]
        public enum PlayWhiffSFXOnNormals : int
        {
            no = 1551001600,
            yes = 1551001601,
        }

        [Flags]
        public enum cmdFlags : uint
        {
            None = 0,
            Unk0x01 = 0x00000001,
            Unk0x02 = 0x00000002,
            Unk0x04 = 0x00000004,
            Unk0x08 = 0x00000008,
            Unk0x10 = 0x00000010,
            Unk0x20 = 0x00000020,
            Unk0x40 = 0x00000040,
            Unk0x80 = 0x00000080,
            Unk0x0100 = 0x00000100,
            Unk0x0200 = 0x00000200,
            Unk0x0400 = 0x00000400,
            Unk0x0800 = 0x00000800,
            Unk0x1000 = 0x00001000,
            Unk0x2000 = 0x00002000,
            Unk0x4000 = 0x00004000,
            Unk0x8000 = 0x00008000,
            Unk0x10000 = 0x00010000,
            Unk0x20000 = 0x00020000,
            Unk0x40000 = 0x00040000,
            Unk0x80000 = 0x00080000,
            Unk0x100000 = 0x00100000,
            Unk0x200000 = 0x00200000,
            Unk0x400000 = 0x00400000,
            Unk0x800000 = 0x00800000,
            Unk0x01000000 = 0x01000000,
            Unk0x02000000 = 0x02000000,
            Unk0x04000000 = 0x04000000,
            Unk0x08000000 = 0x08000000,
            Unk0x10000000 = 0x10000000,
            Unk0x20000000 = 0x20000000,
            Unk0x40000000 = 0x40000000,
            Unk0x80000000 = 0x80000000
    }
    [Flags]
    public enum AirGroundState : uint
    { //Flags are reversed?
        None = 0,
        Standing = 0x00000001,
        Crouching = 0x00000002,
        Unk0x04 = 0x00000004,
        PreJump = 0x00000008,
        SuperJump = 0x00000010,
        Airborne = 0x00000020,
        Forward = 0x00000040,
        Backwards = 0x00000080,
        Dashing = 0x00000100,
        Unk0x200 = 0x00000200,
        TurnAround = 0x00000400,
        Attack = 0x00000800,
        Special = 0x00001000,
        Super = 0x00002000,
        Guard = 0x00004000,
        AutoGuard = 0x00008000,
        Unk0x10000 = 0x00010000,
        ChildA = 0x00020000,
        ChildB = 0x00040000,
        Unk0x80000 = 0x00080000,
        Unk0x100000 = 0x00100000,
        Damage = 0x00200000,
        Unk0x400000 = 0x00400000,
        GroundRecovery = 0x00800000,
        Knockdown = 0x01000000,
        Unk0x02000000 = 0x02000000,
        Assist = 0x04000000,
        TAC = 0x08000000,
        Unk0x10000000 = 0x10000000,
        Unk0x20000000 = 0x20000000,
        Unk0x40000000 = 0x40000000,
        Unk0x80000000 = 0x80000000

    }

        [StructLayout(LayoutKind.Sequential)]
        public struct BaseActChunk
        {
            public int index;
            public int anmchrAction;
            public InputCode inputCodeDirectionLeniency;
            public InputCode inputCodeDirection;
            public InputCode inputCodeButton;
            public AirGroundState AirGroundState;
            public AirGroundState RestrictedState;
            public int unk1C;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct CmdComboHeaderChunk
        {
            public int index;
            public int size;
            public int unk08;
            public float meterRequirement;
            public CmdDisabled disabled;
            public int windowStart;
            public int windowEnd;
            public int delay;
            public int anmChrAction1;
            public int anmChrAction2;
            public int anmChrAction3;
            public int anmChrAction4;
            public int anmChrAction5;
            public int anmChrAction6;
            public int anmChrAction7;
            public int anmChrAction8;
            public ChainFlags ChainFlags;
        }
    [Flags]
    public enum ChainFlags : uint
    {
        None = 0,
        Unk0x01 = 0x00000001,
        Unk0x02 = 0x00000002,
        Unk0x04 = 0x00000004,
        Unk0x08 = 0x00000008,
        NormalsChainLimit = 0x00000010,
        Unk0x20 = 0x00000020,
        Unk0x40 = 0x00000040,
        Unk0x80 = 0x00000080,
        Unk0x0100 = 0x00000100,
        Unk0x0200 = 0x00000200,
        Unk0x0400 = 0x00000400,
        Unk0x0800 = 0x00000800,
        Unk0x1000 = 0x00001000,
        Unk0x2000 = 0x00002000,
        Unk0x4000 = 0x00004000,
        Unk0x8000 = 0x00008000,
        Unk0x010000 = 0x00010000,
        Unk0x020000 = 0x00020000,
        Unk0x040000 = 0x00040000,
        Unk0x080000 = 0x00080000,
        Unk0x100000 = 0x00100000,
        Unk0x200000 = 0x00200000,
        Unk0x400000 = 0x00400000,
        Unk0x800000 = 0x00800000,
        Unkx01000000 = 0x01000000,
        Unk0x02000000 = 0x02000000,
        Unk0x04000000 = 0x04000000,
        Unk0x08000000 = 0x08000000,
        Unk0x10000000 = 0x10000000,
        Unk0x20000000 = 0x20000000,
        Unk0x40000000 = 0x40000000,
        Unk0x80000000 = 0x80000000
    }
        public enum Hierarchy
        {
        Neutral = 0,
        Special = 1,
        SpecialPlus = 2,
        Super = 3,
        DHC = 4,
        Launcher = 5,
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct SpatkHeaderChunk
        {
            public int index;
            public int size;
            public int unk08;
            public float meterRequirement;
            public SpatkDisabled disable;
            public Hierarchy cancelHierarchy;
            public PositionState positionState;
            public ComboState comboState;
            public cmdFlags flags;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct CollisionHeaderChunk
        {
            public int index;
            public int size;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct CollisionStandardChunk // hitbox / hurtbox ??
        {
            public WeaponID weaponID; //ffff = default/char body, 01/02 etc are props
            public int unk04;
            public BoneReferenceId boneReferenceId;
            public float zAxis;
            public float yAxis;
            public float xAxis;
            public float HitHurtBoxRadius;
            public CLIProperties specialProperties;
        }
        public struct ProfileSelfChunk
        {
        public CPIChar SelfID;
        //public byte SelfID;
        public byte unk04;
        public byte unk08;
        public byte unk0C;
        //public ProfileFlagsA IdentityFlags;
        //public ProfileFlagsB IdentityFlags2;
        public ProfileFlags IdentityFlags;
        //public byte unk18;
        //public byte unk1C;
        }
        public struct ProfileChunk //profile WIP here
        {
        public byte introID;
        public byte introProbability;
        public byte soundID;
        public byte unk0C;
        public CPIChar CharacterA;
        public CPIChar CharacterB;
        public CPIChar CharacterC;
        public CPIChar CharacterD;
        }
    public enum CPIChar : byte
    {
        Generic = 00,
        Ryu = 01,
        ChunLi = 02,
        Akuma = 03,
        Chris = 04,
        Wesker = 05,
        ViewtifulJoe = 06,
        Dante = 07,
        Trish = 08,
        FrankWest = 09,
        Spencer = 10,
        Arthur = 11,
        Amaterasu = 12,
        Zero = 13,
        Tron = 14,
        Morrigan = 15,
        HsienKo = 16,
        Felicia = 17,
        CViper = 18,
        Haggar = 19,
        Jill = 20,
        Strider = 21,
        Vergil = 22,
        PhoenixWright = 23,
        Firebrand = 24,
        Nemesis = 25,
        SpiderMan = 26,
        CapAmerica = 27,
        Wolverine = 28,
        Magneto = 29,
        Hulk = 30,
        SheHulk = 31,
        Taskmaster = 32,
        IronMan = 33,
        Thor = 34,
        DrDoom = 35,
        Phoenix = 36,
        Shuma = 37,
        Modok = 38,
        Dormammu = 39,
        Deadpool = 40,
        Storm = 41,
        Skrull = 42,
        Sentinel = 43,
        X23 = 44,
        Nova = 45,
        Rocket = 46,
        GhostRider = 47,
        IronFist = 48,
        DrStrange = 49,
        Hawkeye = 50,
        Galactus = 51,
        flag52 = 52,
        flag53 = 53,
        flag54 = 54,
        flag55 = 55,
        flag56 = 56,
        flag57 = 57,
        flag58 = 58,
        flag59 = 59,
        flag60 = 60,
        flag61 = 61,
        flag62 = 62,
        flag63 = 63,
        flag64 = 64,
        flag65 = 65,
        flag66 = 66,
        flag67 = 67,
        flag68 = 68,
        flag69 = 69,
        Male = 70,
        Female = 71,
        Good = 72,
        Evil = 73,
        flag74 = 74,
        flag75 = 75,
        Hero = 76,
        Villain = 77,
        flag78 = 78,
        flag79 = 79,
        flag80 = 80,
        Mutant = 81,
        StreetFighter = 82,
        DarkStalkers = 83,
        XMen = 84,
        Avenger = 85,
        flag86 = 86,
        flag87 = 87,
        flag88 = 88,
        flag89 = 89,
        flag90 = 90,
        flag91 = 91,
        flag92 = 92,
        flag93 = 93,
        flag94 = 94,
        flag95 = 95,
        flag96 = 96,
        flag97 = 97,
        flag98 = 98,
        flag99 = 99,
        flag100 = 100,
        flag101 = 101,
        flag102 = 102,
        flag103 = 103,
        flag104 = 104,
        flag105 = 105,
        flag106 = 106,
        flag107 = 107,
        flag108 = 108,
        flag109 = 109,
        flag110 = 110,
        flag111 = 111,
        flag112 = 112,
        flag113 = 113,
        XmenLeader = 114,
        AvengersLeader = 115,
        flag116 = 116,
        flag117 = 117,
        flag118 = 118,
        flag119 = 119,
        flag120 = 120,
        flag121 = 121,
        flag122 = 122,
        flag123 = 123,
        flag124 = 124,
        flag125 = 125,
        flag126 = 126,
        flag127 = 127,
        flag128 = 128,
        flag129 = 129,
        flag130 = 130,
        flag131 = 131,
        flag132 = 132,
        flag133 = 133,
        flag134 = 134,
        flag135 = 135,
        flag136 = 136,
        flag137 = 137,
        flag138 = 138,
        flag139 = 139,
        flag140 = 140,
        flag141 = 141,
        flag142 = 142,
        flag143 = 143,
        flag144 = 144,
        flag145 = 145,
        flag146 = 146,
        flag147 = 147,
        flag148 = 148,
        flag149 = 149,
        flag150 = 150,
        flag151 = 151,
        flag152 = 152,
        flag153 = 153,
        flag154 = 154,
        flag155 = 155,
        flag156 = 156,
        flag157 = 157,
        flag158 = 158,
        flag159 = 159,
        flag160 = 160,
        flag161 = 161,
        flag162 = 162,
        flag163 = 163,
        flag164 = 164,
        flag165 = 165,
        flag166 = 166,
        flag167 = 167,
        flag168 = 168,
        flag169 = 169,
        flag170 = 170,
        flag171 = 171,
        flag172 = 172,
        flag173 = 173,
        flag174 = 174,
        flag175 = 175,
        flag176 = 176,
        flag177 = 177,
        flag178 = 178,
        flag179 = 179,
        flag180 = 180,
        flag181 = 181,
        flag182 = 182,
        flag183 = 183,
        flag184 = 184,
        flag185 = 185,
        flag186 = 186,
        flag187 = 187,
        flag188 = 188,
        flag189 = 189,
        flag190 = 190,
        flag191 = 191,
        flag192 = 192,
        flag193 = 193,
        flag194 = 194,
        flag195 = 195,
        flag196 = 196,
        flag197 = 197,
        flag198 = 198,
        flag199 = 199,
        flag200 = 200,
        flag201 = 201,
        flag202 = 202,
        flag203 = 203,
        flag204 = 204,
        flag205 = 205,
        flag206 = 206,
        flag207 = 207,
        flag208 = 208,
        flag209 = 209,
        flag210 = 210,
        flag211 = 211,
        flag212 = 212,
        flag213 = 213,
        SelfColor1 = 214,
        SelfColor2 = 215,
        SelfColor3 = 216,
        SelfColor4 = 217,
        SelfColor5 = 218,
        SelfColor6 = 219,
        SelfColorH = 190,
        SelfColorAlt = 191,
        flag222 = 192,
        flag223 = 193,
        flag224 = 194,
        flag225 = 195,
        flag226 = 196,
        flag227 = 197,
        flag228 = 198,
        flag229 = 199,
        flag230 = 230,
        flag231 = 231,
        flag232 = 232,
        flag233 = 233,
        flag234 = 234,
        flag235 = 235,
        flag236 = 236,
        flag237 = 237,
        flag238 = 238,
        flag239 = 239,
        flag240 = 240,
        flag241 = 241,
        flag242 = 242,
        flag243 = 243,
        flag244 = 244,
        flag245 = 245,
        flag246 = 246,
        flag247 = 247,
        flag248 = 248,
        flag249 = 249,
        flag250 = 250,
        flag251 = 251,
        flag252 = 252,
        flag253 = 253,
        flag254 = 254,
        flag255 = 255
    }

    [Flags]
    public enum ProfileFlags : uint
    {
        None = 0x00,
        Male = 0x01,
        Female = 0x02,
        Good = 0x04,
        Evil = 0x08,
        CapcomGoodUnk = 0x10,
        CapcomEvilUnk = 0x20,
        MarvelGoodUnk = 0x40,
        MarvelEvilUnk = 0x80,
        NonMutant = 0x0100,
        NonHumanUnk = 0x0200,
        RobotUnk = 0x0400,
        Mutant = 0x0800,
        StreetFighter = 0x1000,
        DarkStalkers = 0x2000,
        XMen = 0x4000,
        Avenger = 0x8000,
    }
    [Flags]
    public enum ProfileFlagsA : byte
    {
        None = 0x00,
        Male = 0x01,
        Female = 0x02,
        Good = 0x04,
        Evil = 0x08,
        CapcomGoodUnk = 0x10,
        CapcomEvilUnk = 0x20,
        MarvelGoodUnk = 0x40,
        MarvelEvilUnk = 0x80
    }
    [Flags]
    public enum ProfileFlagsB : byte
    {
        None = 0x00,
        NonMutant = 0x01,
        NonHumanUnk = 0x02,
        RobotUnk = 0x04,
        Mutant = 0x08,
        StreetFighter = 0x10,
        DarkStalkers = 0x20,
        XMen = 0x40,
        Avenger = 0x80,
    }
    public enum BoneReferenceId : uint
    {
        Detached = 4294967295,
        Origin1 = 01,
        Origin2 = 02,
        Pelvis = 03,
        Spine2 = 04,
        Chest = 05,
        Neck = 06,
        Head = 07,
        LeftShoulderBlade = 08,
        LeftShoulder = 09,
        LeftElbow = 10,
        LeftWrist = 11,
        RightShoulderBlade = 12,
        RightShoulder = 13,
        RightElbow = 14,
        RightWrist = 15,
        LeftLeg = 16,
        LeftKnee = 17,
        LeftFoot = 18,
        LeftToe = 19,
        RightLeg = 20,
        RightKnee = 21,
        RightFoot = 22,
        RightToe = 23,
        Bone24 = 24,
        Bone25 = 25,
        Bone26 = 26,
        Bone27 = 27,
        Bone28 = 28,
        Bone29 = 29,
        Bone30 = 30,
        Bone31 = 31,
        Bone32 = 32,
        Bone33 = 33,
        Bone34 = 34,
        Bone35 = 35,
        Bone36 = 36,
        Bone37 = 37,
        Bone38 = 38,
        Bone39 = 39,
        Bone40 = 40,
        Bone41 = 41,
        Bone42 = 42,
        Bone43 = 43,
        Bone44 = 44,
        Bone45 = 45,
        Bone46 = 46,
        Bone47 = 47,
        Bone48 = 48,
        Bone49 = 49,
        Bone50 = 50,
        Bone51 = 51,
        Bone52 = 52,
        Bone53 = 53,
        Bone54 = 54,
        Bone55 = 55,
        Bone56 = 56,
        Bone57 = 57,
        Bone58 = 58,
        Bone59 = 59,
        Bone60 = 60,
        Bone61 = 61,
        Bone62 = 62,
        Bone63 = 63,
        Bone64 = 64,
        Bone65 = 65,
        Bone66 = 66,
        Bone67 = 67,
        Bone68 = 68,
        Bone69 = 69,
        Bone70 = 70,
        Bone71 = 71,
        Bone72 = 72,
        Bone73 = 73,
        Bone74 = 74,
        Bone75 = 75,
        Bone76 = 76,
        Bone77 = 77,
        Bone78 = 78,
        Bone79 = 79,
        Bone80 = 80,
        Bone81 = 81,
        Bone82 = 82,
        Bone83 = 83,
        Bone84 = 84,
        Bone85 = 85,
        Bone86 = 86,
        Bone87 = 87,
        Bone88 = 88,
        Bone89 = 89,
        Bone90 = 90,
        Bone91 = 91,
        Bone92 = 92,
        Bone93 = 93,
        Bone94 = 94,
        Bone95 = 95,
        Bone96 = 96,
        Bone97 = 97,
        Bone98 = 98,
        Bone99 = 99,
        Bone100 = 100,
        Bone101 = 101,
        Bone102 = 102,
        Bone103 = 103,
        Bone104 = 104,
        Bone105 = 105,
        Bone106 = 106,
        Bone107 = 107,
        Bone108 = 108,
        Bone109 = 109,
        Bone110 = 110,
        Bone111 = 111,
        Bone112 = 112,
        Bone113 = 113,
        Bone114 = 114,
        Bone115 = 115,
        Bone116 = 116,
        Bone117 = 117,
        Bone118 = 118,
        Bone119 = 119,
        Bone120 = 120,
        Bone121 = 121,
        Bone122 = 122,
        Bone123 = 123,
        Bone124 = 124,
        Bone125 = 125,
        Bone126 = 126,
        Bone127 = 127,
        Bone128 = 128,
        Bone129 = 129,
        Bone130 = 130,
        Bone131 = 131,
        Bone132 = 132,
        Bone133 = 133,
        Bone134 = 134,
        Bone135 = 135,
        Bone136 = 136,
        Bone137 = 137,
        Bone138 = 138,
        Bone139 = 139,
        Bone140 = 140,
        Bone141 = 141,
        Bone142 = 142,
        Bone143 = 143,
        Bone144 = 144,
        Bone145 = 145,
        Bone146 = 146,
        Bone147 = 147,
        Bone148 = 148,
        Bone149 = 149,
        Bone150 = 150,
        Bone151 = 151,
        Bone152 = 152,
        Bone153 = 153,
        Bone154 = 154,
        Bone155 = 155,
        Bone156 = 156,
        Bone157 = 157,
        Bone158 = 158,
        Bone159 = 159,
        Bone160 = 160,
        Bone161 = 161,
        Bone162 = 162,
        Bone163 = 163,
        Bone164 = 164,
        Bone165 = 165,
        Bone166 = 166,
        Bone167 = 167,
        Bone168 = 168,
        Bone169 = 169,
        Bone170 = 170,
        Bone171 = 171,
        Bone172 = 172,
        Bone173 = 173,
        Bone174 = 174,
        Bone175 = 175,
        Bone176 = 176,
        Bone177 = 177,
        Bone178 = 178,
        Bone179 = 179,
        Bone180 = 180,
        Bone181 = 181,
        Bone182 = 182,
        Bone183 = 183,
        Bone184 = 184,
        Bone185 = 185,
        Bone186 = 186,
        Bone187 = 187,
        Bone188 = 188,
        Bone189 = 189,
        LeftWeapon = 190,
        RightWeapon = 191,
        Bone192 = 192,
        Bone193 = 193,
        Bone194 = 194,
        Bone195 = 195,
        Bone196 = 196,
        Bone197 = 197,
        Bone198 = 198,
        Bone199 = 199,
        Bone200 = 200,
        Bone201 = 201,
        Bone202 = 202,
        Bone203 = 203,
        Bone204 = 204,
        Bone205 = 205,
        Bone206 = 206,
        Bone207 = 207,
        Bone208 = 208,
        Bone209 = 209,
        Bone210 = 210,
        Bone211 = 211,
        Bone212 = 212,
        Bone213 = 213,
        Bone214 = 214,
        Bone215 = 215,
        Bone216 = 216,
        Bone217 = 217,
        Bone218 = 218,
        Bone219 = 219,
        Bone220 = 220,
        Bone221 = 221,
        Bone222 = 222,
        Bone223 = 223,
        Bone224 = 224,
        Bone225 = 225,
        Bone226 = 226,
        Bone227 = 227,
        Bone228 = 228,
        Bone229 = 229,
        Bone230 = 230,
        Bone231 = 231,
        Bone232 = 232,
        Bone233 = 233,
        Bone234 = 234,
        Bone235 = 235,
        Bone236 = 236,
        Bone237 = 237,
        Bone238 = 238,
        Bone239 = 239,
        Bone240 = 240,
        Bone241 = 241,
        Bone242 = 242,
        Bone243 = 243,
        Bone244 = 244,
        Bone245 = 245,
        Bone246 = 246,
        Bone247 = 247,
        Bone248 = 248,
        Bone249 = 249,
        Bone250 = 250,
        Bone251 = 251,
        Bone252 = 252,
        Bone253 = 253,
        Bone254 = 254,
        Origin = 255
    }
    public enum WeaponID : int { 
    None = -1,
    Weapon0 = 0x00,
    Weapon1 = 0x01,
    Weapon2 = 0x02,
    Weapon3 = 0x03,
    Weapon4 = 0x04,
    Weapon5 = 0x05,
    Weapon6 = 0x06,
    Weapon7 = 0x07,
    Weapon8 = 0x08,
    Weapon9 = 0x09,
    Weapon0A = 0x0A,
    Weapon0B = 0x0B,
    Weapon0C = 0x0C,
    Weapon0D = 0x0D,
    Weapon0E = 0x0E,
    Weapon0F = 0x0F,
    Weapon10 = 0x10,
    Weapon11 = 0x11,
    Weapon12 = 0x12,
    Weapon13 = 0x13,
    Weapon14 = 0x14,
    Weapon15 = 0x15
    }

    [Flags]
    public enum CLIProperties : uint
    {
        None = 0,
        Unk0x01 = 0x00000001,
        CanHitChar = 0x00000002,
        Unk0x04 = 0x00000004,
        CanHitProjectiles = 0x00000008,
        Unk0x10 = 0x00000010,
        Unk0x20 = 0x00000020,
        Unk0x40 = 0x00000040,
        Unk0x80 = 0x00000080,
        Unk0x0100 = 0x00000100,
        Unk0x0200 = 0x00000200,
        Unk0x0400 = 0x00000400,
        Unk0x0800 = 0x00000800,
        Unk0x1000 = 0x00001000,
        Unk0x2000 = 0x00002000,
        Unk0x4000 = 0x00004000,
        Unk0x8000 = 0x00008000,
        Unk0x10000 = 0x00010000,
        Unk0x20000 = 0x00020000,
        Unk0x40000 = 0x00040000,
        DestroyProjectiles = 0x00080000,
        Unk0x100000 = 0x00100000,
        Unk0x200000 = 0x00200000,
        Unk0x400000 = 0x00400000,
        Unk0x800000 = 0x00800000,
        Unkx01000000 = 0x01000000,
        Unk0x02000000 = 0x02000000,
        Unk0x04000000 = 0x04000000,
        Unk0x08000000 = 0x08000000,
        Unk0x10000000 = 0x10000000,
        Unk0x20000000 = 0x20000000,
        Unk0x40000000 = 0x40000000,
        Unk0x80000000 = 0x80000000
    }
    [Flags]
    public enum CancelFlags : uint
    {
        None = 0,
        Whiff = 2,
        OnHit = 16,
        OnBlock = 64,
        Blocking = 4096,
        Walljump = 8388608,

    }

    public enum SpecialProperties
        {
            normal = 1769234688,
            disabled = 1769234689
        }

        public enum CmdDisabled
        {
            enabled = 1769234688,
            disabled = 1769234689
        }

        public enum SpatkDisabled
        {
            enabled = 0,
            disabled = 1
        }

        public enum PositionState : int
        {
            Ground = 0,
            Air = 1,
            Either = 2
        }

        public enum ComboState : int
        {
            NeutralAndCombos = 0,
            NeutralOnly = 1,
            ComboOnly = 2,
            Unk3 = 3,
            GuardCancel = 4,
            GuardAndDamageCancel = 5
        }

        public enum BaseActState : int
        {
            Ground = 00,
            Air = 32
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SpatkStandardChunk // 02
        {
            public SubChunkType subChunkType; // 02
            public int cancelWindow;
            public int chargeTime;
            public int holdButtonUnk;
            public int negativeEdge;
            public InputCode inputCodeLeniencyUnk;
            public InputCode inputCode;
            public int unk1C;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SpatkDirectionalDashChunk // 03
        {
            public SubChunkType subChunkType; // 03
            public int cancelWindow;
            public int unk08;
            public int unk0C;
            public int negativeEdge;
            public InputCode inputCodeLeniencyUnk;
            public InputCode inputCode;
            public int unk1C;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SpatkTwoButtonChunk // 04
        {
            public SubChunkType subChunkType; // 04
            public int cancelWindow;
            public int unk08;
            public int atkS;
            public int unk10;
            public int unk14;
            public int unk18;
            public int unk1C;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SpatkDirButtonChunk // 05
        {
            public SubChunkType subChunkType; // 05
            public int cancelWindow;
            public InputCode inputCodeLeniencyUnk;
            public InputCode inputCodeDirection;
            public InputCode inputCodeButton;
            public int unk14;
            public int unk18;
            public int unk1C;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SpatkTwoButtonAirdashChunk // 07
        {
            public SubChunkType subChunkType; // 07
            public int cancelWindow;
            public int chargeTimeUnk;
            public InputCode inputCodeLeniency;
            public InputCode inputCodeDirection;
            public int AtkSInput;
            public int unk18;
            public int unk1C;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SpatkActionChunk // 09
        {
            public SubChunkType subChunkType; // 09
            public int actionClass;
            public int actionIndex;
            public int actionStorageBuffer;
            public int unk10;
            public int unk14;
            public int unk18;
            public int unk1C;
        }
    [StructLayout(LayoutKind.Sequential)]
        public struct SpatkCaptureStateChunk // 0A
        {
        public SubChunkType subChunkType; // 0A
        public int PlayerActionClass;
        public int PlayerActionIndex;
        public int EnemyActionClass;
        public int EnemyClassIndex;
        public int unk14;
        public int unk18;
        public int unk1C;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct SpatkAirGroundState // 0B
    {
        public SubChunkType subChunkType; //0B
        public AirGroundState AirGroundState;
        public int unk08;
        public int unk0C;
        public int unk10;
        public int unk14;
        public int unk18;
        public int unk1C;
    }

    public struct SpatkRequiredStateUnk // 17
        {
            public SubChunkType subChunkType; // 17
            public int stateID;
            public int unk08;
            public int unk0C;
            public int unk10;
            public int unk14;
            public int unk18;
            public int unk1C;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct SpatkChrisStateChunk // 18
        {
            public SubChunkType subChunkType; //18
            public int stateID;
            public int unk08;
            public int unk0C;
            public int unk10;
            public int unk14;
            public int unk18;
            public int unk1C;
        }
    public struct SpatkVergilSwordsChunk // 19
    {
        public SubChunkType subChunkType; //19
        public int anmchrEntry;
        public int unk08;
        public int unk0C;
        public int unk10;
        public int unk14;
        public int unk18;
        public int unk1C;
    }
    [StructLayout(LayoutKind.Sequential)]
        public struct SpatkModeRequiredChunk // 1E
        {
            public SubChunkType subChunkType; // 1E
            public int modeNumber;
            public int unk08;
            public int unk0C;
            public int unk10;
            public int unk14;
            public int unk18;
            public int unk1C;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SpatkTACDHCChunk // 23
        {
            public SubChunkType subChunkType; //23
            public int anmChrAction;
            public int unk08;
            public int unk0C;
            public int unk10;
            public int unk14;
            public int unk18;
            public int unk1C;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SpatkSuperJumpAction // 25
        {
            public SubChunkType subChunkType; //25
            public int NeutralSJAnmchrAction;
            public int ForwardSJAnmchrAction;
            public int BackwardsSJAnmchrAction;
            public int unk10;
            public int unk14;
            public int unk18;
            public int unk1C;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SpatkSnapBack // 26
        {
            public EnumUnk flags; // 26
            public int unk08;
            public int unk0C;
            public int unk10;
            public int unk14;
            public int unk18;
            public int unk1C;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SpatkRestrictedStateChunk // 2F
        {
            public SubChunkType subChunkType; //2F
            public int stateID;
            public int unk08;
            public int unk0C;
            public int unk10;
            public int unk14;
            public int unk18;
            public int unk1C;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SpatkProhibitedChunk // 31
        {
            public SubChunkType subChunkType; //31
            public int prohibitedCategory;
            public int prohibitedID;
            public int unk0C;
            public int unk10;
            public int unk14;
            public int unk18;
            public int unk1C;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SpatkAirdashChunk // 34
        {
            public SubChunkType subChunkType; //34
            public int unk04;
            public int unk08;
            public int unk0C;
            public int unk10;
            public int unk14;
            public int unk18;
            public int unk1C;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SpatkAirSpecialLimiterChunk // 35
        {
            public SubChunkType subChunkType; //35
            public int limit;
            public int unk08;
            public int unk0C;
            public int unk10;
            public int unk14;
            public int unk18;
            public int unk1C;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SpatkGuardTACChunk // 38
        {
            public SubChunkType subChunkType; //38
            public int unk04;
            public int unk08;
            public int unk0C;
            public int unk10;
            public int unk14;
            public int unk18;
            public int unk1C;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SpatkHyperChunk // 3A
        {
            public SubChunkType subChunkType; //3A
            public int unk04;
            public int unk08;
            public int unk0C;
            public int unk10;
            public int unk14;
            public int unk18;
            public int unk1C;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SpatkAllowedChainChunk // 3F
        {
            public SubChunkType subChunkType; //3F
            public AnmFlagsB cancelFlags;
            public int unk08;
            public int unk0C;
            public int unk10;
            public int unk14;
            public int unk18;
            public int unk1C;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SpatkAdvGuardUnk // 49
        {
            public SubChunkType subChunkType; //49
            public AnmFlagsB cancelFlags;
            public int unk08;
            public int unk0C;
            public int unk10;
            public int unk14;
            public int unk18;
            public int unk1C;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct MaximumHeightRestriction // 50
        {
        public int maximumHeight; //50
        public int unk04;
        public int unk08;
        public int unk0C;
        public int unk10;
        public int unk14;
        public int unk18;
        public int unk1C;
        }
    [StructLayout(LayoutKind.Sequential)]
    public struct HeightRestriction // 51
    {
        public int Height; //51
        public int unk04;
        public int unk08;
        public int unk0C;
        public int unk10;
        public int unk14;
        public int unk18;
        public int unk1C;
    }


    [StructLayout(LayoutKind.Sequential)]
        public struct SpatkHaggarFlagsUnk // 55
        {
            public SubChunkType subChunkType; //55
            public EnumUnk flags;
            public int unk08;
            public int unk0C;
            public int unk10;
            public int unk14;
            public int unk18;
            public int unk1C;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SpatkWhiffCancelUnk // 5A
        {
            public SubChunkType subChunkType; //5A
            public EnumUnk flags;
            public int unk08;
            public int unk0C;
            public int unk10;
            public int unk14;
            public int unk18;
            public int unk1C;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SpatkHasPropActive // 5B
        {
            public SubChunkType subChunkType; //5B
            public EnumUnk flags;
            public int unk08;
            public int unk0C;
            public int unk10;
            public int unk14;
            public int unk18;
            public int unk1C;
        }
    [StructLayout(LayoutKind.Sequential)]
    public struct SpatkUnk // 5D
    {
        public SubChunkType subChunkType; //5D
        public int unk04;
        public int unk08;
        public int unk0C;
        public int unk10;
        public int unk14;
        public int unk18;
        public int unk1C;
    }

    [StructLayout(LayoutKind.Sequential)]
        public struct SpatkUnkChunk // ??
        {
            public SubChunkType subChunkType; //??
            public int unk04;
            public int unk08;
            public int unk0C;
            public int unk10;
            public int unk14;
            public int unk18;
            public int unk1C;
        }
    [Flags]
    public enum AnmFlagsA : uint //DeadCharacter 1_2A-1_2E
    {
        None = 0,
        Unk0x01 = 0x00000001,
        Unk0x02 = 0x00000002,
        Unk0x04 = 0x00000004,
        Unk0x08 = 0x00000008,
        Unk0x10 = 0x00000010,
        Unk0x20 = 0x00000020,
        Unk0x40 = 0x00000040,
        Unk0x80 = 0x00000080,
        Unk0x0100 = 0x00000100,
        Unk0x0200 = 0x00000200,
        Unk0x0400 = 0x00000400,
        Unk0x0800 = 0x00000800,
        Unk0x1000 = 0x00001000,
        Unk0x2000 = 0x00002000,
        Unk0x4000 = 0x00004000,
        Unk0x8000 = 0x00008000,
        Unk0x010000 = 0x00010000,
        Unk0x020000 = 0x00020000,
        Unk0x040000 = 0x00040000,
        Unk0x080000 = 0x00080000,
        Unk0x100000 = 0x00100000,
        Unk0x200000 = 0x00200000,
        Unk0x400000 = 0x00400000,
        Unk0x800000 = 0x00800000,
        Unkx01000000 = 0x01000000,
        Unk0x02000000 = 0x02000000,
        Unk0x04000000 = 0x04000000,
        Unk0x08000000 = 0x08000000,
        Unk0x10000000 = 0x10000000,
        Unk0x20000000 = 0x20000000,
        Unk0x40000000 = 0x40000000,
        Unk0x80000000 = 0x80000000
    }
    [Flags]
    public enum AnmFlagsB : uint //Mash or Left/Right modifier 1_35-1_3A
    {
        None = 0,
        Unk0x01 = 0x00000001,
        Whiff = 0x00000002,
        Unk0x04 = 0x00000004,
        Unk0x08 = 0x00000008,
        OnHit = 0x00000010,
        Unk0x20 = 0x00000020,
        OnBlock = 0x00000040,
        Unk0x80 = 0x00000080,
        Unk0x0100 = 0x00000100,
        Unk0x0200 = 0x00000200,
        Unk0x0400 = 0x00000400,
        Unk0x0800 = 0x00000800,
        Falling = 0x00001000,
        TouchingStageEdge = 0x00002000,
        Unk0x4000 = 0x00004000,
        CrossUp = 0x00008000,
        Unk0x010000 = 0x00010000,
        Unk0x020000 = 0x00020000,
        Unk0x040000 = 0x00040000,
        Unk0x080000 = 0x00080000,
        Unk0x100000 = 0x00100000,
        OnP2Side = 0x00200000,
        FacingLeft = 0x00400000,
        TouchingCameraEdge = 0x00800000,
        Unkx01000000 = 0x01000000,
        Unk0x02000000 = 0x02000000,
        Unk0x04000000 = 0x04000000,
        Unk0x08000000 = 0x08000000,
        Unk0x10000000 = 0x10000000,
        Unk0x20000000 = 0x20000000,
        Unk0x40000000 = 0x40000000,
        Unk0x80000000 = 0x80000000
    }
    [Flags]
    public enum AnmFlagsC : uint // Flags for 1_3C/1_3D
    {
        None = 0,
        Unk0x01 = 0x00000001,
        Invisibility = 0x00000002,
        Invincibility = 0x00000004,
        Unk0x08 = 0x00000008,
        Unk0x10 = 0x00000010,
        Invincibility2 = 0x00000020,
        Unk0x40 = 0x00000040,
        Unk0x80 = 0x00000080,
        NoSpecialHyperCancel = 0x00000100,
        Unk0x0200 = 0x00000200,
        Unk0x0400 = 0x00000400,
        NoCollision = 0x00000800,
        Unk0x1000 = 0x00001000,
        NoStageCollision = 0x00002000,
        Unk0x4000 = 0x00004000,
        DisableInput = 0x00008000,
        Unk0x10000 = 0x00010000,
        Unk0x20000 = 0x00020000,
        Unk0x40000 = 0x00040000,
        Unk0x80000 = 0x00080000,
        Unk0x100000 = 0x00100000,
        Unk0x200000 = 0x00200000,
        Unk0x400000 = 0x00400000,
        Unk0x800000 = 0x00800000,
        Unk0x01000000 = 0x01000000,
        DisableCancel = 0x02000000,
        NoCameraTracking = 0x04000000,
        Unk0x08000000 = 0x08000000,
        Unk0x10000000 = 0x10000000,
        Unk0x20000000 = 0x20000000,
        Unk0x40000000 = 0x40000000,
        Unk0x80000000 = 0x80000000
    }
    
    [Flags]
    public enum AnmFlagsD : uint //Special Properties 1_41-1_46
    {
        None = 0,
        Unk0x01 = 0x00000001,
        Unk0x02 = 0x00000002,
        Unk0x04 = 0x00000004,
        Unk0x08 = 0x00000008,
        Unk0x10 = 0x00000010,
        Unk0x20 = 0x00000020,
        Unk0x40 = 0x00000040,
        Unk0x80 = 0x00000080,
        Unk0x0100 = 0x00000100,
        Unk0x0200 = 0x00000200,
        Unk0x0400 = 0x00000400,
        Unk0x0800 = 0x00000800,
        Unk0x1000 = 0x00001000,
        Unk0x2000 = 0x00002000,
        Unk0x4000 = 0x00004000,
        Unk0x8000 = 0x00008000,
        Unk0x010000 = 0x00010000,
        Unk0x020000 = 0x00020000,
        Unk0x040000 = 0x00040000,
        Unk0x080000 = 0x00080000,
        Unk0x100000 = 0x00100000,
        Unk0x200000 = 0x00200000,
        Unk0x400000 = 0x00400000,
        Unk0x800000 = 0x00800000,
        Unkx01000000 = 0x01000000,
        Unk0x02000000 = 0x02000000,
        Unk0x04000000 = 0x04000000,
        Unk0x08000000 = 0x08000000,
        Unk0x10000000 = 0x10000000,
        Unk0x20000000 = 0x20000000,
        Unk0x40000000 = 0x40000000,
        Unk0x80000000 = 0x80000000
    }

    [Flags]
    public enum AnmFlagsE : uint //
    {
        None = 0,
        Unk0x01 = 0x00000001,
        Unk0x02 = 0x00000002,
        Unk0x04 = 0x00000004,
        Unk0x08 = 0x00000008,
        Unk0x10 = 0x00000010,
        Unk0x20 = 0x00000020,
        Unk0x40 = 0x00000040,
        Unk0x80 = 0x00000080,
        Unk0x0100 = 0x00000100,
        Unk0x0200 = 0x00000200,
        Unk0x0400 = 0x00000400,
        Unk0x0800 = 0x00000800,
        Unk0x1000 = 0x00001000,
        Unk0x2000 = 0x00002000,
        Unk0x4000 = 0x00004000,
        Unk0x8000 = 0x00008000,
        Unk0x010000 = 0x00010000,
        Unk0x020000 = 0x00020000,
        Unk0x040000 = 0x00040000,
        Unk0x080000 = 0x00080000,
        Unk0x100000 = 0x00100000,
        Unk0x200000 = 0x00200000,
        Unk0x400000 = 0x00400000,
        Unk0x800000 = 0x00800000,
        Unkx01000000 = 0x01000000,
        Unk0x02000000 = 0x02000000,
        Unk0x04000000 = 0x04000000,
        Unk0x08000000 = 0x08000000,
        Unk0x10000000 = 0x10000000,
        Unk0x20000000 = 0x20000000,
        Unk0x40000000 = 0x40000000,
        Unk0x80000000 = 0x80000000
    }

    [Flags]
    public enum AnmFlagsF : uint //Partner Properties Flags
    {
        None = 0,
        ProjectileReflectUnk = 0x00000001,
        WallBounce = 0x00000002,
        Unk0x04 = 0x00000004,
        THCUnk = 0x00000008,
        HyperUnk = 0x00000010,
        Unk0x20 = 0x00000020,
        Unk0x40 = 0x00000040,
        Unk0x80 = 0x00000080,
        Unk0x0100 = 0x00000100,
        ThrowUnk = 0x00000200,
        LaunchedState = 0x00000400,
        TACState = 0x00000800,
        BreakAwayState = 0x00001000,
        Unk0x2000 = 0x00002000,
        AssistState = 0x00004000,
        JumpUnk = 0x00008000,
        Unk0x010000 = 0x00010000,
        UseGroundBounce = 0x00020000,
        SuperBG = 0x00040000,
        CanStealCorner = 0x00080000,
        FlightState = 0x00100000,
        AirUnk = 0x00200000,
        JumpCancellable = 0x00400000,
        EnableDHC = 0x00800000,
        FaceUpKD = 0x01000000,
        FaceDownKD = 0x02000000,
        Unk0x04000000 = 0x04000000,
        LoopUntilTHC = 0x08000000,
        DisableAssist = 0x10000000,
        AttackMadeContact = 0x20000000,
        DisableYAccel = 0x40000000,
        AirRecoveryUnk = 0x80000000
    }
    [Flags]
    public enum AnmFlagsG : uint //Unknown Properties (1_53 1_54 1_55 1_56 1_57 1_58)
    {
        None = 0,
        Unk0x01 = 0x00000001,
        Unk0x02 = 0x00000002,
        Unk0x04 = 0x00000004,
        Unk0x08 = 0x00000008,
        Unk0x10 = 0x00000010,
        Unk0x20 = 0x00000020,
        Unk0x40 = 0x00000040,
        Unk0x80 = 0x00000080,
        Unk0x0100 = 0x00000100,
        Unk0x0200 = 0x00000200,
        Unk0x0400 = 0x00000400,
        Unk0x0800 = 0x00000800,
        Unk0x1000 = 0x00001000,
        Unk0x2000 = 0x00002000,
        Unk0x4000 = 0x00004000,
        Unk0x8000 = 0x00008000,
        Unk0x010000 = 0x00010000,
        Unk0x020000 = 0x00020000,
        Unk0x040000 = 0x00040000,
        Unk0x080000 = 0x00080000,
        Unk0x100000 = 0x00100000,
        Unk0x200000 = 0x00200000,
        Unk0x400000 = 0x00400000,
        Unk0x800000 = 0x00800000,
        Unkx01000000 = 0x01000000,
        Unk0x02000000 = 0x02000000,
        Unk0x04000000 = 0x04000000,
        Unk0x08000000 = 0x08000000,
        Unk0x10000000 = 0x10000000,
        Unk0x20000000 = 0x20000000,
        Unk0x40000000 = 0x40000000,
        Unk0x80000000 = 0x80000000
    }
    [Flags]
    public enum AnmFlagsH : uint //Character Class Properties (1_59 1_5A 1_5B 1_5C 1_5D 1_5E)
    {
        None = 0,
        Unk0x01 = 0x00000001,
        Unk0x02 = 0x00000002,
        Unk0x04 = 0x00000004,
        Unk0x08 = 0x00000008,
        Unk0x10 = 0x00000010,
        Unk0x20 = 0x00000020,
        Unk0x40 = 0x00000040,
        Unk0x80 = 0x00000080,
        Unk0x0100 = 0x00000100,
        Unk0x0200 = 0x00000200,
        Unk0x0400 = 0x00000400,
        Unk0x0800 = 0x00000800,
        Unk0x1000 = 0x00001000,
        Unk0x2000 = 0x00002000,
        Unk0x4000 = 0x00004000,
        Unk0x8000 = 0x00008000,
        Unk0x010000 = 0x00010000,
        Unk0x020000 = 0x00020000,
        Unk0x040000 = 0x00040000,
        Unk0x080000 = 0x00080000,
        Unk0x100000 = 0x00100000,
        Unk0x200000 = 0x00200000,
        Unk0x400000 = 0x00400000,
        Unk0x800000 = 0x00800000,
        Unkx01000000 = 0x01000000,
        Unk0x02000000 = 0x02000000,
        Unk0x04000000 = 0x04000000,
        Unk0x08000000 = 0x08000000,
        Unk0x10000000 = 0x10000000,
        Unk0x20000000 = 0x20000000,
        Unk0x40000000 = 0x40000000,
        Unk0x80000000 = 0x80000000
    }

    public enum Condition : uint {
    LessThan = 0x00,
    LessOrEqualTo = 0x01,
    EqualTo = 0x02,
    NotEqualTo = 0x03,
    GreaterOrEqualThan = 0x04,
    GreaterThan = 0x05
    }
    public enum SpawnRelation : uint
    {
    Stage = 0x00,
    Self = 0x01,
    Opponent = 0x02
    }

    public enum EnumUnk : uint
        {
            None = 0,
            Unk0x01 = 0x00000001,
            Unk0x02 = 0x00000002,
            Unk0x04 = 0x00000004,
            Unk0x08 = 0x00000008,
            Unk0x10 = 0x00000010,
            Unk0x20 = 0x00000020,
            Unk0x40 = 0x00000040,
            Unk0x80 = 0x00000080,
            Unk0x0100 = 0x00000100,
            Unk0x0200 = 0x00000200,
            Unk0x0400 = 0x00000400,
            Unk0x0800 = 0x00000800,
            Unk0x1000 = 0x00001000,
            Unk0x2000 = 0x00002000,
            Unk0x4000 = 0x00004000,
            Unk0x8000 = 0x00008000,
            Unk0x010000 = 0x00010000,
            Unk0x020000 = 0x00020000,
            Unk0x040000 = 0x00040000,
            Unk0x080000 = 0x00080000,
            Unk0x100000 = 0x00100000,
            Unk0x200000 = 0x00200000,
            Unk0x400000 = 0x00400000,
            Unk0x800000 = 0x00800000,
            Unkx01000000 = 0x01000000,
            Unk0x02000000 = 0x02000000,
            Unk0x04000000 = 0x04000000,
            Unk0x08000000 = 0x08000000,
            Unk0x10000000 = 0x10000000,
            Unk0x20000000 = 0x20000000,
            Unk0x40000000 = 0x40000000,
            Unk0x80000000 = 0x80000000
        }


        public enum SubChunkType : uint
        {
        [Description("0 None")]
        none_0 = 0,
        [Description("1 unk1")]
        unk1_1 = 01,
        [Description("2 Standard Input")]
        standardInput_2 = 02,
        [Description("3 Dash Direction Input")]
        dashDirectionInput_3 = 03,
        [Description("4 Two Button Input")]
        twoButtonInput1_4 = 04,
        [Description("5 Direction and Button Input")]
        directionAndButtonInput = 05,
        [Description("6 unk6")]
        unk6_6 = 06,
        [Description("7 Two Button Input")]
        twoButtonInput2_7 = 07,
        [Description("9 Execute Action")]
        executeAction_9 = 09,
        [Description("10 Capture State")]
        captureState_10 = 10, //0A
        [Description("11 State Restriction")]
        AirGroundStateRestriction_11 = 11, //0B
        [Description("13 Simple Mode Air Combo Unk")]
        simpleModeAirComboUnk_13 = 13, //0D
        [Description("23 Character Class Required")]
        CharacterClassRequired_23 = 23, //17
        [Description("24 Character Class Restriction")]
        CharacterClassRestricted_24 = 24, //18
        [Description("25 VergilBlisteringSwords")]
        vergilChunk_25 = 25, //19
        [Description("26 Taskmaster Air Arrows Unk")]
        taskmasterFlags_26 = 26, //1A
        [Description("30 Install Requirement")]
        InstallRequired_30 = 30, //1E
        [Description("33 TAC Unk")]
        TACUnk_33 = 33, //21
        [Description("34 Character Class Specific")]
        CharacterClass_34 = 34, //22
        [Description("35 TAC/DHC Action")]
        TACDHCAction_35 = 35, //23
        [Description("37 Super Jump Action")]
        superJumpAction_37 = 37, //25
        [Description("38 Snap Back Character")]
        snapBackChar_38 = 38, //26
        [Description("41 Easy Mode Unk?")]
        easyModeUnk_41 = 41, //29
        [Description("47 Install Restricted")]
        InstallRestricted_47 = 47, //2F
        [Description("48 S Unk")]
        SUnk_48 = 48, //30
        [Description("49 Prohibited Follow Up Action")]
        prohibitedFollowUpAction_49 = 49, //31
        [Description("50 Height Restriction")]
        heightRestriction_50 = 50, //32
        [Description("51 Maximum Height Restriction")]
        MaximumHeightRestriction_51 = 51, //32
        [Description("52 Air Dash")]
        airDash_52 = 52, //34
        [Description("53 Air Special Action Limit")]
        airSpecialActionLimit_53 = 53, //35
        [Description("56 Guard TAC Action")]
        guardTACAction_56 = 56, //38
        [Description("58 Hypers")]
        hypers_58 = 58, //3A
        [Description("60 Unk3C")]
        unk3C_60 = 60, //3C
        [Description("61 Unk3D")]
        unk3D_61 = 61, //3D
        [Description("63 Allowed Chain Canceling State")]
        allowedChainCancelingState_63 = 63, //3F
        [Description("73 Advancing Guard Unk")]
        advGuardUnk_73 = 73, //49
        [Description("85 Haggar Flags Unk")]
        haggarFlags_85 = 85, //55
        [Description("90 Whiff Cancel Unk")]
        whiffCancelUnk_90 = 90,
        [Description("91 Is Prop Active")]
        hasPropActive_91 = 91,
        [Description("93")]
            unk5B_93 = 93,
    }


        public class MVC3DataStructures
        {
            public static string[] NumpadDirections = { "5", "6", "4", "?", "8", "9", "7", "?", "2", "3", "1" };
            public static List<string> SubChunkTypeList = new List<string>(new string[] { "standardInput", "dashDirectionInput", "twoButtonInput1", "directionAndButtonInput", 
                "twoButtonInput2", "executeAction", "modeRequired", "TACDHCAction", "restrictedState", "chrisStateCheck", "vergilSwordsCheck", "prohibitedFollowUpAction", "airDash", "airSpecialActionLimit", 
                "guardTACAction", "hypers", "allowedChainOnState" });

            //FIXME: fugly implementation :s
            public static Type[] SpatkChunkTypes =
            {
            typeof(SpatkUnkChunk), // 00                  [0] 
            typeof(SpatkUnkChunk), // 01                  [1] 
            typeof(SpatkStandardChunk), // 02             [2] 
            typeof(SpatkDirectionalDashChunk), // 03      [3] 
            typeof(SpatkTwoButtonChunk), // 04            [4] 
            typeof(SpatkDirButtonChunk), // 05            [5] 
            typeof(SpatkUnkChunk), // 06                  [6] 
            typeof(SpatkTwoButtonAirdashChunk), // 07     [7] 
            typeof(SpatkUnkChunk), // 08                  [8] 
            typeof(SpatkActionChunk), // 09               [9]
            typeof(SpatkCaptureStateChunk), // 0A         [10]
            typeof(SpatkAirGroundState), // 0B            [11]
            typeof(SpatkUnkChunk), // 00                  [12]
            typeof(SpatkUnkChunk), // 00                  [13]
            typeof(SpatkUnkChunk), // 00                  [14]
            typeof(SpatkUnkChunk), // 00                  [15]
            typeof(SpatkUnkChunk), // 00                  [16]
            typeof(SpatkUnkChunk), // 00                  [17]
            typeof(SpatkUnkChunk), // 00                  [18]
            typeof(SpatkUnkChunk), // 00                  [19]
            typeof(SpatkUnkChunk), // 00                  [20]
            typeof(SpatkUnkChunk), // 00                  [21]
            typeof(SpatkUnkChunk), // 00                  [22]
            typeof(SpatkRequiredStateUnk), // 17          [23]
            typeof(SpatkChrisStateChunk), // 00           [24]
            typeof(SpatkVergilSwordsChunk), // 19         [25]
            typeof(SpatkSnapBack), // 00                  [26]
            typeof(SpatkUnkChunk), // 00                  [27]
            typeof(SpatkUnkChunk), // 00                  [28]
            typeof(SpatkUnkChunk), // 00                  [29]
            typeof(SpatkModeRequiredChunk), // 1E         [30]
            typeof(SpatkUnkChunk), // 00                  [31]
            typeof(SpatkUnkChunk), // 00                  [32]
            typeof(SpatkUnkChunk), // 00                  [33]
            typeof(SpatkUnkChunk), // 00                  [34]
            typeof(SpatkTACDHCChunk), // 23               [35]
            typeof(SpatkUnkChunk), // 00                  [36]
            typeof(SpatkSuperJumpAction), // 00           [37]
            typeof(SpatkUnkChunk), // 00                  [38]
            typeof(SpatkUnkChunk), // 00                  [39]
            typeof(SpatkUnkChunk), // 00                  [40]
            typeof(SpatkUnkChunk), // 00                  [41]
            typeof(SpatkUnkChunk), // 00                  [42]
            typeof(SpatkUnkChunk), // 00                  [43]
            typeof(SpatkUnkChunk), // 00                  [44]
            typeof(SpatkUnkChunk), // 00                  [45]
            typeof(SpatkUnkChunk), //                     [46]
            typeof(SpatkRestrictedStateChunk), // 2F      [47]
            typeof(SpatkUnkChunk), // 00                  [48]
            typeof(SpatkProhibitedChunk), // 31           [49]
            typeof(SpatkUnkChunk), // 00                  [50]
            typeof(SpatkUnkChunk), // 00                  [51]
            typeof(SpatkAirdashChunk), // 34              [52]
            typeof(SpatkAirSpecialLimiterChunk), // 35    [53]
            typeof(SpatkUnkChunk), // 00                  [54]
            typeof(SpatkUnkChunk), // 00                  [55]
            typeof(SpatkGuardTACChunk), // 38             [56]
            typeof(SpatkUnkChunk), // 00                  [57]
            typeof(SpatkHyperChunk), // 3A                [58]
            typeof(SpatkUnkChunk), // 00                  [59]
            typeof(SpatkUnkChunk), // 00                  [60]
            typeof(SpatkUnkChunk), // 00                  [61]
            typeof(SpatkUnkChunk), // 00                  [62]
            typeof(SpatkAllowedChainChunk), // 3F         [63]
            typeof(SpatkUnkChunk), // 00                  [64]
            typeof(SpatkUnkChunk), // 00                  [65]
            typeof(SpatkUnkChunk), // 00                  [66]
            typeof(SpatkUnkChunk), // 00                  [67]
            typeof(SpatkUnkChunk), // 00                  [68]
            typeof(SpatkUnkChunk), // 00                  [69]
            typeof(SpatkUnkChunk), // 46                  [70]

            typeof(SpatkUnkChunk), // 00                  [71]
            typeof(SpatkUnkChunk), // 00                  [72]
            typeof(SpatkAdvGuardUnk), // 00               [73]
            typeof(SpatkUnkChunk), // 00                  [74]
            typeof(SpatkUnkChunk), // 00                  [75]
            typeof(SpatkUnkChunk), // 00                  [76]
            typeof(SpatkUnkChunk), // 00                  [77]
            typeof(SpatkUnkChunk), // 00                  [78]
            typeof(SpatkUnkChunk), // 00                  [79]
            typeof(SpatkUnkChunk), // 50                  [80]
            typeof(SpatkUnkChunk), // 00                  [81]
            typeof(SpatkUnkChunk), // 00                  [82]
            typeof(SpatkUnkChunk), // 00                  [83]
            typeof(SpatkUnkChunk), // 00                  [84]
            typeof(SpatkHaggarFlagsUnk),  // 55           [85]
            typeof(SpatkUnkChunk), // 00                  [86]
            typeof(SpatkUnkChunk), // 00                  [87]
            typeof(SpatkUnkChunk), // 00                  [88]
            typeof(SpatkUnkChunk), // 00                  [89]
            typeof(SpatkWhiffCancelUnk), // 5A            [90]
            typeof(SpatkHasPropActive), // 00             [91]
            typeof(SpatkUnkChunk), // 00                  [92]
            typeof(SpatkUnkChunk), // 00                  [93]

        }; // if it's past the end of this list, it'll default to SpatkUnkChunk
        }
    }