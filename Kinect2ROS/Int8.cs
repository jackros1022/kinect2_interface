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
    namespace std_msgs
    {
        public class Int8 : ROS_CS.Core.BaseMessage
        {
            public readonly string typeID = "Int8";
            public readonly string md5sum = "27ffa0c9c4b8fb8492252bcad9e5c57b";
            public System.SByte data;

            public Int8 ()
            {
                data = 0;
            }

            public override string ToString ()
            {
                return ROS_CS.Core.PrettyPrinter.PrettyPrint(ToStringRaw());
            }

            public override string ToStringRaw ()
            {
                string string_rep = typeID + ":\n";
                string_rep += "data: " + Convert.ToString(data) + "\n";
                return string_rep;
            }

            public override void Serialize(MemoryStream stream)
            {
                System.Byte[] data_bytes = BitConverter.GetBytes(data);
                stream.Write(data_bytes, 0, data_bytes.Length);
            }

            public override int Deserialize(System.Byte[] serialized)
            {
                return Deserialize(serialized, 0);
            }

            public override int Deserialize(System.Byte[] serialized, int startIndex)
            {
                int curIndex = startIndex;
                data = (System.SByte)serialized[curIndex];
                curIndex++;
                return (curIndex - startIndex);
            }

        }
    }
}