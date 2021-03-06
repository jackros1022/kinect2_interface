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
        public class Temperature : ROS_CS.Core.BaseMessage
        {
            public readonly string typeID = "Temperature";
            public readonly string md5sum = "ff71b307acdbe7c871a5a6d7ed359100";
            public std_msgs.Header header;
            public double temperature;
            public double variance;

            public Temperature ()
            {
                header = new std_msgs.Header();
                temperature = 0.0;
                variance = 0.0;
            }

            public override string ToString ()
            {
                return ROS_CS.Core.PrettyPrinter.PrettyPrint(ToStringRaw());
            }

            public override string ToStringRaw ()
            {
                string string_rep = typeID + ":\n";
                string_rep += header.ToStringRaw() + "\n";
                string_rep += "temperature: " + Convert.ToString(temperature) + "\n";
                string_rep += "variance: " + Convert.ToString(variance) + "\n";
                return string_rep;
            }

            public override void Serialize(MemoryStream stream)
            {
                header.Serialize(stream);
                System.Byte[] temperature_bytes = BitConverter.GetBytes(temperature);
                stream.Write(temperature_bytes, 0, temperature_bytes.Length);
                System.Byte[] variance_bytes = BitConverter.GetBytes(variance);
                stream.Write(variance_bytes, 0, variance_bytes.Length);
            }

            public override int Deserialize(System.Byte[] serialized)
            {
                return Deserialize(serialized, 0);
            }

            public override int Deserialize(System.Byte[] serialized, int startIndex)
            {
                int curIndex = startIndex;
                curIndex += header.Deserialize(serialized, curIndex);
                temperature = BitConverter.ToDouble(serialized, curIndex);
                curIndex += BitConverter.GetBytes(temperature).Length;
                variance = BitConverter.ToDouble(serialized, curIndex);
                curIndex += BitConverter.GetBytes(variance).Length;
                return (curIndex - startIndex);
            }

        }
    }
}
