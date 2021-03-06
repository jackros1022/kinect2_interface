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
    namespace actionlib_msgs
    {
        public class GoalID : ROS_CS.Core.BaseMessage
        {
            public readonly string typeID = "GoalID";
            public readonly string md5sum = "302881f31927c1df708a2dbab0e80ee8";
            public ROS_CS.Core.Time stamp;
            public string id;

            public GoalID ()
            {
                stamp = new ROS_CS.Core.Time();
                id = "";
            }

            public override string ToString ()
            {
                return ROS_CS.Core.PrettyPrinter.PrettyPrint(ToStringRaw());
            }

            public override string ToStringRaw ()
            {
                string string_rep = typeID + ":\n";
                string_rep += stamp.ToStringRaw() + "\n";
                string_rep += "id: " + id + "\n";
                return string_rep;
            }

            public override void Serialize(MemoryStream stream)
            {
                stamp.Serialize(stream);
                System.Byte[] id_bytes = System.Text.Encoding.UTF8.GetBytes(id);
                System.Byte[] id_len_bytes = BitConverter.GetBytes((System.UInt32)id_bytes.Length);
                stream.Write(id_len_bytes, 0, id_len_bytes.Length);
                stream.Write(id_bytes, 0, id_bytes.Length);
            }

            public override int Deserialize(System.Byte[] serialized)
            {
                return Deserialize(serialized, 0);
            }

            public override int Deserialize(System.Byte[] serialized, int startIndex)
            {
                int curIndex = startIndex;
                curIndex += stamp.Deserialize(serialized, curIndex);
                System.UInt32 id_len = BitConverter.ToUInt32(serialized, curIndex);
                curIndex += BitConverter.GetBytes(id_len).Length;
                id = System.Text.Encoding.UTF8.GetString(serialized, curIndex, (int)id_len);
                curIndex += (int)id_len;
                return (curIndex - startIndex);
            }

        }
    }
}
