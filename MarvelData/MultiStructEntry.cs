﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace MarvelData
{
    public class MultiStructEntry : TableEntry
    {
        public int anmChrIndexMaybe;
        public static int[] anmChrIndexOffsets = {
            0, // 0 movement
            0x1e, // 1 blocking
            0x32,
            0x3c,  //3 Damage
            0x64,  //4 Knockdown
            0x82,  //Non combat
            0x96,  // normals?
            0xAA,  // airdashes?
            0xBE,  // 8 specials
            0xDC,  //9 supers
            0xF0,  //10 ?? dormamu air spell charge
            0x104, // 11 Capture States
            0x12C, //12 Anmtdown
            0x154, //13 Misc
            0x168, //14 TAC and Launcher
            0x17C, // 15 flight
            0x190  //16 etc
        };
        public List<StructEntryBase> subEntries;
        private string chunkName;

        public MultiStructEntry() : base()
        {
            subEntries = new List<StructEntryBase>();
        }

        public override byte[] GetData()
        {
            if (bHasData)
            {
                byte[] output = new byte[size];

                int position = 0;
                for (int i = 0; i < subEntries.Count; i++)
                {
                    byte[] chunk = subEntries[i].GetData();
                    for (int j = 0; j < chunk.Length; j++)
                    {
                        output[position] = chunk[j];
                        position++;
                    }
                }

                return output;
            }
            else
            {
                throw new Exception("NO DATA FOR GETDATA");
            }
        }

        //called in GuessName() to add input info 
        public void SubNameLoop()
        {
            int subCount = subEntries.Count;
            for (int i = 0; i < subCount; i++)
            {
                if (subEntries[i] is StructEntry<SpatkStandardChunk>)
                {
                    SpatkStandardChunk chunk = ((StructEntry<SpatkStandardChunk>)subEntries[i]).data;
                    if ((int)chunk.inputCode <= 10)
                    {
                        nameSB.Append(MVC3DataStructures.NumpadDirections[(int)chunk.inputCode]);
                    }
                    else
                    {
                        nameSB.Append(chunk.inputCode);
                    }
                }
                else if (subEntries[i] is StructEntry<SpatkDirectionalDashChunk>)
                {
                    SpatkDirectionalDashChunk chunk = ((StructEntry<SpatkDirectionalDashChunk>)subEntries[i]).data;
                    if ((int)chunk.inputCode <= 10)
                    {
                        nameSB.Append(MVC3DataStructures.NumpadDirections[(int)chunk.inputCode]);
                    }
                    else
                    {
                        nameSB.Append(chunk.inputCode);
                    }
                }
                else if (subEntries[i] is StructEntry<BaseActChunk>)
                {
                    BaseActChunk chunk = ((StructEntry<BaseActChunk>)subEntries[i]).data;
                    if ((int)chunk.inputCodeDirection <= 10)
                    {
                        nameSB.Append(MVC3DataStructures.NumpadDirections[(int)chunk.inputCodeDirection]);
                    }
                    else
                    {
                        nameSB.Append(chunk.inputCodeButton);
                    }
                }
                else if (subEntries[i] is StructEntry<SpatkDirButtonChunk>)
                {
                    SpatkDirButtonChunk chunk = ((StructEntry<SpatkDirButtonChunk>)subEntries[i]).data;
                    if ((int)chunk.inputCodeDirection <= 10)
                    {
                        nameSB.Append(MVC3DataStructures.NumpadDirections[(int)chunk.inputCodeDirection]);
                    }
                    else
                    {
                        nameSB.Append("?");
                    }

                    nameSB.Append(chunk.inputCodeButton);
                }
                else if (subEntries[i] is StructEntry<SpatkTwoButtonChunk>)
                {
                    SpatkTwoButtonChunk chunk = ((StructEntry<SpatkTwoButtonChunk>)subEntries[i]).data;
                    if ((int)chunk.atkS == 1) { nameSB.Append("AS"); }
                    else
                    {
                        nameSB.Append("AA");
                    }
                }
                else if (subEntries[i] is StructEntry<SpatkTwoButtonAirdashChunk>)
                {
                    SpatkTwoButtonAirdashChunk chunk = ((StructEntry<SpatkTwoButtonAirdashChunk>)subEntries[i]).data;

                    if ((int)chunk.inputCodeDirection <= 10)
                    {
                        nameSB.Append(MVC3DataStructures.NumpadDirections[(int)chunk.inputCodeDirection]);
                    }
                    else
                    {
                        nameSB.Append("?");
                    }
                    nameSB.Append("AA");
                }

                else if (subEntries[i] is StructEntry<SpatkActionChunk> && !isAnmChrEdit)
                {
                    SpatkActionChunk chunk = ((StructEntry<SpatkActionChunk>)subEntries[i]).data;
                    int anmchrIndex = anmChrIndexOffsets[chunk.actionClass] + chunk.actionIndex;
                    if (chunk.actionClass != -1 && chunk.actionIndex != -1) {
                        nameSB.Append(" = anmchr - " + anmchrIndex.ToString("X") + "h");
                    }
                    else
                    {
                    }
                }
            }
        }

        public virtual List<StructEntryBase> RemoveSubChunk(int index)
        {
            // Check if the index is within the bounds of the list
            if (index >= 0 && index < subEntries.Count)
            {
                var firstItem = subEntries.FirstOrDefault() as MarvelData.StructEntry<MarvelData.SpatkHeaderChunk>;
                if (firstItem != null)
                {
                    // reduce header size info
                    firstItem.data.size -= 1;
                }

                // Remove the entry at the specified index
                subEntries.RemoveAt(index);

                return subEntries;
             }
            return subEntries;
        }
        
        public virtual void AddSubChunk()
        {
                StructEntry<SpatkUnkChunk> chunk = new StructEntry<SpatkUnkChunk>();
                chunk.data = new SpatkUnkChunk();
                size += 0x20;
                chunk.size = 0x20;
                chunk.bHasData = true;
                chunkName = Tools.GetDescription(chunk.data.subChunkType);
                chunk.name = chunkName;
                subEntries.Add(chunk);
        }

        // creates subchunk section according to selected type - FM: looks fugly af
        public virtual void AddSubChunk(String subChunkType)
        {
            if (subChunkType.Equals("standardInput"))
            {
                StructEntry<SpatkStandardChunk> chunk = new StructEntry<SpatkStandardChunk>();
                chunk.data = new SpatkStandardChunk();
                chunk.data.subChunkType = (SubChunkType)02;
                size += 0x20;
                chunk.size = 0x20;
                chunk.bHasData = true;
                chunk.name = Tools.GetDescription(chunk.data.subChunkType);
                subEntries.Add(chunk);
            }
            else if (subChunkType.Equals("dashDirectionInput"))
            {
                StructEntry<SpatkDirectionalDashChunk> chunk = new StructEntry<SpatkDirectionalDashChunk>();
                chunk.data = new SpatkDirectionalDashChunk();
                chunk.data.subChunkType = (SubChunkType)03;
                size += 0x20;
                chunk.size = 0x20;
                chunk.bHasData = true;
                chunk.name = Tools.GetDescription(chunk.data.subChunkType);
                subEntries.Add(chunk);
            }
            else if (subChunkType.Equals("twoButtonInput1"))
            {
                StructEntry<SpatkTwoButtonChunk> chunk = new StructEntry<SpatkTwoButtonChunk>();
                chunk.data = new SpatkTwoButtonChunk();
                chunk.data.subChunkType = (SubChunkType)04;
                size += 0x20;
                chunk.size = 0x20;
                chunk.bHasData = true;
                chunk.name = Tools.GetDescription(chunk.data.subChunkType);
                subEntries.Add(chunk);
            }
            else if (subChunkType.Equals("directionAndButtonInput"))
            {
                StructEntry<SpatkDirButtonChunk> chunk = new StructEntry<SpatkDirButtonChunk>();
                chunk.data = new SpatkDirButtonChunk();
                chunk.data.subChunkType = (SubChunkType)05;
                size += 0x20;
                chunk.size = 0x20;
                chunk.bHasData = true;
                chunk.name = Tools.GetDescription(chunk.data.subChunkType);
                subEntries.Add(chunk);
            }
            else if (subChunkType.Equals("twoButtonInput2"))
            {
                StructEntry<SpatkTwoButtonAirdashChunk> chunk = new StructEntry<SpatkTwoButtonAirdashChunk>();
                chunk.data = new SpatkTwoButtonAirdashChunk();
                chunk.data.subChunkType = (SubChunkType)07;
                size += 0x20;
                chunk.size = 0x20;
                chunk.bHasData = true;
                chunk.name = Tools.GetDescription(chunk.data.subChunkType);
                subEntries.Add(chunk);
            }
            else if (subChunkType.Equals("executeAction"))
            {
                StructEntry<SpatkActionChunk> chunk = new StructEntry<SpatkActionChunk>();
                chunk.data = new SpatkActionChunk();
                chunk.data.subChunkType = (SubChunkType)09;
                size += 0x20;
                chunk.size = 0x20;
                chunk.bHasData = true;
                chunk.name = Tools.GetDescription(chunk.data.subChunkType);
                subEntries.Add(chunk);
            }
            //else if (subChunkType.Equals("captureState"))
            //{
            //}
            //else if (subChunkType.Equals("stateRestriction"))
            //{
            //}
            //else if (subChunkType.Equals("simpleModeAirComboUnk"))
            //{
            //}
            else if (subChunkType.Equals("modeRequired"))
            {
                StructEntry<SpatkModeRequiredChunk> chunk = new StructEntry<SpatkModeRequiredChunk>();
                chunk.data = new SpatkModeRequiredChunk();
                chunk.data.subChunkType = (SubChunkType)30;
                size += 0x20;
                chunk.size = 0x20;
                chunk.bHasData = true;
                chunk.name = Tools.GetDescription(chunk.data.subChunkType);
                subEntries.Add(chunk);
            }
            //else if (subChunkType.Equals("TACUnk"))
            //{
            //}
            //else if (subChunkType.Equals("airActionLimit"))
            //{
            //}
            else if (subChunkType.Equals("TACDHCAction"))
            {
                StructEntry<SpatkTACDHCChunk> chunk = new StructEntry<SpatkTACDHCChunk>();
                chunk.data = new SpatkTACDHCChunk();
                chunk.data.subChunkType = (SubChunkType)35;
                size += 0x20;
                chunk.size = 0x20;
                chunk.bHasData = true;
                chunk.name = Tools.GetDescription(chunk.data.subChunkType);
                subEntries.Add(chunk);
            }
            //else if (subChunkType.Equals("superJumpAction"))
            //{
            //}
            //else if (subChunkType.Equals("snapBackChar"))
            //{
            //}
            else if (subChunkType.Equals("restrictedState"))
            {
                StructEntry<SpatkRestrictedStateChunk> chunk = new StructEntry<SpatkRestrictedStateChunk>();
                chunk.data = new SpatkRestrictedStateChunk();
                chunk.data.subChunkType = (SubChunkType)47;
                size += 0x20;
                chunk.size = 0x20;
                chunk.bHasData = true;
                chunk.name = Tools.GetDescription(chunk.data.subChunkType);
                subEntries.Add(chunk);
            }
            //else if (subChunkType.Equals("SUnk"))
            //{
            //}
            else if (subChunkType.Equals("prohibitedFollowUpAction"))
            {
                StructEntry<SpatkProhibitedChunk> chunk = new StructEntry<SpatkProhibitedChunk>();
                chunk.data = new SpatkProhibitedChunk();
                chunk.data.subChunkType = (SubChunkType)49;
                size += 0x20;
                chunk.size = 0x20;
                chunk.bHasData = true;
                chunk.name = Tools.GetDescription(chunk.data.subChunkType);
                subEntries.Add(chunk);
            }
            //else if (subChunkType.Equals("heightRestriction"))
            //{
            //}
            else if (subChunkType.Equals("airDash"))
            {
                StructEntry<SpatkAirdashChunk> chunk = new StructEntry<SpatkAirdashChunk>();
                chunk.data = new SpatkAirdashChunk();
                chunk.data.subChunkType = (SubChunkType)52;
                size += 0x20;
                chunk.size = 0x20;
                chunk.bHasData = true;
                chunk.name = Tools.GetDescription(chunk.data.subChunkType);
                subEntries.Add(chunk);
            }
            else if (subChunkType.Equals("airSpecialActionLimit"))
            {
                StructEntry<SpatkAirSpecialLimiterChunk> chunk = new StructEntry<SpatkAirSpecialLimiterChunk>();
                chunk.data = new SpatkAirSpecialLimiterChunk();
                chunk.data.subChunkType = (SubChunkType)53;
                size += 0x20;
                chunk.size = 0x20;
                chunk.bHasData = true;
                chunk.name = Tools.GetDescription(chunk.data.subChunkType);
                subEntries.Add(chunk);
            }
            else if (subChunkType.Equals("guardTACAction"))
            {
                StructEntry<SpatkGuardTACChunk> chunk = new StructEntry<SpatkGuardTACChunk>();
                chunk.data = new SpatkGuardTACChunk();
                chunk.data.subChunkType = (SubChunkType)56;
                size += 0x20;
                chunk.size = 0x20;
                chunk.bHasData = true;
                chunk.name = Tools.GetDescription(chunk.data.subChunkType);
                subEntries.Add(chunk);
            }
            else if (subChunkType.Equals("hypers"))
            {
                StructEntry<SpatkHyperChunk> chunk = new StructEntry<SpatkHyperChunk>();
                chunk.data = new SpatkHyperChunk();
                chunk.data.subChunkType = (SubChunkType)58;
                size += 0x20;
                chunk.size = 0x20;
                chunk.bHasData = true;
                chunk.name = Tools.GetDescription(chunk.data.subChunkType);
                subEntries.Add(chunk);
            }
            else if (subChunkType.Equals("allowedChainOnState"))
            {
                StructEntry<SpatkAllowedChainChunk> chunk = new StructEntry<SpatkAllowedChainChunk>();
                chunk.data = new SpatkAllowedChainChunk();
                chunk.data.subChunkType = (SubChunkType)63;
                size += 0x20;
                chunk.size = 0x20;
                chunk.bHasData = true;
                chunk.name = Tools.GetDescription(chunk.data.subChunkType);
                subEntries.Add(chunk);
            }
            //else if (subChunkType.Equals("advGuardUnk"))
            //{
            //}
            else
            {
                AddSubChunk();
            }
        }
    }
}
