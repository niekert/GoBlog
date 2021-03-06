﻿using System;
using System.Data.Entity;
using System.Threading;
using GoBlog.Domain.Infrastructure.Persistence.Entities;

namespace GoBlog.Domain.Infrastructure.Persistence.Migrations
{
    public class Configuration : DropCreateDatabaseAlways<BlogDatabase>
    {
        protected override void Seed(BlogDatabase database)
        {
            for (int i = 0; i < 15; i++)
            {
                var entry = new Entry
                {
                    Slug = "test-post-" + i,
                    Header = "Test Post " + i,
                    Summary = "Craft beer bespoke photo booth Thundercats Wes Anderson. Street art kitsch kogi, Etsy Shoreditch Carles Vice occupy PBR&B Pitchfork twee cred cardigan 3 wolf moon. Kale chips PBR&B sartorial ethnic pickled. Wayfarers umami irony cliche roof party, mlkshk swag direct trade sartorial butcher viral literally PBR slow-carb. Fanny pack tattooed yr kale chips VHS, meh banh mi blog cray normcore wolf Bushwick fingerstache single-origin coffee quinoa. Fingerstache Thundercats bespoke organic roof party cred. Banh mi Cosby sweater Williamsburg, bitters try-hard fixie typewriter deep v ethical forage chia synth selvage cliche narwhal.",
                    Content = "Craft beer bespoke photo booth Thundercats Wes Anderson. Street art kitsch kogi, Etsy Shoreditch Carles Vice occupy PBR&B Pitchfork twee cred cardigan 3 wolf moon. Kale chips PBR&B sartorial ethnic pickled. Wayfarers umami irony cliche roof party, mlkshk swag direct trade sartorial butcher viral literally PBR slow-carb. Fanny pack tattooed yr kale chips VHS, meh banh mi blog cray normcore wolf Bushwick fingerstache single-origin coffee quinoa. Fingerstache Thundercats bespoke organic roof party cred. Banh mi Cosby sweater Williamsburg, bitters try-hard fixie typewriter deep v ethical forage chia synth selvage cliche narwhal.",
                    CreatedAt = DateTime.Now,
                    PublishedAt = DateTime.Now,
                    Published = true
                };

                Thread.Sleep(10);
/**/
                database.BlogEntries.Add(entry);
            }

            database.Tags.Add(new Tag { Name = "Programming" });
            database.Tags.Add(new Tag { Name = "Productivity" });
            database.Tags.Add(new Tag { Name = "Science" });
            database.Tags.Add(new Tag { Name = "Math" });

            database.SaveChanges();
        }
    }
}
