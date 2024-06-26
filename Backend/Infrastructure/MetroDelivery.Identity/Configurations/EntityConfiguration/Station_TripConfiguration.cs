﻿using MetroDelivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetroDelivery.Identity.Configurations.EntityConfiguration
{
    public class Station_TripConfiguration : IEntityTypeConfiguration<Station_Trip>
    {
        public void Configure(EntityTypeBuilder<Station_Trip> builder)
        {
            builder.HasData(
                new Station_Trip
                {
                    TripID = Guid.Parse("823ad122-7b51-4dab-9d37-b0f238d4a2ff"),
                    StationID = Guid.Parse("50CB67F8-421E-4AEC-85ED-7114E763D6C7"),
                    Arrived = DateTime.Parse("7/17/2023 12:00 PM")
                },
                new Station_Trip
                {
                    TripID = Guid.Parse("02859382-d88c-4e69-8c47-b8e0456677d5"),
                    StationID = Guid.Parse("50CB67F8-421E-4AEC-85ED-7114E763D6C6"),
                    Arrived = DateTime.Parse("9/15/2023 1:00 PM")
                },
                new Station_Trip
                {
                    TripID = Guid.Parse("27421cac-1da7-4df8-9928-7fb636ca42aa"),
                    StationID = Guid.Parse("50CB67F8-421E-4AEC-85ED-7114E763D6C5"),
                    Arrived = DateTime.Parse("11/14/2023 5:00 PM")
                },
                new Station_Trip
                {
                    TripID = Guid.Parse("5b30c4e9-31ab-456c-b212-dc6b2ba9a3e7"),
                    StationID = Guid.Parse("50CB67F8-421E-4AEC-85ED-7114E763D6C8"),
                    Arrived = DateTime.Parse("12/23/2023 2:00 PM")
                },
                new Station_Trip
                {
                    TripID = Guid.Parse("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00"),
                    StationID = Guid.Parse("50CB67F8-421E-4AEC-85ED-7114E763D6C8"),
                    Arrived = DateTime.Parse("5/25/2023 8:00 PM")
                }
            );
        }
    }

}
