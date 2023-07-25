using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSLEarn6___REST.Models
{
   
        public class Critter
        {
            public string index { get; set; }
            public string name { get; set; }
            public string size { get; set; }
            public string type { get; set; }
            public string alignment { get; set; }
            public Armor_Class[] armor_class { get; set; }
            public int hit_points { get; set; }
            public string hit_dice { get; set; }
            public string hit_points_roll { get; set; }
            public Speed speed { get; set; }
            public int strength { get; set; }
            public int dexterity { get; set; }
            public int constitution { get; set; }
            public int intelligence { get; set; }
            public int wisdom { get; set; }
            public int charisma { get; set; }
            public Proficiency[] proficiencies { get; set; }
            public object[] damage_vulnerabilities { get; set; }
            public object[] damage_resistances { get; set; }
            public string[] damage_immunities { get; set; }
            public object[] condition_immunities { get; set; }
            public Senses senses { get; set; }
            public string languages { get; set; }
            public int challenge_rating { get; set; }
            public int xp { get; set; }
            public Special_Abilities[] special_abilities { get; set; }
            public Action[] actions { get; set; }
            public Legendary_Actions[] legendary_actions { get; set; }
            public string image { get; set; }
            public string url { get; set; }
        }

        public class Speed
        {
            public string walk { get; set; }
            public string fly { get; set; }
            public string swim { get; set; }
        }

        public class Senses
        {
            public string blindsight { get; set; }
            public string darkvision { get; set; }
            public int passive_perception { get; set; }
        }

        public class Armor_Class
        {
            public string type { get; set; }
            public int value { get; set; }
        }

        public class Proficiency
        {
            public int value { get; set; }
            public Proficiency1 proficiency { get; set; }
        }

        public class Proficiency1
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Special_Abilities
        {
            public string name { get; set; }
            public string desc { get; set; }
            public Usage usage { get; set; }
        }

        public class Usage
        {
            public string type { get; set; }
            public int times { get; set; }
            public object[] rest_types { get; set; }
        }

        public class Action
        {
            public string name { get; set; }
            public string multiattack_type { get; set; }
            public string desc { get; set; }
            public Action1[] actions { get; set; }
            public int attack_bonus { get; set; }
            public Damage[] damage { get; set; }
            public Dc dc { get; set; }
            public Usage1 usage { get; set; }
        }

        public class Dc
        {
            public Dc_Type dc_type { get; set; }
            public int dc_value { get; set; }
            public string success_type { get; set; }
        }

        public class Dc_Type
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Usage1
        {
            public string type { get; set; }
            public string dice { get; set; }
            public int min_value { get; set; }
        }

        public class Action1
        {
            public string action_name { get; set; }
            public int count { get; set; }
            public string type { get; set; }
        }

        public class Damage
        {
            public Damage_Type damage_type { get; set; }
            public string damage_dice { get; set; }
        }

        public class Damage_Type
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Legendary_Actions
        {
            public string name { get; set; }
            public string desc { get; set; }
            public Dc1 dc { get; set; }
            public Damage1[] damage { get; set; }
        }

        public class Dc1
        {
            public Dc_Type1 dc_type { get; set; }
            public int dc_value { get; set; }
            public string success_type { get; set; }
        }

        public class Dc_Type1
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Damage1
        {
            public Damage_Type1 damage_type { get; set; }
            public string damage_dice { get; set; }
        }

        public class Damage_Type1
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }
}
