using System;
using System.ComponentModel.DataAnnotations.Schema;
using Intersect.Enums;
using Intersect.GameObjects.Events;
using Intersect.Models;

using Newtonsoft.Json;
using Intersect.GameObjects.Conditions;

namespace Intersect.GameObjects
{
    public partial class FishingSpotBase : DatabaseObject<FishingSpotBase>, IFolderable
    {
        [NotMapped]
        public DbList<FishBase> Fishes = new DbList<FishBase>();


        [JsonConstructor]
        public FishingSpotBase(Guid id) : base(id)
        {
            Name = "New Fishing Spot";
        }

        //Parameterless constructor for EF
        public FishingSpotBase()
        {
            Name = "New Fishing Spot";
        }

        [JsonIgnore]
        [Column("Fishes")]
        public string FishesJson
        {
            get => JsonConvert.SerializeObject(Fishes, Formatting.None);
            protected set => Fishes = JsonConvert.DeserializeObject<DbList<FishBase>>(value);
        }

        public int FishingTimeMin { get; set; } = 7000;

        public int FishingTimeMax { get; set; } = 30000;

        public string Folder { get; set; } = "";

        [NotMapped]
        public ConditionLists FishingRequirements = new ConditionLists();

        //Требования для ловли этой рыбки
        [Column("FishingRequirements")]
        [JsonIgnore]
        public string JsonFishingRequirements
        {
            get => FishingRequirements.Data();
            set => FishingRequirements.Load(value ?? "[]");
        }

        public static Guid IdFromList(int listIndex)
        {
            if (listIndex < 0 || listIndex >= Lookup.KeyList.Count)
            {
                return Guid.Empty;
            }

            return Lookup.KeyList.OrderBy(pairs => Lookup[pairs]?.Name).ToArray()[listIndex];
        }

        private SortByType sortBy;
        public List<Guid> SortingFishByRarity(SortByType sortBy)
        {
            this.sortBy = sortBy;
            List<Guid> result = new List<Guid>();
            result.AddRange(Fishes.ToArray());
            result.Sort(SortByRarity);
            return result;
        }
        public enum SortByType
        {
            INCREASING,
            DECREASING
        }
        private int SortByRarity(Guid fishID1, Guid fishId2)
        {
            int act1 = 1, act2 = -1;
            if (sortBy == SortByType.DECREASING)
            {
                act1 = -1;
                act2 = 1;
            }
            FishBase fish1 = FishBase.Get(fishID1);
            FishBase fish2 = FishBase.Get(fishId2);

            if (fish1 != null && fish2 == null) return act1;
            else if (fish1 == null && fish2 != null) return act2;
            else if (fish1 == null && fish2 == null) return 0;
            else if (fish1 != null && fish2 != null)
            {
                if (fish1.chance > fish2.chance) return act1;
                else if (fish1.chance < fish2.chance) return act2;
                else if (fish1.chance == fish2.chance) return 0;
                else return 0;
            }
            else return 0;
        }


    }
}
