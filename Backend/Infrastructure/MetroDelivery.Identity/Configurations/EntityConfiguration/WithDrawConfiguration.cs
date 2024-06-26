﻿using MetroDelivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Globalization;

namespace MetroDelivery.Identity.Configurations.EntityConfiguration
{
    public class WithDrawConfiguration : IEntityTypeConfiguration<WithDraw>
    {
        public void Configure(EntityTypeBuilder<WithDraw> builder)
        {
            builder.HasData(
                new WithDraw
                {
                    //anh da đen
                    Id = Guid.Parse("4E917707-0EDB-49DA-B6F4-804D2C52821B"),
                    Deposit = 60000,
                    Balance = 150000,
                    CreateTimeOfWithdraw = DateTime.ParseExact("04/05/2023", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    CustomerID = Guid.Parse("0512A248-0054-4616-ADE5-AE412F4F07BD"),
                    PaymentMethodID = Guid.Parse("71B4BF27-E569-47A0-B16A-E484533BD9F2")
                },
                new WithDraw
                {
                    //vĩ bê đê
                    Id = Guid.Parse("8EFB8ACC-2EB9-448D-BFA2-825995F50B59"),
                    Deposit = 30000,
                    Balance = 0,
                    CreateTimeOfWithdraw = DateTime.ParseExact("25/09/2023", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    CustomerID = Guid.Parse("ECF95BF5-D766-4B6E-94A7-D33EA29C0618"),
                    PaymentMethodID = Guid.Parse("71B4BF27-E569-47A0-B16A-E484533BD9F2")
                },
                new WithDraw
                {
                    //nhân
                    Id = Guid.Parse("0BD9818A-5EF1-45E3-A6FE-0C932F970FE8"),
                    Deposit = 125000,
                    Balance = 2000000,
                    CreateTimeOfWithdraw = DateTime.ParseExact("14/12/2022", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    CustomerID = Guid.Parse("01D31C40-14C9-444C-A2FE-F58EA0FBC08A"),
                    PaymentMethodID = Guid.Parse("71B4BF27-E569-47A0-B16A-E484533BD9F2")
                }
            );
        }
    }
}
