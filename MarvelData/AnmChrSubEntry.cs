using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using static System.Windows.Forms.AxHost;

namespace MarvelData
{
    public class AnmChrSubEntry
    {
        public int tableindex;
        public int localindex;
        public int size;
        public int unk08;
        public int unk0C;
        public uint originalPointer; // DONT SAVE THIS
        public List<uint> subsubPointers; // DONT SAVE THIS
        public List<byte[]> subsubEntries;
        public List<int> subsubIndices;
        public bool isEdited;
        public bool isDisabled;

        #region STATIC
        public static StringBuilder sb = new StringBuilder();
        public static Dictionary<long, string> cmdNames;

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
        public static string InitCmdNames(string filename = "AnmChrCmds.cfg")
        {
            AELogger.Log("InitCmdNames " + filename);
            if (!File.Exists(filename))
            {
                AELogger.Log("warning: command label file " + filename + " does not exist!");
                return "command label file " + filename + " does not exist!";
            }

            if (cmdNames == null)
            {
                cmdNames = new Dictionary<long, string>();
            }
            else
            {
                AELogger.Log("odd? cmdNames already initialized?");
            }

            using (StreamReader reader = new StreamReader(File.OpenRead(filename)))
            {
                string line;
                line = reader.ReadLine();
                int i = 0;
                while (line != null)
                {
                    i++;
                    if (line.IndexOf('#') >= 0)
                    {
                        AELogger.Log("comment found " + line);
                        line = line.Substring(0,line.IndexOf('#'));
                    }

                    if (string.IsNullOrWhiteSpace(line))
                    {
                        line = reader.ReadLine();
                        continue;
                    }

                    line = line.Trim();
                    long key = 0;
                    // value A_XXXX
                    if (line.IndexOf(',') >= 0)
                    {
                        try
                        {
                            key = long.Parse(line.Substring(0, line.IndexOf(',')), System.Globalization.NumberStyles.HexNumber) << 32;
                        }
                        catch(Exception e)
                        {
                            AELogger.Log("PARSE ERROR 1ST AROUND LINE " + i + ": " + line + "\nDETAILS: " + e.Message);
                            return "PARSE ERROR 1ST AROUND LINE " + i + ": " + line + "\nDETAILS: " + e.Message;
                        }
                    }
                    else
                    {
                        AELogger.Log("PARSE ERROR 1ST AROUND LINE " + i + ": NO 1ST COMMA DETECTED: " + line);
                        return "PARSE ERROR 1ST AROUND LINE " + i + ": NO 1ST COMMA DETECTED: " + line;
                    }
                    line = line.Substring(line.IndexOf(',') + 1);
                    // value X_AAXX
                    if (line.IndexOf(',') >= 0)
                    {
                        try
                        {
                            key += long.Parse(line.Substring(0, line.IndexOf(',')), System.Globalization.NumberStyles.HexNumber);
                        }
                        catch (Exception e)
                        {
                            AELogger.Log("PARSE ERROR 2ND AROUND LINE " + i + ": " + line + "\nDETAILS: " + e.Message);
                            return "PARSE ERROR 2ND AROUND LINE " + i + ": " + line + "\nDETAILS: " + e.Message;
                        }
                    }
                    else
                    {
                        AELogger.Log("PARSE ERROR 2ND AROUND LINE " + i + ": NO 2ND COMMA DETECTED: " + line);
                        return "PARSE ERROR 2ND AROUND LINE " + i + ": NO 2ND COMMA DETECTED: " + line;
                    }
                    // value X_XXAA
                    line = line.Substring(line.IndexOf(',') + 1);
                    if (line.IndexOf(',') >= 0)
                    {
                        try
                        {
                            key += long.Parse(line.Substring(0, line.IndexOf(',')), System.Globalization.NumberStyles.HexNumber) << 8;
                        }
                        catch (Exception e)
                        {
                            AELogger.Log("PARSE ERROR 3RD AROUND LINE " + i + ": " + line + "\nDETAILS: " + e.Message);
                            return "PARSE ERROR 3RD AROUND LINE " + i + ": " + line + "\nDETAILS: " + e.Message;
                        }
                    }
                    else
                    {
                        AELogger.Log("PARSE ERROR 3RD AROUND LINE " + i + ": NO 3RD COMMA DETECTED: " + line);
                        return "PARSE ERROR 3RD AROUND LINE " + i + ": NO 3RD COMMA DETECTED: " + line;
                    }
                    // output string
                    line = line.Substring(line.IndexOf(',') + 1);
                    line = line.TrimStart();
                    if (cmdNames.ContainsKey(key))
                    {
                        AELogger.Log("warning, duplicate key " + key.ToString("X") + " with old value '" + cmdNames[key] + "' overwritten with '" + line + "' on line number " + i);
                        cmdNames[key] = line;
                    }
                    else
                    {
                        AELogger.Log("line " + i + ": " + key.ToString("X") + " set to '" + line + "'");
                        cmdNames.Add(key, line);
                    }

                    line = reader.ReadLine();
                } // while 
            } // using
            AELogger.Log("end InitCmdNames");
            return string.Empty;
        }
        #endregion

        public AnmChrSubEntry()
        {
            subsubEntries = new List<byte[]>();
            subsubIndices = new List<int>();
            subsubPointers = new List<uint>();
            isEdited = false;
            isDisabled = (localindex == 21012);
        }

        public void SetData(BinaryReader reader, uint nextPointer)
        {
            reader.BaseStream.Seek(originalPointer, SeekOrigin.Begin);

            localindex = reader.ReadInt32();
            if (localindex != tableindex)
            {
                AELogger.Log(" localindex " + localindex + " != tableindex " + tableindex);
            }
            int subcount = reader.ReadInt32();
            unk08 = reader.ReadInt32();
            unk0C = reader.ReadInt32();
            subsubEntries.Clear();
            subsubIndices.Clear();
            subsubPointers.Clear();

            for (int i = 0; i < subcount; i++)
            {
                subsubPointers.Add(reader.ReadUInt32());
                subsubIndices.Add(reader.ReadInt32());
            }

            for (int i = 0; i < subcount; i++)
            {
                int currentSize;
                if (i == subcount - 1)
                {
                    currentSize = (int)nextPointer - ((int)subsubPointers[i] + (int)originalPointer);
                }
                else
                {
                    currentSize = (int)subsubPointers[i+1] - (int)subsubPointers[i];
                }
                reader.BaseStream.Seek(originalPointer + subsubPointers[i], SeekOrigin.Begin);

                subsubEntries.Add(reader.ReadBytes(currentSize));
            }
        }

        public void WriteData(BinaryWriter writer)
        {
            int subcount = subsubEntries.Count;
            if (localindex != tableindex)
            {
                AELogger.Log(" localindex " + localindex + " != tableindex " + tableindex);
            }

            writer.Write(localindex);
            writer.Write(subcount);
            writer.Write(unk08);
            writer.Write(unk0C);
            int pointer = 16 + (subcount * 8);
            for (int i = 0; i < subcount; i++)
            {
                writer.Write(pointer);
                writer.Write(subsubIndices[i]);
                pointer += subsubEntries[i].Length;
            }
            for (int i = 0; i < subcount; i++)
            {
#if DEBUG
                AELogger.Log("position is: " + writer.BaseStream.Position + " / " + writer.BaseStream.Length + " and about to write " + subsubEntries[i].Length);
#endif
                writer.Write(subsubEntries[i]);
            }
        }

        public int GetSize()
        {
            int subsubcount = subsubEntries.Count;
            size = 16 + (subsubcount * 8);
            for (int i = 0; i < subsubcount; i++)
            {
                size += subsubEntries[i].Length;
            }
            return size;
        }

        public AnmChrSubEntry Copy()
        {
            AnmChrSubEntry output = new AnmChrSubEntry();
            output.localindex = localindex;
            output.tableindex = localindex;
            using (MemoryStream stream = new MemoryStream())
            {
                using (BinaryWriter writer=  new BinaryWriter(stream))
                {
                    WriteData(writer);
                    writer.Flush();
                    stream.Seek(0, SeekOrigin.Begin);
                    // dont close writer
                    using (BinaryReader reader = new BinaryReader(stream))
                    {
                        output.SetData(reader, (uint)GetSize());
                    }
                }
            }
            output.isEdited = true;
            output.isDisabled = isDisabled;
            return output;
        }

        public BindingList<string> GetCommandList()
        {
            int subsubcount = subsubEntries.Count;
            BindingList<string> output = new BindingList<string>();
            
            for (int i = 0; i < subsubcount; i++)
            {
                output.Add(GetSubSubName(i));
            }
            return output;
        }

        public string GetName()
        {
            sb.Clear();
            if (isDisabled || localindex >= 21011)
            {
                sb.Append("Disabled at #0" + (localindex - 21012));
                isDisabled = localindex >= 21011;
            } else
            {
                sb.Append("Time ");
                sb.Append(localindex.ToString("000;-00"));
            }
            sb.Append(": ");
            sb.Append(subsubEntries.Count);
            sb.Append(" commands");

            return sb.ToString();
        }

        public String GetSubSubName(int i)
        {
            sb.Clear();
            int currentCount = subsubEntries[i].Length;
            if (currentCount >= 8)
            {
                if (cmdNames != null)
                {
                    long header = ((long)subsubEntries[i][0] << 32) + (long)subsubEntries[i][4] + ((long)subsubEntries[i][5] << 8);
                    if (cmdNames.ContainsKey(header))
                    {
                        return UpdateCmdNameByContent(cmdNames[header], subsubEntries[i]);
                    }
                }
                
                // If command isnt labeled in AnmChrCmds
                sb.Append(subsubEntries[i][0].ToString("X"));
                sb.Append("_");

                if (subsubEntries[i][7] != 0)
                {
                    sb.Append(subsubEntries[i][7].ToString("X"));
                }
                if (subsubEntries[i][6] != 0)
                {
                    sb.Append(subsubEntries[i][6].ToString("X2"));
                }
                if (subsubEntries[i][5] != 0) { 
                sb.Append(subsubEntries[i][5].ToString("X2"));
                }

                sb.Append(subsubEntries[i][4].ToString("X2"));
            }
            else
            {
                sb.Append("unk");
                sb.Append(subsubPointers[i]);
                sb.Append(" w size ");
                sb.Append(currentCount);
            }
            return sb.ToString();
        }
        private String UpdateCmdNameByContent(string cmdName, byte[] subsubEntry) 
        {
            bool IsDebug = false;
            if (cmdName.ToUpper().Contains("DEBUG")) {
                IsDebug = true;
            }
            string newName = "";

            if (cmdName.Contains("0_01 ") || cmdName.Contains("0_02 ") || cmdName.Contains("0_04 ") || cmdName.Contains("0_1C ")) //GotoIf
            {

                byte[] V1 = new byte[4];
                byte[] V2 = new byte[4];
                byte[] V3 = new byte[4];
                string condition = "";
                int subSize = subsubEntry.Length;
                //Need to get command length to avoid crashes when file too small
                if (subsubEntry.Length >= 12)
                {
                    Array.Copy(subsubEntry, subsubEntry.Length - 12, V1, 0, 4);
                    Array.Copy(subsubEntry, subsubEntry.Length - 8, V2, 0, 4);
                    Array.Copy(subsubEntry, subsubEntry.Length - 4, V3, 0, 4);
                    Condition flags = (Condition)BitConverter.ToUInt32(V2, 0);
                    condition = flags.ToString("F");

                }

                else if (cmdName.Contains("0_01 ") && subSize == 40)
                {
                    string GoTo = BitConverter.ToInt32(V3, 0).ToString("X");
                    string vInt = BitConverter.ToInt32(V1, 0).ToString();
                    if (IsDebug) { newName = "Debug "; }
                    newName = newName + "0_01 GoTo Anmchr " + GoTo + "h If " + condition + " " + vInt;
                    return newName;
                }
                else if (cmdName.Contains("0_02 ") && subSize == 40)
                {
                    string GoTo = BitConverter.ToInt32(V3, 0).ToString("D");
                    string vInt = BitConverter.ToInt32(V1, 0).ToString();
                    if (IsDebug) { newName = "Debug "; }
                    newName = newName + "0_02 GoTo Frame " + GoTo + " If " + condition + " " + vInt;
                    return newName;
                }
                if (cmdName.Contains("0_04 ") && subSize == 40)
                {
                    string GoTo = BitConverter.ToInt32(V3, 0).ToString("D");
                    string Var2 = BitConverter.ToSingle(V1, 0).ToString();
                    if (IsDebug) { newName = "Debug "; }
                    newName = newName + "0_04 Goto Frame " + GoTo + " If " + condition + " " + Var2 + " Frames";
                    return newName;
                }
                else if (cmdName.Contains("0_1C ") && subSize == 24)
                {
                    string GoTo = BitConverter.ToInt32(V3, 0).ToString("D");
                    if (IsDebug) { newName = "Debug "; }
                    newName = newName + "0_1C GoTo Frame " + GoTo;
                    return newName;
                }
                else
                {
                    return cmdName + ", Size Error " + subsubEntry.Length.ToString("D");
                }
            }

            else if (cmdName.Contains("0_07 ")) //Goto Cmd (Revisit this later)  
            {
                if (subsubEntry.Length == 24)
                {
                    string commandName = "0_07 GotoCmd ";
                    byte[] V1 = new byte[4];
                    Array.Copy(subsubEntry, subsubEntry.Length - 12, V1, 0, 4);
                    string S1 = BitConverter.ToInt32(V1, 0).ToString("D"); //Remember to add this code later to visually show the commands added to the If statement

                    if (IsDebug) { newName = "Debug "; }
                    return newName + commandName + "(" + S1 + " Commands)";
                }
            }
            else if (cmdName.Contains("0_08 ")) //Goto Cmd If (Revisit this later)  
            {
                if (subsubEntry.Length == 40)
                {
                    string commandName = "0_08 GotoCmd If ";
                    byte[] V1 = new byte[4];
                    byte[] V2 = new byte[4];
                    byte[] V3 = new byte[4];
                    Array.Copy(subsubEntry, subsubEntry.Length - 12, V1, 0, 4);
                    string S1 = BitConverter.ToInt32(V1, 0).ToString();
                    Array.Copy(subsubEntry, subsubEntry.Length - 8, V2, 0, 4);
                    Condition flags = (Condition)BitConverter.ToUInt32(V2, 0);
                    string condition = flags.ToString("F");

                    Array.Copy(subsubEntry, subsubEntry.Length - 4, V3, 0, 4);
                    string S3 = BitConverter.ToInt32(V3, 0).ToString("D"); //Remember to add this code later to visually show the commands added to the If statement

                    if (IsDebug) { newName = "Debug "; }
                    return newName + commandName + condition + " " + S1 + " (" + S3 + " Commands)";
                }
                else
                {
                    return cmdName + ", Size Error " + subsubEntry.Length.ToString("D");
                }
            }


            else if (cmdName.Contains("0_21 ")) //Play Anim
            {
                if (subsubEntry.Length == 48)
                {
                    string commandName = "0_21 Play Animation";
                    byte[] lmt = new byte[4];
                    byte[] anim = new byte[4];
                    Array.Copy(subsubEntry, subsubEntry.Length - 16, lmt, 0, 4);
                    Array.Copy(subsubEntry, subsubEntry.Length - 12, anim, 0, 4);
                    string S1 = BitConverter.ToInt32(lmt, 0).ToString("D");
                    string S2 = BitConverter.ToInt32(anim, 0).ToString("D");
                    if (IsDebug) { newName = "Debug "; }
                    return newName + commandName + " (LMT " + S1 + ", Anim " + S2 + ")";
                }
                else
                {
                    return cmdName + ", Size Error " + subsubEntry.Length.ToString("D");
                }
            }
            else if (cmdName.Contains("0_22 ")) //Animation Frame Skip
            {
                if (subsubEntry.Length == 56)
                {
                    string commandName = "0_22 Animation Frame Skip";
                    byte[] lmt = new byte[4];
                    byte[] anim = new byte[4];
                    byte[] skip = new byte[4];
                    Array.Copy(subsubEntry, subsubEntry.Length - 20, lmt, 0, 4);
                    Array.Copy(subsubEntry, subsubEntry.Length - 16, anim, 0, 4);
                    Array.Copy(subsubEntry, subsubEntry.Length - 8, skip, 0, 4);
                    string S1 = BitConverter.ToInt32(lmt, 0).ToString("D");
                    string S2 = BitConverter.ToInt32(anim, 0).ToString("D");
                    string S3 = BitConverter.ToSingle(skip, 0).ToString();
                    if (IsDebug) { newName = "Debug "; }
                    return newName + commandName + " (LMT " + S1 + ", Anim " + S2 + ", Frame Skip " + S3 + ")";
                }
                else
                {
                    return cmdName + ", Size Error " + subsubEntry.Length.ToString("D");
                }
            }
            else if (cmdName.Contains("0_24 ")) //Animation Frame Skip
            {
                if (subsubEntry.Length == 64)
                {
                    string commandName = "0_24 Blend Animation";
                    byte[] condition = new byte[4];
                    byte[] lmt = new byte[4];
                    byte[] anim = new byte[4];
                    byte[] skip = new byte[4];
                    byte[] blend = new byte[4];
                    Array.Copy(subsubEntry, subsubEntry.Length - 24, condition, 0, 4);
                    Array.Copy(subsubEntry, subsubEntry.Length - 20, lmt, 0, 4);
                    Array.Copy(subsubEntry, subsubEntry.Length - 16, anim, 0, 4);
                    Array.Copy(subsubEntry, subsubEntry.Length - 12, blend, 0, 4);
                    Array.Copy(subsubEntry, subsubEntry.Length - 8, skip, 0, 4);

                    string S1 = BitConverter.ToInt32(lmt, 0).ToString("D");
                    string S2 = BitConverter.ToInt32(anim, 0).ToString("D");
                    string S3 = BitConverter.ToSingle(skip, 0).ToString();
                    string S4 = BitConverter.ToSingle(blend, 0).ToString("P");

                    if (IsDebug) { newName = "Debug "; }
                    return newName + commandName + " (LMT " + S1 + ", Anim " + S2 + ", Blend " + S4 + ", Frame Skip " + S3 + ")";
                }
                else
                {
                    return cmdName + ", Size Error " + subsubEntry.Length.ToString("D");
                }
            }



            else if (cmdName.Contains("0_2B ")) //Screen Shake
            {
                if (subsubEntry.Length == 24)
                {
                    string commandName = "0_2B Screen Shake ";
                    byte[] strength = new byte[1];
                    Array.Copy(subsubEntry, subsubEntry.Length - 4, strength, 0, 1);
                    string V1 = BitConverter.ToString(strength);
                    if (IsDebug) { newName = "Debug "; }
                    return newName + commandName + "(" + V1 + ")";
                }
                else
                {
                    return cmdName + ", Size Error " + subsubEntry.Length.ToString("D");
                }
            }


            else if (cmdName.Contains("1_00 ")) //Goto Anmchr Script 
            {
                if (subsubEntry.Length == 32)
                {
                    string commandName = "1_00 GoTo Anmchr Script ";
                    byte[] V1 = new byte[4];
                    Array.Copy(subsubEntry, subsubEntry.Length - 8, V1, 0, 4);
                    byte[] V2 = new byte[4];
                    Array.Copy(subsubEntry, subsubEntry.Length - 4, V2, 0, 4);
                    int I1 = BitConverter.ToInt32(V1, 0);
                    string S1 = "";
                    if (IsDebug) { newName = "Debug "; }
                    if (I1 < 0x10)
                    {
                        S1 = (anmChrIndexOffsets[I1] + BitConverter.ToInt32(V2, 0)).ToString("X3");
                    }
                    else
                    {
                        return newName + commandName + "(ERRh)";
                    }

                    return newName + commandName + "(" + S1 + "h)";
                }
                else
                {
                    return cmdName + ", Size Error " + subsubEntry.Length.ToString("D");
                }
            }



            else if (cmdName.Contains("1_2F") || cmdName.Contains("1_30") || cmdName.Contains("1_31") || cmdName.Contains("1_32") || cmdName.Contains("1_33") || cmdName.Contains("1_34"))  //AirGroundState
            {
                string commandName = "";
                if (cmdName.Contains("1_2F "))
                {
                    commandName = "1_2F Enable Air/Ground State";
                }
                else if (cmdName.Contains("1_30 "))
                {
                    commandName = "1_30 Enable Air/Ground State";
                }
                else if (cmdName.Contains("1_31 "))
                {
                    commandName = "1_31 Disable Air/Ground State";
                }
                else if (cmdName.Contains("1_32 "))
                {
                    commandName = "1_32 Disable Air/Ground State";
                }
                else if (cmdName.Contains("1_33 "))
                {
                    commandName = "1_33 Check Air/Ground State";
                }
                else if (cmdName.Contains("1_34 "))
                {
                    commandName = "1_34 Check Air/Ground State";
                }
                if (subsubEntry.Length == 24)
                {
                    byte[] last4Bytes = new byte[4];
                    Array.Copy(subsubEntry, subsubEntry.Length - 4, last4Bytes, 0, 4);
                    AirGroundState flags = (AirGroundState)BitConverter.ToUInt32(last4Bytes, 0);
                    string flagNames = flags.ToString("F");

                    if (IsDebug) { newName = "Debug "; }
                    return newName + commandName + " (" + flagNames + ")";
                }
                else
                {
                    return cmdName + ", Size Error " + subsubEntry.Length.ToString("D");
                }
            }

            //FlagsA
            else if (cmdName.Contains("1_3B") || cmdName.Contains("1_3C") || cmdName.Contains("1_3D") || cmdName.Contains("1_3E") || cmdName.Contains("1_3F") || cmdName.Contains("1_40"))
            {
                string commandName = "";
                if (cmdName.Contains("1_3B "))
                {
                    commandName = "1_3B Start State";
                }
                else if (cmdName.Contains("1_3C "))
                {
                    commandName = "1_3C Start State";
                }
                else if (cmdName.Contains("1_3D "))
                {
                    commandName = "1_3D End State";
                }
                else if (cmdName.Contains("1_3E "))
                {
                    commandName = "1_3E End State";
                }
                else if (cmdName.Contains("1_3F "))
                {
                    commandName = "1_3F Check Enabled State";
                }
                else if (cmdName.Contains("1_40 "))
                {
                    commandName = "1_40 Check Disabled State";
                }
                if (subsubEntry.Length == 24)
                {
                    byte[] last4Bytes = new byte[4];
                    Array.Copy(subsubEntry, subsubEntry.Length - 4, last4Bytes, 0, 4);
                    AnmFlagsA flags = (AnmFlagsA)BitConverter.ToUInt32(last4Bytes, 0);
                    string flagNames = flags.ToString("F");
                    if (IsDebug) { newName = "Debug "; }
                    return newName + commandName + " (" + flagNames + ")";
                }
                else
                {
                    return cmdName + ", Size Error " + subsubEntry.Length.ToString("D");
                }
            }

            if (cmdName.Contains("1_DB Add/Subtract Meter"))
            {
                if (subsubEntry.Length == 24)
                {
                    byte[] last4Bytes = new byte[4];
                    int meter = 0;
                    Array.Copy(subsubEntry, subsubEntry.Length - 4, last4Bytes, 0, 4);
                    meter = Tools.MVCHexToDecimal(BitConverter.ToString(last4Bytes).Replace("-", ""));
                    if (IsDebug) { newName = "Debug "; }
                    
                    if (meter >= 0)
                    {
                        return newName + "1_DB add " + meter + " meter (10000 = 1 Meter bar)";
                    }
                    else
                    {
                        return newName + "1_DB subtract " + meter + " meter (10000 = 1 Meter bar)";
                    }
                }
                else
                {
                    return cmdName + ", Size Error " + subsubEntry.Length.ToString("D");
                }
            }


            else if (cmdName.Contains("1_FF ")|| cmdName.Contains("1_101 ")|| cmdName.Contains("1_102 ")) //Check Charge Input
            {
                string commandName = " ";
                
                if (subsubEntry.Length == 24)
                {
                    if (cmdName.Contains("1_FF "))
                    {
                        commandName = "1_FF Check Button Hold ";
                    }
                    else if (cmdName.Contains("1_101 "))
                    {
                        commandName = "1_101 Check Button Mash ";
                    }
                    else if (cmdName.Contains("1_102 "))
                    {
                        commandName = "1_102 Check Button Press ";
                    }
                    byte[] button = new byte[4];
                    Array.Copy(subsubEntry, subsubEntry.Length - 4, button, 0, 4);
                    InputCode flags = (InputCode)BitConverter.ToUInt32(button, 0);
                    string Button = flags.ToString("F");
                    if (IsDebug) { newName = "Debug "; }
                    return newName + commandName + "(" + Button + ")";
                }
                else
                {
                    return cmdName + ", Size Error " + subsubEntry.Length.ToString("D");
                }
            }

            else if (cmdName.Contains("3_30 ")) //Spawn Projectile
            {
                if (subsubEntry.Length == 132)
                {
                    string commandName = "3_30 Spawn Projectile";
                    string flags = "";
                    byte[] pName = new byte[64];
                    byte[] atiIndex = new byte[4];
                    byte[] spawnTo = new byte[4];
                    Array.Copy(subsubEntry, subsubEntry.Length - 8, atiIndex, 0, 4);
                    Array.Copy(subsubEntry, 44, pName, 0, 64);
                    Array.Copy(subsubEntry, subsubEntry.Length - 20, spawnTo, 0, 4);

                    string V1 = Encoding.UTF8.GetString(pName, 0, 64).Replace("\0", "");
                    string V2 = BitConverter.ToInt32(atiIndex, 0).ToString("D").Replace("-1","Default");
                    SpawnRelation V3 = (SpawnRelation)BitConverter.ToUInt32(spawnTo, 0);
                    flags = V3.ToString("F");
                    if (IsDebug) { newName = "Debug "; }
                    return newName + commandName + ": " + V1 + " from " + flags + " (ATI: " + V2 + ")";
                }
                else
                {
                    return cmdName + ", Size Error " + subsubEntry.Length.ToString("D");
                }
            }
            else if (cmdName.Contains("3_31 ")) //Spawn Projectile
            {
                if (subsubEntry.Length == 180)
                {
                    string commandName = "3_31 Spawn Extra Projectile";
                    string flags = "";
                    byte[] pName = new byte[64];
                    byte[] spawnTo = new byte[4];
                    byte[] atiIndex = new byte[4];
                    //Location
                    byte[] lBone = new byte[4];
                    Array.Copy(subsubEntry, subsubEntry.Length - 48, lBone, 0, 4);
                    byte[] lZ = new byte[4];
                    Array.Copy(subsubEntry, subsubEntry.Length - 44, lZ, 0, 4);
                    byte[] lY = new byte[4];
                    Array.Copy(subsubEntry, subsubEntry.Length - 40, lY, 0, 4);
                    byte[] lX = new byte[4];
                    Array.Copy(subsubEntry, subsubEntry.Length - 36, lX, 0, 4);
                    //Rotation
                    byte[] rBone = new byte[4];
                    Array.Copy(subsubEntry, subsubEntry.Length - 32, rBone, 0, 4);
                    byte[] rZ = new byte[4];
                    Array.Copy(subsubEntry, subsubEntry.Length - 28, rZ, 0, 4);
                    byte[] rY = new byte[4];
                    Array.Copy(subsubEntry, subsubEntry.Length - 24, rY, 0, 4);
                    byte[] rX = new byte[4];
                    Array.Copy(subsubEntry, subsubEntry.Length - 20, rX, 0, 4);


                    Array.Copy(subsubEntry, subsubEntry.Length - 8, atiIndex, 0, 4);
                    Array.Copy(subsubEntry, 60, pName, 0, 64);
                    Array.Copy(subsubEntry, subsubEntry.Length - 52, spawnTo, 0, 4);



                    string V1 = Encoding.UTF8.GetString(pName, 0, 64).Replace("\0", "");
                    string V2 = BitConverter.ToInt32(atiIndex, 0).ToString("D").Replace("-1", "Default");
                    SpawnRelation V3 = (SpawnRelation)BitConverter.ToUInt32(spawnTo, 0);
                    flags = V3.ToString("F");
                    string LB = BitConverter.ToInt32(lBone, 0).ToString("D").Replace("-1","Default");

                    string sLZ = BitConverter.ToSingle(lZ, 0).ToString();
                    string sLY = BitConverter.ToSingle(lY, 0).ToString();
                    string sLX = BitConverter.ToSingle(lX, 0).ToString();

                    string RB = BitConverter.ToSingle(rBone, 0).ToString().Replace("NaN","Default");

                    string sRZ = BitConverter.ToSingle(rZ, 0).ToString();
                    string sRY = BitConverter.ToSingle(rY, 0).ToString();
                    string sRX = BitConverter.ToSingle(rX, 0).ToString();


                    if (IsDebug) { newName = "Debug "; }
                    return newName + commandName + ": " + V1 + " from " + flags + " Bone: " + LB + ", (Location Z: " + sLZ + ", Y: " + sLY + ", X: " + sLX + 
                        "), (Rotation Z: " + sRZ + ", Y: " + sRY + ", X: " + sRX + "), (ATI: " + V2 + ")";
                }
                else
                {
                    return cmdName + ", Size Error " + subsubEntry.Length.ToString("D");
                }
            }
            else if (cmdName.Contains("3_32 ")) //Spawn Physics Projectile
            {
                if (subsubEntry.Length == 212)
                {
                    string commandName = "3_32 Spawn Physics Projectile";
                    string flags = "";
                    byte[] pName = new byte[64];
                    Array.Copy(subsubEntry, 76, pName, 0, 64);
                    byte[] spawnTo = new byte[4];
                    Array.Copy(subsubEntry, 144, spawnTo, 0, 4);
                    byte[] atiIndex = new byte[4];
                    Array.Copy(subsubEntry, subsubEntry.Length - 8, atiIndex, 0, 4);


                    //Location
                    byte[] lBone = new byte[4];
                    Array.Copy(subsubEntry, subsubEntry.Length - 64, lBone, 0, 4);
                    byte[] lZ = new byte[4];
                    Array.Copy(subsubEntry, subsubEntry.Length - 60, lZ, 0, 4);
                    byte[] lY = new byte[4];
                    Array.Copy(subsubEntry, subsubEntry.Length - 56, lY, 0, 4);
                    byte[] lX = new byte[4];
                    Array.Copy(subsubEntry, subsubEntry.Length - 52, lX, 0, 4);
                    //Rotation
                    byte[] rBone = new byte[4];
                    Array.Copy(subsubEntry, subsubEntry.Length - 48, rBone, 0, 4);
                    byte[] rZ = new byte[4];
                    Array.Copy(subsubEntry, subsubEntry.Length - 44, rZ, 0, 4);
                    byte[] rY = new byte[4];
                    Array.Copy(subsubEntry, subsubEntry.Length - 40, rY, 0, 4);
                    byte[] rX = new byte[4];
                    Array.Copy(subsubEntry, subsubEntry.Length - 36, rX, 0, 4);
                    //X Physics
                    byte[] pX = new byte[4];
                    Array.Copy(subsubEntry, subsubEntry.Length - 32, pX, 0, 4);
                    byte[] pXa = new byte[4];
                    Array.Copy(subsubEntry, subsubEntry.Length - 28, pXa, 0, 4);
                    //Y Physics
                    byte[] pY = new byte[4];
                    Array.Copy(subsubEntry, subsubEntry.Length - 24, pY, 0, 4);
                    byte[] pYa = new byte[4];
                    Array.Copy(subsubEntry, subsubEntry.Length - 20, pYa, 0, 4);


                    string V1 = Encoding.UTF8.GetString(pName, 0, 64).Replace("\0", "");
                    string V2 = BitConverter.ToInt32(atiIndex, 0).ToString("D").Replace("-1", "Default");
                    SpawnRelation V3 = (SpawnRelation)BitConverter.ToUInt32(spawnTo, 0);
                    flags = V3.ToString("F");
                    string LB = BitConverter.ToInt32(lBone, 0).ToString("D").Replace("-1", "Default");

                    string sLZ = BitConverter.ToSingle(lZ, 0).ToString();
                    string sLY = BitConverter.ToSingle(lY, 0).ToString();
                    string sLX = BitConverter.ToSingle(lX, 0).ToString();

                    string RB = BitConverter.ToSingle(rBone, 0).ToString().Replace("NaN", "Default");

                    string sRZ = BitConverter.ToSingle(rZ, 0).ToString();
                    string sRY = BitConverter.ToSingle(rY, 0).ToString();
                    string sRX = BitConverter.ToSingle(rX, 0).ToString();

                    string sPX = BitConverter.ToSingle(pX, 0).ToString();
                    string sPXa = BitConverter.ToSingle(pXa, 0).ToString();
                    string sPY = BitConverter.ToSingle(pY, 0).ToString();
                    string sPYa = BitConverter.ToSingle(pYa, 0).ToString();



                    if (IsDebug) { newName = "Debug "; }
                    return newName + commandName + ": " + V1 + " from " + flags + " Bone: " + LB + ", (Location Z: " + sLZ + ", Y: " + sLY + ", X: " + sLX +
                        "), (Rotation Z: " + sRZ + ", Y: " + sRY + ", X: " + sRX + 
                        "), (Physics X " + sPX + ", " + sPXa + "), (Y: " + sPY + ", " + sPYa + 
                        "), (ATI: " + V2 + ")";
                }
                else
                {
                    return cmdName + ", Size Error " + subsubEntry.Length.ToString("D");
                }
            }

            else
            {

                return cmdName;
            }
        }
    }
}
