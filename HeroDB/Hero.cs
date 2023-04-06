﻿namespace HeroDB
{
    public struct Stats
    {
        public int Intelligence;
        public int Strength;
        public int Speed;
        public int Durability;
        public int Power;
        public int Combat;
    }

    public struct Appearance
    {
        public string Gender;
        public string Race;
        public string[] Height;
        public string[] Weight;
        public string EyeColor;
        public string HairColor;
    }

    public struct Bio
    {
        public string FullName;
        public string AlterEgos;
        public string[] Aliases;
        public string PlaceOfBirth;
        public string FirstAppearance;
        public string Publisher;
        public string Alignment;
    }
    public struct Work
    {
        public string Occupation;
        public string Base;
    }
    public struct Connections
    {
        public string GroupAffiliation;
        public string Relatives;
    }
    public struct Images
    {
        public string XS;
        public string SM;
        public string MD;
        public string LG;
    }
    public class Hero : IEquatable<Hero>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //string slug

        public Stats Powerstats { get; set; }
        public Appearance Appearance { get; set; }
        public Bio Biography { get; set; }
        public Work Work { get; set; }
        public Connections Connections { get; set; }
        public Images Images { get; set; }



        public bool Equals(Hero other)
        {
            if (other is null)
                return false;

            return this.Name == other.Name && this.Id == other.Id;
        }

        public override bool Equals(object obj) => Equals(obj as Hero);
        public override int GetHashCode() => (Name, Id).GetHashCode();
    }
}