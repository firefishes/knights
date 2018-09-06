using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Knights.Game
{
    public class DataUtils
    {

        public static void SetConfigValue(ref JSONObject source, ref string value, ref string property, string field)
        {
            source.GetField(ref value, field);
            property = value;
        }

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

        public static void SetKnightMeridian(ref JSONObject source, ref KnightMeridian target)
        {
            float value = 0;
            SetConfigValue(ref source, ref value, ref target.meridian, "meridian");
            SetConfigValue(ref source, ref value, ref target.meridianYin, "yin");
            SetConfigValue(ref source, ref value, ref target.meridianYang, "yang");
            SetConfigValue(ref source, ref value, ref target.meridianHard, "hard");
            SetConfigValue(ref source, ref value, ref target.meridianSoft, "soft");
            SetConfigValue(ref source, ref value, ref target.meridianToxin, "toxin");
        }

        public static void SetKnightAttainments(ref JSONObject source, ref KnightAttainments target)
        {
            float value = 0;
            SetConfigValue(ref source, ref value, ref target.blade, "blade");
            SetConfigValue(ref source, ref value, ref target.fist, "fist");
            SetConfigValue(ref source, ref value, ref target.meritDarkarm, "merit_darkarm");
            SetConfigValue(ref source, ref value, ref target.meritDodge, "merit_dodge");
            SetConfigValue(ref source, ref value, ref target.meritExternal, "merit_external");
            SetConfigValue(ref source, ref value, ref target.meritInternal, "merit_internal");
            SetConfigValue(ref source, ref value, ref target.meritMedical, "merit_medical");
            SetConfigValue(ref source, ref value, ref target.meritToxin, "merit_toxin");
            SetConfigValue(ref source, ref value, ref target.meritKnowledge, "merit_knowledge");
        }
    }

}