using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarvelData
{
    public class CmdComboEntry : MultiStructEntry
    {

        private StructEntry<CmdComboHeaderChunk> header;
        
        public override StructEntry<CmdComboHeaderChunk> getCmdComboHeader() 
        {
            return header;
        }

        public void setCmdComboHeader(StructEntry<CmdComboHeaderChunk> header)
        {
            this.header = header;
        }
        public override void SetData(byte[] newdata)
        {
            bHasData = true;

            if (subEntries == null)
            {
                subEntries = new List<StructEntryBase>();
            }
            else
            {
                subEntries.Clear();
            }
            size = newdata.Length;
            if (size < 0x44)
            {
                throw new Exception("HEADER TOO SMALL");
            }
            setCmdComboHeader(new StructEntry<CmdComboHeaderChunk>());
            getCmdComboHeader().size = 0x44;
            getCmdComboHeader().SetData(newdata,0);
            subEntries.Add(getCmdComboHeader());

            for (int i = 0x44; i + 0x19 < size; i += 0x20)
            {
                int subType = newdata[i];
                AELogger.Log("subtype " + subType);
                if (subType < MVC3DataStructures.SpatkChunkTypes.Length
                    && MVC3DataStructures.SpatkChunkTypes[subType] != typeof(SpatkUnkChunk))
                {
                    Type entryType = typeof(StructEntry<>).MakeGenericType((Type)MVC3DataStructures.SpatkChunkTypes[subType]);
                    StructEntryBase newChunk = (StructEntryBase)Activator.CreateInstance(entryType);
                    newChunk.size = 0x20;
                    newChunk.SetData(newdata, i);

                    subEntries.Add(newChunk);
                    /*
#if DEBUG
                    AELogger.Log("creating subchunk of type" + entryType);
#endif
                    */
                }
                else
                {
                    StructEntry<SpatkUnkChunk> newChunk = new StructEntry<SpatkUnkChunk>();
                    newChunk.size = 0x20;
                    newChunk.SetData(newdata, i);

                    subEntries.Add(newChunk);
                }
            }
        } // setdata


        public override void GuessName()
        {
            bool isEmpty = false;
            if (nameSB == null)
            {
                nameSB = new StringBuilder();

            }
            else
            {
                nameSB.Clear();
            }

            StructEntry<CmdComboHeaderChunk> header = (StructEntry<CmdComboHeaderChunk>)subEntries[0];

            if (header.data.disabled.Equals(MarvelData.CmdDisabled.disabled))
            {
                nameSB.Append("DISABLED ");
            }

            if (header.data.meterRequirement > 0)
            {
                nameSB.Append(header.data.meterRequirement);
                nameSB.Append("bar ");
            }
            //TODO: make sure this applies to aCA 2-8 in a way that isnt completely illegibile
            switch (header.data.anmChrAction1)
            {
                case 0x96:
                    nameSB.Append("5L? ");
                    break;
                case 0x97:
                    nameSB.Append("5M? ");
                    break;
                case 0x98:
                    nameSB.Append("5H? ");
                    break;
                case 0x99:
                    nameSB.Append("2L? ");
                    break;
                case 0x9A:
                    nameSB.Append("2M? ");
                    break;
                case 0x9B:
                    nameSB.Append("2H? ");
                    break;
                case 0x9C:
                    nameSB.Append("jL? ");
                    break;
                case 0x9D:
                    nameSB.Append("jM? ");
                    break;
                case 0x9E:
                    nameSB.Append("jH? ");
                    break;
                case 0x0168:
                    nameSB.Append("5S ");
                    break;

                default:
                    isEmpty = true;
                    break;
            }

            if (header.data.anmChrAction1 != -1 && isEmpty)
            {
                nameSB.Append(header.data.anmChrAction1.ToString("X") + "h ");
            }
            if (header.data.anmChrAction2 != -1 && isEmpty)
            {
                nameSB.Append(header.data.anmChrAction2.ToString("X") + "h ");
            }
            if (header.data.anmChrAction3 != -1 && isEmpty)
            {
                nameSB.Append(header.data.anmChrAction3.ToString("X") + "h ");
            }
            if (header.data.anmChrAction4 != -1  && isEmpty)
            {
                nameSB.Append(header.data.anmChrAction4.ToString("X") + "h ");
            }
            if (header.data.anmChrAction5 != -1 && isEmpty)
            {
                nameSB.Append(header.data.anmChrAction5.ToString("X") + "h ");
            }
            if (header.data.anmChrAction6 != -1 && isEmpty)
            {
                nameSB.Append(header.data.anmChrAction6.ToString("X") + "h ");
            }
            if (header.data.anmChrAction7 != -1 && isEmpty)
            {
                nameSB.Append(header.data.anmChrAction7.ToString("X") + "h ");
            }
            if (header.data.anmChrAction8 != -1 && isEmpty)
            {
                nameSB.Append(header.data.anmChrAction8.ToString("X") + "h ");
            }
            nameSB.Append("+ ");

            SubNameLoop();


            // finish up
            if (nameSB.Length > 0)
            {
                name = nameSB.ToString();
            }
            else
            {
                name = "unknown";
            }
        }
    } // class
}
