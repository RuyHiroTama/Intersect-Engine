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
        //���� ������� �����
        [JsonProperty(Order = -13)]
        public int chance { get; set; } = 100;
        //��� ����� ������� ������� ������
        [JsonProperty(Order = -12)]
        public int weight { get; set; } = 20;
        //�������� ����� ������ � ������ �������
        [JsonProperty(Order = -11)]
        public int pushStrength { get; set; } = 0;
        //���� ��������� ������ � �������� �������
        [JsonProperty(Order = -10)]
        public int strength { get; set; } = 20;
        //������� �� �������� � ������ �������
        [JsonProperty(Order = -9)]
        public int position { get; set; } = 0;

        //������ ��������� ����� ����
        [JsonProperty(Order = -8)]
        public int rangeSize { get; set; } = 33;
        //�������� ����
        [JsonProperty(Order = -7)]
        public int speedMove { get; set; } = 20;
        //������������ ����. ��, ��������� ������ ����� �������� �������� �� ����� ������
        [JsonProperty(Order = -6)]
        public int speedChangeRangeSize { get; set; } = 50;


        //����������� �����������������. ��������� ����� ���������� ��������� ���� �� ����������.
        //�� ��� ����� ����������� ��������� ����. ��, ��������� ����� �������� � ��������� � ���������.
        //��� 100 ��������� ���� ����� �������� ���� � ��������� ��������� ���� �� �����
        //��� 0 ��� ����� ����� ���� ������ � �����������
        [JsonProperty(Order = -5)]
        public int coeffUnpredictability { get; set; } = 0;
        //����� ����� ����������� ����
        [JsonProperty(Order = -4)]
        public int timeChangeSpeed { get; set; } = 2000;
        //����� ����� ��������� ����
        [JsonProperty(Order = -3)]
        public int timeChangeRangeSize { get; set; } = 5000;

        //������� �����
        [JsonProperty(Order = -2)]
        public Guid ItemId { get; set; }

        /// <inheritdoc />
        public string Folder { get; set; } = "";

        //����� �����
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

        //���������� ��� ����� ���� �����
        [Column("FishingRequirements")]
        [JsonIgnore]
        public string JsonFishingRequirements
        {
            get => FishingRequirements.Data();
            set => FishingRequirements.Load(value ?? "[]");
        }
    }
}
