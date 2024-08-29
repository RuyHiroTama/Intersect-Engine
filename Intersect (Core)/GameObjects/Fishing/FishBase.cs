using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

using Intersect.Models;
using Intersect.GameObjects.Events;

using Newtonsoft.Json;
using Intersect.GameObjects.Conditions;

namespace Intersect.GameObjects
{
    public partial class FishBase : DatabaseObject<FishBase>, IFolderable
    {
        [JsonConstructor]
        public FishBase(Guid id) : base(id)
        {
            Name = "New Fish";
        }

        //Parameterless constructor for EF
        public FishBase()
        {
            Name = "New Fish";
        }

        //{ get; set; }
        //Шанс поймать рыбку
        [JsonProperty(Order = -13)]
        public int chance { get; set; } = 100;
        //Как часто придётся долбить кнопку
        [JsonProperty(Order = -12)]
        public int weight { get; set; } = 20;
        //Дерзость рывка крючка в начале рыбалки
        [JsonProperty(Order = -11)]
        public int pushStrength { get; set; } = 0;
        //сила вырывание крючка в процессе рыбалки
        [JsonProperty(Order = -10)]
        public int strength { get; set; } = 20;
        //Позиция на ползунке в начале рыбалки
        [JsonProperty(Order = -9)]
        public int position { get; set; } = 0;

        //Размер диапазона ловли рыбы
        [JsonProperty(Order = -8)]
        public int rangeSize { get; set; } = 33;
        //Скорость рыбы
        [JsonProperty(Order = -7)]
        public int speedMove { get; set; } = 20;
        //Манёвренность рыбы. То, насколько быстро будет меняться диапазон на новый размер
        [JsonProperty(Order = -6)]
        public int speedChangeRangeSize { get; set; } = 50;


        //Коэффициент непредсказуемости. Насколько могут отличаться параметры рыбы от заявленных.
        //Не даёт точно предсказать поведение рыбы. То, насколько часто меняется её поведение и насколько.
        //При 100 поведение рыбы будет меняться чаще с огромными отличиями друг от друга
        //При 0 она будет вести себя строго с параметрами
        [JsonProperty(Order = -5)]
        public int coeffUnpredictability { get; set; } = 0;
        //Время смены направления рыбы
        [JsonProperty(Order = -4)]
        public int timeChangeSpeed { get; set; } = 2000;
        //Время смены диапазона рыбы
        [JsonProperty(Order = -3)]
        public int timeChangeRangeSize { get; set; } = 5000;

        //Предмет рыбки
        [JsonProperty(Order = -2)]
        public Guid ItemId { get; set; }

        /// <inheritdoc />
        public string Folder { get; set; } = "";

        //Ивент рыбки
        [Column("Event")]
        [JsonProperty]
        public Guid EventId { get; set; }

        [NotMapped]
        [JsonIgnore]
        public EventBase Event
        {
            get => EventBase.Get(EventId);
            set => EventId = value?.Id ?? Guid.Empty;
        }

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
    }
}
