using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

//////////////////////////////////////////////////
/////    AUTOGENERATED MESSAGE DEFINITION    /////
//////////////////////////////////////////////////
/////         DO NOT MODIFY BY HAND!         /////
//////////////////////////////////////////////////

namespace ROS_CS
{
    namespace sensor_msgs
    {
        public class TimeReference : ROS_CS.Core.BaseMessage
        {
            public readonly string typeID = "TimeReference";
            public readonly string md5sum = "fded64a0265108ba86c3d38fb11c0c16";
            public std_msgs.Header header;
            public ROS_CS.Core.Time time_ref;
            public string source;

            public TimeReference ()
            {
                header = new std_msgs.Header();
                time_ref = new ROS_CS.Core.Time();
                source = "";
            }

            public override string ToString ()
            {
                return ROS_CS.Core.PrettyPrinter.PrettyPrint(ToStringRaw());
            }

            public override string ToStringRaw ()
            {
                string string_rep = typeID + ":\n";
                string_rep += header.ToStringRaw() + "\n";
                string_rep += time_ref.ToStringRaw() + "\n";
                string_rep += "source: " + source + "\n";
                return string_rep;
            }

            public override void Serialize(MemoryStream stream)
            {
                header.Serialize(stream);
                time_ref.Serialize(stream);
                System.Byte[] source_bytes = System.Text.Encoding.UTF8.GetBytes(source);
                System.Byte[] source_len_bytes = BitConverter.GetBytes((System.UInt32)source_bytes.Length);
                stream.Write(source_len_bytes, 0, source_len_bytes.Length);
                stream.Write(source_bytes, 0, source_bytes.Length);
            }

            public override int Deserialize(System.Byte[] serialized)
            {
                return Deserialize(serialized, 0);
            }

            public override int Deserialize(System.Byte[] serialized, int startIndex)
            {
                int curIndex = startIndex;
                curIndex += header.Deserialize(serialized, curIndex);
                curIndex += time_ref.Deserialize(serialized, curIndex);
                System.UInt32 source_len = BitConverter.ToUInt32(serialized, curIndex);
                curIndex += BitConverter.GetBytes(source_len).Length;
                source = System.Text.Encoding.UTF8.GetString(serialized, curIndex, (int)source_len);
                curIndex += (int)source_len;
                return (curIndex - startIndex);
            }

        }
    }
}