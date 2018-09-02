using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Knights.Game
{
    public class DataUtils
    {
        public static void SetConfigValue(ref JSONObject source, ref float value, ref float property, string field)
        {
            source.GetField(ref value, field);
            property = value * 1000;
        }
        public static void SetConfigValue(ref JSONObject source, ref int value, ref int property, string field)
        {
            source.GetField(ref value, field);
            property = value * 1000;
        }
        public static void SetConfigValue(ref JSONObject source, ref bool property, string field)
        {
            source.GetField(ref property, field);
        }
    }

}