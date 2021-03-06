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
    namespace geometry_msgs
    {
        public class Pose2D : ROS_CS.Core.BaseMessage
        {
            public readonly string typeID = "Pose2D";
            public readonly string md5sum = "938fa65709584ad8e77d238529be13b8";
            public double x;
            public double y;
            public double theta;

            public Pose2D ()
            {
                x = 0.0;
                y = 0.0;
                theta = 0.0;
            }

            public override string ToString ()
            {
                return ROS_CS.Core.PrettyPrinter.PrettyPrint(ToStringRaw());
            }

            public override string ToStringRaw ()
            {
                string string_rep = typeID + ":\n";
                string_rep += "x: " + Convert.ToString(x) + "\n";
                string_rep += "y: " + Convert.ToString(y) + "\n";
                string_rep += "theta: " + Convert.ToString(theta) + "\n";
                return string_rep;
            }

            public override void Serialize(MemoryStream stream)
            {
                System.Byte[] x_bytes = BitConverter.GetBytes(x);
                stream.Write(x_bytes, 0, x_bytes.Length);
                System.Byte[] y_bytes = BitConverter.GetBytes(y);
                stream.Write(y_bytes, 0, y_bytes.Length);
                System.Byte[] theta_bytes = BitConverter.GetBytes(theta);
                stream.Write(theta_bytes, 0, theta_bytes.Length);
            }

            public override int Deserialize(System.Byte[] serialized)
            {
                return Deserialize(serialized, 0);
            }

            public override int Deserialize(System.Byte[] serialized, int startIndex)
            {
                int curIndex = startIndex;
                x = BitConverter.ToDouble(serialized, curIndex);
                curIndex += BitConverter.GetBytes(x).Length;
                y = BitConverter.ToDouble(serialized, curIndex);
                curIndex += BitConverter.GetBytes(y).Length;
                theta = BitConverter.ToDouble(serialized, curIndex);
                curIndex += BitConverter.GetBytes(theta).Length;
                return (curIndex - startIndex);
            }

        }
    }
}
