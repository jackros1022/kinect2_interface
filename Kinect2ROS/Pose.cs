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
        public class Pose : ROS_CS.Core.BaseMessage
        {
            public readonly string typeID = "Pose";
            public readonly string md5sum = "e45d45a5a1ce597b249e23fb30fc871f";
            public geometry_msgs.Point position;
            public geometry_msgs.Quaternion orientation;

            public Pose ()
            {
                position = new geometry_msgs.Point();
                orientation = new geometry_msgs.Quaternion();
            }

            public override string ToString ()
            {
                return ROS_CS.Core.PrettyPrinter.PrettyPrint(ToStringRaw());
            }

            public override string ToStringRaw ()
            {
                string string_rep = typeID + ":\n";
                string_rep += position.ToStringRaw() + "\n";
                string_rep += orientation.ToStringRaw() + "\n";
                return string_rep;
            }

            public override void Serialize(MemoryStream stream)
            {
                position.Serialize(stream);
                orientation.Serialize(stream);
            }

            public override int Deserialize(System.Byte[] serialized)
            {
                return Deserialize(serialized, 0);
            }

            public override int Deserialize(System.Byte[] serialized, int startIndex)
            {
                int curIndex = startIndex;
                curIndex += position.Deserialize(serialized, curIndex);
                curIndex += orientation.Deserialize(serialized, curIndex);
                return (curIndex - startIndex);
            }

        }
    }
}
